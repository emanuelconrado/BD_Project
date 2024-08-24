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
using Microsoft.Identity.Client;

namespace BD_Project
{
    public partial class insert_screen : Form
    {

        string user;
        string password;

        public Inserir inserir = new Inserir();
        public insert_screen(string user, string password)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void add_click(object sender, EventArgs e)
        {
            inserir.Inse(user, password, student_name_input.Text, cpf_input.Text, instrument_input.Text, sobrenome_input.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }


    public class Inserir
    {
        public void Inse(string user, string password, string nome, string cpf, string instrumento, string sobrenome)
        {
            string comm = "INSERT INTO aluno (nome, sobrenome, instrumento, cpf, id_sala) VALUES (@nome, @sobrenome, @instrumento, @cpf, @id_sala)";
            string connection_string = @"Server = DUEL\SQLEXPRESS; Database = music_school;" + "User Id = " + user + ";Password = " + password + ";TrustServerCertificate = True;";
            SqlConnection connection = new SqlConnection(connection_string);
            try
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(comm, connection))
                {
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@sobrenome", sobrenome);
                    command.Parameters.AddWithValue("@instrumento", instrumento);
                    command.Parameters.AddWithValue("@cpf", cpf);
                    command.Parameters.AddWithValue("@id_sala", 1);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
