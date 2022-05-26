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
    public partial class OnayBasvuru : Form
    {
        public int sayi;
        

        Random rastgele = new Random();

        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        public SqlConnection con = new SqlConnection(SqlCon);
        public SqlCommand cmd;
        public SqlDataAdapter da = new SqlDataAdapter();
      
        public void uyeekle()
        {

            {
                con.Open();
                
                basadon:
                sayi = rastgele.Next(100000, 999999);
                string sorgu2 = "Select essizid from tablo_calisan where essizid =@essizid ";
                SqlCommand komut = new SqlCommand(sorgu2, con);
                komut.Parameters.AddWithValue("@essizid", sayi.ToString());
                komut.ExecuteNonQuery();
                da.SelectCommand = komut;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    string sorgu = "INSERT INTO tablo_calisan(UyePosta,essizid,sifre,admin,UyeTcNo,UyeAd,UyePozisyon,UyeTelNo,UyeCinsiyet,UyeDogumTarihi) VALUES (@UyePosta,@essizid,@sifre,@admin,@UyeTcNo,@UyeAd,@UyePozisyon,@UyeTelNo,@UyeCinsiyet,@UyeDogumTarihi)";
                    komut = new SqlCommand(sorgu, con);
                    komut.Parameters.AddWithValue("@sifre", "0000");
                    komut.Parameters.AddWithValue("@admin", false);
                    komut.Parameters.AddWithValue("@UyeTcNo", lbl_tc.Text);
                    komut.Parameters.AddWithValue("@UyeAd", lbl_ad.Text);
                    komut.Parameters.AddWithValue("@UyePozisyon", lbl_talepEdilenPoz.Text);
                    komut.Parameters.AddWithValue("@UyeTelNo", lbl_tel.Text);
                    komut.Parameters.AddWithValue("@UyeCinsiyet", lbl_cinsiyet.Text);
                    komut.Parameters.AddWithValue("@UyeDogumTarihi", lbl_dogum.Text);
                    komut.Parameters.AddWithValue("@essizid", sayi);
                    komut.Parameters.AddWithValue("@UyePosta", lbl_posta.Text);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Başvuru Onaylandı!\nessizid :" + sayi + "şifre :0000");

                }
                else
                    goto basadon;

                con.Close();
            }

        }
        public OnayBasvuru()
        {
            InitializeComponent();
        }

        private void OnayBasvuru_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            con = new SqlConnection(SqlCon);
            con.Open();
            cmd = new SqlCommand("select *from tablo_basvuru", con);
            SqlDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                if (drr["basvuruno"] != comboBox_kisi.Items)

                { comboBox_kisi.Items.Add(drr["basvuruno"]); }
                else { }
            }
            con.Close();

        }

        private void comboBox_kisi_SelectedIndexChanged(object sender, EventArgs e)
        {

            int k;

            k = Convert.ToInt32(comboBox_kisi.SelectedItem);
            con.Open();
            cmd = new SqlCommand("select *from tablo_basvuru where basvuruno='" + k + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {



                lbl_ad.Text = dr["Ad"].ToString();
                lbl_tel.Text = dr["telnumarasi"].ToString();
                lbl_posta.Text = dr["EPosta"].ToString();
                lbl_adres.Text = dr["Adres"].ToString();
                lbl_tc.Text = dr["TcKimlikNo"].ToString();
                lbl_cinsiyet.Text = dr["Cinsiyet"].ToString();
                lbl_kan.Text = dr["KanGrubu"].ToString();
                lbl_dogum.Text = dr["DogumTarihi"].ToString();
                lbl_okul.Text = dr["Okul"].ToString();
                lbl_bolum.Text = dr["Bolum"].ToString();
                lbl_meztarih.Text = dr["yil"].ToString();
                lbl_dil.Text = dr["YabanciDil"].ToString();
                lbl_firmaadi.Text = dr["FirmaAdi"].ToString();
                lbl_pozisyon.Text = dr["Pozisyon"].ToString();
                lbl_calismasaati.Text = dr["CalismaSuresi"].ToString();
                lbl_maas.Text = dr["AylikGelir"].ToString();
                lbl_reffirmaadi.Text = dr["RefFirmaAdi"].ToString();
                lbl_refpozisyon.Text = dr["RefPozisyon"].ToString();
                lbl_refadi.Text = dr["RefAd"].ToString();
                lbl_refiletisimno.Text = dr["RefTelNo"].ToString();
                lbl_basvuruno.Text = dr["basvuruno"].ToString();
                lbl_talepEdilenPoz.Text = dr["TalepEdilenPozisyon"].ToString();
                lbl_basvurudurumm.Text = dr["OnayDurumu"].ToString();




            }

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string onay = "Başvuru Reddedildi!";
            string sorgu = "update tablo_basvuru set OnayDurumu='" + onay + "' where TcKimlikNo='" + lbl_tc.Text.Trim() + "'";
            con.Open();
            SqlCommand nk = new SqlCommand(sorgu, con);
            nk.ExecuteNonQuery();
            con.Close();
            lbl_basvurudurumm.Text = "Başvuru Reddedildi!";
            MessageBox.Show("Başvuru Reddedildi!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeekle();
            con.Open();
            string onay1 = "Başvuru Onaylandı!";
            string sorgu2 = "update tablo_basvuru set OnayDurumu='" + onay1 + "' where TcKimlikNo='" + lbl_tc.Text.Trim() + "'";
            SqlCommand cmdd = new SqlCommand(sorgu2, con);
            lbl_basvurudurumm.Text = "Başvuru Onaylandi!";
            cmdd.ExecuteNonQuery();
            con.Close();

        }

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM tablo_basvuru where basvuruno='" + comboBox_kisi.SelectedItem + "'";
            con.Open();
            cmd = new SqlCommand(sorgu, con);
            cmd.ExecuteNonQuery();
            con.Close();
            comboBox_kisi.Items.Remove(comboBox_kisi.SelectedItem);


            lbl_ad.Text = "";
            lbl_tel.Text = "";
            lbl_posta.Text = "";
            lbl_adres.Text = "";
            lbl_tc.Text = "";
            lbl_cinsiyet.Text = "";
            lbl_kan.Text = "";
            lbl_dogum.Text = "";
            lbl_okul.Text = "";
            lbl_bolum.Text = "";
            lbl_meztarih.Text = "";
            lbl_dil.Text = "";
            lbl_firmaadi.Text = "";
            lbl_pozisyon.Text = "";
            lbl_calismasaati.Text = "";
            lbl_maas.Text = "";
            lbl_reffirmaadi.Text = "";
            lbl_refpozisyon.Text = "";
            lbl_refadi.Text = "";
            lbl_refiletisimno.Text = "";
            lbl_basvuruno.Text = "";
            lbl_talepEdilenPoz.Text = "";
            lbl_basvurudurumm.Text = "";
            MessageBox.Show("Seçili Başvuru Silindi!");

        }
    }
}
