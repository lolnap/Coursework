using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DotNetEnv;
using Npgsql;

namespace Курсач
{
    public partial class Regist : Form
    {
        int k = 0;
        int password = 0;
        int RepeatPassword = 0;

        public Regist()
        {
            this.FormClosed += (s, args) => Application.Exit();
            InitializeComponent();
            CenterForm();
        }

        private void CenterForm()
        {
            int centerX = Screen.PrimaryScreen.WorkingArea.Width / 2;
            int centerY = Screen.PrimaryScreen.WorkingArea.Height / 2;

            int formX = this.Width / 2;
            int formY = this.Height / 2;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(centerX - formX, centerY - formY);
        }

        private NpgsqlConnection ConnectDB()
        {
            Env.Load("..\\..\\.env");
            string pass = Environment.GetEnvironmentVariable("DB_PASS");

            MessageBox.Show(pass);
            NpgsqlConnection conn = new NpgsqlConnection($"Server=localhost;Database=postgres;User Id=postgres;Password={pass}");

            conn.Open();
            return conn;
        }



        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRepeatPassword_Click(object sender, EventArgs e)
        {
            if (RepeatPassword == 0)
            {
                textBoxRepeatPassword.Text = "";
                textBoxRepeatPassword.UseSystemPasswordChar = true;
                RepeatPassword++;
            }
            else
            {
                if (textBoxRepeatPassword.Text == "") {
                    textBoxRepeatPassword.UseSystemPasswordChar = false;
                    textBoxRepeatPassword.Text = "Repeat Password"; 
                    RepeatPassword = 0; }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            if (k == 0)
            {
                textBoxEmail.Text = ""; k++;
            }
            else
            {
                if (textBoxEmail.Text == "") { textBoxEmail.Text = "Email"; k = 0; }
            }
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            if (password == 0)
            {
                textBoxPassword.Text = ""; password++;
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                if (textBoxPassword.Text == "") {
                    textBoxPassword.UseSystemPasswordChar = false;
                    textBoxPassword.Text = "Password";
                    password = 0; }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string passwordd;
            bool check=true;
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z.-]+\.[a-zA-Z]{2,}$";
            bool isValid = Regex.IsMatch(email, pattern);
            if (isValid == false)
            {
                MessageBox.Show("почта введена не коректнно");
            }
            else
            {
                using (NpgsqlConnection conn = ConnectDB())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM users WHERE email = '{email}'", conn);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Такой email уже существует!");
                        check = false;
                    }
                }
                if (check)
                {
                    if (textBoxPassword.Text == "Password" && textBoxRepeatPassword.Text == "Repeat Password")
                    {
                        MessageBox.Show("поля с паролем и повторением пароля не заполнены");
                    }
                    else if (textBoxPassword.Text == "Password" || textBoxRepeatPassword.Text == "Repeat Password")
                    {
                        MessageBox.Show("поле с поролем или с повторением пороля не заполнено");
                    }
                    else
                    {
                        if (textBoxPassword.Text != textBoxRepeatPassword.Text)
                        {
                            MessageBox.Show("пароли не совпадают!!!");
                        }
                        else
                        {
                            using (NpgsqlConnection conn = ConnectDB())
                            {

                                passwordd = textBoxPassword.Text;
                                NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO users (email, password) VALUES ('{email}', '{passwordd}')", conn);
                                NpgsqlDataReader reader = cmd.ExecuteReader();
                                MessageBox.Show("OK");
                                this.Close();
                            }
                        }
                    }
                }
            }

        }
    }
}
