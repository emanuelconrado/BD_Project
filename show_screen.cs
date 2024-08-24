using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BD_Project
{

   public partial class show_screen : Form
    {
        string user;
        string password;
        public Buscar busca;

        Boolean nameCheck = false;
        Boolean cpfCheck = false;
        Boolean instruCheck = false;
        Boolean salaCheck = false;


        public show_screen(string user, string password)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
            busca = new Buscar(user, password);
        }

        private void search_click(object sender, EventArgs e)
        {
            Stack<String> lines = new Stack<String>();
            

            string command = "SELECT * FROM " + "aluno" + " WHERE ";

            if (nameCheck) {
                lines.Push(busca.BuscaNome(nome_search_input.Text));
            }
            if (cpfCheck)
            {
                lines.Push(busca.BuscaCpf(cpf_search_input.Text));
            }
            if (instruCheck)
            {
                lines.Push(busca.BuscaInstru(instrumento_search_input.Text));
            }
            if (salaCheck)
            {
                lines.Push(busca.BuscaSala(sala_search_input.Text));
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

        //CheckBoxes
        private void checkBox_nome(object sender, EventArgs e)
        {
            nameCheck = !nameCheck;
        }
        private void checkBox_cpf(object sender, EventArgs e)
        {
            cpfCheck = !cpfCheck;
        }
        private void checkBox_instrumento(object sender, EventArgs e)
        {
            instruCheck = !instruCheck;

        }
        private void checkBox_sala(object sender, EventArgs e)
        {
            salaCheck = !salaCheck;
        }
    }

    //SELECT * FROM aluno + WHERE + nome + "= " + 

    public class Buscar
    {
        string user;
        string password;

        public Buscar(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        public string BuscaNome(string nome)
        {
            return "nome = '" + nome + "'";
        }

        public string BuscaCpf(string cpf)
        {
            return "cpf = " + "'" + cpf + "'";
        }

        public string BuscaInstru(string instru)
        {
            return "instrumento = " + "'" + instru + "'";
        }

        public string BuscaSala(string sala)
        {
            return "id_sala = " + "'" + sala + "'";
        }

        public string BuscaMatricula(int mat)
        {
            return "matricula = " + mat;
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
                        result = result + (String.Format("Matrícula: {0} || Nome: {1} {2} || Instrumento: {3} || Sala: {4}\n", reader[0], reader[1], reader[5], reader[3], reader[4]));
                    }
                    MessageBox.Show(result);
                }
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de busca: " + ex.Message);
            }
        }
    }
}
