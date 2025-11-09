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

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=AZEEMHUSAIN\\SQLEXPRESS;Initial Catalog=textile_project;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            //sign up button
            SignUp s=new SignUp();
            s.Show();
            this.Hide();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            //Exit button
            Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox01.Text.Trim();
                string password = textBox02.Text.Trim();

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM USERTABLE WHERE username = @username AND passwords = @passwords", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@passwords", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Open the Homepage form or perform other actions upon successful login
                    Homepage h1 = new Homepage();
                    h1.Show();
                    this.Hide(); // Hide the current login form
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox01.Focus(); // Set focus to textBox01
                    textBox01.SelectAll(); // Select all text in textBox01
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox01.Clear();
            textBox02.Clear();

            textBox01.Focus();
        }
    }
}
