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

    public partial class Alltour : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Database=project;User id=root;password=''");
        MySqlCommand comm;
        public Alltour()
        {
            InitializeComponent();
        }
        private void load_tour_griddata_init()
        {
            string sql = "select * from project.tour";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "tour");
            tour.DataSource = ds.Tables["tour"];
        }

        private void tour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(tour.SelectedRows.Count > 0)
            {
                string t_id = tour.SelectedRows[0].Cells[0].Value.ToString();
                string location = tour.SelectedRows[0].Cells[1].Value.ToString();
                string country = tour.SelectedRows[0].Cells[2].Value.ToString();
                string price = tour.SelectedRows[0].Cells[3].Value.ToString();
                string vehicle = tour.SelectedRows[0].Cells[4].Value.ToString();
                string date_departure = tour.SelectedRows[0].Cells[5].Value.ToString();

                TidInfo.Name = t_id;
                show.Text = t_id;
            }
        }

        private void Alltour_Load(object sender, EventArgs e)
        {
            con.Open();
            load_tour_griddata_init();
        }

        private void show_TextChanged(object sender, EventArgs e)
        {

        }

        private void addtour_Click(object sender, EventArgs e)
        {
            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO project.buy_tour (`t_id`, `u_id`) " + "VALUES  " + "(@tid,@uid)";
            comm.Parameters.AddWithValue("@tid", TidInfo.Name);
            comm.Parameters.AddWithValue("@uid", UserInfo.Name);
            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Tour Added!");
                Alltour newform = (Alltour)Application.OpenForms["Alltour"];
                newform.Close();
                Acc oldform = (Acc)Application.OpenForms["Acc"];
                oldform.Close();
                this.Close();
                Acc fm = new Acc(UserInfo.Name);
                fm.Show();
                con.Close();

            }
            catch
            {
                MessageBox.Show("Tour already in your plan!");
            }
        }
        
    }
    public static class TidInfo
    {
        public static string Name { get; set; }
    }
}
