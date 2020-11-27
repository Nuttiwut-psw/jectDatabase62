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
    public partial class Register : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Database=project;User id=root;password=''");
        MySqlCommand comm;
        public Register()
        {
            InitializeComponent();
        }

        private void registerbut_Click(object sender, EventArgs e)
        {
            var u_id = user_idtext.Text;
            var password = passwordtext.Text;
            var name = nametext.Text;
            var personal = personaltext.Text;
            var age = agetext.Text;
            var gender = "";
            if(maleradioButton.Checked)
            {
                gender = maleradioButton.Text;
            }
            else
            {
                gender = femaleradioButton.Text;
            }
            var tel = teltext.Text;

            if (user_idtext.Text != "" && passwordtext.Text != "" && personaltext.Text != "" && nametext.Text != "" && agetext.Text != ""&&teltext.Text !="")
            {
                comm = con.CreateCommand();
                comm.CommandText = "Insert into project.user_account (u_id,password,name,personal_id,age,gender,tel)" +
                   "values" + "(@u_id,@password,@name,@personal_id,@age,@gender,@tel)";

                comm.Parameters.AddWithValue("@personal_id", personal);
                comm.Parameters.AddWithValue("@name", name);
                comm.Parameters.AddWithValue("@gender", gender);
                comm.Parameters.AddWithValue("@age", age);
                comm.Parameters.AddWithValue("@tel", tel);
                comm.Parameters.AddWithValue("@u_id", u_id);
                comm.Parameters.AddWithValue("@password", password);
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Register complete!");
                this.Close();
                con.Close();
            }
            else
            { 
                MessageBox.Show("please enter information!");

            }
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
            con.Open();
        }
    }
}
