using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Sales : Form
    {
        SqlConnection con = new SqlConnection("Data Source=AZEEMHUSAIN\\SQLEXPRESS;Initial Catalog=textile_project;Integrated Security=True");
        public Sales()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Save button Click
            //try {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO SALES(sales_id,product_id,customer_id,dates,qty,price,discount,total_sales,qty_discription) VALUES(@sales_id, @product_id, @customer_id, @dates, @qty, @price, @discount, @total_sales, @qty_discription", con);
            cmd.Parameters.AddWithValue("@sales_id", textBox01.Text.Trim());
            cmd.Parameters.AddWithValue("@product_id", textBox02.Text.Trim());
            cmd.Parameters.AddWithValue("@customer_id", textBox03.Text.Trim());
            cmd.Parameters.AddWithValue("@dates", dateTimePicker04.Text.Trim());
            cmd.Parameters.AddWithValue("@qty", textBox05.Text.Trim());
            cmd.Parameters.AddWithValue("@price", textBox06.Text.Trim());
            cmd.Parameters.AddWithValue("@discount", textBox07.Text.Trim());
            cmd.Parameters.AddWithValue("@total_sales", textBox08.Text.Trim());
            cmd.Parameters.AddWithValue("@qty_discription", textBox09.Text.Trim());
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Saved Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetSalesRecord();
            Clear();


            // } 
            /*catch (Exception ex)
                {
                    MessageBox.Show("Error in Saved");
                } */
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }
        void GetSalesRecord()
        {
            int i = 0;
            con.Open();
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT sales_id,product_id,customer_id,dates,qty,price,discount,total_sales,qty_discription", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        void Clear()
        {
            textBox01.Clear();
            textBox02.Clear();
            textBox03.Clear();
            dateTimePicker04.Value= DateTime.Now;
            textBox05.Clear();
            textBox06.Clear();
            textBox07.Clear();
            textBox08.Clear();
            textBox09.Clear();
            textBoxS1.Clear();

            textBox01.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Update Button Click
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SALES SET sales_id=@sales_id, product_id=@product_id, dates=@dates, qty=@qty, price=@price, discount=@discount, total_sales=@totalsales, qty_discription=@qty_discription WHERE product_id=@product_id  ", con);
                cmd.Parameters.AddWithValue("@sales_id", textBox01.Text.Trim());
                cmd.Parameters.AddWithValue("@product_id", textBox02.Text.Trim());
                cmd.Parameters.AddWithValue("@customer_id", textBox03.Text.Trim());
                cmd.Parameters.AddWithValue("@dates", dateTimePicker04.Text.Trim());
                cmd.Parameters.AddWithValue("@qty", textBox05.Text.Trim());
                cmd.Parameters.AddWithValue("@price", textBox06.Text.Trim());
                cmd.Parameters.AddWithValue("@discount", textBox07.Text.Trim());
                cmd.Parameters.AddWithValue("@total_sales", textBox08.Text.Trim());
                cmd.Parameters.AddWithValue("@qty_discription", textBox09.Text.Trim());

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Updated Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetSalesRecord();
                Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Updated");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Delete Button Click
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM SALES  WHERE sales_id=@sales_id  ", con);
                cmd.Parameters.AddWithValue("@sales_id", textBox01.Text.Trim());

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Deleted Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetSalesRecord();
                Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Delete");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // New Button click
            Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Back Button Click
            Homepage h1 = new Homepage();
            h1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Serch Button Click above Gridview
            int i = 0;
            con.Open();
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT SELECT sales_id,product_id,customer_id,dates,qty,price,discount,total_sales,qty_discription FROM PRODUCT WHERE product_id=@product_id", con);
            cmd.Parameters.AddWithValue("@sales_id", textBoxS1.Text.Trim());

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Refresh Button Click 
            GetSalesRecord();
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
            textBox05.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox06.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox07.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox08.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }
    }
}
