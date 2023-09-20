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

namespace Krepsininku_sistema
{
    public partial class AdminPanel : Form
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\something\Kauno Kolegija\Pirmas semestras\Kursinis projektas\Krepsininku sistema\Krepsininku sistema\Database1.mdf;Integrated Security=True";
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void AdminExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_BackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm BackToLogin = new LoginForm();
            this.Hide();
            BackToLogin.Show();
        }

        private void Admin_DisplayAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Player", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
        }

        private void Admin_Insert_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                cmd = new SqlCommand("insert into Player values('" + txtFirstName.Text + "' , '" + txtLastName.Text + "' , '" + txtTeam.Text + "' , '" + txtPosition.Text + "' , '" + txtAge.Text + "' , '" + txtAveragePoints.Text
                    + "' , '" + txtValue.Text + "')", sqlCon);
               
                if (txtFirstName.Text == "" && txtLastName.Text == "" && txtPosition.Text == "" && txtTeam.Text == "" && txtAge.Text == "" && txtAveragePoints.Text == "" && txtValue.Text == "")
                {
                    MessageBox.Show(" Fields are empty ");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Data has been inserted ");
                }
                sqlCon.Close();
                Clear();
            }
        }
        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtTeam.Text = "";
            txtPosition.Text = "";
            txtAge.Text = "";
            txtAveragePoints.Text = "";
            txtValue.Text = "";
        }
        
        public void DisplayData()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                adpt = new SqlDataAdapter(" select * from Player", sqlCon);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlCon.Close();

            }
        }

        private void Admin_Delete_Click(object sender, EventArgs e)
        {   
            
            string SelectedFirstName = dataGridView1.CurrentRow.Cells["First Name"].Value.ToString();
            string SelectedLastName = dataGridView1.CurrentRow.Cells["Last Name"].Value.ToString();
            string Team = dataGridView1.CurrentRow.Cells["Team"].Value.ToString();
            string Position = dataGridView1.CurrentRow.Cells["Position"].Value.ToString();
            string Age = dataGridView1.CurrentRow.Cells["Age"].Value.ToString();
            string AvgPoints = dataGridView1.CurrentRow.Cells["Avg Points"].Value.ToString();
            string Value = dataGridView1.CurrentRow.Cells["Value"].Value.ToString();
            
            
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                cmd = new SqlCommand("delete from [dbo].[Player] where [First Name] = '" + SelectedFirstName + "' AND [Last Name] ='" + SelectedLastName + "' AND [Team] ='" + Team + "' AND [Position] ='" + Position + "' AND [Age] ='" + Age + "' AND [Avg Points] ='" + AvgPoints + "'AND [Value] ='" + Value + "'", sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Data has been deleted ");
                sqlCon.Close();
                DisplayData();
                Clear();
                
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTeam.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPosition.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAveragePoints.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtValue.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Concat(txtFirstName.Text.Where(char.IsLetterOrDigit));
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            txtAge.Text = string.Concat(txtAge.Text.Where(char.IsLetterOrDigit));
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtLastName.Text = string.Concat(txtLastName.Text.Where(char.IsLetterOrDigit));
        }

        private void txtAveragePoints_TextChanged(object sender, EventArgs e)
        {
            txtAveragePoints.Text = string.Concat(txtAveragePoints.Text.Where(char.IsLetterOrDigit));
        }

        private void txtTeam_TextChanged(object sender, EventArgs e)
        {
            txtTeam.Text = string.Concat(txtTeam.Text.Where(char.IsLetterOrDigit));
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            txtValue.Text = string.Concat(txtValue.Text.Where(char.IsLetterOrDigit));
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            txtPosition.Text = string.Concat(txtPosition.Text.Where(char.IsLetterOrDigit));
        }
    }
}
