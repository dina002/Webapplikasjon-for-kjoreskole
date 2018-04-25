namespace admin
{
    partial class regBruker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.brukernavnTxt = new System.Windows.Forms.TextBox();
            this.passordTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.fornavnTxt = new System.Windows.Forms.TextBox();
            this.etternavnTxt = new System.Windows.Forms.TextBox();
            this.dropdownRights = new System.Windows.Forms.ComboBox();
            this.brukerTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrer ny bruker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brukernavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fornavn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Etternavn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrer bruker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brukernavnTxt
            // 
            this.brukernavnTxt.Location = new System.Drawing.Point(126, 97);
            this.brukernavnTxt.Name = "brukernavnTxt";
            this.brukernavnTxt.Size = new System.Drawing.Size(252, 20);
            this.brukernavnTxt.TabIndex = 7;
            // 
            // passordTxt
            // 
            this.passordTxt.Location = new System.Drawing.Point(126, 133);
            this.passordTxt.Name = "passordTxt";
            this.passordTxt.PasswordChar = '*';
            this.passordTxt.Size = new System.Drawing.Size(252, 20);
            this.passordTxt.TabIndex = 7;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(126, 169);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(252, 20);
            this.emailTxt.TabIndex = 7;
            // 
            // fornavnTxt
            // 
            this.fornavnTxt.Location = new System.Drawing.Point(126, 205);
            this.fornavnTxt.Name = "fornavnTxt";
            this.fornavnTxt.Size = new System.Drawing.Size(252, 20);
            this.fornavnTxt.TabIndex = 7;
            // 
            // etternavnTxt
            // 
            this.etternavnTxt.Location = new System.Drawing.Point(126, 241);
            this.etternavnTxt.Name = "etternavnTxt";
            this.etternavnTxt.Size = new System.Drawing.Size(252, 20);
            this.etternavnTxt.TabIndex = 7;
            // 
            // dropdownRights
            // 
            this.dropdownRights.FormattingEnabled = true;
            this.dropdownRights.Location = new System.Drawing.Point(126, 268);
            this.dropdownRights.Name = "dropdownRights";
            this.dropdownRights.Size = new System.Drawing.Size(252, 21);
            this.dropdownRights.TabIndex = 8;
            // 
            // brukerTxt
            // 
            this.brukerTxt.AutoSize = true;
            this.brukerTxt.Location = new System.Drawing.Point(55, 268);
            this.brukerTxt.Name = "brukerTxt";
            this.brukerTxt.Size = new System.Drawing.Size(58, 13);
            this.brukerTxt.TabIndex = 5;
            this.brukerTxt.Text = "Brukertype";
            // 
            // regBruker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 618);
            this.Controls.Add(this.dropdownRights);
            this.Controls.Add(this.etternavnTxt);
            this.Controls.Add(this.fornavnTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.passordTxt);
            this.Controls.Add(this.brukernavnTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.brukerTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "regBruker";
            this.Text = "regBruker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.regBruker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox brukernavnTxt;
        private System.Windows.Forms.TextBox passordTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox fornavnTxt;
        private System.Windows.Forms.TextBox etternavnTxt;
        private System.Windows.Forms.ComboBox dropdownRights;
        private System.Windows.Forms.Label brukerTxt;
    }
}