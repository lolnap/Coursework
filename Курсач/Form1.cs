using Npgsql;
using System;
using System.Windows.Forms;

namespace Курсач
{
    public partial class Form1 : Form
    {
        int k = 0;
        int f = 0;
        public Form1()
        {
            InitializeComponent();
            ConnectDB();
            this.FormClosed += (s, args) => Application.Exit();
        }
        private NpgsqlConnection ConnectDB()
        {
            NpgsqlConnection conn = new NpgsqlConnection($"Server=localhost;Database=postgres;User Id=postgres;Password=gcahDsvJVLeRoSV9Z51m");
            conn.Open();
            return conn;

        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email=textBoxEmail.Text;
            string password=textBoxPassword.Text;
            User user = new User();
            user.Email = email;
            user.Password = password;
            if (user.Login())
            {
                MessageBox.Show("ты гений!!");
            }
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            
            if(k==0)
            {
                 textBoxEmail.Text = ""; k++;   
            }
            else {
                if (textBoxEmail.Text == "") { textBoxEmail.Text = "Email"; k = 0; }
            }
            

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

       

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                textBoxPassword.Text = ""; f++;
            }
            else
            {
                if (textBoxPassword.Text == "") { textBoxEmail.Text = "Password"; f = 0; }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
