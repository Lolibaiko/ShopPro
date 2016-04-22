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
    public partial class Info : Form
    {
        string type;
        public Info(String tepeStr)
        {
            type = tepeStr;
            InitializeComponent();
            GetInfo();
        }
        void GetInfo()
        {
            if (type == "main")
            {
                richTextBox_Main.Visible = true;
            }
            else if (type == "admin")
            {
                richTextBox_Admin.Visible = true;
            }
            else
                MessageBox.Show("ERROR!");
        }
    }
}
