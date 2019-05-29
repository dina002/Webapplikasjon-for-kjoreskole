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
    public partial class endreSpm : Form
    {
        
        public static MySqlConnection dbconn = new MySqlConnection("Database=drivingschool;Data Source=localhost;User=root;Password=");
        

        public endreSpm()
        {
            InitializeComponent();
        }

        private void endreSpm_Load(object sender, EventArgs e)
        {

            cc();
            
        }

        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbconn.Open();
            MySqlCommand cmd = dbconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from questions where id='" + dropdown.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                questionTxt.Text = dr["question"].ToString();
                questionID.Text = dr["id"].ToString();
                A1.Text = dr["A1"].ToString();
                A2.Text = dr["A2"].ToString();
                A3.Text = dr["A3"].ToString();
                A4.Text = dr["A4"].ToString();
                correctTxt.Text = dr["correct"].ToString();
                imageTxt.Text = dr["imageurl"].ToString();
            }
            dbconn.Close();
        }

        private void endreBtn_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            MySqlCommand cmd = dbconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update questions set question='" + questionTxt.Text + "', A1='"+A1.Text+"', A2='"+A2.Text+"', A3='"+A3.Text+"', A4='"+A4.Text+"', correct='"+correctTxt.Text+"', imageurl='"+imageTxt.Text+"' WHERE id='"+questionID.Text+"'";
            cmd.ExecuteNonQuery();
            dbconn.Close();

            questionTxt.Text = "";
            questionID.Text = "";
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            A4.Text = "";
            correctTxt.Text = "";
            imageTxt.Text = "";

            cc(); 

            MessageBox.Show("Spørsmål er oppdatert");

        }

        private void slettBtn_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            MySqlCommand cmd = dbconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from questions WHERE id='" + questionID.Text + "'";
            cmd.ExecuteNonQuery();
            dbconn.Close();

            questionTxt.Text = "";
            questionID.Text = "";
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            A4.Text = "";
            correctTxt.Text = "";
            imageTxt.Text = "";

            cc();

            MessageBox.Show("Spørsmål er slettet");
        }
        public void cc()
        {
            dropdown.Items.Clear();
            dbconn.Open();
            MySqlCommand cmd = dbconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from questions";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                dropdown.Items.Add(String.Format("{0} {1}", dr["id"], dr["question"]));
                questionsLbl.Text += dr["question"].ToString() + "\n\n";
            }
            dbconn.Close();
        }
        private void imageTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void correctTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void A4_TextChanged(object sender, EventArgs e)
        {

        }

        private void A3_TextChanged(object sender, EventArgs e)
        {

        }

        private void A2_TextChanged(object sender, EventArgs e)
        {

        }

        private void A1_TextChanged(object sender, EventArgs e)
        {

        }

        private void questionTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void questionID_Click(object sender, EventArgs e)
        {

        }
    }
}
