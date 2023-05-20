using Film_Application.Models;

namespace Film_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Empty", "Error", MessageBoxButtons.YesNo);
            }
            if (textBox2.Text!=textBox3.Text)
            {
                MessageBox.Show("PasswordError", "Conform Error", MessageBoxButtons.OKCancel);
            }
            if (textBox1.Text.Length<7)
            {
                MessageBox.Show("Email Lenght Can'nt small 7 ","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button3,MessageBoxOptions.DefaultDesktopOnly);

             }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                using (Data database = new Data())
                {
                    User user = new User { Email = textBox1.Text, Password = textBox2.Text, ConfirmPassword = textBox3.Text };
                    await database.Users.AddAsync(user);
                    await database.SaveChangesAsync();
                }
                Form2 form2 = new Form2();
                form2.label2.Text=textBox1.Text;
                form2.Show();
            }
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                     char symbolEmail = '@';
                    if (textBox1.Text.StartsWith(symbolEmail))
                    {
                        MessageBox.Show("Error Email", "Not havy Email");
                    }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}