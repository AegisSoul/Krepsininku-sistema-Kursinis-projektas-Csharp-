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
    public partial class UserPanel : Form
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\something\Kauno Kolegija\Pirmas semestras\Kursinis projektas\Krepsininku sistema\Krepsininku sistema\Database1.mdf;Integrated Security=True";
        SqlDataAdapter adpt;
        DataTable dt;

        
        public UserPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
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


        public void SearchData(string search)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            string query = "select * from [dbo].[Player] where [First Name] like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, sqlCon);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SysExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SysBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm BackToLogin = new LoginForm();
            this.Hide();
            BackToLogin.Show();
        }

        private void SysDisplayAllButton_Click(object sender, EventArgs e)
        {
           
            
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Concat(txtFirstName.Text.Where(char.IsLetterOrDigit));
            SearchData(txtFirstName.Text);
        }
    }   
}
