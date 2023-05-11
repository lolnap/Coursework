using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Login()
        {
            bool isAuth = false;

            

            using (NpgsqlConnection conn = new NpgsqlConnection($"Server=localhost;Database=postgres;User Id=postgres;Password=gcahDsvJVLeRoSV9Z51m"))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM users WHERE email = '{Email}' AND password = '{Password}' ", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isAuth = true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password!");
                        }
                    }
                }
            }

            return isAuth;
        }
    }
}
