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
    public partial class Product : Form
    {
        SqlConnection con = new SqlConnection("Data Source=AZEEMHUSAIN\\SQLEXPRESS;Initial Catalog=textile_project;Integrated Security=True");
       
        public Product()
        {
            InitializeComponent();
            GetProductRecord();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Search Button Click in above text box 
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT product_id, product_name, product_catogery, descriptions, total_stock, supplier_id FROM PRODUCT WHERE product_id=@product_id ");
            cmd.Parameters.AddWithValue("@product_id",textBoxS1.Text.Trim());

            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                textBox01.Text = dr1[0].ToString();
                textBox02.Text = dr1[1].ToString();
                textBox03.Text = dr1[2].ToString();
                richTextBox04.Text = dr1[3].ToString();
                textBox05.Text = dr1[4].ToString();
                textBox06.Text = dr1[5].ToString();
            }
            con.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        void GetProductRecord()
        {
            int i = 0;
            con.Open();
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT product_id, product_name, product_catogery, descriptions, total_stock, supplier_id FROM PRODUCT", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        void Clear()
        {
            textBox01.Clear();
            textBox02.Clear();
            textBox03.Clear();
            richTextBox04.Clear();
            textBox05.Clear();
            textBox06.Clear();
            textBoxS1.Clear();

            textBox01.Focus();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cell Click in dayta gridview
            int Rollno;
            Rollno = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
            textBox01.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox02.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox03.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            richTextBox04.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox05.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox06.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //Save button Click
            try {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCT(product_id, product_name, product_catogery, descriptions, total_stock, supplier_id) VALUES(@product_id, @product_name, @product_catogery, @descriptions, @total_stock, @supplier_id) ", con);
            cmd.Parameters.AddWithValue("@product_id", textBox01.Text.Trim());
            cmd.Parameters.AddWithValue("@product_name", textBox02.Text.Trim());
            cmd.Parameters.AddWithValue("@product_catogery", textBox03.Text.Trim());
            cmd.Parameters.AddWithValue("@descriptions", richTextBox04.Text.Trim());
            cmd.Parameters.AddWithValue("@total_stock", textBox05.Text.Trim());
            cmd.Parameters.AddWithValue("@supplier_id", textBox06.Text.Trim());

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Saved Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetProductRecord();
            Clear();
             } 
            
            catch (Exception ex){
                    MessageBox.Show("Error in Saved");
             }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            // Update Button Click
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE PRODUCT SET product_name=@product_name, product_catogery=@product_catogery, descriptions=@descriptions, total_stock=@total_stock, supplier_id=@supplier_id  WHERE product_id=@product_id  ", con);
                cmd.Parameters.AddWithValue("@product_id", textBox01.Text.Trim());
                cmd.Parameters.AddWithValue("@product_name", textBox02.Text.Trim());
                cmd.Parameters.AddWithValue("@product_catogery", textBox03.Text.Trim());
                cmd.Parameters.AddWithValue("@descriptions", richTextBox04.Text.Trim());
                cmd.Parameters.AddWithValue("@total_stock", textBox05.Text.Trim());
                cmd.Parameters.AddWithValue("@supplier_id", textBox06.Text.Trim());

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Updated Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetProductRecord();
                Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Updated");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            // Delete Button Click
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCT  WHERE product_id=@product_id  ", con);
                cmd.Parameters.AddWithValue("@product_id", textBox01.Text.Trim());

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Deleted Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetProductRecord();
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
            // Back Button Click
            Homepage h1 = new Homepage();
            h1.Show();
            this.Hide();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            // Serch Button Click above Gridview
            int i = 0;
            con.Open();
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT product_id, product_name, product_catogery, descriptions, total_stock, supplier_id FROM PRODUCT WHERE product_id=@product_id", con);
            cmd.Parameters.AddWithValue("@product_id", textBoxS1.Text.Trim());

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            // Refresh Button Click 
            GetProductRecord();
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }
    }
}
