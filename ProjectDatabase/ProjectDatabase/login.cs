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
    public partial class login : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Database=project;User id=root;password=''");
        MySqlCommand comm;
        int i;
        public login()
        {
            InitializeComponent();
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if(showpassword.Checked == true)
            {
                passwordtextbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtextbox.UseSystemPasswordChar = true;
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            i = 0;
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from user_account where u_id='" + usernametextbox.Text + "'and password='" + passwordtextbox.Text + "'";
            cmd.ExecuteNonQuery();
            var name = usernametextbox.Text;
            comm = con.CreateCommand();
            comm.CommandText = "Insert into project.login_his values @u_id";
            comm.Parameters.AddWithValue("@u_id", name);
            UserInfo.Name = usernametextbox.Text;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("The username or password is incorrect. Try again!");
                usernametextbox.Clear();
                passwordtextbox.Clear();
                usernametextbox.Select();
            }
            else
            {
                string data = usernametextbox.Text;
                register_login newform = (register_login)Application.OpenForms["register_login"];
                newform.Close();
                this.Close();
                Acc fm = new Acc(data);
                fm.Show();
                con.Close();
            }
            
            
        }

        private void login_Load(object sender, EventArgs e)
        {
            con.Open();
        }
    }
    public static class UserInfo
    {
        public static string Name { get; set; }
    }
}
