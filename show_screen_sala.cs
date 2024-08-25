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
    public partial class show_screen_sala : Form
    {
        string user;
        string password;

        public BuscarSala busca;

        Boolean CheckId_sala = false;
        Boolean CheckNome_sala = false;
        Boolean CheckId_professor = false;
        Boolean CheckClave = false;
        Boolean CheckHorario = false;
        public show_screen_sala(string user, string password)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
            busca = new BuscarSala(user, password);
        }

        private void back(object sender, EventArgs e)
        {
            BD_acess main = new BD_acess(user, password);
            main.Show();
            this.Hide();
        }
        private void consultar_aluno(object sender, EventArgs e)
        {
            show_screen_aluno aluno = new show_screen_aluno(user, password);
            aluno.Show();
            this.Hide();
        }

        private void consultar_professor(object sender, EventArgs e)
        {
            show_screen_professor professor = new show_screen_professor(user, password);
            professor.Show();
            this.Hide();
        }

        private void consultar_musica(object sender, EventArgs e)
        {
            show_screen_musica musica = new show_screen_musica(user, password);
            musica.Show();
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


            string command = "SELECT * FROM " + "sala" + " WHERE ";

            if (CheckId_sala)
            {
                lines.Push(busca.BuscaId_sala(id_sala_search_input.Text));
            }
            if (CheckId_professor)
            {
                lines.Push(busca.BuscaId_professor(id_professor_search_input.Text));
            }
            if (CheckNome_sala)
            {
                lines.Push(busca.BuscaNome_sala(sala_search_input.Text));
            }
            if (CheckClave)
            {
                lines.Push(busca.BuscaClave(clave_search_input.Text));
            }
            if (CheckHorario)
            {
                lines.Push(busca.BuscaHarario(horario_search_input.Text));
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
            Console.WriteLine(command);
            busca.ExecutarComando(command);
        }


        //Check Box

        private void checkBox_id_sala(object sender, EventArgs e)
        {
            CheckId_sala = !CheckId_sala;
        }
        private void checkBox_nome_sala(object sender, EventArgs e)
        {
            CheckNome_sala = !CheckNome_sala;
        }
        private void checkBox_id_professor(object sender, EventArgs e)
        {
            CheckId_professor = !CheckId_professor;
        }
        private void checkBox_clave(object sender, EventArgs e)
        {
            CheckClave = !CheckClave;
        }
        private void checkBox_horario(object sender, EventArgs e)
        {
            CheckHorario = !CheckHorario;
        }

        //Check box

        public class BuscarSala : Buscar
        {
            public BuscarSala(string user, string password) : base (user, password) 
            {
            }

            //Executa um comando de leitura na table
            public void ExecutarComando(string comm)
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
                            result = result + (String.Format("ID Sala: {0} || Nome da sala: {1} || ID Professor: {2} || Clave: {3} || Harário: {4}\n", reader[0], reader[1], reader[2], reader[3], reader[4]));
                        }
                        MessageBox.Show(result, "Salas");
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
