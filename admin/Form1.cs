using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace admin
{
    public partial class Form1 : Form
    {
        MySqlConnection dbconn;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataAdapter da1;
        MySqlDataAdapter da2;
        DataSet ds;
        DataSet ds1;
        DataSet ds2;
        String myconnectionstring; 
        MySqlCommandBuilder cb;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.Update(ds, "sporsmal");
            GridView1.Update();
            GridView1.Refresh();
            label2.Text = "sporsmål er oppdatert!";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myconnectionstring = "Database=drivingschool;Data Source=localhost;User=root;Password=Dina002";
            dbconn = new MySqlConnection(myconnectionstring);
            dbconn.Open();

            String sql = "SELECT * from questions";
            cmd = new MySqlCommand(sql, dbconn);
            da = new MySqlDataAdapter(cmd);
            cb = new MySqlCommandBuilder(da);
            ds = new DataSet("spm");
            da.Fill(ds, "sporsmal");
            GridView1.DataSource = ds;
            GridView1.DataMember = "sporsmal";

            String sql1 = "SELECT * from users where rights=1";
            cmd = new MySqlCommand(sql1, dbconn);
            da1 = new MySqlDataAdapter(cmd);
            ds1 = new DataSet("lerere");
            cb = new MySqlCommandBuilder(da1);
            da1.Fill(ds1, "brukere");
            dataGridView1.DataSource = ds1;
            dataGridView1.DataMember = "brukere";

            String sql2 = "SELECT * from users where rights = 0";
            cmd = new MySqlCommand(sql2, dbconn);
            da2 = new MySqlDataAdapter(cmd);
            ds2 = new DataSet("elever");
            cb = new MySqlCommandBuilder(da2);
            da2.Fill(ds2, "brukeradmin");
            dataGridView2.DataSource = ds2;
            dataGridView2.DataMember = "brukeradmin";
        }

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            Console.WriteLine(e.RowIndex);
            DataGridView dgv = (DataGridView)sender;
            Console.WriteLine(dgv.CurrentCell.Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            Console.WriteLine(e.RowIndex);
            DataGridView dgv = (DataGridView)sender;
            Console.WriteLine(dgv.CurrentCell.Value);
        }

        private void updateUsers_Click(object sender, EventArgs e)
        {
            da1.Update(ds1, "brukere");
            dataGridView1.Update();
            dataGridView1.Refresh();
            label2.Text = "brukere er oppdatert!";

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            Console.WriteLine(e.RowIndex);
            DataGridView dgv = (DataGridView)sender;
            Console.WriteLine(dgv.CurrentCell.Value);

        }

        private void updateAdmin_Click(object sender, EventArgs e)
        {
            da2.Update(ds2, "brukeradmin");
            dataGridView2.Update();
            dataGridView2.Refresh();
            label2.Text = "admin er oppdatert!";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
