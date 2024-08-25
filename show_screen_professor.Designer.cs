namespace BD_Project
{
    partial class show_screen_professor
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.id_search_input = new System.Windows.Forms.TextBox();
            this.sobrenome_search_input = new System.Windows.Forms.TextBox();
            this.nome_search_input = new System.Windows.Forms.TextBox();
            this.instrumento_check = new System.Windows.Forms.CheckBox();
            this.cpf_check = new System.Windows.Forms.CheckBox();
            this.nome_check = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(611, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 23);
            this.button6.TabIndex = 57;
            this.button6.Text = "Consultar todos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.consultar_todos);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(611, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 23);
            this.button5.TabIndex = 56;
            this.button5.Text = "Consultar musica";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.consultar_musica);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(611, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 55;
            this.button4.Text = "Consultar sala";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.consultar_sala);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "Consultar aluno";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.consultar_aluno);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 28);
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
            this.label.Location = new System.Drawing.Point(362, 101);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(97, 13);
            this.label.TabIndex = 52;
            this.label.Text = "Consultar professor";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Sobrenome";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(220, 173);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 45;
            this.Nome.Text = "Nome";
            // 
            // id_search_input
            // 
            this.id_search_input.Location = new System.Drawing.Point(282, 264);
            this.id_search_input.Name = "id_search_input";
            this.id_search_input.Size = new System.Drawing.Size(249, 20);
            this.id_search_input.TabIndex = 42;
            // 
            // sobrenome_search_input
            // 
            this.sobrenome_search_input.Location = new System.Drawing.Point(282, 214);
            this.sobrenome_search_input.Name = "sobrenome_search_input";
            this.sobrenome_search_input.Size = new System.Drawing.Size(249, 20);
            this.sobrenome_search_input.TabIndex = 41;
            // 
            // nome_search_input
            // 
            this.nome_search_input.Location = new System.Drawing.Point(282, 165);
            this.nome_search_input.Name = "nome_search_input";
            this.nome_search_input.Size = new System.Drawing.Size(249, 20);
            this.nome_search_input.TabIndex = 40;
            // 
            // instrumento_check
            // 
            this.instrumento_check.AutoSize = true;
            this.instrumento_check.Location = new System.Drawing.Point(261, 270);
            this.instrumento_check.Name = "instrumento_check";
            this.instrumento_check.Size = new System.Drawing.Size(15, 14);
            this.instrumento_check.TabIndex = 39;
            this.instrumento_check.UseVisualStyleBackColor = true;
            this.instrumento_check.Click += new System.EventHandler(this.checkBox_id_professor);
            // 
            // cpf_check
            // 
            this.cpf_check.AutoSize = true;
            this.cpf_check.Location = new System.Drawing.Point(261, 221);
            this.cpf_check.Name = "cpf_check";
            this.cpf_check.Size = new System.Drawing.Size(15, 14);
            this.cpf_check.TabIndex = 38;
            this.cpf_check.UseVisualStyleBackColor = true;
            this.cpf_check.Click += new System.EventHandler(this.checkBox_sobrenome);
            // 
            // nome_check
            // 
            this.nome_check.AutoSize = true;
            this.nome_check.Location = new System.Drawing.Point(261, 172);
            this.nome_check.Name = "nome_check";
            this.nome_check.Size = new System.Drawing.Size(15, 14);
            this.nome_check.TabIndex = 37;
            this.nome_check.UseVisualStyleBackColor = true;
            this.nome_check.Click += new System.EventHandler(this.checkBox_nome_professor);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.search_click);
            // 
            // show_screen_professor
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.id_search_input);
            this.Controls.Add(this.sobrenome_search_input);
            this.Controls.Add(this.nome_search_input);
            this.Controls.Add(this.instrumento_check);
            this.Controls.Add(this.cpf_check);
            this.Controls.Add(this.nome_check);
            this.Controls.Add(this.button1);
            this.Name = "show_screen_professor";
            this.Text = "show_screen";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox id_search_input;
        private System.Windows.Forms.TextBox sobrenome_search_input;
        private System.Windows.Forms.TextBox nome_search_input;
        private System.Windows.Forms.CheckBox instrumento_check;
        private System.Windows.Forms.CheckBox cpf_check;
        private System.Windows.Forms.CheckBox nome_check;
        private System.Windows.Forms.Button button1;
    }
}