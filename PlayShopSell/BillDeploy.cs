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
    public partial class BillDeploy : Form
    {
        int idBill;
        string connectionStr;
        SqlConnection connectionDB;
        public BillDeploy(int id)
        {
            InitializeComponent();
            DBConnect();
            idBill = id;
            DeployBill();
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

        void DeployBill()
        {

            Reconnect();
            SqlCommand cmd = new SqlCommand("SELECT name, amount, priceUAH FROM SaleTrans WHERE id != 0 AND idBill = "+ idBill, connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    dataGridView_Main.Rows.Add();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[0].Value = dataGridView_Main.Rows.Count;
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[1].Value = dr.GetValue(0).ToString().Trim();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[2].Value = dr.GetValue(1).ToString().Trim();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[4].Value = dr.GetValue(2).ToString().Trim();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[5].Value = (Convert.ToDouble(dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[2].Value) * Convert.ToDouble(dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[4].Value)).ToString();
                }
            }

            Reconnect();
            cmd = new SqlCommand("SELECT Rent.name, Rent.secondDate, Rent.amount, Rent.priceUAH, Bill.date "+
                "FROM Rent INNER JOIN Bill ON Rent.idBill = Bill.id WHERE Rent.id != 0 AND Rent.idBill = " + idBill, connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    dataGridView_Main.Rows.Add();
                    DateTime firsDate = Convert.ToDateTime(dr.GetValue(4).ToString().Trim()), secondDate = Convert.ToDateTime(dr.GetValue(1).ToString().Trim());
                    TimeSpan span = secondDate.Date - firsDate.Date;
                    int days = span.Days;
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[0].Value = dataGridView_Main.Rows.Count;
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[1].Value = dr.GetValue(0).ToString().Trim();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[2].Value = dr.GetValue(2).ToString().Trim();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[3].Value = dr.GetValue(1).ToString().Trim();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[4].Value = dr.GetValue(3).ToString().Trim();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[5].Value = (Convert.ToDouble(dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[2].Value) * Convert.ToDouble(dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[4].Value) * days).ToString();
                }
            }

            Reconnect();
            cmd = new SqlCommand("SELECT name, amount, priceUAH FROM RepairTrans WHERE id != 0 AND idBill = " + idBill, connectionDB);
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                while (dr.Read())
                {
                    dataGridView_Main.Rows.Add();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[0].Value = dataGridView_Main.Rows.Count;
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[1].Value = dr.GetValue(0).ToString().Trim();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[2].Value = dr.GetValue(1).ToString().Trim();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[4].Value = dr.GetValue(2).ToString().Trim();
                    dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[5].Value = (Convert.ToDouble(dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[2].Value) * Convert.ToDouble(dataGridView_Main.Rows[dataGridView_Main.Rows.Count - 1].Cells[4].Value)).ToString();
                }
            }
        }
    }
}
