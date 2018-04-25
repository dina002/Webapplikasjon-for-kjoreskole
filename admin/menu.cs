using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin
{
    public partial class menu : UserControl
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void endreSpm_Click(object sender, EventArgs e)
        {
            endreSpm objendreSpm = new endreSpm();
            
            objendreSpm.Show();
        }

        private void regBruker_Click_1(object sender, EventArgs e)
        {
           


            //regBruker objregBruker = new regBruker();
            //this.Hide();
            //objregBruker.Show();
        }

        private void endreBruker_Click_1(object sender, EventArgs e)
        {
            endreBruker objendreBruker = new endreBruker();

            objendreBruker.Show();
        }

        private void seResultater_Click_1(object sender, EventArgs e)
        {
            seResultater objseResultater = new seResultater();
            
            objseResultater.Show();
        }

        private void endreResultater_Click_1(object sender, EventArgs e)
        {
            endreResultater objendreResultater = new endreResultater();

            objendreResultater.Show();
        }

        private void leggTilSpm_Click_1(object sender, EventArgs e)
        {
            leggTilSpm objleggTilSpm = new leggTilSpm();
            
            objleggTilSpm.Show();
        }
    }
}
