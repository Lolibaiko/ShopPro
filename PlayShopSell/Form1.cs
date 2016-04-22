using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;

namespace PlayShopSell
{
    public partial class Form1 : Form
    {

        string connectionStr;
        public double USD;
        SqlConnection connectionDB;
        public Form1()
        {
            InitializeComponent();
            USD = 0;
            DBConnect();
            BoxFilling();
            UpdateDollar();
        }

        void DBConnect()//підключення до бази
        {
            connectionStr = @"Data Source=OLEH-PC\SQLEXPRESS;
                            Initial Catalog=PlayShopDB;
                            Integrated Security=True";
            /*connectionStr = @"Data Source=WEEMAN\MSSQLSERVER2014;
                            Initial Catalog=PlayShopDB;
                            Integrated Security=True";*/
            connectionDB = new SqlConnection(connectionStr);
            try
            {
                connectionDB.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Підключення до бази данних не відбулося: " + se);
            }
        }

        void Reconnect()//перепідключення до бази
        {
            try
            {
                if (connectionDB.State != ConnectionState.Open)
                    connectionDB.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("З’єднання з базою не відбулось:" + ex.ToString());
            }
        }

        public int FindLastId(string cell, string table)//знаходження останнього id в таблиці бази
        {
            int id;
            Reconnect();
            SqlCommand cmd = new SqlCommand("SELECT Max(" + cell + ") FROM " + table, connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                dr.Read();
                id = Convert.ToInt32(dr.GetValue(0)) + 1;
            }
            return id;
        }

        void BoxFilling()//заповнення лістБоксів з позиціями
        {
            listBox_Sale.Items.Clear();
            listBox_Rent.Items.Clear();
            listBox_Repair.Items.Clear();
            Reconnect();
            SqlCommand cmd = new SqlCommand("SELECT name FROM SaleStorage", connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    if (dr.GetValue(0).ToString().Trim() != "0")
                        listBox_Sale.Items.Add(dr.GetValue(0).ToString().Trim());
                }
            }
            Reconnect();
            cmd = new SqlCommand("SELECT name FROM RentStorage", connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    if (dr.GetValue(0).ToString().Trim() != "0")
                        listBox_Rent.Items.Add(dr.GetValue(0).ToString().Trim());
                }
            }
            Reconnect();
            cmd = new SqlCommand("SELECT name FROM RepairInfo", connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    if (dr.GetValue(0).ToString().Trim() != "0")
                        listBox_Repair.Items.Add(dr.GetValue(0).ToString().Trim());
                }
            }
        }

        void FindBalance()//знаходження залишку на складах
        {
            String tableStr = "SaleStorage", priceTypeStr = "priceUSD", amountStr = "amountS,";
            int index = 0;
            double usd = USD;
            if (tabControl_Main.SelectedTab == tabPage_Sale) {index = listBox_Sale.SelectedIndex + 1; }
            else if (tabControl_Main.SelectedTab == tabPage_Rent) { tableStr = "RentStorage"; priceTypeStr = "priceUAH"; index = listBox_Rent.SelectedIndex + 1; usd = 1; }
            else if(tabControl_Main.SelectedTab == tabPage_Repair) { tableStr = "RepairInfo"; priceTypeStr = "priceUAH"; amountStr = ""; index = listBox_Repair.SelectedIndex + 1; textBox_AmountS.Clear(); usd = 1; }
            Reconnect();
            textBox_AmountS.Clear();
            SqlCommand cmd = new SqlCommand("SELECT "+ amountStr +" "+ priceTypeStr +" FROM " + tableStr + " WHERE id = " + index, connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    if (tabControl_Main.SelectedTab != tabPage_Repair)
                    {
                        textBox_AmountS.Text = dr.GetValue(0).ToString().Trim();
                        textBox_PriceUAH.Text = (Math.Round((Convert.ToDouble(dr.GetValue(1).ToString().Trim()) * usd),2)).ToString();
                    }
                    else
                        textBox_PriceUAH.Text = (Math.Round((Convert.ToDouble(dr.GetValue(0).ToString().Trim()) * usd), 2)).ToString();
                }
            }
        }

        public void PositionSort()//сортування нумерації позицій в рахунку
        {
            for (int i = 0; i < dataGridView_Main.Rows.Count; i++)
                dataGridView_Main.Rows[i].Cells[0].Value = i + 1;
        }
        public double FindSum()//знаходшення суми рахунку
        {
            double sum = 0;
            for (int i = 0; i < dataGridView_Main.RowCount; i++)
            {
                sum += Convert.ToDouble(dataGridView_Main.Rows[i].Cells[5].Value);
            }
            return Math.Round(sum, 2);
        }

        int FindDaysAmount(DateTime secondDate)
        {
            DateTime firstDate = DateTime.Now.Date;
            TimeSpan span = secondDate - firstDate;
            return span.Days;
        }

        bool AmountCheck(int id, char type)
        {
            int amount = 0;
            for (int i = 0; i < dataGridView_Main.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView_Main.Rows[i].Cells[6].Value) == id && Convert.ToChar(dataGridView_Main.Rows[i].Cells[7].Value) == type)
                    amount += Convert.ToInt32(dataGridView_Main.Rows[i].Cells[2].Value);
            }
            amount += Convert.ToInt32(numericUpDown_Amount.Value);
            if (amount > Convert.ToInt32(textBox_AmountS.Text))
                return true;
            else
                return false;

        }

        public void AddPos()//додавання позиції до рахунку
        {
            ListBox activeListBox = new ListBox();
            int daysAmount = 1;
            bool avalible = true;
            String tableStr = "null";
            String priceStr = "null";
            char type = '0';
            
            if (tabControl_Main.SelectedTab == tabPage_Sale)//додавання з ліст боксу продажу
            {
                if (textBox_AmountS.Text != "")
                {
                    activeListBox = listBox_Sale;
                    if (Convert.ToInt32(textBox_AmountS.Text) < 1 || Convert.ToInt32(numericUpDown_Amount.Text) > Convert.ToInt32(textBox_AmountS.Text) || AmountCheck(activeListBox.SelectedIndex + 1, 'S')) avalible = false;
                 
                    tableStr = "SaleStorage";
                    priceStr = "priceUSD";
                    type = 'S';
                }
                else
                    avalible = false;
            }
            else if (tabControl_Main.SelectedTab == tabPage_Rent)
            {
                if (dateTimePicker_SecondDate.Value.Date <= DateTime.Now.Date)
                {
                    MessageBox.Show("Невірне значення дати!"); avalible = false;
                }
                else if (textBox_AmountS.Text != "")
                {
                    activeListBox = listBox_Rent;
                    if (Convert.ToInt32(textBox_AmountS.Text) < 1 || Convert.ToInt32(numericUpDown_Amount.Text) > Convert.ToInt32(textBox_AmountS.Text) || AmountCheck(activeListBox.SelectedIndex + 1, 'P')) avalible = false;
                    
                    tableStr = "RentStorage";
                    priceStr = "priceUAH";
                    type = 'P';
                    daysAmount = FindDaysAmount(dateTimePicker_SecondDate.Value.Date);
                }
                else
                    avalible = false;
            }
            else if (tabControl_Main.SelectedTab == tabPage_Repair)
            {
                activeListBox = listBox_Repair;
                tableStr = "RepairInfo";
                priceStr = "priceUAH";
                type = 'R';
            }
            else
                MessageBox.Show("Виберіть тип операції!");


            if (activeListBox.SelectedIndex != -1 && avalible)
            {
                dataGridView_Main.Rows.Add();
                PositionSort();
                Reconnect();
                SqlCommand cmd = new SqlCommand("SELECT id, name , "+ priceStr +" FROM "+ tableStr +" WHERE id = " + (activeListBox.SelectedIndex + 1), connectionDB);
                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    dr.Read();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[6].Value = dr.GetValue(0).ToString().Trim();//id
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[1].Value = dr.GetValue(1).ToString().Trim();//назва
                    if(tabControl_Main.SelectedTab == tabPage_Sale)
                        dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[4].Value = Math.Round(Convert.ToDouble(dr.GetValue(2).ToString().Trim()) * USD, 2);//ціна в грн
                    else
                        dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[4].Value = Math.Round(Convert.ToDouble(dr.GetValue(2).ToString().Trim()),2);//ціна в грн

                }
                if (numericUpDown_Amount.Text == "" || numericUpDown_Amount.Text == "0")//кількість
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[2].Value = "1";
                else
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[2].Value = numericUpDown_Amount.Text;
                dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[5].Value = Convert.ToString(Math.Round((Convert.ToDouble(dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[2].Value) * Convert.ToDouble(dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[4].Value) * daysAmount),2));//сума
                dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[7].Value = type;//тип продукту
                if (tabControl_Main.SelectedTab == tabPage_Rent)
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[3].Value = dateTimePicker_SecondDate.Value.Date;
            }
            else
                MessageBox.Show("Не вибрана позиція або товару немає в наявності!");

        }
        public void DeletePos()//видалення позиції з рахунку
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити позицію?", "Видалити позицію?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //DataGridView activeGrid = gridList[tabControl_Bills.SelectedIndex];
                if (dataGridView_Main.RowCount != 0)
                {
                    dataGridView_Main.Rows.RemoveAt(dataGridView_Main.CurrentRow.Index);
                    PositionSort();
                }
            }
        }

        public void CloseBill()//закриття рахунку
        {
            if (MessageBox.Show("Ви дійсно бажаєте закрити рахунок?", "Закрити рахунок?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (dataGridView_Main.RowCount != 0)
                {
                    int billId = FindLastId("id", "Bill");
                    Reconnect();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Bill(id, date, sumUAH) VALUES(@id, @date, @sumUAH)", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = billId;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@date";
                        param.Value = DateTime.Now;
                        param.SqlDbType = SqlDbType.DateTime;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@sumUAH";
                        param.Value = FindSum();
                        param.SqlDbType = SqlDbType.Float;
                        cmd.Parameters.Add(param);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Помилка при додванні даних в табл. Рахунок!" + ex.ToString());
                            return;
                        }
                    }

                    for (int i = 0; i < dataGridView_Main.RowCount; i++)
                    {
                        if (dataGridView_Main.Rows[i].Cells[7].Value.ToString() == "S")
                        {
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO SaleTrans(id, idBill, idStorage, name, amount, priceUAH) " +
                                        "VALUES(@id, @idBill, @idStorage, @name, @amount, @priceUAH)", connectionDB))
                            {
                                SqlParameter param = new SqlParameter();
                                param.ParameterName = "@id";
                                param.Value = FindLastId("id", "SaleTrans");
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@idBill";
                                param.Value = billId;
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@idStorage";
                                param.Value = Convert.ToInt32(dataGridView_Main.Rows[i].Cells[6].Value);
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@name";
                                param.Value = dataGridView_Main.Rows[i].Cells[1].Value.ToString();
                                param.SqlDbType = SqlDbType.NChar;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@amount";
                                param.Value = Convert.ToInt32(dataGridView_Main.Rows[i].Cells[2].Value);
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@priceUAH";
                                param.Value = Convert.ToDouble(dataGridView_Main.Rows[i].Cells[4].Value);
                                param.SqlDbType = SqlDbType.Float;
                                cmd.Parameters.Add(param);

                                try
                                {
                                    if (connectionDB.State != ConnectionState.Open)
                                        connectionDB.Open();
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Помилка при додванні даних в табл. SaleTrans!" + ex.ToString());
                                    return;
                                }
                                if (connectionDB.State == ConnectionState.Open)
                                    connectionDB.Close();
                            }
                            Reconnect();
                            using (SqlCommand cmd = new SqlCommand("UPDATE SaleStorage SET amountS = amountS - @amount WHERE id=@id", connectionDB))
                            {
                                SqlParameter param = new SqlParameter();
                                param.ParameterName = "@id";
                                param.Value = dataGridView_Main.Rows[i].Cells[6].Value.ToString();
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@amount";
                                param.Value = dataGridView_Main.Rows[i].Cells[2].Value.ToString();
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Помилка оновлення таблиці SaleStorage" + ex.ToString());
                                    return;
                                }
                            }

                        }
                        else if (Convert.ToString(dataGridView_Main.Rows[i].Cells[7].Value) == "P")
                        {
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO Rent(id, idBill, idStorage, name, secondDate, state, amount, priceUAH) " +
                                        "VALUES(@id, @idBill, @idStorage, @name, @secondDate, @state, @amount, @priceUAH)", connectionDB))
                            {
                                SqlParameter param = new SqlParameter();
                                param.ParameterName = "@id";
                                param.Value = FindLastId("id", "Rent");
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@idBill";
                                param.Value = billId;
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@idStorage";
                                param.Value = Convert.ToInt32(dataGridView_Main.Rows[i].Cells[6].Value);
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@name";
                                param.Value = dataGridView_Main.Rows[i].Cells[1].Value.ToString();
                                param.SqlDbType = SqlDbType.NChar;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@secondDate";
                                param.Value = dataGridView_Main.Rows[i].Cells[3].Value.ToString();
                                param.SqlDbType = SqlDbType.Date;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@state";
                                param.Value = 0;
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@amount";
                                param.Value = Convert.ToInt32(dataGridView_Main.Rows[i].Cells[2].Value);
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@priceUAH";
                                param.Value = Convert.ToDouble(dataGridView_Main.Rows[i].Cells[4].Value);
                                param.SqlDbType = SqlDbType.Float;
                                cmd.Parameters.Add(param);

                                try
                                {
                                    if (connectionDB.State != ConnectionState.Open)
                                        connectionDB.Open();
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Помилка при додванні даних в табл. Rent!" + ex.ToString());
                                    return;
                                }
                                if (connectionDB.State == ConnectionState.Open)
                                    connectionDB.Close();
                            }
                            Reconnect();
                            using (SqlCommand cmd = new SqlCommand("UPDATE RentStorage SET amountS = amountS - @amount WHERE id=@id", connectionDB))
                            {
                                SqlParameter param = new SqlParameter();
                                param.ParameterName = "@id";
                                param.Value = dataGridView_Main.Rows[i].Cells[6].Value.ToString();
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@amount";
                                param.Value = dataGridView_Main.Rows[i].Cells[2].Value.ToString();
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Помилка оновлення таблиці SaleStorage" + ex.ToString());
                                    return;
                                }
                            }
                        }
                        else if (Convert.ToString(dataGridView_Main.Rows[i].Cells[7].Value) == "R")
                        {
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO RepairTrans(id, idBill, idInfo, name, amount, priceUAH) " +
                                        "VALUES(@id, @idBill, @idInfo, @name, @amount, @priceUAH)", connectionDB))
                            {
                                SqlParameter param = new SqlParameter();
                                param.ParameterName = "@id";
                                param.Value = FindLastId("id", "RepairTrans");
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@idBill";
                                param.Value = billId;
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@idInfo";
                                param.Value = Convert.ToInt32(dataGridView_Main.Rows[i].Cells[6].Value);
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@name";
                                param.Value = dataGridView_Main.Rows[i].Cells[1].Value.ToString();
                                param.SqlDbType = SqlDbType.NChar;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@amount";
                                param.Value = Convert.ToInt32(dataGridView_Main.Rows[i].Cells[2].Value);
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@priceUAH";
                                param.Value = Convert.ToDouble(dataGridView_Main.Rows[i].Cells[4].Value);
                                param.SqlDbType = SqlDbType.Float;
                                cmd.Parameters.Add(param);

                                try
                                {
                                    if (connectionDB.State != ConnectionState.Open)
                                        connectionDB.Open();
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Помилка при додванні даних в табл. Rent!" + ex.ToString());
                                    return;
                                }
                                if (connectionDB.State == ConnectionState.Open)
                                    connectionDB.Close();
                            }
                        }
                    }
                }
                PrintBill();
                dataGridView_Main.Rows.Clear();
                FindBalance();
            }
        }

        void ListSearch()//пошук по ліст боксам
        {
            if (tabControl_Main.SelectedTab == tabPage_Sale)//пошук по ліст боксу продажу
            {
                if (textBox_ListSearch.Text == "")
                    listBox_Sale.SelectedIndex = -1;
                else
                    listBox_Sale.SelectedIndex = listBox_Sale.FindString(textBox_ListSearch.Text);
            }
            else if (tabControl_Main.SelectedTab == tabPage_Rent)
            {
                if (textBox_ListSearch.Text == "")
                    listBox_Rent.SelectedIndex = -1;
                else
                    listBox_Rent.SelectedIndex = listBox_Rent.FindString(textBox_ListSearch.Text);
            }
            else if (tabControl_Main.SelectedTab == tabPage_Repair)
            {
                if (textBox_ListSearch.Text == "")
                    listBox_Repair.SelectedIndex = -1;
                else
                    listBox_Repair.SelectedIndex = listBox_Repair.FindString(textBox_ListSearch.Text);
            }
        }

        void UpdateDollar()
        {
            var findDollar = new DollarForm();
            findDollar.Owner = this;
            findDollar.ShowDialog();
        }

        void PrintBill()
        {
            double sum=0;
            Reconnect();
            SqlCommand cmd = new SqlCommand("SELECT sumUAH FROM Bill WHERE id = "+ (FindLastId("id", "Bill")-1).ToString(), connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                        sum = Convert.ToDouble(dr.GetValue(0).ToString().Trim());
                }
            }
            var billPrint = new BillPrint(dataGridView_Main, FindLastId("id", "Bill")-1, sum);
        }

        private void listBox_Sale_SelectedIndexChanged(object sender, EventArgs e)//вивід залишку на складі
        {
            FindBalance();
        }

        private void button_AddPos_Click(object sender, EventArgs e)
        {
            AddPos();
        }

        private void textBox_ListSearch_TextChanged(object sender, EventArgs e)
        {
            ListSearch();
        }

        private void button_DeletePos_Click(object sender, EventArgs e)
        {
            DeletePos();
        }

        private void button_Sell_Click(object sender, EventArgs e)
        {
            CloseBill();
        }
        
        private void курсДолараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDollar();
        }

        private void tabControl_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_AmountS.Clear();
            textBox_PriceUAH.Clear();
        }

        private void відкритийПрокатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var opentRent = new RentOpen();
            opentRent.Show();
        }

        private void надходженняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var income = new Income();
            income.ShowDialog();
        }

        private void адмініструванняToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminForm();
            adminForm.ShowDialog();
            BoxFilling();
        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InfoMain = new Info("main");
            InfoMain.ShowDialog();
        }
    }
}
