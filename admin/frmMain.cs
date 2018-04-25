using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void regBruker_Click_1(object sender, EventArgs e)
        {
            regBruker regBrukerForm = new regBruker();
            regBrukerForm.TopLevel = false;
            regBrukerForm.AutoScroll = true;
            panel1.Controls.Add(regBrukerForm);
            regBrukerForm.FormBorderStyle = FormBorderStyle.None;
            regBrukerForm.Show();
        }

        private void seResultater_Click_1(object sender, EventArgs e)
        {
            seResultater seResultaterForm = new seResultater();
            seResultaterForm.TopLevel = false;
            seResultaterForm.AutoScroll = true;
            panel1.Controls.Add(seResultaterForm);
            seResultaterForm.FormBorderStyle = FormBorderStyle.None;
            seResultaterForm.Dock = DockStyle.Fill;
            seResultaterForm.Show();
        }

        private void leggTilSpm_Click_1(object sender, EventArgs e)
        {
            leggTilSpm leggTilSpmForm = new leggTilSpm();
            leggTilSpmForm.TopLevel = false;
            leggTilSpmForm.AutoScroll = true;
            panel1.Controls.Add(leggTilSpmForm);
            leggTilSpmForm.FormBorderStyle = FormBorderStyle.None;
            leggTilSpmForm.Dock = DockStyle.Fill;
            leggTilSpmForm.Show();
        }

        private void endreBruker_Click_1(object sender, EventArgs e)
        {
            endreBruker endreBrukerForm = new endreBruker();
            endreBrukerForm.TopLevel = false;
            endreBrukerForm.AutoScroll = true;
            panel1.Controls.Add(endreBrukerForm);
            endreBrukerForm.FormBorderStyle = FormBorderStyle.None;
            endreBrukerForm.Dock = DockStyle.Fill;
            endreBrukerForm.Show();
        }

        private void endreResultater_Click_1(object sender, EventArgs e)
        {
            endreResultater endreResultaterForm = new endreResultater();
            endreResultaterForm.TopLevel = false;
            endreResultaterForm.AutoScroll = true;
            panel1.Controls.Add(endreResultaterForm);
            endreResultaterForm.FormBorderStyle = FormBorderStyle.None;
            endreResultaterForm.Dock = DockStyle.Fill;
            endreResultaterForm.Show();
        }

        private void endreSpm_Click_1(object sender, EventArgs e)
        {
            endreSpm endreSpmForm = new endreSpm();
            endreSpmForm.TopLevel = false;
            endreSpmForm.AutoScroll = true;
            panel1.Controls.Add(endreSpmForm);
            endreSpmForm.FormBorderStyle = FormBorderStyle.None;
            endreSpmForm.Dock = DockStyle.Fill;
            endreSpmForm.Show();
        }

        private void menu1_Load(object sender, EventArgs e)
        {

        }

        

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
