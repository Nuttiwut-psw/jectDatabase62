using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class register_login : Form
    {
        public register_login()
        {
            InitializeComponent();
        }

        private void buy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register f3 = new Register();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login f3 = new login();
            f3.ShowDialog();
        }
    }
}
