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
    public partial class regBruker : Form
    {
        public static MySqlConnection dbconn = new MySqlConnection("Database=drivingschool;Data Source=localhost;User=root;Password=");

        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection con = new MySqlConnection();

        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding uTF8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(uTF8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        public regBruker()
        {
            InitializeComponent();
            con = new MySqlConnection("Database=drivingschool; Data Source = localhost; User = root; Password = Dina002");
            cmd = new MySqlCommand();
            con.Open();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            frmMain objfrmMain = new frmMain();
            this.Hide();
            objfrmMain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dropdownRights.SelectedItem.ToString() == "Student")
                {
                    string pass = Encrypt(passordTxt.Text);
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users (brukernavn, passord, email, fornavn, etternavn, rights)VALUES(@brukernavn, @passord, @email, @fornavn, @etternavn, 0)", con);
                    cmd.Parameters.AddWithValue("@brukernavn", brukernavnTxt.Text);
                    cmd.Parameters.AddWithValue("@passord", pass);
                    cmd.Parameters.AddWithValue("@email", emailTxt.Text);
                    cmd.Parameters.AddWithValue("@fornavn", fornavnTxt.Text);
                    cmd.Parameters.AddWithValue("@etternavn", etternavnTxt.Text);
                    
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string pass = Encrypt(passordTxt.Text);
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users (brukernavn, passord, email, fornavn, etternavn, rights)VALUES(@brukernavn, @passord, @email, @fornavn, @etternavn, 1)", con);
                    cmd.Parameters.AddWithValue("@brukernavn", brukernavnTxt.Text);
                    cmd.Parameters.AddWithValue("@passord", pass);
                    cmd.Parameters.AddWithValue("@email", emailTxt.Text);
                    cmd.Parameters.AddWithValue("@fornavn", fornavnTxt.Text);
                    cmd.Parameters.AddWithValue("@etternavn", etternavnTxt.Text);
                    
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Ny konto er oprettet");
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Brukernavn eksisterer fra før av");
                }
                else
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        private void regBruker_Load(object sender, EventArgs e)
        {
            findTeachers();
        }

        public void findTeachers()
        {

            dropdownRights.Items.Add("Teacher");
            dropdownRights.Items.Add("Student");
        }
    }
}
