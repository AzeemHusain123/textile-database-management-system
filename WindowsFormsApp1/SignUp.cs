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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection("Data Source=AZEEMHUSAIN\\SQLEXPRESS;Initial Catalog=textile_project;Integrated Security=True");
        public SignUp()
        {
            InitializeComponent();
        }
        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
               
                string username = textBox03.Text.Trim();
                string password = textBox04.Text.Trim();
                string confirmPassword = textBox05.Text.Trim();

                // Check if the passwords match
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords are mismatched. Please try again...", "Error in saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Check if the username already exists
                if (IsUsernameExist(username))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                con.Open();

                // Hash the password (use a proper hashing algorithm in a real-world scenario)
               // string hashedPassword = hashedPassword(password);

                SqlCommand cmd = new SqlCommand("INSERT INTO USERTABLE(username, passwords, full_name, DOB) VALUES(@username, @passwords, @full_name, @DOB)", con);
                cmd.Parameters.AddWithValue("@full_name", textBox01.Text.Trim());
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker02.Value); // Assuming dateTimePicker02 is your DateTimePicker control
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@passwords", password); // Use hashed password

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Saved Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsUsernameExist(string username)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM USERTABLE WHERE username = @username", con);
            cmd.Parameters.AddWithValue("@username", username);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count > 0;
        }
        void Clear()
        {
            textBox01.Clear();
            dateTimePicker02.Value = DateTime.Now;
            textBox03.Clear();
            textBox04.Clear();
            textBox05.Clear();

            textBox01.Focus();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Login l1= new Login();
            l1.Show();
            this.Hide();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }

    internal class HashPassword
    {
        private string password;

        public HashPassword(string password)
        {
            this.password = password;
        }
    }
}
