namespace admin
{
    partial class leggTilSpm
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
            this.imageTxt = new System.Windows.Forms.TextBox();
            this.correctTxt = new System.Windows.Forms.TextBox();
            this.A4 = new System.Windows.Forms.TextBox();
            this.A3 = new System.Windows.Forms.TextBox();
            this.A2 = new System.Windows.Forms.TextBox();
            this.A1 = new System.Windows.Forms.TextBox();
            this.questionTxt = new System.Windows.Forms.TextBox();
            this.leggTilBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageTxt
            // 
            this.imageTxt.Location = new System.Drawing.Point(163, 361);
            this.imageTxt.Name = "imageTxt";
            this.imageTxt.Size = new System.Drawing.Size(287, 20);
            this.imageTxt.TabIndex = 9;
            // 
            // correctTxt
            // 
            this.correctTxt.Location = new System.Drawing.Point(163, 311);
            this.correctTxt.Name = "correctTxt";
            this.correctTxt.Size = new System.Drawing.Size(287, 20);
            this.correctTxt.TabIndex = 10;
            // 
            // A4
            // 
            this.A4.Location = new System.Drawing.Point(163, 264);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(287, 20);
            this.A4.TabIndex = 11;
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(163, 218);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(287, 20);
            this.A3.TabIndex = 12;
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(163, 174);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(287, 20);
            this.A2.TabIndex = 13;
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(163, 127);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(287, 20);
            this.A1.TabIndex = 8;
            // 
            // questionTxt
            // 
            this.questionTxt.Location = new System.Drawing.Point(163, 78);
            this.questionTxt.Name = "questionTxt";
            this.questionTxt.Size = new System.Drawing.Size(287, 20);
            this.questionTxt.TabIndex = 7;
            // 
            // leggTilBtn
            // 
            this.leggTilBtn.Location = new System.Drawing.Point(163, 418);
            this.leggTilBtn.Name = "leggTilBtn";
            this.leggTilBtn.Size = new System.Drawing.Size(287, 23);
            this.leggTilBtn.TabIndex = 14;
            this.leggTilBtn.Text = "Legg til spørsmål";
            this.leggTilBtn.UseVisualStyleBackColor = true;
            this.leggTilBtn.Click += new System.EventHandler(this.leggTilBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Question";
            // 
            // leggTilSpm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leggTilBtn);
            this.Controls.Add(this.imageTxt);
            this.Controls.Add(this.correctTxt);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.questionTxt);
            this.Name = "leggTilSpm";
            this.Text = "leggTilSpm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.leggTilSpm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imageTxt;
        private System.Windows.Forms.TextBox correctTxt;
        private System.Windows.Forms.TextBox A4;
        private System.Windows.Forms.TextBox A3;
        private System.Windows.Forms.TextBox A2;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.TextBox questionTxt;
        private System.Windows.Forms.Button leggTilBtn;
        private System.Windows.Forms.Label label1;
    }
}