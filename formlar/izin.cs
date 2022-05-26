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
    public partial class izin : Form
    {
        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        public SqlConnection con = new SqlConnection(SqlCon);
        public SqlCommand cmd;
        public SqlDataAdapter da = new SqlDataAdapter();

        public izin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu2 = "select *from tablo_calisan where essizid='" + id.eId.ToString().Trim() + "'";
            
            con.Open();
            SqlCommand komut = new SqlCommand(sorgu2,con);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = dr["UyeAd"].ToString().Trim();
            }
            con.Close();
            
            
            
                string sorgu = "INSERT INTO tablo_izin(BasvuruTarihi,basvuranid,IzinBaslangicTarihi,IzinBitisTarihi,IzinTalepEdenKisi,IzinOnayDurumu,Aciklama) VALUES (@BasvuruTarihi,@basvuranid,@IzinBaslangicTarihi,@IzinBitisTarihi,@IzinTalepEdenKisi,@IzinOnayDurumu,@Aciklama) ";
            

            cmd = new SqlCommand(sorgu,con);
            cmd.Parameters.AddWithValue("@basvuranid",id.eId.ToString().Trim());
            cmd.Parameters.AddWithValue("@IzinBaslangicTarihi",dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@IzinBitisTarihi", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@BasvuruTarihi", DateTime.Now);
            cmd.Parameters.AddWithValue("@IzinOnayDurumu", "Onay Bekliyor");
            cmd.Parameters.AddWithValue("@IzinTalepEdenKisi",label4.Text);
            cmd.Parameters.AddWithValue("@Aciklama", richTextBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Talebiniz Alındı!");

        }

        private void izin_Load(object sender, EventArgs e)
        {

        }
    }
}
