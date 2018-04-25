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
    public partial class seResultater : Form
    {

        public static MySqlConnection dbconn = new MySqlConnection("Database=drivingschool;Data Source=localhost;User=root;Password=Dina002");

        public seResultater()
        {
            InitializeComponent();
        }

        private void dropdownBruker_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbconn.Open();
            MySqlCommand cmd = dbconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from results where user_id='" + dropdownBruker.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            resultsTxt.Text = " ";
            over.Text = " ";
            if(dt.Rows.Count >= 1)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    over.Text = "resultat | riktige svar | feil svar | prosent | dato |";
                    resultsTxt.Text += dr["result"].ToString() + "     ";
                    resultsTxt.Text += dr["correct_ans"].ToString() + "   ";
                    resultsTxt.Text += dr["wrong_ans"].ToString() + "      ";
                    resultsTxt.Text += dr["prosent"].ToString() + "      ";
                    resultsTxt.Text += dr["date"].ToString() + "\n\n";
                }
            } else
            {
                resultsTxt.Text = " er ikke noen resuøtater ";
            }
            dbconn.Close();
        }

        private void seResultater_Load(object sender, EventArgs e)
        {
            cc();
        }
        public void cc()
        {
            dropdownBruker.Items.Clear();
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

                dropdownBruker.Items.Add(String.Format("{0} {1} {2}", dr["user_id"], dr["fornavn"], dr["etternavn"]));
                
            }
            dbconn.Close();
        }
    }
}
