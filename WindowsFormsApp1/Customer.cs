using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Customer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=AZEEMHUSAIN\\SQLEXPRESS;Initial Catalog=textile_project;Integrated Security=True");
        public Customer()
        {
            InitializeComponent();
            GetCustomerRecord();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void GetCustomerRecord()
        {
                int i = 0;
                con.Open();
                dataGridView1.Rows.Clear();
                SqlCommand cmd = new SqlCommand("SELECT customer_id,customer_name, membership_status, contact_info, addres FROM CUSTOMER", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }
                dr.Close();
                con.Close();
            
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        
        void Clear()
        {
            textBox01.Clear();
            textBox02.Clear();
            textBox03.Clear();
            richTextBox04.Clear();
            textBox05.Clear();
            textBoxS1.Clear();

            textBox01.Focus();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void new_button_Click(object sender, EventArgs e)
        {
            //new_button
            Clear();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            //Delete Button Click
            try
            {
                con.Open();

                // First, delete from SALES table
                SqlCommand deleteSalesCmd = new SqlCommand("DELETE FROM SALES WHERE customer_id=@customer_id", con);
                deleteSalesCmd.Parameters.AddWithValue("@customer_id", textBox01.Text.Trim());
                deleteSalesCmd.ExecuteNonQuery();

                // Then, delete from CUSTOMER table
                SqlCommand deleteCustomerCmd = new SqlCommand("DELETE FROM CUSTOMER WHERE customer_id=@customer_id", con);
                deleteCustomerCmd.Parameters.AddWithValue("@customer_id", textBox01.Text.Trim());
                deleteCustomerCmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Data Deleted Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCustomerRecord();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Delete: " + ex.Message);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //Save button Click
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CUSTOMER(customer_id, customer_name, membership_status, contact_info, addres) VALUES(@customer_id, @customer_name, @membership_status, @contact_info, @addres) ", con);
                cmd.Parameters.AddWithValue("@customer_id", textBox01.Text.Trim());
                cmd.Parameters.AddWithValue("@customer_name", textBox02.Text.Trim());
                cmd.Parameters.AddWithValue("@membership_status", textBox03.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_info", richTextBox04.Text.Trim());
                cmd.Parameters.AddWithValue("@addres", textBox05.Text.Trim());

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Saved Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCustomerRecord();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Saved");
            }  
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Homepage h1 = new Homepage();
            h1.Show();
            this.Hide();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            //update button
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CUSTOMER SET customer_name=@customer_name, membership_status=@membership_status, contact_info=@contact_info, addres=@addres WHERE customer_id=@customer_id  ", con);
                cmd.Parameters.AddWithValue("@customer_id", textBox01.Text.Trim());
                cmd.Parameters.AddWithValue("@customer_name", textBox02.Text.Trim());
                cmd.Parameters.AddWithValue("@membership_status", textBox03.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_info", richTextBox04.Text.Trim());
                cmd.Parameters.AddWithValue("@addres", textBox05.Text.Trim());

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Updated Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCustomerRecord();
                Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Updated");
            } 
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            int i = 0;
            con.Open();
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT customer_id, customer_name, membership_status, contact_info, addres FROM CUSTOMER WHERE customer_id=@customer_id", con);
            cmd.Parameters.AddWithValue("@product_id", textBoxS1.Text.Trim());

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            GetCustomerRecord();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // Page Load
            GetCustomerRecord();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Clell Click Data Gridview
            int Rollno;
            Rollno = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
            textBox01.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox02.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox03.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            richTextBox04.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox05.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
