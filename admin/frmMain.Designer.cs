namespace admin
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.endreResultater = new System.Windows.Forms.Button();
            this.seResultater = new System.Windows.Forms.Button();
            this.endreSpm = new System.Windows.Forms.Button();
            this.leggTilSpm = new System.Windows.Forms.Button();
            this.endreBruker = new System.Windows.Forms.Button();
            this.regBruker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(263, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 871);
            this.panel1.TabIndex = 1;
            // 
            // endreResultater
            // 
            this.endreResultater.Location = new System.Drawing.Point(2, 295);
            this.endreResultater.Name = "endreResultater";
            this.endreResultater.Size = new System.Drawing.Size(187, 90);
            this.endreResultater.TabIndex = 7;
            this.endreResultater.Text = "Slette resultater";
            this.endreResultater.UseVisualStyleBackColor = true;
            this.endreResultater.Click += new System.EventHandler(this.endreResultater_Click_1);
            // 
            // seResultater
            // 
            this.seResultater.Location = new System.Drawing.Point(2, 197);
            this.seResultater.Name = "seResultater";
            this.seResultater.Size = new System.Drawing.Size(187, 90);
            this.seResultater.TabIndex = 8;
            this.seResultater.Text = "Se resultater";
            this.seResultater.UseVisualStyleBackColor = true;
            this.seResultater.Click += new System.EventHandler(this.seResultater_Click_1);
            // 
            // endreSpm
            // 
            this.endreSpm.Location = new System.Drawing.Point(2, 491);
            this.endreSpm.Name = "endreSpm";
            this.endreSpm.Size = new System.Drawing.Size(187, 90);
            this.endreSpm.TabIndex = 9;
            this.endreSpm.Text = "Endre/Slette spørsmål";
            this.endreSpm.UseVisualStyleBackColor = true;
            this.endreSpm.Click += new System.EventHandler(this.endreSpm_Click_1);
            // 
            // leggTilSpm
            // 
            this.leggTilSpm.Location = new System.Drawing.Point(2, 393);
            this.leggTilSpm.Name = "leggTilSpm";
            this.leggTilSpm.Size = new System.Drawing.Size(187, 90);
            this.leggTilSpm.TabIndex = 10;
            this.leggTilSpm.Text = "Legg til spørsmål";
            this.leggTilSpm.UseVisualStyleBackColor = true;
            this.leggTilSpm.Click += new System.EventHandler(this.leggTilSpm_Click_1);
            // 
            // endreBruker
            // 
            this.endreBruker.Location = new System.Drawing.Point(2, 99);
            this.endreBruker.Name = "endreBruker";
            this.endreBruker.Size = new System.Drawing.Size(187, 90);
            this.endreBruker.TabIndex = 11;
            this.endreBruker.Text = "Endre/slett bruker";
            this.endreBruker.UseVisualStyleBackColor = true;
            this.endreBruker.Click += new System.EventHandler(this.endreBruker_Click_1);
            // 
            // regBruker
            // 
            this.regBruker.Location = new System.Drawing.Point(2, 1);
            this.regBruker.Name = "regBruker";
            this.regBruker.Size = new System.Drawing.Size(187, 90);
            this.regBruker.TabIndex = 12;
            this.regBruker.Text = "Registrer bruker";
            this.regBruker.UseVisualStyleBackColor = true;
            this.regBruker.Click += new System.EventHandler(this.regBruker_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.endreResultater);
            this.Controls.Add(this.seResultater);
            this.Controls.Add(this.endreSpm);
            this.Controls.Add(this.leggTilSpm);
            this.Controls.Add(this.endreBruker);
            this.Controls.Add(this.regBruker);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button endreResultater;
        private System.Windows.Forms.Button seResultater;
        private System.Windows.Forms.Button endreSpm;
        private System.Windows.Forms.Button leggTilSpm;
        private System.Windows.Forms.Button endreBruker;
        private System.Windows.Forms.Button regBruker;
    }
}