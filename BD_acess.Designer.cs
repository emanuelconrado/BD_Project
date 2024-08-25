namespace BD_Project
{
    partial class BD_acess
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
            this.insert_button = new System.Windows.Forms.Button();
            this.show_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(277, 137);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(229, 23);
            this.insert_button.TabIndex = 0;
            this.insert_button.Text = "Cadastrar";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_Click);
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(277, 178);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(229, 23);
            this.show_button.TabIndex = 1;
            this.show_button.Text = "Mostrar";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.update_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // BD_acess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.insert_button);
            this.Name = "BD_acess";
            this.Text = "BD_acess";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}