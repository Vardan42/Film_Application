using Film_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Film_Application
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Empty Error", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            }
            else if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Empty Error", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            }
            else if (string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Empty Error", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            }
            else
            {
                try
                {
                    Order order = new Order
                    {
                        Name = textBox1.Text ?? throw new Exception("Error"),
                        Address = textBox2.Text ?? throw new Exception("Error"),
                        PostalCode = textBox3.Text ?? throw new Exception("Error"),
                        Surname = textBox4.Text ?? throw new Exception("Error"),
                        City = textBox6.Text ?? throw new Exception("Error"),
                        Country = textBox8.Text ?? throw new Exception("Error"),
                        Age = Convert.ToInt32(textBox5.Text) ,
                        Phone = textBox7.Text ?? throw new Exception("Error"),
                        BankCard = textBox9.Text ?? throw new Exception("Error"),
                    };
                    using Data database = new Data();
  
                    database.Orders.Add(order);
                    Close();
                }
                catch (Exception)
                {

                    throw new  Exception("Application Error");
                }
            } }


        }

    }
