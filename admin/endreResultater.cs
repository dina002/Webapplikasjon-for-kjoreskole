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
    public partial class endreResultater : Form
    {
        public static MySqlConnection dbconn = new MySqlConnection("Database=drivingschool;Data Source=localhost;User=root;Password=");

        public endreResultater()
        {
            InitializeComponent();
        }

        private void Endre_Click(object sender, EventArgs e)
        {

        }

        private void endreResultater_Load(object sender, EventArgs e)
        {
            cc();
        }

        public void cc()
        {
            dropdownStudents.Items.Clear();
            dbconn.Open();
            MySqlCommand cmd = dbconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where rights=0";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                dropdownStudents.Items.Add(String.Format("{0} {1} {2}",dr["user_id"], dr["fornavn"], dr["etternavn"]));
                
            }
            dbconn.Close();
        }

        private void dropdownStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbconn.Open();
            MySqlCommand cmd = dbconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from results where user_id='" + dropdownStudents.SelectedItem.ToString() + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                dropdownResults.Items.Add(String.Format("{0} {1} {2} {3} {4} {5}", dr["test_id"], dr["result"], dr["correct_ans"], dr["wrong_ans"], dr["prosent"], dr["date"]));

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
                cmd.CommandText = "delete from results WHERE test_id='" + dropdownResults.SelectedItem.ToString().Substring(0, 2) + "'";
                cmd.ExecuteNonQuery();
                dbconn.Close();

                cc();
                


                MessageBox.Show("Resultat slettet");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
