namespace admin
{
    partial class endreResultater
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
            this.dropdownStudents = new System.Windows.Forms.ComboBox();
            this.dropdownResults = new System.Windows.Forms.ComboBox();
            this.slettBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropdownStudents
            // 
            this.dropdownStudents.FormattingEnabled = true;
            this.dropdownStudents.Location = new System.Drawing.Point(39, 48);
            this.dropdownStudents.Name = "dropdownStudents";
            this.dropdownStudents.Size = new System.Drawing.Size(433, 21);
            this.dropdownStudents.TabIndex = 0;
            this.dropdownStudents.SelectedIndexChanged += new System.EventHandler(this.dropdownStudents_SelectedIndexChanged);
            // 
            // dropdownResults
            // 
            this.dropdownResults.FormattingEnabled = true;
            this.dropdownResults.Location = new System.Drawing.Point(39, 123);
            this.dropdownResults.Name = "dropdownResults";
            this.dropdownResults.Size = new System.Drawing.Size(433, 21);
            this.dropdownResults.TabIndex = 1;
            // 
            // slettBtn
            // 
            this.slettBtn.Location = new System.Drawing.Point(39, 202);
            this.slettBtn.Name = "slettBtn";
            this.slettBtn.Size = new System.Drawing.Size(433, 36);
            this.slettBtn.TabIndex = 2;
            this.slettBtn.Text = "Slett resultat";
            this.slettBtn.UseVisualStyleBackColor = true;
            this.slettBtn.Click += new System.EventHandler(this.slettBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bruker:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultat:";
            // 
            // endreResultater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 630);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slettBtn);
            this.Controls.Add(this.dropdownResults);
            this.Controls.Add(this.dropdownStudents);
            this.Name = "endreResultater";
            this.Text = "Slette Resultater";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.endreResultater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropdownStudents;
        private System.Windows.Forms.ComboBox dropdownResults;
        private System.Windows.Forms.Button slettBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}