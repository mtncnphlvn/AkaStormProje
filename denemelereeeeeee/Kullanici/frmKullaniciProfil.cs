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
    public partial class frmKullaniciProfil : Form
    {
        public frmKullaniciAnasayfa frmKullaniciAnasayfa;
        int kulAdKontrol;
        int sifreKontrol;
        int epostaKontrol;
        int telKontorl;
        int resimKontrol;
        int hesapKontrol;


        public frmKullaniciProfil()
        {
            InitializeComponent();
        }
        public void KullaniciBilgi()
        {
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
            try
            {
                MySqlCommand komut = new MySqlCommand("select kullanici.kul_ad, kullanici.kul_soyad, kullanici.kul_kullaniciAdi, kullanici.kul_eposta, kullanici.kul_telefon, kullanici.kul_cinsiyet, kullanici_resim.kul_resim from kullanici inner join kullanici_resim on kullanici_resim.kul_id = kullanici.kul_id where kullanici.kul_id = '"+Kullanici.kullaniciID+"'",veritabaniYonetici.OpenConnection());

                MySqlDataReader reader;
                reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    lblAd.Text = Convert.ToString(reader[0]); ;
                    lblSoyad.Text = Convert.ToString(reader[1]); ;
                    lblKulAd.Text = Convert.ToString(reader[2]);
                    lblEposta.Text = Convert.ToString(reader[3]); ;
                    lblTelefon.Text = Convert.ToString(reader[4]); ;
                    lblCinsiyet.Text = Convert.ToString(reader[5]); ;
                    pbResim.ImageLocation = Convert.ToString(reader[6]);
                }
                veritabaniYonetici.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var : ", ex.Message);
            }

        }

        private void frmKullaniciProfil_Load(object sender, EventArgs e)
        {
            KullaniciBilgi();
            panKul.Visible = false;
            panSifre.Visible = false;
            panTel.Visible = false;
            panEposta.Visible = false;
            panResim.Visible = false;
            panHesap.Visible = false;
        }
        //------------------------------btn olaylar-------------------------------------------
        private void btnKulAdDegis_MouseHover(object sender, EventArgs e)
        {
            btnKulAdDegis.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnKulAdDegis_MouseLeave(object sender, EventArgs e)
        {
            btnKulAdDegis.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnSifreDegis_MouseHover(object sender, EventArgs e)
        {
            btnSifreDegis.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnSifreDegis_MouseLeave(object sender, EventArgs e)
        {
            btnSifreDegis.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnEpostaDegis_MouseHover(object sender, EventArgs e)
        {
            btnEpostaDegis.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnEpostaDegis_MouseLeave(object sender, EventArgs e)
        {
            btnEpostaDegis.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnTelNoDegis_MouseHover(object sender, EventArgs e)
        {
            btnTelNoDegis.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnTelNoDegis_MouseLeave(object sender, EventArgs e)
        {
            btnTelNoDegis.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnResimDegis_MouseHover(object sender, EventArgs e)
        {
            btnResimDegis.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnResimDegis_MouseLeave(object sender, EventArgs e)
        {
            btnResimDegis.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnHesapSil_MouseHover(object sender, EventArgs e)
        {
            btnHesapSil.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnHesapSil_MouseLeave(object sender, EventArgs e)
        {
            btnHesapSil.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnAdGuncelle_MouseHover(object sender, EventArgs e)
        {
            btnAdGuncelle.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnAdGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btnAdGuncelle.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnSifreGuncelle_MouseHover(object sender, EventArgs e)
        {
            btnSifreGuncelle.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnSifreGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btnSifreGuncelle.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnEpostaGuncelle_MouseHover(object sender, EventArgs e)
        {
            btnEpostaGuncelle.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnEpostaGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btnEpostaGuncelle.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnTelefonGuncelle_MouseHover(object sender, EventArgs e)
        {
            btnTelefonGuncelle.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnTelefonGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btnTelefonGuncelle.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnResimGuncelle_MouseHover(object sender, EventArgs e)
        {
            btnResimGuncelle.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnResimGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btnResimGuncelle.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnSil_MouseHover(object sender, EventArgs e)
        {
            btnSil.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            btnSil.BackgroundImage = Properties.Resources.BtnLeave;
        }
        //-----------------------buton clickler----------------------------------
        private void btnKulAdDegis_Click(object sender, EventArgs e)
        {
            if (kulAdKontrol == 1)
            {
                kulAdKontrol = 0;
                panKul.Visible = false;
            }
            else
            {
                kulAdKontrol = 1;
                panKul.Visible = true;
            }
        }

        private void btnSifreDegis_Click(object sender, EventArgs e)
        {
            if (sifreKontrol == 1)
            {
                sifreKontrol = 0;
                panSifre.Visible = false;
            }
            else
            {
                sifreKontrol = 1;
                panSifre.Visible = true;
            }
        }

        private void btnEpostaDegis_Click(object sender, EventArgs e)
        {
            if (epostaKontrol == 1)
            {
                epostaKontrol = 0;
                panEposta.Visible = false;
            }
            else
            {
                epostaKontrol = 1;
                panEposta.Visible = true;
            }
        }
        private void btnTelNoDegis_Click(object sender, EventArgs e)
        {
            if (telKontorl == 1)
            {
                telKontorl = 0;
                panTel.Visible = false;
            }
            else
            {
                telKontorl = 1;
                panTel.Visible = true;
            }
        }
        private void btnResimDegis_Click(object sender, EventArgs e)
        {
            if (resimKontrol == 1)
            {
                resimKontrol = 0;
                panResim.Visible = false;
            }
            else
            {
                resimKontrol = 1;
                panResim.Visible = true;
            }
        }
        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            if (hesapKontrol == 1)
            {
                hesapKontrol = 0;
                panHesap.Visible = false;
            }
            else
            {
                hesapKontrol = 1;
                panHesap.Visible = true;
            }
        }
        //-----------------txt olaylar------------------------------------
        Kontrol kontrol = new Kontrol();
        private void txtKulAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.KullaniciHarf(e);
        }
        private void txtKulAd_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtKulAd, 0, 5, lblBos);
            kontrol.KullaniciAdiKontrol(txtKulAd, lblBos);
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtSifre, 0, 8, lblBos);
        }
        private void txtEposta_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.EpostaHarf(e);
        }
        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.SayiGir(e);

        }
        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtTelefon, 0, 11, lblBos);
            if (txtTelefon.TextLength == 11 && kontrol.TelefonFormatKontrol(txtTelefon.Text) == false)
            {
                lblBos.Text = "Geçersiz Numara";
            }
        }
        //------------------Guncelle clickler-----------------------------------
        KullaniciGuncelleme kullaniciGuncelleme = new KullaniciGuncelleme();
        private void btnAdGuncelle_Click(object sender, EventArgs e)
        {
            if(kontrol.KarakterKontrol(txtKulAd, 0, 5, lblBos) == true && !string.IsNullOrEmpty(txtKulAd.Text))
            {
                kullaniciGuncelleme.KullaniciAdiDegis(txtKulAd);
                frmKullaniciAnasayfa.KullaniciBilgi();
                lblKulAd.Text = txtKulAd.Text;
                txtKulAd.Text = "";
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }
        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            if (kontrol.KarakterKontrol(txtSifre, 0, 8, lblBos) == true && !string.IsNullOrEmpty(txtSifre.Text) && txtSifre.Text == txtSifreTekrar.Text)
            {
                kullaniciGuncelleme.SifreDegis(txtSifre);
                txtSifre.Text = "";
                txtSifreTekrar.Text = "";
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }
        private void btnEpostaGuncelle_Click(object sender, EventArgs e)
        {
            if (kontrol.EpostaKontrol(txtEposta, lblBos) == true && !string.IsNullOrEmpty(txtEposta.Text))
            {
                kullaniciGuncelleme.EpostaDegis(txtEposta);
                lblEposta.Text = txtEposta.Text;
                txtEposta.Text = "";
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }
        private void btnTelefonGuncelle_Click(object sender, EventArgs e)
        {
            if (kontrol.TelefonFormatKontrol(txtTelefon.Text) == true && !string.IsNullOrEmpty(txtTelefon.Text))
            {
                kullaniciGuncelleme.TelefonDegis(txtTelefon);
                lblTelefon.Text = txtTelefon.Text;
                txtTelefon.Text = "";
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void btnResimGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResimYolu.Text))
            {
                kullaniciGuncelleme.ResimDegis(txtResimYolu);
                pbResim.ImageLocation = txtResimYolu.Text;
                frmKullaniciAnasayfa.KullaniciBilgi();
                txtResimYolu.Text = "";
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog resim = new OpenFileDialog();
            resim.Filter = "Resim Dosyası |*.jpg;*.nef;*.png;* |  Tüm Dosyalar |*.*";
            resim.ShowDialog();
            txtResimYolu.Text = resim.FileName;
            pbResim.ImageLocation = resim.FileName.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            kullaniciGuncelleme.HesapSil();
            Application.Exit();
        }
    }
}
