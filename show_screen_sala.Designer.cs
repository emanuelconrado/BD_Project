namespace BD_Project
{
    partial class show_screen_sala
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.horario_search_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.sala = new System.Windows.Forms.CheckBox();
            this.clave_search_input = new System.Windows.Forms.TextBox();
            this.id_professor_search_input = new System.Windows.Forms.TextBox();
            this.sala_search_input = new System.Windows.Forms.TextBox();
            this.id_sala_search_input = new System.Windows.Forms.TextBox();
            this.instrumento_check = new System.Windows.Forms.CheckBox();
            this.cpf_check = new System.Windows.Forms.CheckBox();
            this.nome_check = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(601, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 23);
            this.button6.TabIndex = 57;
            this.button6.Text = "Consultar todos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.consultar_todos);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(601, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 23);
            this.button5.TabIndex = 56;
            this.button5.Text = "Consultar musica";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.consultar_musica);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(601, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 55;
            this.button4.Text = "Consultar aluno";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.consultar_aluno);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(601, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "Consultar professor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.consultar_professor);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.back);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(352, 99);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 13);
            this.label.TabIndex = 52;
            this.label.Text = "Consultar sala";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(251, 294);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 51;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox_horario);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Horário";
            // 
            // horario_search_input
            // 
            this.horario_search_input.Location = new System.Drawing.Point(272, 288);
            this.horario_search_input.Name = "horario_search_input";
            this.horario_search_input.Size = new System.Drawing.Size(249, 20);
            this.horario_search_input.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "ID Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Sala";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(206, 146);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(42, 13);
            this.Nome.TabIndex = 45;
            this.Nome.Text = "ID Sala";
            // 
            // sala
            // 
            this.sala.AutoSize = true;
            this.sala.Location = new System.Drawing.Point(251, 254);
            this.sala.Name = "sala";
            this.sala.Size = new System.Drawing.Size(15, 14);
            this.sala.TabIndex = 44;
            this.sala.UseVisualStyleBackColor = true;
            this.sala.Click += new System.EventHandler(this.checkBox_clave);
            // 
            // clave_search_input
            // 
            this.clave_search_input.Location = new System.Drawing.Point(272, 248);
            this.clave_search_input.Name = "clave_search_input";
            this.clave_search_input.Size = new System.Drawing.Size(249, 20);
            this.clave_search_input.TabIndex = 43;
            // 
            // id_professor_search_input
            // 
            this.id_professor_search_input.Location = new System.Drawing.Point(272, 212);
            this.id_professor_search_input.Name = "id_professor_search_input";
            this.id_professor_search_input.Size = new System.Drawing.Size(249, 20);
            this.id_professor_search_input.TabIndex = 42;
            // 
            // sala_search_input
            // 
            this.sala_search_input.Location = new System.Drawing.Point(272, 177);
            this.sala_search_input.Name = "sala_search_input";
            this.sala_search_input.Size = new System.Drawing.Size(249, 20);
            this.sala_search_input.TabIndex = 41;
            // 
            // id_sala_search_input
            // 
            this.id_sala_search_input.Location = new System.Drawing.Point(272, 140);
            this.id_sala_search_input.Name = "id_sala_search_input";
            this.id_sala_search_input.Size = new System.Drawing.Size(249, 20);
            this.id_sala_search_input.TabIndex = 40;
            // 
            // instrumento_check
            // 
            this.instrumento_check.AutoSize = true;
            this.instrumento_check.Location = new System.Drawing.Point(251, 218);
            this.instrumento_check.Name = "instrumento_check";
            this.instrumento_check.Size = new System.Drawing.Size(15, 14);
            this.instrumento_check.TabIndex = 39;
            this.instrumento_check.UseVisualStyleBackColor = true;
            this.instrumento_check.Click += new System.EventHandler(this.checkBox_id_professor);
            // 
            // cpf_check
            // 
            this.cpf_check.AutoSize = true;
            this.cpf_check.Location = new System.Drawing.Point(251, 183);
            this.cpf_check.Name = "cpf_check";
            this.cpf_check.Size = new System.Drawing.Size(15, 14);
            this.cpf_check.TabIndex = 38;
            this.cpf_check.UseVisualStyleBackColor = true;
            this.cpf_check.Click += new System.EventHandler(this.checkBox_nome_sala);
            // 
            // nome_check
            // 
            this.nome_check.AutoSize = true;
            this.nome_check.Location = new System.Drawing.Point(251, 146);
            this.nome_check.Name = "nome_check";
            this.nome_check.Size = new System.Drawing.Size(15, 14);
            this.nome_check.TabIndex = 37;
            this.nome_check.UseVisualStyleBackColor = true;
            this.nome_check.Click += new System.EventHandler(this.checkBox_id_sala);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.search_click);
            // 
            // show_screen_sala
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
            this.Controls.Add(this.horario_search_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.sala);
            this.Controls.Add(this.clave_search_input);
            this.Controls.Add(this.id_professor_search_input);
            this.Controls.Add(this.sala_search_input);
            this.Controls.Add(this.id_sala_search_input);
            this.Controls.Add(this.instrumento_check);
            this.Controls.Add(this.cpf_check);
            this.Controls.Add(this.nome_check);
            this.Controls.Add(this.button1);
            this.Name = "show_screen_sala";
            this.Text = "show_screen_sala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox horario_search_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.CheckBox sala;
        private System.Windows.Forms.TextBox clave_search_input;
        private System.Windows.Forms.TextBox id_professor_search_input;
        private System.Windows.Forms.TextBox sala_search_input;
        private System.Windows.Forms.TextBox id_sala_search_input;
        private System.Windows.Forms.CheckBox instrumento_check;
        private System.Windows.Forms.CheckBox cpf_check;
        private System.Windows.Forms.CheckBox nome_check;
        private System.Windows.Forms.Button button1;
    }
}