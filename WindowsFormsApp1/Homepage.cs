using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Product Button Click
            Product p1 = new Product();
            p1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Sales Button Click
            Invoice01 s1 = new Invoice01();
            s1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Customer Button Click
            Customer c1 = new Customer();
            c1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Employee Button Click
            Employee e1 = new Employee();
            e1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Supplier Button Click
            Supplier su1 = new Supplier();
            su1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            //Logout button
            this.Close();
            Login l1= new Login();
            l1.Show();
        }
    }
}
