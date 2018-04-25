using MySql.Data.MySqlClient;
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
    public partial class leggTilSpm : Form
    {
        MySqlConnection dbconn;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds;
        MySqlCommandBuilder cb;
        string myconnectionstring = "Database=drivingschool;Data Source=localhost;User=root;Password=Dina002";
        public leggTilSpm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void leggTilSpm_Load(object sender, EventArgs e)
        {
            dbconn = new MySqlConnection(myconnectionstring);
        }

        private void leggTilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.Open();
                MySqlCommand cmd = dbconn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into questions(question, A1, A2, A3, A4, correct, imageurl) values('" + questionTxt.Text + "','" + A1.Text + "','" + A2.Text + "','" + A3.Text + "','" + A4.Text + "','" + correctTxt.Text + "','" + imageTxt.Text + "')";
                cmd.ExecuteNonQuery();
                dbconn.Close();
                MessageBox.Show("Nytt spm er lagt til");
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("spørsmål eksisterer fra før av");
                }
                else
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }
    }
}
