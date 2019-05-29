using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin
{
    public partial class frmLogin : Form
    {
#pragma warning restore CS0169 // The field 'frmLogin.cb' is never used

        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding uTF8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(uTF8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string passStr = Encrypt(passordTxt.Text);
            string myconnectionstring = "Database=drivingschool;Data Source=localhost;User=root;Password=";
            MySqlConnection dbconn = new MySqlConnection(myconnectionstring);
            dbconn.Open();
            string query = "select * from users where brukernavn='" + brukernavnTxt.Text.Trim() + "' AND passord='" + passStr + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, myconnectionstring);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                frmMain objFrmMain = new frmMain();
                this.Hide();
                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("Brukernavn eller passord stemmer ikke!");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
