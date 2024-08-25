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
    public partial class BD_acess : Form
    {
        string user;
        string password;

        public BD_acess(string user, string password)
        {
            InitializeComponent();
            this.user = user;
            this.password = password;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            insert_screen_aluno main = new insert_screen_aluno(user, password);
            main.Show();
            this.Hide();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            show_screen_aluno main = new show_screen_aluno(user, password);
            main.Show();
            this.Hide();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            update main = new update(user, password);
            main.Show();
            this.Hide();
        }

        private void delete_button_Click(Object sender, EventArgs e)
        {
            delete main = new delete(user, password);
            main.Show();
            this.Hide();
        }
    }
}
