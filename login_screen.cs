using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BD_Project
{
    public partial class login_screen : Form
    {

        public login_screen()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Connection BD_conn = new Connection();
            if (BD_conn.BD_connection(username_input.Text, password_input.Text))
            {
                MessageBox.Show("Usuario logado: " + username_input.Text);
                BD_acess main = new BD_acess(username_input.Text, password_input.Text);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username ou senha incorreta");
            }
        }
    }

    public class Connection
    {
        Boolean connected = true;
        public Boolean BD_connection(string username, string password)
        {
            string connection_string = @"Server = DUEL\SQLEXPRESS; Database = music_school;" + 
                "User Id = " + username + ";Password = " + password + ";TrustServerCertificate = True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    connection.Close();
                    return connected;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro no login: " + ex.Message);
                connected = false;
                return connected;
            }
        }
    }
}