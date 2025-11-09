using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Invoice01 : Form
    {
        
       SqlConnection con = new SqlConnection("Data Source=AZEEMHUSAIN\\SQLEXPRESS;Initial Catalog=textile_project;Integrated Security=True");

        public Invoice01()
        {
            InitializeComponent();
            
        }

        private void textBox01_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT MAX(sales_id) FROM SALES", con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        string lastSalesId = result.ToString();
                        int numericPart;

                        if (int.TryParse(lastSalesId, out numericPart))
                        {
                            int newSalesIdNumericPart = numericPart + 1;
                            string newSalesId = newSalesIdNumericPart.ToString("D3");

                            textBox01.Text = newSalesId;
                        }
                        else
                        {
                            // Handle the case where the sales_id doesn't contain a valid numeric part
                            // You can log, display an error, or take other appropriate action
                            textBox01.Text = "Error";
                        }
                    }
                    else
                    {
                        // Handle the case where there are no existing sales IDs
                        textBox01.Text = "001";
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Invoice01_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'textile_projectDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.textile_projectDataSet.CUSTOMER);
            textBox01_TextChanged(sender, e);
            comboBox02.Focus();
        }

        private void textBox03_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox02_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combo Selected CustId
            try
            {
                // Open the connection
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Retrieve customer_name based on selected customer_id
                string selectedCustomerId = comboBox02.Text;

                using (SqlCommand cmd = new SqlCommand("SELECT customer_name FROM CUSTOMER WHERE customer_id = @customerId", con))
                {
                    cmd.Parameters.AddWithValue("@customerId", selectedCustomerId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        textBox03.Text = result.ToString();
                    }
                    else
                    {
                        // Handle the case where customer_name is not found
                        textBox03.Text = "Customer Name Not Found";
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void textBox001_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox001_KeyDown(object sender, KeyEventArgs e)
        {
            //Key Down press
            if (e.KeyCode == Keys.Enter) {
                try
                {
                    // Open the connection
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    // Retrieve customer_name based on selected customer_id
                    //string selectedCustomerId = comboBox02.Text;

                    using (SqlCommand cmd = new SqlCommand("SELECT product_name,price FROM PRODUCT WHERE product_id = @product_id", con))
                    {
                        cmd.Parameters.AddWithValue("@product_id", textBox001.Text.Trim());

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            textBox002.Text = dr[0].ToString();
                            textBox003.Text = dr[1].ToString();
                        }
                        else
                        {
                            // Handle the case where customer_name is not found
                            MessageBox.Show("Invalid Product ID ");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    con.Close();
                }
            }
        }

        private void textBox004_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Assuming textBox003 and textBox004 contain integer values
                if (int.TryParse(textBox003.Text, out int value1) && int.TryParse(textBox004.Text, out int value2))
                {
                    // Calculate the total amount
                    int totalAmount = value1 * value2;

                    // Display the total amount in textBox005
                    textBox005.Text = totalAmount.ToString();
                }
                else
                {
                    // Handle invalid input if textBox003 or textBox004 doesn't contain valid integers
                    textBox005.Text = "Invalid Input";
                }
            }
        }

        private int serialNumber = 1;
        private static int totalAmount = 0;
        private void enter_button_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = int.Parse(textBox005.Text);

                // Add a new row to the DataGridView with serial number, textBox values, and the calculated totalAmount
                dataGridView1.Rows.Add(serialNumber, textBox01.Text, comboBox02.Text, textBox03.Text,
                                       textBox001.Text, textBox002.Text, textBox003.Text, textBox004.Text, textBox005.Text);

                totalAmount += amount;

                // Display the accumulated total amount in textBox_Total
                textBox_Total.Text = totalAmount.ToString();

                // Increment the serial number for the next row
                serialNumber++;

                clear();
            }
            catch (Exception ex)
            {
                // Handle invalid input if textBox003 or textBox004 doesn't contain valid integers
                MessageBox.Show("Invalid Inputs");
            }
        }
        private void clear()
        {
            textBox001.Clear();
            textBox002.Clear();
            textBox003.Clear();
            textBox004.Clear();
            textBox005.Clear();

            textBox001.Focus();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            // Clear all rows from the DataGridView
            dataGridView1.Rows.Clear();

            // Reset serial number and total amount
            serialNumber = 1;
            totalAmount = 0;

            // Clear TextBox_Total
            textBox_Total.Clear();
            textBox_Pay.Clear();
            textBox_Discount.Clear();
            textBox_Balance.Clear();

            // Optionally, clear other input fields if needed
            clear();
        }

        private void textBox_Pay_KeyDown(object sender, KeyEventArgs e)
        {
            // Key Down press
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    // Move focus to textBox_Discount
                    textBox_Discount.Focus();
                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void textBox_Discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int balance = int.Parse(textBox_Pay.Text) - int.Parse(textBox_Discount.Text)-int.Parse(textBox_Total.Text);
                textBox_Balance.Text = balance.ToString();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Homepage h1= new Homepage();
            h1.Show();
            this.Hide();
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Your code to draw the content of the invoice on the print page
            // For simplicity, let's just draw a sample text for now

            Font font = new Font("Arial", 12);
            Brush brush = new SolidBrush(Color.Black);
            float x = 10;
            float y = 10;

            e.Graphics.DrawString("Invoice Content Goes Here", font, brush, x, y);
        }
    }
}
