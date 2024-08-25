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
    public partial class delete : Form
    {

        string user;
        string password;
        Delete att;
        Boolean CheckNome = false;
        Boolean CheckSobrenome = false;
        Boolean CheckInstru = false;
        Boolean CheckCpf = false;
        Boolean CheckSala = false;
        Boolean CheckMatricula = false;

        public delete(string user, string password)
        {
            InitializeComponent();
            att = new Delete(user, password);
            this.user = user;
            this.password = password;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Stack<String> lines = new Stack<String>();


            string command = "DELETE FROM " + "aluno" + " WHERE ";
            string select = "SELECT * FROM " + "aluno" + " WHERE ";

            if (CheckNome)
            {
                lines.Push(att.BuscaNome(nome_input.Text));
            }
            if (CheckCpf)
            {
                lines.Push(att.BuscaCpf(cpf_input.Text));
            }
            if (CheckSobrenome)
            {
                lines.Push(att.BuscaSobrenome(sobrenome_input.Text));
            }
            if (CheckInstru)
            {
                lines.Push(att.BuscaInstru(instru_input.Text));
            }
            if (CheckSala)
            {
                lines.Push(att.BuscaSala(id_sala_input.Text));
            }
            if (CheckMatricula)
            {
                lines.Push(att.BuscaMatricula(matricula_input.Text));
            }

            String aux = "";
            try
            {
                while (true)
                {
                    aux = lines.Pop();
                    //Se falhar, pula para o catch e não executa a parte abaixo
                    select = select + aux;
                    command = command + aux;
                    if (lines.Count >= 1) {
                        command = command + " AND ";
                        select = select + " AND ";
                    }
                }
            }
            catch
            {
            }

            Console.WriteLine(command);
            att.ExecutarComando(select);
            att.ExecutarComandoApagar(command);
        }

        //CheckBox

        private void checkBox_sobrenome(object sender, EventArgs e)
        {
            CheckSobrenome = !CheckSobrenome;
        }
        private void checkBox_nome(object sender, EventArgs e)
        {
            CheckNome = !CheckNome;
        }
        private void checkBox_instru(object sender, EventArgs e)
        {
            CheckInstru = !CheckInstru;
        }
        private void checkBox_cpf(object sender, EventArgs e)
        {
            CheckCpf = !CheckCpf;
        }
        private void checkBox_matricula(object sender, EventArgs e)
        {
            CheckMatricula = !CheckMatricula;
        }

        private void checkBox_id_sala(object sender, EventArgs e)
        {
            CheckSala = !CheckSala;
        }

        //Check Box

        private void back(object sender, EventArgs e)
        {
            BD_acess main = new BD_acess(user, password);
            main.Show();
            this.Hide();
        }


        public class Delete : Buscar
        {
            public Delete(string user, string password) : base(user, password)
            {
            }

            public void ExecutarComandoApagar(string comm)
            {
                string connection_string = @"Server = DUEL\SQLEXPRESS; Database = music_school;" + "User Id = " + user + ";Password = " + password + ";TrustServerCertificate = True;";
                SqlConnection connection = new SqlConnection(connection_string);
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(comm, connection);
                    command.ExecuteNonQuery();
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
