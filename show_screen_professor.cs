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
    public partial class show_screen_professor : Form
    {
        string user;
        string password;
        BuscarProf busca;

        Boolean CheckNome = false;
        Boolean CheckSobrenome = false;
        Boolean CheckId_professor = false;


        public show_screen_professor(string user, string password)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
            busca = new BuscarProf(user, password);
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

        private void consultar_sala(object sender, EventArgs e)
        {
            show_screen_sala sala = new show_screen_sala(user, password);
            sala.Show();
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

            string command = "SELECT * FROM " + "professor" + " WHERE ";

            //nome_search_input
            //sobrenome_search_input
            //id_search_input
            if (CheckNome)
            {
                lines.Push(busca.BuscaNome(nome_search_input.Text));
            }
            if (CheckSobrenome)
            {
                lines.Push(busca.BuscaSobrenome(sobrenome_search_input.Text));
            }
            if (CheckId_professor)
            {
                lines.Push(busca.BuscaId_professor(id_search_input.Text));
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

        private void checkBox_sobrenome(object sender, EventArgs e)
        {
            CheckSobrenome = !CheckSobrenome;
        }
        private void checkBox_nome_professor(object sender, EventArgs e)
        {
            CheckNome = !CheckNome;
        }
        private void checkBox_id_professor(object sender, EventArgs e)
        {
            CheckId_professor = !CheckId_professor;

        }

        //Check Box
    }

    public class BuscarProf : Buscar
    {
        public BuscarProf(string user, string password) : base(user, password)
        {
        }

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
                        result = result + (String.Format("ID: {0} || Nome: {1} {2}\n", reader[0], reader[1], reader[2]));
                    }
                    MessageBox.Show(result, "Professores");
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
