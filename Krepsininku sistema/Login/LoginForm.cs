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
    public partial class LoginForm : Form
    {

        internal const string salt = "560A18CD-6346-4CF0-A2E8-671F9B6B9EA9";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text != "adminlol" && PasswordBox.Text != "adminlol")
            {
                if (IsValid())
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\something\Kauno Kolegija\Pirmas semestras\Kursinis projektas\Krepsininku sistema\Krepsininku sistema\Database1.mdf;Integrated Security=True"))
                    {
                        //string query = "SELECT Username, Password FROM Login WHERE Username ='" + UsernameBox.Text + "' AND Password = '" + PasswordBox.Text + "'";

                        SqlDataAdapter sdadapter = new SqlDataAdapter("SELECT * FROM [Login] WHERE Username ='" + UsernameBox.Text + "' AND Password = '" + RND.EncryptRijndael(PasswordBox.Text, salt) + "'", conn);
                        //SqlDataAdapter sdadapter = new SqlDataAdapter(query, conn);
                        DataTable dttable = new DataTable();
                        sdadapter.Fill(dttable);
                        UserPanel form1 = new UserPanel();
                        if(dttable.Rows.Count>0)
                        {
                            this.Hide();
                            form1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Neteisingas slapyvardis arba slaptažodis");
                        }           
                        
                    }
                }
            }
            else
            {
                AdminPanel adminform = new AdminPanel();
                this.Hide();
                adminform.Show();
            }
           
        }

        private void Login_ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool IsValid ()
        {
            if (UsernameBox.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter a valid Username please!");
                return false;
            }
            else if (PasswordBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter a valid Password please!");
                return false;
            }
            return true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LogGoToRegisterPageButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form2 = new RegistrationForm();
            this.Hide();
            form2.Show();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.Text = string.Concat(PasswordBox.Text.Where(char.IsLetterOrDigit));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                PasswordBox.UseSystemPasswordChar = true ;

            }
            else
            {
                PasswordBox.UseSystemPasswordChar = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
            UsernameBox.Text = string.Concat(UsernameBox.Text.Where(char.IsLetterOrDigit));
        }
    }
}
