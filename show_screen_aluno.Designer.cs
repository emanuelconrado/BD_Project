namespace BD_Project
{
    partial class show_screen_aluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.nome_check = new System.Windows.Forms.CheckBox();
            this.cpf_check = new System.Windows.Forms.CheckBox();
            this.instrumento_check = new System.Windows.Forms.CheckBox();
            this.nome_search_input = new System.Windows.Forms.TextBox();
            this.cpf_search_input = new System.Windows.Forms.TextBox();
            this.instrumento_search_input = new System.Windows.Forms.TextBox();
            this.sala_search_input = new System.Windows.Forms.TextBox();
            this.sala = new System.Windows.Forms.CheckBox();
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.matricula_serach_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.search_click);
            // 
            // nome_check
            // 
            this.nome_check.AutoSize = true;
            this.nome_check.Location = new System.Drawing.Point(259, 145);
            this.nome_check.Name = "nome_check";
            this.nome_check.Size = new System.Drawing.Size(15, 14);
            this.nome_check.TabIndex = 1;
            this.nome_check.UseVisualStyleBackColor = true;
            this.nome_check.CheckedChanged += new System.EventHandler(this.checkBox_nome);
            // 
            // cpf_check
            // 
            this.cpf_check.AutoSize = true;
            this.cpf_check.Location = new System.Drawing.Point(259, 182);
            this.cpf_check.Name = "cpf_check";
            this.cpf_check.Size = new System.Drawing.Size(15, 14);
            this.cpf_check.TabIndex = 2;
            this.cpf_check.UseVisualStyleBackColor = true;
            this.cpf_check.CheckedChanged += new System.EventHandler(this.checkBox_cpf);
            // 
            // instrumento_check
            // 
            this.instrumento_check.AutoSize = true;
            this.instrumento_check.Location = new System.Drawing.Point(259, 217);
            this.instrumento_check.Name = "instrumento_check";
            this.instrumento_check.Size = new System.Drawing.Size(15, 14);
            this.instrumento_check.TabIndex = 3;
            this.instrumento_check.UseVisualStyleBackColor = true;
            this.instrumento_check.CheckedChanged += new System.EventHandler(this.checkBox_instrumento);
            // 
            // nome_search_input
            // 
            this.nome_search_input.Location = new System.Drawing.Point(280, 139);
            this.nome_search_input.Name = "nome_search_input";
            this.nome_search_input.Size = new System.Drawing.Size(249, 20);
            this.nome_search_input.TabIndex = 4;
            // 
            // cpf_search_input
            // 
            this.cpf_search_input.Location = new System.Drawing.Point(280, 176);
            this.cpf_search_input.Name = "cpf_search_input";
            this.cpf_search_input.Size = new System.Drawing.Size(249, 20);
            this.cpf_search_input.TabIndex = 5;
            // 
            // instrumento_search_input
            // 
            this.instrumento_search_input.Location = new System.Drawing.Point(280, 211);
            this.instrumento_search_input.Name = "instrumento_search_input";
            this.instrumento_search_input.Size = new System.Drawing.Size(249, 20);
            this.instrumento_search_input.TabIndex = 6;
            // 
            // sala_search_input
            // 
            this.sala_search_input.Location = new System.Drawing.Point(280, 247);
            this.sala_search_input.Name = "sala_search_input";
            this.sala_search_input.Size = new System.Drawing.Size(249, 20);
            this.sala_search_input.TabIndex = 7;
            // 
            // sala
            // 
            this.sala.AutoSize = true;
            this.sala.Location = new System.Drawing.Point(259, 253);
            this.sala.Name = "sala";
            this.sala.Size = new System.Drawing.Size(15, 14);
            this.sala.TabIndex = 8;
            this.sala.UseVisualStyleBackColor = true;
            this.sala.CheckedChanged += new System.EventHandler(this.checkBox_sala);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(217, 146);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 10;
            this.Nome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Instrumento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sala";
            // 
            // matricula_serach_input
            // 
            this.matricula_serach_input.Location = new System.Drawing.Point(280, 287);
            this.matricula_serach_input.Name = "matricula_serach_input";
            this.matricula_serach_input.Size = new System.Drawing.Size(249, 20);
            this.matricula_serach_input.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Matrícula";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(259, 293);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox_matricula);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(360, 98);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 13);
            this.label.TabIndex = 30;
            this.label.Text = "Consultar aluno";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.back);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(609, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Consultar professor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.consultar_professor);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(609, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Consultar sala";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.consultar_sala);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(609, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Consultar musica";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.consultar_musica);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(609, 249);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 23);
            this.button6.TabIndex = 35;
            this.button6.Text = "Consultar todos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.consultar_todos);
            // 
            // show_screen_aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matricula_serach_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.sala);
            this.Controls.Add(this.sala_search_input);
            this.Controls.Add(this.instrumento_search_input);
            this.Controls.Add(this.cpf_search_input);
            this.Controls.Add(this.nome_search_input);
            this.Controls.Add(this.instrumento_check);
            this.Controls.Add(this.cpf_check);
            this.Controls.Add(this.nome_check);
            this.Controls.Add(this.button1);
            this.Name = "show_screen_aluno";
            this.Text = "show_screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox nome_check;
        private System.Windows.Forms.CheckBox cpf_check;
        private System.Windows.Forms.CheckBox instrumento_check;
        private System.Windows.Forms.TextBox nome_search_input;
        private System.Windows.Forms.TextBox cpf_search_input;
        private System.Windows.Forms.TextBox instrumento_search_input;
        private System.Windows.Forms.TextBox sala_search_input;
        private System.Windows.Forms.CheckBox sala;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox matricula_serach_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}