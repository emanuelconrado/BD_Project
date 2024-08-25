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

public class Buscar
{
    public string user;
    public string password;

    public Buscar(string user, string password)
    {
        this.user = user;
        this.password = password;
    }

    //Funcoes de Busca
    public string BuscaNome(string nome)
    {
        return "nome = '" + nome + "'";
    }

    public string BuscaSobrenome(string sobrenome)
    {
        return "sobrenome = '" + sobrenome + "'";
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

    public string BuscaId_musica(string id_musica)
    {
        return "id_musica = " + "'" + id_musica + "'";
    }

    public string BuscaId_partitura(string id_partitura)
    {
        return "id_partitura = " + "'" + id_partitura + "'";
    }

    public string BuscaMatricula(string mat)
    {
        return "matricula = '" + mat + "'";
    }

    public string BuscaId_sala(string id)
    {
        return "id = '" + id + "'";
    }

    public string BuscaNome_sala(string nome_sala)
    {
        return "nome_sala = " + "'" + nome_sala + "'";
    }

    public string BuscaId_professor(string id_professor)
    {
        return "id_professor = " + "'" + id_professor + "'";
    }

    public string BuscaClave(string clave)
    {
        return "clave = " + "'" + clave + "'";
    }

    public string BuscaHarario(string horario)
    {
        return "horario = " + "'" + horario + "'";
    }

    public string verifica_partitura(string user, string password, string id)
    {
        string comm = "SELECT * FROM partitura Where id = '" + id + "'";
        string connection_string = @"Server = DUEL\SQLEXPRESS; Database = music_school;" + "User Id = " + user + ";Password = " + password + ";TrustServerCertificate = True;";
        string result = "";

        SqlConnection connection = new SqlConnection(connection_string);
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(comm, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                result = (String.Format("{0}", reader[0]));
                }
            }

            connection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
            return result;
        }
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
                    result = result + (String.Format("Matrícula: {0} || Nome: {1} {2} || Instrumento: {3} || Sala: {4}\n", reader[0], reader[1], reader[5], reader[3], reader[4]));
                }
                MessageBox.Show(result, "Alunos");
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

public class Inserir
{
    public void Inse(string user, string password, string nome, string cpf, string instrumento, string sobrenome, string sala)
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
                command.Parameters.AddWithValue("@id_sala", sala);

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Aluno cadastrado: " + nome + " " + sobrenome + " " + "ID Sala: " + sala);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro: " + ex.Message);
        }
    }

    public string verifica_sala(string user, string password, string clave)
    {
        string comm = "SELECT * FROM sala Where clave = '" + clave + "'";
        string connection_string = @"Server = DUEL\SQLEXPRESS; Database = music_school;" + "User Id = " + user + ";Password = " + password + ";TrustServerCertificate = True;";
        string result = "";

        SqlConnection connection = new SqlConnection(connection_string);
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(comm, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result = (String.Format("{0}", reader[0]));
                }
            }

            connection.Close();
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
            return result;
        }
    }
}