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
    public partial class mesaj : Form
    {
        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public mesaj()
        {
            InitializeComponent();
        }

        private void mesaj_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            con.Open();
            cmd = new SqlCommand("select *from tablo_calisan",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["UyeAd"] != comboBox_kisi.Items)

                { comboBox_kisi.Items.Add(dr["UyeAd"]); }
                else { }
            }
            con.Close();


        }

        private void comboBox_kisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);

            da = new SqlDataAdapter();
            con.Open();
            
            string sorgu2 = "Select essizid from tablo_calisan where UyeAd =@UyeAd ";

            SqlCommand komut = new SqlCommand(sorgu2, con);
            komut.Parameters.AddWithValue("@UyeAd",comboBox_kisi.SelectedItem.ToString());
            
            komut.ExecuteNonQuery();
            da.SelectCommand = komut;
            DataTable dt = new DataTable();
            da.Fill(dt);

            string sorgu3 = "Select UyeAd from tablo_calisan where essizid =@essizid ";

            SqlCommand komut2 = new SqlCommand(sorgu3, con);
            komut2.Parameters.AddWithValue("@essizid", id.eId.ToString().Trim());

            komut2.ExecuteNonQuery();
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = komut2;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            



            string sorgu = "INSERT INTO tablo_mesaj(aliciad,gonderenad,gonderenid,aliciid,konu,ileti,gonderilmetarihi) VALUES (@aliciad,@gonderenad,@gonderenid,@aliciid,@konu,@ileti,@gonderilmetarihi)";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@gonderenid", id.eId.ToString());
            cmd.Parameters.AddWithValue("@aliciid",dt.Rows[0]["essizid"].ToString().Trim());
            cmd.Parameters.AddWithValue("@konu", txt_konu.Text);
            cmd.Parameters.AddWithValue("@ileti", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@gonderilmetarihi", DateTime.Now);
            cmd.Parameters.AddWithValue("@gonderenad",dt2.Rows[0]["UyeAd"]);
            cmd.Parameters.AddWithValue(@"aliciad", comboBox_kisi.SelectedItem.ToString().Trim());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Mesaj başarılı bir şekilde iletildi!");


        }
    }
}
