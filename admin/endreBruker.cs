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
    public partial class endreBruker : Form
    {
        public static MySqlConnection dbconn = new MySqlConnection("Database=drivingschool;Data Source=localhost;User=root;Password=");
        

        public endreBruker()
        {
            InitializeComponent();
        }

        private void endreBruker_Load(object sender, EventArgs e)
        {
            cc();
            findTeachers();
        }

        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbconn.Open();
            MySqlCommand cmd = dbconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where user_id='" + dropdown.SelectedItem.ToString() + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dropdownRights.Items.Add("Teacher");
            dropdownRights.Items.Add("Student");
            String lerer = null;

            foreach (DataRow dr in dt.Rows)
            {

                userIdLbl.Text = dr["user_id"].ToString();
                brukernavnTxt.Text = dr["brukernavn"].ToString();
                emailTxt.Text = dr["email"].ToString();
                fornavnTxt.Text = dr["fornavn"].ToString();
                etternavnTxt.Text = dr["etternavn"].ToString();
                lerer = dr["teacher"].ToString();





                if (dr["rights"].ToString() == "0")
                {
                    dropdownRights.SelectedItem = "Student";
                }
                else
                {
                    dropdownRights.SelectedItem = "Teacher";
                }

            }
            dbconn.Close();

            dbconn.Open();
            MySqlCommand cmd2 = dbconn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
           cmd2.CommandText = "select * from users where user_id='" + lerer + "' ";
           
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            
            dropdownTeacher.SelectedItem = " ";
            foreach (DataRow dr2 in dt2.Rows)
            {

                dropdownTeacher.SelectedItem = dr2["user_id"].ToString()+" "+dr2["fornavn"].ToString() + " " + dr2["etternavn"].ToString();
                
            }


            dbconn.Close();
        }

        
                  

        public void cc()
        {
            dropdown.Items.Clear();
            dropdownRights.Items.Clear();
            dbconn.Open();
            MySqlCommand cmd = dbconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            usersLbl.Text= "";
            dropdownTeacher.ResetText();

            foreach (DataRow dr in dt.Rows)
            {

                dropdown.Items.Add(String.Format("{0} {1} {2}", dr["user_id"], dr["fornavn"], dr["etternavn"]));
                usersLbl.Text += (String.Format("{0} {1} {2}", dr["user_id"], dr["fornavn"], dr["etternavn"])) + "\n";
            }
            
            dbconn.Close();
        }
        public void findTeachers()
        {
            
            dropdownRights.Items.Clear();
            dbconn.Open();
            MySqlCommand cmd = dbconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users WHERE rights='1'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dropdownTeacher.Items.Add(" ");


            foreach (DataRow dr in dt.Rows)
            {

                dropdownTeacher.Items.Add(String.Format("{0} {1} {2}",dr["user_id"], dr["fornavn"], dr["etternavn"]));
                
            }
            dbconn.Close();
        }

        private void slettBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.Open();
                MySqlCommand cmd = dbconn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from users WHERE user_id='" + userIdLbl.Text + "'";
                cmd.ExecuteNonQuery();
                dbconn.Close();

                userIdLbl.Text = "";
                brukernavnTxt.Text = "";
                emailTxt.Text = "";
                passordTxt.Text = "";
                fornavnTxt.Text = "";
                etternavnTxt.Text = "";

                cc();

                MessageBox.Show("Bruker er slettet");
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Brukeren kan ikke bli slettet, slett data brukeren har registrert fra før av");
                }
                else
                {
                    MessageBox.Show("Error : " + ex.Message + ex.Number);
                }
            }
        }

        private void endreBtn_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            MySqlCommand cmd = dbconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if(dropdownRights.SelectedItem.ToString() == "Student")
            {
                cmd.CommandText = "update users set brukernavn='" + brukernavnTxt.Text + "', email='" + emailTxt.Text + "', fornavn='" + fornavnTxt.Text + "', etternavn='" + etternavnTxt.Text + "', rights='0' WHERE user_id='" + userIdLbl.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd.CommandText = "update users set brukernavn='" + brukernavnTxt.Text + "', email='" + emailTxt.Text + "', fornavn='" + fornavnTxt.Text + "', etternavn='" + etternavnTxt.Text + "', rights='1' WHERE user_id='" + userIdLbl.Text + "'";
                cmd.ExecuteNonQuery();
            }
            
            dbconn.Close();

            userIdLbl.Text = "";
            brukernavnTxt.Text = "";
            emailTxt.Text = "";
            passordTxt.Text = "";
            fornavnTxt.Text = "";
            etternavnTxt.Text = "";

            cc();

            MessageBox.Show("Bruker er oppdatert");
        }
    }
}
