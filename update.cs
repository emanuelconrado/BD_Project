using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
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
    public partial class update : Form
    {
        string user;
        string password;
        Update att;
        Boolean CheckNome = false;
        Boolean CheckSobrenome = false;
        Boolean CheckInstru = false;
        Boolean CheckCpf = false;

        public update(string user, string password)
        {
            InitializeComponent();
            att = new Update(user, password);
            this.user = user;
            this.password = password;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string command = "UPDATE aluno SET ";

            //nome_input
            //sobrenome_input
            //instru_input
            //cpf_input
            if (CheckNome)
            {
                //Comando para mudar nome
                att.ExecutarComando(command + "nome = '" + nome_input.Text + "' WHERE matricula = '" + matricula_input.Text + "'");
            }
            if (CheckSobrenome)
            {
                //Comando pra mudar sobrenome
                att.ExecutarComando(command + "sobrenome = '" + sobrenome_input.Text + "' WHERE matricula = '" + matricula_input.Text + "'");
            }
            if (CheckCpf)
            {
                //Comando para mudar cpf
                att.ExecutarComando(command + "cpf = '" + cpf_input.Text + "' WHERE matricula = '" + matricula_input.Text + "'");
            }
            if (CheckInstru)
            {
                Inserir verify = new Inserir();
                string clave = "";
                if ((instru_input.Text).ToLower() == "violino")
                {
                    clave = "Sol";
                }
                if ((instru_input.Text).ToLower() == "viola")
                {
                    clave = "Dó";
                }
                if ((instru_input.Text).ToLower() == "cello")
                {
                    clave = "Fá";
                }

                //Mudança de instrumento requer também uma mudança de sala
                att.ExecutarComando(command + "instrumento = '" + instru_input.Text + "' WHERE matricula = '" + matricula_input.Text + "'");
                att.ExecutarComando(command + "id_sala = '" + verify.verifica_sala(user, password, clave) + "' WHERE matricula = '" + matricula_input.Text + "'");
            }
        }

        //Check Box

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

        private void back(object sender, EventArgs e)
        {
            BD_acess main = new BD_acess(user, password);
            main.Show();
            this.Hide();
        }

        //Check Box

    }

    public class Update
    {
        public string user;
        public string password;

        public Update(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        public void ExecutarComando(string comm)
        {
            string connection_string = @"Server = DUEL\SQLEXPRESS; Database = music_school;" + "User Id = " + user + ";Password = " + password + ";TrustServerCertificate = True;";
            SqlConnection connection = new SqlConnection(connection_string);
            int result = 0;

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(comm, connection);
                result = command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (result == 0)
                MessageBox.Show("Nenhuma linha foi alterada");
            else
                MessageBox.Show("Elemento alterado com sucesso");
        }
    }
}
