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
    public partial class Supplier : Form
    {
        SqlConnection con = new SqlConnection("Data Source=AZEEMHUSAIN\\SQLEXPRESS;Initial Catalog=textile_project;Integrated Security=True");
        public Supplier()
        {
            InitializeComponent();
            GetSupplierRecord();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //save button
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO SUPPLIER(supplier_id, supplier_name, contact_info,addres) VALUES(@supplier_id, @supplier_name, @contact_info,@addres) ", con);
                cmd.Parameters.AddWithValue("@supplier_id", textBox01.Text.Trim());
                cmd.Parameters.AddWithValue("@supplier_name", textBox02.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_info", richTextBox03.Text.Trim());
                cmd.Parameters.AddWithValue("@addres", textBox04.Text.Trim());

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Saved Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetSupplierRecord();
                Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error in Saved");
            }
        }
        void GetSupplierRecord()
        {
            int i = 0;
            con.Open();
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT supplier_id, supplier_name, contact_info,addres FROM SUPPLIER", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }
        void Clear()
        {
            textBox01.Clear();
            textBox02.Clear();
            richTextBox03.Clear();
            textBox04.Clear();
            textBoxS1.Clear();

            textBox01.Focus();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            //update button
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SUPPLIER SET supplier_name=@supplier_name,contact_info=@contact_info,addres=@addres WHERE supplier_id=@supplier_id", con);
                cmd.Parameters.AddWithValue("@supplier_id", textBox01.Text.Trim());
                cmd.Parameters.AddWithValue("@supplier_name", textBox02.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_info", richTextBox03.Text.Trim());
                cmd.Parameters.AddWithValue("@addres", textBox04.Text.Trim());

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Updated Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetSupplierRecord();
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
                SqlCommand cmd = new SqlCommand("DELETE FROM SUPPLIER WHERE supplier_id=@supplier_id  ", con);
                cmd.Parameters.AddWithValue("supplier_id", textBox01.Text.Trim());

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Data Deleted Successfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetSupplierRecord();
                Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Delete");
            }
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            //new button
            Clear();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            //back button
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
            SqlCommand cmd = new SqlCommand("SELECT supplier_id, supplier_name, contact_info,addres FROM SUPPLIER WHERE supplier_id=@supplier_id", con);
            cmd.Parameters.AddWithValue("@supplier_id", textBoxS1.Text.Trim());

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            GetSupplierRecord();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            GetSupplierRecord();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cell Click in dayta gridview
            int Rollno;
            Rollno = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
            textBox01.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox02.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            richTextBox03.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox04.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
