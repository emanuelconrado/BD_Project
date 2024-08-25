using System;
using System.Collections;
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
    public partial class insert_screen_aluno : Form
    {

        string user;
        string password;
        string clave;

        public Inserir inserir = new Inserir();
        public insert_screen_aluno(string user, string password)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
        }

        private void back(object sender, EventArgs e)
        {
            BD_acess main = new BD_acess(user, password);
            main.Show();
            this.Hide();
        }
    

        private void add_click(object sender, EventArgs e)
        {
            if((instrument_input.Text).ToLower() == "violino")
            {
                clave = "Sol";
            }
            if ((instrument_input.Text).ToLower() == "viola")
            {
                clave = "Dó";
            }
            if ((instrument_input.Text).ToLower() == "cello")
            {
                clave = "Fá";
            }

            string result = inserir.verifica_sala(user, password, clave);
            inserir.Inse(user, password, student_name_input.Text, cpf_input.Text, instrument_input.Text, sobrenome_input.Text, result);
        }

    }
}
