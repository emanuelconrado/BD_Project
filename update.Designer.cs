namespace BD_Project
{
    partial class update
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
            this.button2 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.matricula_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.sala = new System.Windows.Forms.CheckBox();
            this.sobrenome_input = new System.Windows.Forms.TextBox();
            this.instru_input = new System.Windows.Forms.TextBox();
            this.cpf_input = new System.Windows.Forms.TextBox();
            this.nome_input = new System.Windows.Forms.TextBox();
            this.instrumento_check = new System.Windows.Forms.CheckBox();
            this.cpf_check = new System.Windows.Forms.CheckBox();
            this.nome_check = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 30);
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
            this.label.Location = new System.Drawing.Point(375, 102);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 13);
            this.label.TabIndex = 52;
            this.label.Text = "Alterar aluno";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Matrícula";
            // 
            // matricula_input
            // 
            this.matricula_input.Location = new System.Drawing.Point(285, 129);
            this.matricula_input.Name = "matricula_input";
            this.matricula_input.Size = new System.Drawing.Size(249, 20);
            this.matricula_input.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Instrumento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "CPF";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(222, 175);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 45;
            this.Nome.Text = "Nome";
            // 
            // sala
            // 
            this.sala.AutoSize = true;
            this.sala.Location = new System.Drawing.Point(264, 217);
            this.sala.Name = "sala";
            this.sala.Size = new System.Drawing.Size(15, 14);
            this.sala.TabIndex = 44;
            this.sala.UseVisualStyleBackColor = true;
            this.sala.Click += new System.EventHandler(this.checkBox_sobrenome);
            // 
            // sobrenome_input
            // 
            this.sobrenome_input.Location = new System.Drawing.Point(285, 211);
            this.sobrenome_input.Name = "sobrenome_input";
            this.sobrenome_input.Size = new System.Drawing.Size(249, 20);
            this.sobrenome_input.TabIndex = 43;
            // 
            // instru_input
            // 
            this.instru_input.Location = new System.Drawing.Point(285, 285);
            this.instru_input.Name = "instru_input";
            this.instru_input.Size = new System.Drawing.Size(249, 20);
            this.instru_input.TabIndex = 42;
            // 
            // cpf_input
            // 
            this.cpf_input.Location = new System.Drawing.Point(285, 250);
            this.cpf_input.Name = "cpf_input";
            this.cpf_input.Size = new System.Drawing.Size(249, 20);
            this.cpf_input.TabIndex = 41;
            // 
            // nome_input
            // 
            this.nome_input.Location = new System.Drawing.Point(285, 168);
            this.nome_input.Name = "nome_input";
            this.nome_input.Size = new System.Drawing.Size(249, 20);
            this.nome_input.TabIndex = 40;
            // 
            // instrumento_check
            // 
            this.instrumento_check.AutoSize = true;
            this.instrumento_check.Location = new System.Drawing.Point(264, 292);
            this.instrumento_check.Name = "instrumento_check";
            this.instrumento_check.Size = new System.Drawing.Size(15, 14);
            this.instrumento_check.TabIndex = 39;
            this.instrumento_check.UseVisualStyleBackColor = true;
            this.instrumento_check.Click += new System.EventHandler(this.checkBox_instru);
            // 
            // cpf_check
            // 
            this.cpf_check.AutoSize = true;
            this.cpf_check.Location = new System.Drawing.Point(264, 256);
            this.cpf_check.Name = "cpf_check";
            this.cpf_check.Size = new System.Drawing.Size(15, 14);
            this.cpf_check.TabIndex = 38;
            this.cpf_check.UseVisualStyleBackColor = true;
            this.cpf_check.Click += new System.EventHandler(this.checkBox_cpf);
            // 
            // nome_check
            // 
            this.nome_check.AutoSize = true;
            this.nome_check.Location = new System.Drawing.Point(264, 174);
            this.nome_check.Name = "nome_check";
            this.nome_check.Size = new System.Drawing.Size(15, 14);
            this.nome_check.TabIndex = 37;
            this.nome_check.UseVisualStyleBackColor = true;
            this.nome_check.Click += new System.EventHandler(this.checkBox_nome);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.update_button_Click);
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.matricula_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.sala);
            this.Controls.Add(this.sobrenome_input);
            this.Controls.Add(this.instru_input);
            this.Controls.Add(this.cpf_input);
            this.Controls.Add(this.nome_input);
            this.Controls.Add(this.instrumento_check);
            this.Controls.Add(this.cpf_check);
            this.Controls.Add(this.nome_check);
            this.Controls.Add(this.button1);
            this.Name = "update";
            this.Text = "update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox matricula_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.CheckBox sala;
        private System.Windows.Forms.TextBox sobrenome_input;
        private System.Windows.Forms.TextBox instru_input;
        private System.Windows.Forms.TextBox cpf_input;
        private System.Windows.Forms.TextBox nome_input;
        private System.Windows.Forms.CheckBox instrumento_check;
        private System.Windows.Forms.CheckBox cpf_check;
        private System.Windows.Forms.CheckBox nome_check;
        private System.Windows.Forms.Button button1;
    }
}