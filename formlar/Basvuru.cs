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
    public partial class Basvuru : Form
    {
        public static string SqlCon = @"Data Source=DESKTOP-E6GDS73\SQLEXPRESS02;Initial Catalog=okanalpturk;Integrated Security=True";
        public SqlConnection con = new SqlConnection(SqlCon);
        public SqlCommand cmd;

        public Basvuru()
        {
            InitializeComponent();

        }
        public void ekle()
        {
            
            {
                con.Open();

                string sorgu = "INSERT INTO tablo_basvuru(BasvuruTarihi,OnayDurumu,TalepEdilenPozisyon,Ad,telnumarasi,Adres,EPosta,TcKimlikNo,Cinsiyet,DogumTarihi,KanGrubu,Okul,Bolum,Yil,YabanciDil,FirmaAdi,Pozisyon,CalismaSuresi,AylikGelir,RefFirmaAdi,RefPozisyon,RefAd,RefTelNo) VALUES (@BasvuruTarihi,@OnayDurumu,@TalepEdilenPozisyon,@Ad,@telnumarasi,@Adres,@EPosta,@TcKimlikNo,@Cinsiyet,@DogumTarihi,@KanGrubu,@Okul,@Bolum,@Yil,@YabanciDil,@FirmaAdi,@Pozisyon,@CalismaSuresi,@AylikGelir,@RefFirmaAdi,@RefPozisyon,@RefAd,@RefTelNo)"; 
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@TalepEdilenPozisyon", txt_taleppoz.Text);
                cmd.Parameters.AddWithValue("@Ad",txt_ad.Text);
                cmd.Parameters.AddWithValue("@telnumarasi",txt_telno.Text);
                cmd.Parameters.AddWithValue("@Adres", richtxt_adres.Text);
                cmd.Parameters.AddWithValue("@EPosta", txt_eposta.Text);
                cmd.Parameters.AddWithValue("@TcKimlikNo", txt_tc.Text);
                cmd.Parameters.AddWithValue("@Cinsiyet", comboBox_cinsiyet.SelectedItem);
                cmd.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@KanGrubu", comboBox_Kan.SelectedItem);
                cmd.Parameters.AddWithValue("@Okul", txt_okuladi.Text);
                cmd.Parameters.AddWithValue("@Bolum", txt_bolum.Text);
                cmd.Parameters.AddWithValue("@Yil", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@YabanciDil", txt_dil.Text);
                cmd.Parameters.AddWithValue("@FirmaAdi", txt_firmaadi.Text);
                cmd.Parameters.AddWithValue("@Pozisyon", txt_pozisyon.Text);
                cmd.Parameters.AddWithValue("@CalismaSuresi", txt_sure.Text);
                cmd.Parameters.AddWithValue("@AylikGelir", txt_maas.Text);
                cmd.Parameters.AddWithValue("@RefFirmaAdi",txt_reffirmaadi.Text);
                cmd.Parameters.AddWithValue("@RefPozisyon", txt_refpozisyon.Text);
                cmd.Parameters.AddWithValue("@RefAd", txt_refadi.Text);
                cmd.Parameters.AddWithValue("@RefTelNo", txt_iletisimno.Text);
                cmd.Parameters.AddWithValue("@OnayDurumu", "Onay Bekliyor");
                cmd.Parameters.AddWithValue("@BasvuruTarihi", DateTime.Now);
                cmd.ExecuteNonQuery();


                con.Close();

                MessageBox.Show("Başvurunuz başarıyla gerçekleştirildi.");
               
            }
           
        }
        
 

        private void Basvuru_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            comboBox_Kan.SelectedIndex = 0;
            comboBox_cinsiyet.SelectedIndex = 0;
            
        }

        private void txt_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_telno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_sure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_maas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_iletisimno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Kan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_iletisimno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_refpozisyon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_refadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_reffirmaadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_maas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sure_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pozisyon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_firmaadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_dil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bolum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_okuladi_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_cinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_tc_TextChanged(object sender, EventArgs e)
        {

        }

        private void richtxt_adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_eposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool k = true;

            if (txt_ad.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_ad, "Bu Alan Boş Geçilemez.");
                k = false;
            }
            else { errorProvider1.Clear(); }
            if (txt_telno.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_telno, "Bu Alan Boş Geçilemez.");
                k = false;
            }
            else { errorProvider1.Clear(); }
            if (txt_eposta.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_eposta, "Bu Alan Boş Geçilemez.");
                k = false;
            }
            else { errorProvider1.Clear(); }
            if (richtxt_adres.Text.Trim() == "")
            {
                errorProvider1.SetError(richtxt_adres, "Bu Alan Boş Geçilemez.");
                k = false;
            }
            else { errorProvider1.Clear(); }
            if (txt_tc.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_tc, "Bu Alan Boş Geçilemez.");
                k = false;
            }
            else { errorProvider1.Clear(); }

            if (txt_okuladi.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_okuladi, "Bu Alan Boş Geçilemez.");
                k = false;
            }
            else { errorProvider1.Clear(); }

            if (txt_bolum.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_bolum, "Bu Alan Boş Geçilemez.");
                k = false;
            }

            else { errorProvider1.Clear(); }

            if (txt_taleppoz.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_taleppoz, "Bu Alan Boş Geçilemez.");
                k = false;
            }
            else { errorProvider1.Clear(); }
            if (k)
            {
                ekle();

            }
        }
    }
}
