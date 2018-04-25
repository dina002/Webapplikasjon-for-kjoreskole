namespace admin
{
    partial class seResultater
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
            this.dropdownBruker = new System.Windows.Forms.ComboBox();
            this.brukerTxt = new System.Windows.Forms.Label();
            this.resultsTxt = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropdownBruker
            // 
            this.dropdownBruker.FormattingEnabled = true;
            this.dropdownBruker.Location = new System.Drawing.Point(12, 62);
            this.dropdownBruker.Name = "dropdownBruker";
            this.dropdownBruker.Size = new System.Drawing.Size(372, 21);
            this.dropdownBruker.TabIndex = 1;
            this.dropdownBruker.SelectedIndexChanged += new System.EventHandler(this.dropdownBruker_SelectedIndexChanged);
            // 
            // brukerTxt
            // 
            this.brukerTxt.AutoSize = true;
            this.brukerTxt.Location = new System.Drawing.Point(12, 43);
            this.brukerTxt.Name = "brukerTxt";
            this.brukerTxt.Size = new System.Drawing.Size(63, 13);
            this.brukerTxt.TabIndex = 2;
            this.brukerTxt.Text = "Hent bruker";
            // 
            // resultsTxt
            // 
            this.resultsTxt.AutoSize = true;
            this.resultsTxt.Location = new System.Drawing.Point(27, 134);
            this.resultsTxt.Name = "resultsTxt";
            this.resultsTxt.Size = new System.Drawing.Size(0, 13);
            this.resultsTxt.TabIndex = 3;
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.Location = new System.Drawing.Point(27, 104);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(0, 13);
            this.over.TabIndex = 4;
            // 
            // seResultater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 756);
            this.Controls.Add(this.over);
            this.Controls.Add(this.resultsTxt);
            this.Controls.Add(this.brukerTxt);
            this.Controls.Add(this.dropdownBruker);
            this.Name = "seResultater";
            this.Text = "seResultater";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.seResultater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox dropdownBruker;
        private System.Windows.Forms.Label brukerTxt;
        private System.Windows.Forms.Label resultsTxt;
        private System.Windows.Forms.Label over;
    }
}