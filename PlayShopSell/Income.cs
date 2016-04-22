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
    public partial class Income : Form
    {
        string connectionStr;
        SqlConnection connectionDB;
        public Income()
        {
            InitializeComponent();
            DBConnect();
            BoxFilling();
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

        void BoxFilling()
        {
            Reconnect();
            SqlCommand cmd = new SqlCommand("SELECT name FROM SaleStorage WHERE id != 0", connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    if (dr.GetValue(0).ToString().Trim() != "0")
                        listBox_List.Items.Add(dr.GetValue(0).ToString().Trim());
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

        void AddIncome()
        {
            if (MessageBox.Show("Ви дійсно бажаєте додати надходження?", "Додати надходження?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int temp;
                if (!Int32.TryParse(textBox_Amount.Text, out temp))
                    MessageBox.Show("Введено невірні дані кількості!");
                else if (textBox_Amount.Text != "")
                {
                    Reconnect();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO StorageIncome(id, idStorage, amount, date) VALUES(@id, @idStorage, @amount, @date)", connectionDB))
                    {
                        int billId = FindLastId("id", "StorageIncome");
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = billId;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@idStorage";
                        param.Value = Convert.ToInt32(listBox_List.SelectedIndex + 1);
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@amount";
                        param.Value = Convert.ToInt32(textBox_Amount.Text);
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@date";
                        param.Value = DateTime.Now;
                        param.SqlDbType = SqlDbType.DateTime;
                        cmd.Parameters.Add(param);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка при додванні даних в табл. НадходженняДоСкладу!" + ex.ToString());
                            return;
                        }
                    }
                    Reconnect();
                    using (SqlCommand cmd = new SqlCommand("UPDATE SaleStorage SET amountS = amountS + @amount WHERE id = @id", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = Convert.ToInt32(listBox_List.SelectedIndex + 1);
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@amount";
                        param.Value = Convert.ToInt32(textBox_Amount.Text);
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка при оновленні даних в табл. склад!" + ex.ToString());
                            return;
                        }
                    }
                }
                else
                    MessageBox.Show("Не введена кількість!");
            }
        }

        void ListSearch()//пошук по ліст боксам
        {
                if (textBox_Search.Text == "")
                    listBox_List.SelectedIndex = -1;
                else
                    listBox_List.SelectedIndex = listBox_List.FindString(textBox_Search.Text);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddIncome();
        }

        private void textBox_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
    }
}
