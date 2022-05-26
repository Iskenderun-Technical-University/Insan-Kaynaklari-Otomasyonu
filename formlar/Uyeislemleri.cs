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
    public partial class Uyeislemleri : Form
    {
        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(SqlCon);
        SqlCommand komut;
        SqlDataAdapter da;

        DataTable MusteriGetir()
        {
            baglanti.Open();
            da = new SqlDataAdapter("Select *From tablo_calisan", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
            return tablo;
        }

      

        public Uyeislemleri()
        {
            InitializeComponent();
        }


        private void Uyeislemleri_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.DataSource = MusteriGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string  UyeNo,essiid, sifre, Admin, UyeTcNo, UyeAd, UyePozisyon, UyeTelNo, UyePosta, UyeCinsiyet, UyeDogumTarihi;
            UyeNo = dataGridView1.CurrentRow.Cells["UyeNo"].Value.ToString().Trim();
            essiid = dataGridView1.CurrentRow.Cells["essizid"].Value.ToString().Trim() ;
            sifre = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString().Trim();
            Admin = dataGridView1.CurrentRow.Cells["Admin"].Value.ToString();
            UyeTcNo = dataGridView1.CurrentRow.Cells["UyeTcNo"].Value.ToString().Trim();
            UyeAd = dataGridView1.CurrentRow.Cells["UyeAd"].Value.ToString().Trim();
            UyePozisyon = dataGridView1.CurrentRow.Cells["UyePozisyon"].Value.ToString().Trim();
            UyeTelNo = dataGridView1.CurrentRow.Cells["UyeTelNo"].Value.ToString().Trim();
            UyePosta = dataGridView1.CurrentRow.Cells["UyePosta"].Value.ToString().Trim();
            UyeCinsiyet = dataGridView1.CurrentRow.Cells["UyeCinsiyet"].Value.ToString().Trim();
            UyeDogumTarihi = dataGridView1.CurrentRow.Cells["UyeDogumTarihi"].Value.ToString().Trim();
            baglanti.Open();
            komut = new SqlCommand("update tablo_calisan set sifre='" + sifre + "',Admin='" + Admin + "',UyeTcNo='" + UyeTcNo + "', UyeAd='"+UyeAd+ "',UyePozisyon='"+UyePozisyon+ "',UyeTelNo='"+UyeTelNo+ "',UyePosta='"+UyePosta+ "',UyeCinsiyet='"+UyeCinsiyet+ "',UyeDogumTarihi='"+UyeDogumTarihi+"' where UyeNo='"+UyeNo+"' ",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataGridView1.DataSource = MusteriGetir();
            MessageBox.Show("İşlem Başarıyla Gerçekleştirildi!\nYeni Veriler Kaydedildi!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string UyeNo;
            UyeNo = dataGridView1.CurrentRow.Cells["UyeNo"].Value.ToString().Trim();

            string sorgu = "DELETE FROM tablo_calisan where UyeNo='" + UyeNo + "'";
            komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
           
            MessageBox.Show("Silme işlemi başarılı!");
            MusteriGetir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            baglanti.Open();

            da = new SqlDataAdapter("Select *From tablo_calisan where UyeAd like '%" + textBox1.Text + "%'", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MusteriGetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string sorgu = "Select * FROM tablo_calisan ORDER BY UyeAd ASC";
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * FROM tablo_calisan ORDER BY UyeAd DESC";
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
