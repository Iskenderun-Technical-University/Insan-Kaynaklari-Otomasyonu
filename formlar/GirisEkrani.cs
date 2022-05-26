using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace okanalpturk_IK
{
    
    public partial class GirisEkrani : Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        

        public GirisEkrani()
        {
            InitializeComponent();
        }
        public void logadmin()
        {


            string sorgu = "select*from tablo_calisan where essizid=@essizid and sifre =@sifre and Admin=1";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@essizid", textBox1.Text);
            cmd.Parameters.AddWithValue("@sifre", textBox2.Text);

            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id.eId = textBox1.Text.Trim();
                MessageBox.Show("Veritabanına admin olarak erişim sağlandı");
                admin_arayuz aa = new admin_arayuz();
                aa.ShowDialog();
               

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. \nLütfen giriş bilgilerinizi kontrol ediniz.");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            con.Close();
        }

        public void loguser()
        {
            string sorgu = "select*from tablo_calisan where essizid=@essizid and sifre =@sifre and Admin=0";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@essizid", textBox1.Text);
            cmd.Parameters.AddWithValue("@sifre", textBox2.Text);

            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id.eId = textBox1.Text.Trim();
                MessageBox.Show("Veritabanına standart kullanıcı olarak erişim sağlandı");
                uye_arayuz ua = new uye_arayuz();
                ua.ShowDialog();
                

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. \nLütfen giriş bilgilerinizi kontrol ediniz.");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            if (radio_admin.Checked == true)
            {
                logadmin();
            }
            else if (radio_user.Checked == true)
            {
                loguser();
            }
        }
    }
    public static class id
    {
        public static string eId;
    }
}
