using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BD_Project.show_screen_musica;
using static BD_Project.show_screen_sala;

namespace BD_Project
{
    public partial class show_screen_all : Form
    {
        string user;
        string password;

        Boolean[] checkBox = new Boolean[5];
        BuscarProf buscaProf;
        BuscarAluno buscaAluno;
        BuscarSala buscaSala;
        BuscarMusica buscaMusica;

        public show_screen_all(string user, string password)
        {
            InitializeComponent();
            buscaAluno = new BuscarAluno(user, password);
            buscaProf = new BuscarProf(user, password);
            buscaSala = new BuscarSala(user, password);
            buscaMusica = new BuscarMusica(user, password);
            this.user = user;
            this.password = password;
        }

        private void consultar_professor(object sender, EventArgs e)
        {
            show_screen_professor professor = new show_screen_professor(user, password);
            professor.Show();
            this.Hide();
        }

        private void back(object sender, EventArgs e)
        {
            BD_acess main = new BD_acess(user, password);
            main.Show();
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

        private void consultar_aluno(object sender, EventArgs e)
        {
            show_screen_aluno aluno = new show_screen_aluno(user, password);
            aluno.Show();
            this.Hide();
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (checkBox[0])
            {
                buscaAluno.ExecutarComando("SELECT * FROM aluno");
            }
            if (checkBox[1])
            {
                buscaProf.ExecutarComando("SELECT * FROM professor");
            }
            if (checkBox[2])
            {
                buscaSala.ExecutarComando("SELECT * FROM sala");
            }
            if (checkBox[3])
            {
                buscaMusica.ExecutarComando("SELECT * FROM musica");
            }
            if (checkBox[4])
            {
                buscaMusica.ExecutarComandoPart("SELECT * FROM partitura");
            }
        }

        //Check box
        private void checkBox_aluno(object sender, EventArgs e)
        {
            checkBox[0] = !checkBox[0];
        }
        private void checkBox_prof(object sender, EventArgs e)
        {
            checkBox[1] = !checkBox[1];
        }
        private void checkBox_sala(object sender, EventArgs e)
        {
            checkBox[2] = !checkBox[2];
        }
        private void checkBox_musica(object sender, EventArgs e)
        {
            checkBox[3] = !checkBox[3];
        }
        private void checkBox_partitura(object sender, EventArgs e)
        {
            checkBox[4] = !checkBox[4];
        }

        //Check box

    }
}
