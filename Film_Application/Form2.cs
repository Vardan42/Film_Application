using Film_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Film_Application
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Realization(1, label3, label4, label5, label6, label7);
            Realization(2, label12, label11, label10, label9, label8);
            Realization(3, label17, label15, label15, label14, label13);
            Realization(4, label22, label21, label20, label19, label18);
            Realization(5, label27, label26, label25, label24, label23);;
            Realization(6, label32, label31, label30, label29, label28);
        }
        Data Data=new Data();
        private  void Realization(int id,Label label1,Label label2,Label label3,Label label4,Label label5)
        {
            if (id == 0 || id==null)
            {
                throw new ArgumentException("Id can'nt 0 or empty");
            }
            var collection = from item in Data.FileData
                             where item.Id == id
                             select item;
            foreach (var item in collection)
            {
                label1.Text =$"Name - {item.Name}";
                label2.Text=$"Description - {item.Description}";
                label3.Text=$"Price - ${Convert.ToString(item.Price)}";
                label4.Text =$"Comapany - {item.NameComapany}";
                label5.Text=$"Count - { Convert.ToString(item.Count)}";
            }
        }
        Form3 form3 = new Form3();
        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void FindByPayment(string name,Label label)
        {
            var collection = from item in Data.FileData
                             where item.Name == name
                             select item;
            foreach (var item in collection)
            {
                label.Text =Convert.ToString(item.Price);
            }
        }
        private void FindByPrice(int Id,Label label)
        {
            var collection = from item in Data.FileData
                             where item.Id == Id
                             select item;
            foreach (var item in collection)
            {
                label.Text=$"Total Price $"+Convert.ToString(item.Price);
            }
        }
        Form3 form = new Form3();
        private void button2_Click(object sender, EventArgs e)
        {
            FindByPrice(1,form.label2);

            form.ShowDialog();
        
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            FindByPrice(2, form.label2);
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FindByPrice(3, form.label2);
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FindByPrice(5, form.label2);
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FindByPrice(6, form.label2);
            form.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FindByPrice(4, form.label2);
            form.ShowDialog();
        }
    }
}
