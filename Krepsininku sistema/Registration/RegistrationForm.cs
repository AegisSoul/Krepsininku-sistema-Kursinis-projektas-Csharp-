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
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.IO;

namespace Krepsininku_sistema
{
    public partial class RegistrationForm : Form
    {
        internal const string salt = "560A18CD-6346-4CF0-A2E8-671F9B6B9EA9";

        
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void Reg_RegisterButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCnnct = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\something\Kauno Kolegija\Pirmas semestras\Kursinis projektas\Krepsininku sistema\Krepsininku sistema\Database1.mdf;Integrated Security=True"))
            {
                sqlCnnct.Open();
                string query2 = "Select * from [Login] where Username='" + RegUsername.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query2, sqlCnnct);
                DataTable dtbl2 = new DataTable();
                sda.Fill(dtbl2);
                if (dtbl2.Rows.Count > 0)
                {
                    MessageBox.Show("Šis vartotojo vardas yra užimtas!");

                }
                else if (RegUsername.Text == "" || RegPassword.Text == "" || RegPasswordConfirm.Text == "")
                {
                    MessageBox.Show("Užpildykite visus laukus!");
                }
                else if (RegPassword.Text != RegPasswordConfirm.Text)
                {
                    MessageBox.Show("Slaptažodžiai nesutampa!");
                }
                else
                {

                    SqlCommand sqlCmmnd = new SqlCommand("PridetiVartotoja", sqlCnnct);
                    sqlCmmnd.CommandType = CommandType.StoredProcedure;
                    sqlCmmnd.Parameters.AddWithValue("@vartotojoVardas", RegUsername.Text);
                    sqlCmmnd.Parameters.AddWithValue("@slaptazodis", RND.EncryptRijndael(RegPassword.Text, salt));
                    sqlCmmnd.Parameters.AddWithValue("@slaptazodisPakartot", RegPasswordConfirm.Text);
                    MessageBox.Show("Registracija sėkminga");
                    sqlCmmnd.ExecuteNonQuery();
                    Clear();
                }
              
                sqlCnnct.Close();
            }

        }
        public void Clear()
        {
            RegUsername.Text = "";
            RegPassword.Text = "";
            RegPasswordConfirm.Text = "";
        }

        private bool IsValid()
        {
            if (RegUsername.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter a valid Username please!");
                return false;
            }
            else if (RegPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter a valid Password please!");
                return false;
            }
            return true;
        }

        private void RegBackToLOGIN_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.Show();
        }

        private void Reg_ClearFields_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Login_ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void Registration_ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                RegPassword.UseSystemPasswordChar = true;
                RegPasswordConfirm.UseSystemPasswordChar = true;
            }
            else
            {
                RegPassword.UseSystemPasswordChar = false;
                RegPasswordConfirm.UseSystemPasswordChar = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegUsername_TextChanged(object sender, EventArgs e)
        {
            RegUsername.Text = string.Concat(RegUsername.Text.Where(char.IsLetterOrDigit));
        }

        private void RegPassword_TextChanged(object sender, EventArgs e)
        {
            RegPassword.Text = string.Concat(RegPassword.Text.Where(char.IsLetterOrDigit));
        }

        private void RegPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            RegPasswordConfirm.Text = string.Concat(RegPasswordConfirm.Text.Where(char.IsLetterOrDigit));
        }
    }
}
