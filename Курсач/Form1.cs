using Npgsql;
using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using DotNetEnv;

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
            LoadAccount();
            this.FormClosed += (s, args) => Application.Exit();
            if (checkBoxRememberMe.Checked == true)
            {
                this.Hide();
                Regist index = new Regist();
                index.Show();
            }  
            
        }
        public void LoadAccount()
        {
            Env.Load("..\\..\\.env");
            if (Env.GetString("EMAIL") != null)
            {
                string email = Env.GetString("EMAIL");
                string password = Env.GetString("PASSWORD");
                

                User user = new User();
                user.Email = email;
                user.Password = password;

                if (user.Login())
                {
                    Main index = new Main();
                    index.ShowDialog();
                    this.Hide();
                }
           }
            //else if (Env.GetString("GOOGLE_AUTH") == "true" && Env.GetString("EMAIL") != null && Env.GetString("TOKEN") != null)
            //{
            //    string email = Env.GetString("EMAIL");
            //    string token = Env.GetString("TOKEN");

            //    User authManager = new User();
            //    authManager.Email = email;
            //    authManager.Token = token;

            //    if (authManager.GoogleAuth())
            //    {
            //        Main index = new Main();
            //        index.ShowDialog();
            //        this.Hide();
            //    }
            //}
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

       
       

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                textBoxPassword.Text = ""; f++;
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                if (textBoxPassword.Text == "") { textBoxPassword.Text = "Password"; f = 0; textBoxPassword.UseSystemPasswordChar = false; }
            }
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            User user = new User();
            user.Email = email;
            user.Password = password;
            DataBank.Email=textBoxEmail.Text;
            if (user.Login())
            {
                Main m1 = new Main();
                this.Hide();
                m1.Show();

                if (checkBoxRememberMe.Checked == true)
                {
                    var lines = File.ReadAllLines("..\\..\\.env");

                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].StartsWith("EMAIL="))
                            lines[i] = $"EMAIL={email}";
                        else if (lines[i].StartsWith("PASSWORD="))
                            lines[i] = $"PASSWORD={password}";
                    }

                    File.WriteAllLines("..\\..\\.env", lines);
                }
            }

            



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Regist index = new Regist();
            index.Show();
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
