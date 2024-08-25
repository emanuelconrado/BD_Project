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
    public partial class show_screen_musica : Form
    {
        string user;
        string password;

        BuscarMusica busca;

        Boolean CheckId_musica = false;
        Boolean CheckId_sala = false;
        Boolean CheckId_partitura = false;
        public show_screen_musica(string user, string password)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
            busca = new BuscarMusica(user, password);
        }

        private void back(object sender, EventArgs e)
        {
            BD_acess main = new BD_acess(user, password);
            main.Show();
            this.Hide();
        }
        private void consultar_professor(object sender, EventArgs e)
        {
            show_screen_professor professor = new show_screen_professor(user, password);
            professor.Show();
            this.Hide();
        }

        private void consultar_sala(object sender, EventArgs e)
        {
            show_screen_sala sala = new show_screen_sala(user, password);
            sala.Show();
            this.Hide();
        }

        private void consultar_aluno(object sender, EventArgs e)
        {
            show_screen_aluno aluno = new show_screen_aluno(user, password);
            aluno.Show();
            this.Hide();
        }

        private void consultar_todos(object sender, EventArgs e)
        {
            show_screen_all todos = new show_screen_all(user, password);
            todos.Show();
            this.Hide();
        }

        private void search_click(object sender, EventArgs e)
        {
            Stack<String> lines = new Stack<String>();


            string command = "SELECT * FROM " + "musica" + " WHERE ";

            if (CheckId_musica)
            {
                lines.Push(busca.BuscaId_musica(id_musica_search_input.Text));
            }
            if (CheckId_sala)
            {
                lines.Push(busca.BuscaSala(sala_search_input.Text));
            }
            if (CheckId_partitura)
            {
                lines.Push(busca.BuscaId_partitura(id_partitura_search_input.Text));
            }

            String aux = "";
            try
            {
                while (true)
                {
                    aux = lines.Pop();
                    //Se falhar, pula para o catch e não executa a parte abaixo
                    command = command + aux;
                    if (lines.Count >= 1)
                        command = command + " AND ";
                }
            }
            catch
            {
            }

            busca.ExecutarComando(command);
        }

        //Check Box

        private void checkBox_id_musica(object sender, EventArgs e)
        {
            CheckId_musica = !CheckId_musica;
        }
        private void checkBox_id_sala(object sender, EventArgs e)
        {
            CheckId_sala = !CheckId_sala;
        }
        private void checkBox_id_partitura(object sender, EventArgs e)
        {
            CheckId_partitura = !CheckId_partitura;

        }


        //Check Box




        public class BuscarMusica : Buscar
        {
            public BuscarMusica(string user, string password) : base(user, password)
            {
            }

            public void ExecutarComando(string comm)
            {
                string connection_string = @"Server = DUEL\SQLEXPRESS; Database = music_school;" + "User Id = " + user + ";Password = " + password + ";TrustServerCertificate = True;";
                SqlConnection connection = new SqlConnection(connection_string);
                try
                {
                    string result = "";
                    string id_musica = "";
                    connection.Open();
                    SqlCommand command = new SqlCommand(comm, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            id_musica = String.Format("{0}", reader[2]);
                            result = result + "Nome da partitura: " + base.verifica_partitura(user, password, id_musica) + (String.Format(" ID Musica: {0} || ID Partitura: {1} || ID da sala: {2}\n", reader[0], reader[1], reader[2]));

                        }

                        MessageBox.Show(result, "Musicas");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Erro de busca: Campo não especificado.");
                }
            }

            public void ExecutarComandoPart(string comm)
            {
                string connection_string = @"Server = DUEL\SQLEXPRESS; Database = music_school;" + "User Id = " + user + ";Password = " + password + ";TrustServerCertificate = True;";
                SqlConnection connection = new SqlConnection(connection_string);
                try
                {
                    string result = "";
                    connection.Open();
                    SqlCommand command = new SqlCommand(comm, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            result = result + (String.Format("Nome da Partitura: {0} || Autor: {1} || Clave: {2} || ID: {3}\n", reader[0], reader[1], reader[2], reader[3]));
                        }

                        MessageBox.Show(result, "Partituras");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Erro de busca: Campo não especificado.");
                }
            }
        }
    }
}
