using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectDatabase
{
    public partial class passchange : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Database=project;User id=root;password=''");
        MySqlCommand comm;
        public passchange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p1 = pass1.Text;
            var p2 = pass2.Text;
            if (p1 == p2)
            {
                comm = con.CreateCommand();
                comm.CommandText = "Update project.user_account" +
                    " set password = @pass where u_id='"+ UserInfo.Name +"'";
                comm.Parameters.AddWithValue("@pass", p2);
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("password updated!");
                this.Close();
                EditAcc newform = (EditAcc)Application.OpenForms["EditAcc"];
                newform.Close();
                EditAcc fm = new EditAcc();
                fm.Show();
            }
            else
            {
                MessageBox.Show("password is not the same or can't blank!");
                pass1.Clear();
                pass2.Clear();
                pass1.Select();
            }
           
            
        }

        private void passchange_Load(object sender, EventArgs e)
        {
            con.Open();
        }
    }
}
