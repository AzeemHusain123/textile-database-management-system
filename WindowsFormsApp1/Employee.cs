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
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=AZEEMHUSAIN\\SQLEXPRESS;Initial Catalog=textile_project;Integrated Security=True");
        public Employee()
        {
            InitializeComponent();
            GetEmployeeRecord();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //save_button
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO EMPLOYEE(emp_id, emp_name,position, joined_date,contact_info,addres,salary,gender) VALUES(@emp_id, @emp_name,@position, @joined_date,@contact_info,@addres,@salary,@gender) ", con);
            cmd.Parameters.AddWithValue("@emp_id", textBox01.Text.Trim());
            cmd.Parameters.AddWithValue("@emp_name", textBox02.Text.Trim());
            cmd.Parameters.AddWithValue("@position", textBox03.Text.Trim());
            cmd.Parameters.AddWithValue("@joined_date", dateTimePicker04.Value);
            cmd.Parameters.AddWithValue("@contact_info", richTextBox05.Text.Trim());
            cmd.Parameters.AddWithValue("@addres", textBox06.Text.Trim());
            cmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(textBox07.Text.Trim()).ToString());

            if (radioButton08.Checked)
                cmd.Parameters.AddWithValue("@gender", radioButton08.Text.Trim());
            else if (radioButton09.Checked)
                cmd.Parameters.AddWithValue("@gender", radioButton09.Text.Trim());

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Saved Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetEmployeeRecord();
            Clear();
        }
        void GetEmployeeRecord()
        {
            int i = 0;
            con.Open();
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT emp_id, emp_name,position, joined_date,contact_info,addres,salary,gender FROM EMPLOYEE", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            con.Close();
        }
        void Clear()
        {
            textBox01.Clear();
            textBox02.Clear();
            textBox03.Clear();
            dateTimePicker04.Value=DateTime.Now;
            richTextBox05.Clear();
            textBox06.Clear();
            textBox07.Clear();
            radioButton08.Checked=false;
            radioButton09.Checked=false;
            textBoxS1.Clear();

            textBox01.Focus();

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE EMPLOYEE SET emp_name = @emp_name, position = @position, joined_date = @joined_date, " +
                    "contact_info = @contact_info, addres = @addres, salary = @salary, gender = @gender WHERE emp_id = @emp_id", con);

                cmd.Parameters.AddWithValue("@emp_id", textBox01.Text.Trim());
                cmd.Parameters.AddWithValue("@emp_name", textBox02.Text.Trim());
                cmd.Parameters.AddWithValue("@position", textBox03.Text.Trim());  // Assuming textBox03 is the control for position
                cmd.Parameters.AddWithValue("@joined_date", dateTimePicker04.Value); // Using dateTimePicker04.Value instead of Text
                cmd.Parameters.AddWithValue("@contact_info", richTextBox05.Text.Trim());
                cmd.Parameters.AddWithValue("@addres", textBox06.Text.Trim());
                cmd.Parameters.AddWithValue("@salary", Convert.ToDecimal(textBox07.Text.Trim()).ToString());

                // Handle radio buttons for gender
                if (radioButton08.Checked)
                    cmd.Parameters.AddWithValue("@gender", radioButton08.Text.Trim());
                else if (radioButton09.Checked)
                    cmd.Parameters.AddWithValue("@gender", radioButton09.Text.Trim());

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Updated Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetEmployeeRecord();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Update: " + ex.Message);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            //delete_button_Click
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM EMPLOYEE WHERE emp_id=@emp_id  ", con);
                cmd.Parameters.AddWithValue("@emp_id", textBox01.Text.Trim());

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Deleted Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetEmployeeRecord();
                Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Delete");
            }
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            // New Button click
            Clear();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Homepage h1= new Homepage();
            h1.Show();
            this.Hide();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            // Serch Button Click above Gridview
            int i = 0;
            con.Open();
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT emp_id, emp_name,position, joined_date,contact_info,addres,salary,gender FROM PRODUCT WHERE emp_id=@emp_id", con);
            cmd.Parameters.AddWithValue("@emp_id", textBoxS1.Text.Trim());

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            //refresh button
            GetEmployeeRecord();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cell Click in dayta gridview
            int Rollno;
            Rollno = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
            textBox01.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox02.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox03.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker04.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            richTextBox05.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox06.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox07.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            // Check for "Male" or "Female" (case-insensitive) and set radio buttons
            string gender = dataGridView1.SelectedRows[0].Cells[8].Value?.ToString();
            if (gender != null)
            {
                if (gender.ToLower() == "male")
                {
                    radioButton08.Checked = true;
                    radioButton09.Checked = false;
                }
                else if (gender.ToLower() == "female")
                {
                    radioButton08.Checked = false;
                    radioButton09.Checked = true;
                }
                else
                {
                    // If gender is not recognized, leave both radio buttons unchecked
                    radioButton08.Checked = false;
                    radioButton09.Checked = false;
                }
            }
            else
            {
                // If gender is null, leave both radio buttons unchecked
                radioButton08.Checked = false;
                radioButton09.Checked = false;
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            GetEmployeeRecord();
        }
    }
}
