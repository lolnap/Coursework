using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;

namespace Курсач
{
    public partial class Main : Form
    {
        public Main()
        {
            this.FormClosed += (s, args) => Application.Exit();
            InitializeComponent();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
               

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Profile p1= new Profile();
            p1.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
