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
    public partial class EditAcc : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Database=project;User id=root;password=''");
        MySqlCommand comm;
        public EditAcc()
        {
            InitializeComponent();
        }

        private void EditAcc_Load(object sender, EventArgs e)
        {
            load_AccInfo_init();
        }
        private void load_AccInfo_init()
        {
            con.Open();
            string sql = "call project.showinfo('" + UserInfo.Name + "')";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "Acc_Info");
            Acc_Info.DataSource = ds.Tables["Acc_Info"].DefaultView;
            
        }

        private void Acc_Info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Acc_Info.SelectedColumns.Count > 0)
            {
                string name = Acc_Info.SelectedRows[0].Cells[0].Value.ToString();
                string personal_id = Acc_Info.SelectedRows[1].Cells[0].Value.ToString();
                string u_id = Acc_Info.SelectedRows[2].Cells[0].Value.ToString();
                string password = Acc_Info.SelectedRows[3].Cells[0].Value.ToString();
                string age = Acc_Info.SelectedRows[4].Cells[0].Value.ToString();
                string gender = Acc_Info.SelectedRows[5].Cells[0].Value.ToString();
                string tel = Acc_Info.SelectedRows[6].Cells[0].Value.ToString();

            }
        }

        private void pass_change_Click(object sender, EventArgs e)
        {
            passchange f2 = new passchange();
            f2.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("logged out!");
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Home")
                    Application.OpenForms[i].Close();
            };           
        }
    }
}
