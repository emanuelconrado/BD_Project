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
            insert_screen main = new insert_screen(user, password);
            main.Show();
            this.Hide();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            show_screen main = new show_screen(user, password);
            main.Show();
            this.Hide();
        }
    }
}
