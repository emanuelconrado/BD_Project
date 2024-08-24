namespace BD_Project
{
    partial class insert_screen
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
            this.student_name_input = new System.Windows.Forms.TextBox();
            this.insert_button = new System.Windows.Forms.Button();
            this.cpf_input = new System.Windows.Forms.TextBox();
            this.instrument_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sobrenome_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // student_name_input
            // 
            this.student_name_input.Location = new System.Drawing.Point(291, 105);
            this.student_name_input.Name = "student_name_input";
            this.student_name_input.Size = new System.Drawing.Size(225, 20);
            this.student_name_input.TabIndex = 0;
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(362, 317);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(75, 23);
            this.insert_button.TabIndex = 1;
            this.insert_button.Text = "Adicionar";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.add_click);
            // 
            // cpf_input
            // 
            this.cpf_input.Location = new System.Drawing.Point(291, 186);
            this.cpf_input.Name = "cpf_input";
            this.cpf_input.Size = new System.Drawing.Size(225, 20);
            this.cpf_input.TabIndex = 3;
            // 
            // instrument_input
            // 
            this.instrument_input.Location = new System.Drawing.Point(291, 226);
            this.instrument_input.Name = "instrument_input";
            this.instrument_input.Size = new System.Drawing.Size(225, 20);
            this.instrument_input.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Instrumento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sobrenome_input
            // 
            this.sobrenome_input.Location = new System.Drawing.Point(291, 143);
            this.sobrenome_input.Name = "sobrenome_input";
            this.sobrenome_input.Size = new System.Drawing.Size(225, 20);
            this.sobrenome_input.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sobrenome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // insert_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sobrenome_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instrument_input);
            this.Controls.Add(this.cpf_input);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.student_name_input);
            this.Name = "insert_screen";
            this.Text = "insert_screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox student_name_input;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.TextBox cpf_input;
        private System.Windows.Forms.TextBox instrument_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sobrenome_input;
        private System.Windows.Forms.Label label3;
    }
}