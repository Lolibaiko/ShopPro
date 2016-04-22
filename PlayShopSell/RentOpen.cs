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
    public partial class RentOpen : Form
    {
        string connectionStr;
        SqlConnection connectionDB;
        public RentOpen()
        {
            InitializeComponent();
            DBConnect();
            GridFilling();
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
            dataGridView_RentOpen.Rows.Clear();
            Reconnect();
            SqlCommand cmd = new SqlCommand("SELECT id, name, secondDate, amount, priceUAH FROM Rent WHERE state = 0", connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {

                while (dr.Read())
                {
                    dataGridView_RentOpen.Rows.Add();
                    dataGridView_RentOpen.Rows[dataGridView_RentOpen.Rows.Count - 1].Cells[0].Value = dr.GetValue(0).ToString().Trim();
                    dataGridView_RentOpen.Rows[dataGridView_RentOpen.Rows.Count - 1].Cells[1].Value = dr.GetValue(1).ToString().Trim();
                    dataGridView_RentOpen.Rows[dataGridView_RentOpen.Rows.Count - 1].Cells[2].Value = dr.GetValue(2).ToString().Trim();
                    dataGridView_RentOpen.Rows[dataGridView_RentOpen.Rows.Count - 1].Cells[3].Value = dr.GetValue(3).ToString().Trim();
                    dataGridView_RentOpen.Rows[dataGridView_RentOpen.Rows.Count - 1].Cells[4].Value = dr.GetValue(4).ToString().Trim();
                }
            }
        }

        private void button_RentClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте закрити рахунок?", "Закрити рахунок?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Reconnect();
                if (dataGridView_RentOpen.Rows.Count > 0)
                {
                    int idStorage = 0, amount = 0;
                    SqlCommand cmd = new SqlCommand("SELECT idStorage, amount FROM Rent WHERE id = "+ Convert.ToInt32(dataGridView_RentOpen.Rows[dataGridView_RentOpen.CurrentRow.Index].Cells[0].Value), connectionDB);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            
                            idStorage = Convert.ToInt32(dr.GetValue(0).ToString().Trim());
                            amount = Convert.ToInt32(dr.GetValue(1).ToString().Trim());
                        }
                    }

                    Reconnect();
                    using (cmd = new SqlCommand("UPDATE Rent SET state = 1 WHERE id=@id", connectionDB))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id";
                        param.Value = Convert.ToInt32(dataGridView_RentOpen.Rows[dataGridView_RentOpen.CurrentRow.Index].Cells[0].Value);
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка оновлення таблиці Rent" + ex.ToString());
                            return;
                        }
                    }
                    if (idStorage != 0)
                    {
                        Reconnect();
                        using (cmd = new SqlCommand("UPDATE RentStorage SET amountS = AmountS + @amount WHERE id=@id", connectionDB))
                        {
                            SqlParameter param = new SqlParameter();
                            param.ParameterName = "@id";
                            param.Value = idStorage;
                            param.SqlDbType = SqlDbType.Int;
                            cmd.Parameters.Add(param);

                            param = new SqlParameter();
                            param.ParameterName = "@amount";
                            param.Value = amount;
                            param.SqlDbType = SqlDbType.Int;
                            cmd.Parameters.Add(param);
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Помилка оновлення таблиці Rent" + ex.ToString());
                                return;
                            }
                        }
                    }
                    else
                        MessageBox.Show("Помилка оновлення табл. RentStorage");
                }
                GridFilling();
            }
        }
    }
}
