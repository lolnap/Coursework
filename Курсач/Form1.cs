using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
