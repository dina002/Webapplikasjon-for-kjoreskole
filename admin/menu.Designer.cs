namespace admin
{
    partial class menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.endreResultater = new System.Windows.Forms.Button();
            this.seResultater = new System.Windows.Forms.Button();
            this.endreSpm = new System.Windows.Forms.Button();
            this.leggTilSpm = new System.Windows.Forms.Button();
            this.endreBruker = new System.Windows.Forms.Button();
            this.regBruker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // endreResultater
            // 
            this.endreResultater.Location = new System.Drawing.Point(17, 284);
            this.endreResultater.Name = "endreResultater";
            this.endreResultater.Size = new System.Drawing.Size(187, 70);
            this.endreResultater.TabIndex = 1;
            this.endreResultater.Text = "Endre/Slette resultater";
            this.endreResultater.UseVisualStyleBackColor = true;
            this.endreResultater.Click += new System.EventHandler(this.endreResultater_Click_1);
            // 
            // seResultater
            // 
            this.seResultater.Location = new System.Drawing.Point(17, 197);
            this.seResultater.Name = "seResultater";
            this.seResultater.Size = new System.Drawing.Size(187, 70);
            this.seResultater.TabIndex = 2;
            this.seResultater.Text = "Se resultater";
            this.seResultater.UseVisualStyleBackColor = true;
            this.seResultater.Click += new System.EventHandler(this.seResultater_Click_1);
            // 
            // endreSpm
            // 
            this.endreSpm.Location = new System.Drawing.Point(17, 458);
            this.endreSpm.Name = "endreSpm";
            this.endreSpm.Size = new System.Drawing.Size(187, 70);
            this.endreSpm.TabIndex = 3;
            this.endreSpm.Text = "Endre/Slette spørsmål";
            this.endreSpm.UseVisualStyleBackColor = true;
            this.endreSpm.Click += new System.EventHandler(this.endreSpm_Click);
            // 
            // leggTilSpm
            // 
            this.leggTilSpm.Location = new System.Drawing.Point(17, 371);
            this.leggTilSpm.Name = "leggTilSpm";
            this.leggTilSpm.Size = new System.Drawing.Size(187, 70);
            this.leggTilSpm.TabIndex = 4;
            this.leggTilSpm.Text = "Legg til spørsmål";
            this.leggTilSpm.UseVisualStyleBackColor = true;
            this.leggTilSpm.Click += new System.EventHandler(this.leggTilSpm_Click_1);
            // 
            // endreBruker
            // 
            this.endreBruker.Location = new System.Drawing.Point(17, 110);
            this.endreBruker.Name = "endreBruker";
            this.endreBruker.Size = new System.Drawing.Size(187, 70);
            this.endreBruker.TabIndex = 5;
            this.endreBruker.Text = "Endre/slett bruker";
            this.endreBruker.UseVisualStyleBackColor = true;
            this.endreBruker.Click += new System.EventHandler(this.endreBruker_Click_1);
            // 
            // regBruker
            // 
            this.regBruker.Location = new System.Drawing.Point(17, 23);
            this.regBruker.Name = "regBruker";
            this.regBruker.Size = new System.Drawing.Size(187, 70);
            this.regBruker.TabIndex = 6;
            this.regBruker.Text = "Registrer bruker";
            this.regBruker.UseVisualStyleBackColor = true;
            this.regBruker.Click += new System.EventHandler(this.regBruker_Click_1);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endreResultater);
            this.Controls.Add(this.seResultater);
            this.Controls.Add(this.endreSpm);
            this.Controls.Add(this.leggTilSpm);
            this.Controls.Add(this.endreBruker);
            this.Controls.Add(this.regBruker);
            this.Name = "menu";
            this.Size = new System.Drawing.Size(383, 559);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button endreResultater;
        private System.Windows.Forms.Button seResultater;
        private System.Windows.Forms.Button endreSpm;
        private System.Windows.Forms.Button leggTilSpm;
        private System.Windows.Forms.Button endreBruker;
        private System.Windows.Forms.Button regBruker;
    }
}
