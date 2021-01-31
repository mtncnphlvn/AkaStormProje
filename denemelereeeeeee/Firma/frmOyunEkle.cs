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

namespace AkaStormProje
{
    public partial class frmOyunEkle : Form
    {
       

        public frmOyunEkle()
        {
            InitializeComponent();
        }      
        private void btnEkle_MouseHover(object sender, EventArgs e)
        {
            btnEkle.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            btnEkle.BackgroundImage = Properties.Resources.BtnLeave;
        }
        public void LabelTemizle()
        {
            lblAdUyari.Text = "";
            lblKonuUyari.Text = "";
            lblKatUyari.Text = "";
            lblFiyatUyari.Text = "";
            lblResimUyari.Text = "";
            lblYil.Text = DateTime.Now.Year.ToString();
            lblFiyat.Text = "";
            lblSozlesmeUari.Text = "";

        }
        public void TextTemizle()
        {
            txtOyunAdi.Text = "";
            txtKonu.Text = "";
            cmbKategori.SelectedIndex = 0;
            txtFiyat.Text = "";
            txtResimYolu.Text = "";
            pictureBox1.ImageLocation = null;
            rtxtOyunAdi.Text = " Oyun Adı";
            rtxtKonu.Text = "Konusu";
            lblKategori.Text = "Seçiniz.";

        }
        private void GelistiriciBilgi()
        {
            VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
            //lblTarih.Text = DateTime.Now.ToShortDateString();
            try
            {
                string sorgu = "select firma_ad from firma where firma_id='"+Firma.firmaID+"'";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

                MySqlDataReader reader;
                reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    lblGelistirici.Text = reader["firma_ad"].ToString();

                }
                veritabaniYonetici.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var : ", ex.Message);
            }

        }
        //------------------------------Olaylar--------------------------------
        Kontrol kontrol = new Kontrol();
        private void txtOyunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.OyunOzel(e);          
        }
        private void txtOyunAdi_TextChanged(object sender, EventArgs e)
        {
            rtxtOyunAdi.Text = txtOyunAdi.Text;
        }
        private void txtKonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.OyunOzel(e);
        }
        private void txtKonu_TextChanged(object sender, EventArgs e)
        {
            rtxtKonu.Text = txtKonu.Text;
        }
        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.SayiGir(e);
        }
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKategori.Text = cmbKategori.SelectedItem.ToString();
        }
        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            lblFiyat.Text = txtFiyat.Text + " TL";
        }
        private void txtResimYolu_TextChanged(object sender, EventArgs e)
        {
            pbOyunResim.ImageLocation = txtResimYolu.Text;
        }

        //--------------------------load-----------------------------------
        OyunYonetici oyunYonetici = new OyunYonetici();
        private void frmOyunEkle_Load(object sender, EventArgs e)
        {
            pbOyunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            GelistiriciBilgi();         
            LabelTemizle();
            oyunYonetici.KategoriDoldur(cmbKategori);
            TextTemizle();

        }
        //---------------------------btnResimSec-------------------------------------
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog resim = new OpenFileDialog();
            resim.Filter = "Resim Dosyası |*.jpg;*.nef;*.png;* |  Tüm Dosyalar |*.*";
            resim.ShowDialog();
            txtResimYolu.Text = resim.FileName;
            pictureBox1.ImageLocation = resim.FileName.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            LabelTemizle();
            if (string.IsNullOrEmpty(txtOyunAdi.Text))
            {
                lblAdUyari.Text = "!";
            }
            else if (string.IsNullOrEmpty(txtKonu.Text))
            {
                lblKonuUyari.Text = "!";
            }
            else if (cmbKategori.SelectedIndex == 0)
            {
                lblKatUyari.Text = "!";
            }
            else if (string.IsNullOrEmpty(txtFiyat.Text))
            {
                lblFiyatUyari.Text = "!";
            }
            else if (string.IsNullOrEmpty(txtResimYolu.Text))
            {
                lblResimUyari.Text = "!";
            }
            else if (chxOnay.Checked == false)
            {
                lblSozlesmeUari.Text = "!";
            }
            else
            {
                Oyun oyun = new Oyun();
                oyun.getOyunAdi = txtOyunAdi.Text;
                oyun.getOyunKonusu = txtKonu.Text;
                oyun.getOyunKategori = oyunYonetici.KategoriSec(cmbKategori);
                oyun.getOyunFiyat = Convert.ToInt32(txtFiyat.Text);
                oyun.getOyunResim = txtResimYolu.Text;

                oyunYonetici.OyunEkle(oyun);
                TextTemizle();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
