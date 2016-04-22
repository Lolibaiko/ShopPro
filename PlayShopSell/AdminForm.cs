using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayShopSell
{
    public partial class AdminForm : Form
    {
        string connectionStr;
        SqlConnection connectionDB;
        public AdminForm()
        {
            InitializeComponent();
            DBConnect();
            GridFilling();
            tabChange();
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

        void GridFilling()
        {
            dataGridView_SaleStorage.Rows.Clear();
            dataGridView_RentStorage.Rows.Clear();
            dataGridView_RepairInfo.Rows.Clear();
            Reconnect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SaleStorage WHERE id != 0", connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    dataGridView_SaleStorage.Rows.Add();
                    dataGridView_SaleStorage.Rows[dataGridView_SaleStorage.Rows.Count - 1].Cells[0].Value = dr.GetValue(0).ToString().Trim();
                    dataGridView_SaleStorage.Rows[dataGridView_SaleStorage.Rows.Count - 1].Cells[1].Value = dr.GetValue(1).ToString().Trim();
                    dataGridView_SaleStorage.Rows[dataGridView_SaleStorage.Rows.Count - 1].Cells[2].Value = dr.GetValue(2).ToString().Trim();
                    dataGridView_SaleStorage.Rows[dataGridView_SaleStorage.Rows.Count - 1].Cells[3].Value = dr.GetValue(3).ToString().Trim();
                }
            }

            Reconnect();
            cmd = new SqlCommand("SELECT * FROM RentStorage WHERE id != 0", connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    dataGridView_RentStorage.Rows.Add();
                    dataGridView_RentStorage.Rows[dataGridView_RentStorage.Rows.Count - 1].Cells[0].Value = dr.GetValue(0).ToString().Trim();
                    dataGridView_RentStorage.Rows[dataGridView_RentStorage.Rows.Count - 1].Cells[1].Value = dr.GetValue(1).ToString().Trim();
                    dataGridView_RentStorage.Rows[dataGridView_RentStorage.Rows.Count - 1].Cells[2].Value = dr.GetValue(2).ToString().Trim();
                    dataGridView_RentStorage.Rows[dataGridView_RentStorage.Rows.Count - 1].Cells[3].Value = dr.GetValue(3).ToString().Trim();
                }
            }

            Reconnect();
            cmd = new SqlCommand("SELECT * FROM RepairInfo WHERE id != 0", connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    dataGridView_RepairInfo.Rows.Add();
                    dataGridView_RepairInfo.Rows[dataGridView_RepairInfo.Rows.Count - 1].Cells[0].Value = dr.GetValue(0).ToString().Trim();
                    dataGridView_RepairInfo.Rows[dataGridView_RepairInfo.Rows.Count - 1].Cells[1].Value = dr.GetValue(1).ToString().Trim();
                    dataGridView_RepairInfo.Rows[dataGridView_RepairInfo.Rows.Count - 1].Cells[2].Value = dr.GetValue(2).ToString().Trim();
                }
            }
        }

        void BillsFilling()
        {
            if (tabControl_Admin.SelectedTab == tabPage_Bills)
            {
                dataGridView_Bills.Rows.Clear();
                Reconnect();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Bill WHERE id != 0 AND date BETWEEN '"+ String.Format("{0:MM-dd-yyyy}", dateTimePicker_FirstDate.Value.Date) +"' AND '"+ String.Format("{0:MM-dd-yyyy}", dateTimePicker_SecondDate.Value.Date) +"'" , connectionDB);
                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (dr.Read())
                    {
                        dataGridView_Bills.Rows.Add();
                        dataGridView_Bills.Rows[dataGridView_Bills.Rows.Count - 1].Cells[0].Value = dr.GetValue(0).ToString().Trim();
                        dataGridView_Bills.Rows[dataGridView_Bills.Rows.Count - 1].Cells[1].Value = dr.GetValue(1).ToString().Trim();
                        dataGridView_Bills.Rows[dataGridView_Bills.Rows.Count - 1].Cells[2].Value = dr.GetValue(2).ToString().Trim();
                    }
                }
            }
            else if(tabControl_Admin.SelectedTab == tabPage_StorageIncome)
            {
                dataGridView_StorageIncome.Rows.Clear();
                Reconnect();
                SqlCommand cmd = new SqlCommand("SELECT StorageIncome.id, SaleStorage.name, StorageIncome.amount, StorageIncome.date FROM StorageIncome " +
                "JOIN SaleStorage ON SaleStorage.id = StorageIncome.idStorage WHERE StorageIncome.id != 0 AND StorageIncome.date BETWEEN '"+ String.Format("{0:MM-dd-yyyy}", dateTimePicker_FirstDate.Value.Date) + "' AND '"+ String.Format("{0:MM-dd-yyyy}", dateTimePicker_SecondDate.Value.Date) + "'", connectionDB);
                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (dr.Read())
                    {
                        dataGridView_StorageIncome.Rows.Add();
                        dataGridView_StorageIncome.Rows[dataGridView_StorageIncome.Rows.Count - 1].Cells[0].Value = dr.GetValue(0).ToString().Trim();
                        dataGridView_StorageIncome.Rows[dataGridView_StorageIncome.Rows.Count - 1].Cells[1].Value = dr.GetValue(1).ToString().Trim();
                        dataGridView_StorageIncome.Rows[dataGridView_StorageIncome.Rows.Count - 1].Cells[2].Value = dr.GetValue(2).ToString().Trim();
                        dataGridView_StorageIncome.Rows[dataGridView_StorageIncome.Rows.Count - 1].Cells[3].Value = dr.GetValue(3).ToString().Trim();
                    }
                }
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

        int FindTableCount(string table)
        {
            int res;
            Reconnect();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM " + table, connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                dr.Read();
                res = Convert.ToInt32(dr.GetValue(0));
            }
            return res;
        }

        void TransSort(string table, string cell, int value, int oldValue)
        {
            Reconnect();
            using (SqlCommand cmd = new SqlCommand("UPDATE " + table + " SET " + cell + " = @id WHERE " + cell + " = " + oldValue + "AND id != 0", connectionDB))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id";
                param.Value = value;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка оновлення таблиці " + table + ex.ToString());
                    return;
                }
            }
        }

        void DBSort(string table, DataGridView activeGrid)
        {
            Reconnect();
            int idCount = FindTableCount(table);
            for (int i = 1; i < idCount; i++)
            {
                if (activeGrid.Name == "dataGridView_SaleStorage")
                {
                    TransSort("SaleTrans", "idStorage", 0, Convert.ToInt32(activeGrid.Rows[i - 1].Cells[0].Value));
                    TransSort("StorageIncome", "idStorage", 0, Convert.ToInt32(activeGrid.Rows[i - 1].Cells[0].Value));
                }
                else if (activeGrid.Name == "dataGridView_RentStorage")
                    TransSort("Rent", "idStorage", 0, Convert.ToInt32(activeGrid.Rows[i - 1].Cells[0].Value));
                else if (activeGrid.Name == "dataGridView_RepairInfo")
                    TransSort("RepairTrans", "idInfo", 0, Convert.ToInt32(activeGrid.Rows[i - 1].Cells[0].Value));
                using (SqlCommand cmd = new SqlCommand("UPDATE " + table + " SET id = @id WHERE id = " + Convert.ToInt32(activeGrid.Rows[i - 1].Cells[0].Value), connectionDB))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@id";
                    param.Value = i;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка оновлення таблиці " + table + ex.ToString());
                        return;
                    }
                }
                if (activeGrid.Name == "dataGridView_SaleStorage")
                {
                    TransSort("SaleTrans", "idStorage", i, 0);
                    TransSort("StorageIncome", "idStorage", i, 0);
                }
                else if (activeGrid.Name == "dataGridView_RentStorage")
                    TransSort("Rent", "idStorage", i, 0);
                else if (activeGrid.Name == "dataGridView_RepairInfo")
                    TransSort("RepairTrans", "idInfo", i, 0);
            }
        }

        void AddPos()
        {
            if (MessageBox.Show("Ви дійсно бажаєте дадати позицію?", "Додати позицію?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (textBox_Name.Text == "")
                    MessageBox.Show("Поле \"Назва\" не заповнене!");
                else if (textBox_Price.Text == "")
                    MessageBox.Show("Поле \"Ціна\" не заповнене!");
                else if (tabControl_Admin.SelectedTab == tabPage_SaleStorage)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO SaleStorage(id, name, amountS, priceUSD) " +
                                            "VALUES(@id, @name, @amountS, @priceUSD)", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = FindLastId("id", "SaleStorage");
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@name";
                        param.Value = textBox_Name.Text;
                        param.SqlDbType = SqlDbType.NChar;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@amountS";
                        param.Value = 0;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@priceUSD";
                        param.Value = Convert.ToDouble(textBox_Price.Text);
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
                            MessageBox.Show("Помилка при додванні даних в табл. SaleStorage!" + ex.ToString());
                            return;
                        }
                        if (connectionDB.State == ConnectionState.Open)
                            connectionDB.Close();
                    }
                    GridFilling();
                }
                else if (tabControl_Admin.SelectedTab == tabPage_RentStorage)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO RentStorage(id, name, amountS, priceUAH) " +
                                            "VALUES(@id, @name, @amountS, @priceUAH)", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = FindLastId("id", "RentStorage");
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@name";
                        param.Value = textBox_Name.Text;
                        param.SqlDbType = SqlDbType.NChar;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@amountS";
                        param.Value = 0;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@priceUAH";
                        param.Value = Convert.ToDouble(textBox_Price.Text);
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
                            MessageBox.Show("Помилка при додванні даних в табл. RentStorage!" + ex.ToString());
                            return;
                        }
                        if (connectionDB.State == ConnectionState.Open)
                            connectionDB.Close();
                    }
                    GridFilling();
                }
                else if (tabControl_Admin.SelectedTab == tabPage_RepairInfo)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO RepairInfo(id, name, priceUAH) " +
                                            "VALUES(@id, @name, @priceUAH)", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = FindLastId("id", "RepairInfo");
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@name";
                        param.Value = textBox_Name.Text;
                        param.SqlDbType = SqlDbType.NChar;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@priceUAH";
                        param.Value = Convert.ToDouble(textBox_Price.Text);
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
                            MessageBox.Show("Помилка при додванні даних в табл. RepairInfo!" + ex.ToString());
                            return;
                        }
                        if (connectionDB.State == ConnectionState.Open)
                            connectionDB.Close();
                    }
                    GridFilling();
                }
                else
                    MessageBox.Show("Вибрана невірна вкладка!");
            }
        }

        void DeletePos()
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити позицію?", "Видалити позицію?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (tabControl_Admin.SelectedTab == tabPage_SaleStorage)
                {
                    int id = Convert.ToInt32(dataGridView_SaleStorage.Rows[dataGridView_SaleStorage.CurrentRow.Index].Cells[0].Value);
                    Reconnect();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM SaleTrans WHERE idStorage = @id", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.ToString());
                            return;
                        }
                    }

                    Reconnect();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM StorageIncome WHERE idStorage = @id", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.ToString());
                            return;
                        }
                    }

                    Reconnect();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM SaleStorage WHERE id = @id", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.ToString());
                            return;
                        }
                    }
                    GridFilling();
                    DBSort("SaleStorage", dataGridView_SaleStorage);
                    GridFilling();
                }
                else if (tabControl_Admin.SelectedTab == tabPage_RentStorage)
                {
                    int id = Convert.ToInt32(dataGridView_RentStorage.Rows[dataGridView_RentStorage.CurrentRow.Index].Cells[0].Value);
                    Reconnect();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Rent WHERE idStorage = @idStorage", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@idStorage";
                        param.Value = id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.ToString());
                            return;
                        }
                    }

                    Reconnect();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM RentStorage WHERE id = @id", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.ToString());
                            return;
                        }
                    }
                    GridFilling();
                    DBSort("RentStorage", dataGridView_RentStorage);
                    GridFilling();
                }
                else if (tabControl_Admin.SelectedTab == tabPage_RepairInfo)
                {
                    int id = Convert.ToInt32(dataGridView_RepairInfo.Rows[dataGridView_RepairInfo.CurrentRow.Index].Cells[0].Value);
                    Reconnect();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM RepairTrans WHERE idInfo = @idInfo", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@idInfo";
                        param.Value = id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.ToString());
                            return;
                        }
                    }

                    Reconnect();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM RepairInfo WHERE id = @id", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = Convert.ToInt32(dataGridView_RepairInfo.Rows[dataGridView_RepairInfo.CurrentRow.Index].Cells[0].Value);
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.ToString());
                            return;
                        }
                    }

                    GridFilling();
                    DBSort("RepairInfo", dataGridView_RepairInfo);
                    GridFilling();
                }
            }
        }

        void tabChange()
        {
            if (tabControl_Admin.SelectedTab == tabPage_Bills)
            {
                textBox_Name.Enabled = false;
                textBox_Price.Enabled = false;
                button_Add.Enabled = false;
                button_DeletePos.Enabled = false;
                button_Update.Enabled = false;
                dateTimePicker_FirstDate.Enabled = true;
                dateTimePicker_SecondDate.Enabled = true;
                button_Show.Enabled = true;
                button_Deploy.Enabled = true;
            }
            else if (tabControl_Admin.SelectedTab == tabPage_SaleStorage)
            {
                textBox_Name.Enabled = true;
                textBox_Price.Enabled = true;
                button_Add.Enabled = true;
                button_DeletePos.Enabled = true;
                button_Update.Enabled = true;
                dateTimePicker_FirstDate.Enabled = false;
                dateTimePicker_SecondDate.Enabled = false;
                button_Show.Enabled = false;
                button_Deploy.Enabled = false;
                label_Price.Text = "USD";
            }
            else if (tabControl_Admin.SelectedTab == tabPage_RentStorage)
            {
                textBox_Name.Enabled = true;
                textBox_Price.Enabled = true;
                button_Add.Enabled = true;
                button_DeletePos.Enabled = true;
                button_Update.Enabled = true;
                dateTimePicker_FirstDate.Enabled = false;
                dateTimePicker_SecondDate.Enabled = false;
                button_Show.Enabled = false;
                button_Deploy.Enabled = false;
                label_Price.Text = "UAH";
            }
            else if (tabControl_Admin.SelectedTab == tabPage_RepairInfo)
            {
                textBox_Name.Enabled = true;
                textBox_Price.Enabled = true;
                button_Add.Enabled = true;
                button_DeletePos.Enabled = true;
                button_Update.Enabled = true;
                dateTimePicker_FirstDate.Enabled = false;
                dateTimePicker_SecondDate.Enabled = false;
                button_Show.Enabled = false;
                button_Deploy.Enabled = false;
                label_Price.Text = "UAH";
            }
            else if (tabControl_Admin.SelectedTab == tabPage_StorageIncome)
            {
                textBox_Name.Enabled = false;
                textBox_Price.Enabled = false;
                button_Add.Enabled = false;
                button_DeletePos.Enabled = false;
                button_Update.Enabled = false;
                dateTimePicker_FirstDate.Enabled = true;
                dateTimePicker_SecondDate.Enabled = true;
                button_Show.Enabled = true;
                button_Deploy.Enabled = false;
            }
        }

        void UpdatePos()
        {
            Reconnect();
            if (tabControl_Admin.SelectedTab == tabPage_SaleStorage)
            {
                for (int i = 0; i < dataGridView_SaleStorage.Rows.Count; i++)
                {
                    int temp;
                    if(!Int32.TryParse(dataGridView_SaleStorage.Rows[i].Cells[2].Value.ToString(), out temp))
                        MessageBox.Show("Введено невірні дані кількості!");
                    else if (Convert.ToDouble(dataGridView_SaleStorage.Rows[i].Cells[2].Value) != Convert.ToInt32(dataGridView_SaleStorage.Rows[i].Cells[2].Value))
                        MessageBox.Show("Введено невірні дані кількості!");
                    else
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE SaleStorage SET name = @name, amountS = @amountS, priceUSD = @priceUSD WHERE id=@id", connectionDB);
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = dataGridView_SaleStorage.Rows[i].Cells[0].Value;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@name";
                        param.Value = dataGridView_SaleStorage.Rows[i].Cells[1].Value;
                        param.SqlDbType = SqlDbType.NChar;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@amountS";
                        param.Value = dataGridView_SaleStorage.Rows[i].Cells[2].Value;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@priceUSD";
                        param.Value = dataGridView_SaleStorage.Rows[i].Cells[3].Value;
                        param.SqlDbType = SqlDbType.Float;
                        cmd.Parameters.Add(param);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка, при выполнении запроса на изменение записи(ей)" + ex.ToString());
                            return;
                        }
                    }
                }
            }
            else if (tabControl_Admin.SelectedTab == tabPage_RentStorage)
            {
                for (int i = 0; i < dataGridView_RentStorage.Rows.Count; i++)
                {
                    int temp;
                    if (!Int32.TryParse(dataGridView_RentStorage.Rows[i].Cells[2].Value.ToString(), out temp))
                        MessageBox.Show("Введено невірні дані кількості!");
                    else if(Convert.ToDouble(dataGridView_RentStorage.Rows[i].Cells[2].Value) != Convert.ToInt32(dataGridView_RentStorage.Rows[i].Cells[2].Value))
                        MessageBox.Show("Введено невірні дані кількості!");
                    else
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE RentStorage SET name = @name, amountS = @amountS, priceUAH = @priceUAH WHERE id=@id", connectionDB);

                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = dataGridView_RentStorage.Rows[i].Cells[0].Value;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@name";
                        param.Value = dataGridView_RentStorage.Rows[i].Cells[1].Value;
                        param.SqlDbType = SqlDbType.NChar;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@amountS";
                        param.Value = dataGridView_RentStorage.Rows[i].Cells[2].Value;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@priceUAH";
                        param.Value = dataGridView_RentStorage.Rows[i].Cells[3].Value;
                        param.SqlDbType = SqlDbType.Float;
                        cmd.Parameters.Add(param);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка, при выполнении запроса на изменение записи(ей)" + ex.ToString());
                            return;
                        }
                    }
                }
            }
            else if (tabControl_Admin.SelectedTab == tabPage_RepairInfo)
            {
                for (int i = 0; i < dataGridView_RepairInfo.Rows.Count; i++)
                {
                    if (Convert.ToDouble(dataGridView_SaleStorage.Rows[i].Cells[2].Value) != Convert.ToInt32(dataGridView_SaleStorage.Rows[i].Cells[2].Value))
                        MessageBox.Show("Введено невірні дані кількості!");
                    else
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE SaleStorage SET name = @name, priceUAH = @priceUAH WHERE id=@id", connectionDB);

                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = dataGridView_RepairInfo.Rows[i].Cells[0].Value;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@name";
                        param.Value = dataGridView_RepairInfo.Rows[i].Cells[1].Value;
                        param.SqlDbType = SqlDbType.NChar;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@priceUSD";
                        param.Value = dataGridView_RepairInfo.Rows[i].Cells[2].Value;
                        param.SqlDbType = SqlDbType.Float;
                        cmd.Parameters.Add(param);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка, при выполнении запроса на изменение записи(ей)" + ex.ToString());
                            return;
                        }
                    }
                }
            }
            GridFilling();
        }

        void GetIncome()
        {
            if (comboBox_IncomeType.SelectedIndex == 0)
            {
                double res = 0;
                Reconnect();
                SqlCommand cmd = new SqlCommand("SELECT sumUAH FROM Bill WHERE date BETWEEN '" + String.Format("{0:MM-dd-yyyy}", dateTimePicker_FirstDate.Value.Date) + "' AND '" + String.Format("{0:MM-dd-yyyy}", dateTimePicker_SecondDate.Value.Date) + "'", connectionDB);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while(dr.Read())
                        res += Convert.ToDouble(dr.GetValue(0));
                }
                MessageBox.Show("Загальний прибуток складає: " + res.ToString());
            }
            else if (comboBox_IncomeType.SelectedIndex == 1)
            {
                double res = 0;
                Reconnect();
                SqlCommand cmd = new SqlCommand("SELECT SaleTrans.amount, SaleTrans.priceUAH "+
                    "FROM Bill INNER JOIN SaleTrans ON Bill.id = SaleTrans.idBill WHERE Bill.date BETWEEN '" + String.Format("{0:MM-dd-yyyy}", dateTimePicker_FirstDate.Value.Date) + "' AND '" + String.Format("{0:MM-dd-yyyy}", dateTimePicker_SecondDate.Value.Date) + "'", connectionDB);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while(dr.Read())
                        res += Convert.ToDouble(dr.GetValue(0))*Convert.ToDouble(dr.GetValue(1));
                }
                MessageBox.Show("Прибуток за продаж складає: " + res.ToString());
            }
            else if (comboBox_IncomeType.SelectedIndex == 2)
            {
                double res = 0;
                Reconnect();
                SqlCommand cmd = new SqlCommand("SELECT Bill.date, Rent.secondDate, Rent.amount, Rent.priceUAH " +
                    "FROM Bill INNER JOIN Rent ON Bill.id = Rent.idBill WHERE Rent.id != 0 AND Bill.date BETWEEN '" + String.Format("{0:MM-dd-yyyy}", dateTimePicker_FirstDate.Value.Date) + "' AND '" + String.Format("{0:MM-dd-yyyy}", dateTimePicker_SecondDate.Value.Date) + "'", connectionDB);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        TimeSpan days = Convert.ToDateTime(dr.GetValue(1)).Date - Convert.ToDateTime(dr.GetValue(0)).Date;
                        int daysCount = days.Days;
                        res += Convert.ToDouble(dr.GetValue(2)) * Convert.ToDouble(dr.GetValue(3)) * daysCount;
                    }
                }
                MessageBox.Show("Прибуток за прокат складає: " + res.ToString());
            }
            else if (comboBox_IncomeType.SelectedIndex == 3)
            {
                double res = 0;
                Reconnect();
                SqlCommand cmd = new SqlCommand("SELECT RepairTrans.amount, RepairTrans.priceUAH " +
                    "FROM RepairTrans INNER JOIN Bill ON Bill.id = RepairTrans.idBill WHERE Bill.date BETWEEN '" + String.Format("{0:MM-dd-yyyy}", dateTimePicker_FirstDate.Value.Date) + "' AND '" + String.Format("{0:MM-dd-yyyy}", dateTimePicker_SecondDate.Value.Date) + "'", connectionDB);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        res += Convert.ToDouble(dr.GetValue(0)) * Convert.ToDouble(dr.GetValue(1));
                    }
                }
                MessageBox.Show("Прибуток за ремонт складає: " + res.ToString());
            }
            else if (comboBox_IncomeType.SelectedIndex == 4)
            {
                double res = 0;
                    Reconnect();
                    SqlCommand cmd = new SqlCommand("SELECT SaleTrans.amount, SaleStorage.priceUSD " +
                        "FROM SaleTrans INNER JOIN SaleStorage ON SaleTrans.idStorage = SaleStorage.id INNER JOIN Bill ON SaleTrans.idBill = Bill.id WHERE SaleStorage.id != 0 AND Bill.date BETWEEN '" + String.Format("{0:MM-dd-yyyy}", dateTimePicker_FirstDate.Value.Date) + "' AND '" + String.Format("{0:MM-dd-yyyy}", dateTimePicker_SecondDate.Value.Date) + "'", connectionDB);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            res += Convert.ToDouble(dr.GetValue(0)) * Convert.ToDouble(dr.GetValue(1));
                        }
                    }
                MessageBox.Show("Прибуток за ремонт складає: " + res.ToString());
            }
            else
                MessageBox.Show("Виберіть тип прибутку!");
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            BillsFilling();
        }

        private void button_Deploy_Click(object sender, EventArgs e)
        {
            if (tabControl_Admin.SelectedTab == tabPage_Bills && dataGridView_Bills.Rows.Count > 0)
            {
                var deployGrid = new BillDeploy(Convert.ToInt32(dataGridView_Bills.CurrentRow.Cells[0].Value));
                deployGrid.Show();
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddPos();
        }

        private void tabControl_Admin_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabChange();
        }

        private void button_DeletePos_Click(object sender, EventArgs e)
        {
            DeletePos();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            UpdatePos();
        }

        private void button_GetIncome_Click(object sender, EventArgs e)
        {
            GetIncome();
        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InfoAdmin = new Info("admin");
            InfoAdmin.ShowDialog();
        }

        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
                e.KeyChar = ',';
            else if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
