using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayShopSell
{
    public partial class DollarForm : Form
    {
        public DollarForm()
        {
            InitializeComponent();
        }

        void UpdateUSD()
        {
            if (textBox_Dollar.Text != "" && textBox_Dollar.Text != "0")
                if (MessageBox.Show("Ви дійсно бажаєте оновити курс?", "Оновити курс?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form1 MainForm = (Form1)this.Owner;
                    MainForm.USD = Convert.ToDouble(textBox_Dollar.Text);
                    MainForm.textBox_Dollar.Text = textBox_Dollar.Text;
                    this.Close();
                }
                else
                    MessageBox.Show("Не введено курс!");
        }

        private void button_DollarUpdute_Click(object sender, EventArgs e)
        {
            UpdateUSD();
        }

        private void textBox_Dollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
                e.KeyChar = ',';
            else if (e.KeyChar == 13)
                UpdateUSD();
            else if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
