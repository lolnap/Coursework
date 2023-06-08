using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DotNetEnv;
using System.IO;

namespace Курсач
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            Account();
            this.FormClosed += (s, args) => Application.Exit();



        }

        public void Account()
        {
           

            int diameter = Math.Min(pictureBoxAccount.Width, pictureBoxAccount.Height);
            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(
                pictureBoxAccount.Width / 2 - diameter / 2,
                pictureBoxAccount.Height / 2 - diameter / 2, diameter, diameter);
            pictureBoxAccount.Region = new Region(circlePath);

            pictureBoxAccount.BackColor = Color.FromArgb(255, 192, 192);

            Env.Load("..\\..\\.env");
            label1.Text = Env.GetString("EMAIL");
            
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogaout_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("..\\..\\.env");

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("EMAIL="))
                    lines[i] = $"EMAIL=";
                else if (lines[i].StartsWith("PASSWORD="))
                    lines[i] = $"PASSWORD=";
            }

            File.WriteAllLines("..\\..\\.env", lines);

            Form1 login = new Form1();
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form form in openForms)
            {
                if (form != login)
                {
                    form.Hide();
                }
            }

            login.Show();
        }
    }
}
