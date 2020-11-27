using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ProjectDatabase
{
    public partial class Acc : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Database=project;User id=root;password=''");
        MySqlCommand comm;
        public Acc(string data)
        {
            InitializeComponent();
            label3.Text = data;
        }
       
        private void edit_Click(object sender, EventArgs e)
        {
            Alltour f2 = new Alltour();
            f2.Show();
        }

        private void load_tour_display_griddata_init()
        {
            con.Open();
           string sql = "call project.getInfo('"+UserInfo.Name+"')";
           comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "Tour_Display");
            Tour_display.DataSource = ds.Tables["Tour_display"].DefaultView;
            Tour_display.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss";
        }

        private void Tour_display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Tour_display.SelectedRows.Count > 0)
            {
                string t_id = Tour_display.SelectedRows[0].Cells[0].Value.ToString();
                string location = Tour_display.SelectedRows[0].Cells[1].Value.ToString();
                string country = Tour_display.SelectedRows[0].Cells[2].Value.ToString();
                string price = Tour_display.SelectedRows[0].Cells[3].Value.ToString();
                string vehicle = Tour_display.SelectedRows[0].Cells[4].Value.ToString();
                string date_departure = Tour_display.SelectedRows[0].Cells[5].Value.ToString();

                delete_text.Text = t_id;
            }
        }

        private void Acc_Load(object sender, EventArgs e)
        {
             load_tour_display_griddata_init();
        }

        private void EditAcc_Click(object sender, EventArgs e)
        {
            EditAcc f2 = new EditAcc();
            f2.Show();
        }

        private void Detour_Click(object sender, EventArgs e)
        {
            TidInfo.Name = delete_text.Text;
            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM `project`.`buy_tour` WHERE t_id ='"+TidInfo.Name+ "'and u_id = '"+UserInfo.Name+"'";

            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Tour Removed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Acc oldform = (Acc)Application.OpenForms["Acc"];
            oldform.Close();
            this.Close();
            Acc fm = new Acc(UserInfo.Name);
            fm.Show();
            con.Close();
        }
    }
}
