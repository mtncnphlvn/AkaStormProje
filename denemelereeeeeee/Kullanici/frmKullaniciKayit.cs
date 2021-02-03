using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AkaStormProje
{
    public partial class frmKullaniciKayit : Form
    {
        public frmKullaniciKayit()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void frmKullaniciKayit_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void frmKullaniciKayit_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void frmKullaniciKayit_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        private void Cinsiyet(ComboBox combobox)
        {
            combobox.Items.Add("Cinsiyet Seçiniz...");
            combobox.Items.Add("Kadın");
            combobox.Items.Add("Erkek");
            combobox.Items.Add("Belirtmek İstemiyorum");
            combobox.SelectedIndex = 0;
        }
        //----------------------------------------------- FormLoad ----------------------------------------------------
        Tarih tarih = new Tarih();
        private void frmKullaniciKayit_Load(object sender, EventArgs e)
        {         
            tarih.Ay(cmbAy);  // Ay Listeler                    
            tarih.Yil(cmbYil); // Yıl Listeler
            Cinsiyet(cmbCinsiyet); // Cinsiyet Listeler
            cmbGun.ForeColor = Color.Silver;
            cmbAy.ForeColor = Color.Silver;
            cmbYil.ForeColor = Color.Silver;
            cmbCinsiyet.ForeColor = Color.Silver;
        }
        //----------------------------------------------- cmbGun_SelectedIndexChanged ---------------------------------
        private void cmbGun_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTarihUyari.Text = "";
            tarih.TarihRenk(cmbGun);

        }
        //----------------------------------------------- cmbAy_SelectedIndexChanged ----------------------------------
        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTarihUyari.Text = "";
            tarih.Gun(cmbGun, cmbAy); // Ay'a göre gün listeler
            tarih.TarihRenk(cmbAy);
        }
        //----------------------------------------------- cmbYıl_SelectedIndexChanged ---------------------------------
        private void cmbYil_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTarihUyari.Text = "";
            tarih.TarihRenk(cmbYil);
        }
        //----------------------------------------------- cmbCinsiyet_SelectedIndexChanged ----------------------------
        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCinsiyet.SelectedIndex != 0)
            {
                lblCinsiyetUyari.Text = "";
            }
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(50, 100, 150);
            cmbCinsiyet.ForeColor = myRgbColor;
        }
        Kontrol kontrol = new Kontrol();
        TextDoldur textDoldur = new TextDoldur();     
        //----------------------------------------------- txtAd -------------------------------------------------------
        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.HarfGir(e);           
        }
        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtAd, 0, 2, lblAdUyari);
        }
        private void txtAd_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtAd,"Ad");
        }
        private void txtAd_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtAd,"Ad");
        }
        //----------------------------------------------- txtSoyad ----------------------------------------------------

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.HarfGir(e);
        }
        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtSoyad, 0, 2, lblSoyadUyari);
        }
        private void txtSoyad_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtSoyad, "Soyad");
        }
        private void txtSoyad_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtSoyad, "Soyad");
        }
        //-------------------------------------------------- txtTelefonNo ---------------------------------------------
        private void txtTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.SayiGir(e);
        }
        private void txtTelefonNo_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtTelefonNo, 0, 11,lblTelefonUyari);
            if(txtTelefonNo.TextLength == 11 && kontrol.TelefonFormatKontrol(txtTelefonNo.Text) == false)
            {
                lblTelefonUyari.Text = "Geçersiz Numara";
            }
        }
        private void txtTelefonNo_Enter(object sender, EventArgs e)
        {

            textDoldur.TextEnter(txtTelefonNo, "Telefon Numarası");
        }
        private void txtTelefonNo_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtTelefonNo, "Telefon Numarası");
        }
        //------------------------------------------------ txtEposta --------------------------------------------------
        private void txtEposta_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.EpostaHarf(e);
        }
        private void txtEposta_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtEposta, "E-Posta");
        }
        private void txtEposta_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtEposta, "E-Posta");
        }
        //----------------------------------------------------- txtKullaniciAdi ---------------------------------------
        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.KullaniciHarf(e);
        }     
        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtKullaniciAdi,"Kullanıcı Adı");
        }
        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtKullaniciAdi, "Kullanıcı Adı");
        }
        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtKullaniciAdi, 0, 5, lblKullaniciAdiUyari);
            kontrol.KullaniciAdiKontrol(txtKullaniciAdi, lblKullaniciAdiUyari);
        }
        //----------------------------------------------------- txtSifre ----------------------------------------------
        private void txtSifre_Enter(object sender, EventArgs e)
        {
            textDoldur.SifreEnter(txtSifre,"Şifre (En az 8 Haneli)");
        }
        private void txtSifre_Leave(object sender, EventArgs e)
        {
            textDoldur.SifreLeave(txtSifre,"Şifre (En az 8 Haneli)");
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtSifre, 0, 8, lblSifreUyari);
        }
        //----------------------------------------------------- txtSifreTekrar ----------------------------------------
        private void txtSifreTekrar_Enter(object sender, EventArgs e)
        {
            textDoldur.SifreEnter(txtSifreTekrar, "Şifre Tekrar");
        }
        private void txtSifreTekrar_Leave(object sender, EventArgs e)
        {
            textDoldur.SifreLeave(txtSifreTekrar, "Şifre Tekrar");
        }
        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtSifreTekrar, 0, 8, lblSifreUyari);
        }
        //----------------------------------------------- btnKayit ----------------------------------------------------
        private void btnKayit_Click(object sender, EventArgs e)
        {
            //txtAd----------------------------------------------------------------------------------------------------
            if(kontrol.KarakterKontrol(txtAd, 0, 2, lblAdUyari) == false || txtAd.Text == "Ad")
            {
                if (string.IsNullOrEmpty(txtAd.Text) || txtAd.Text =="Ad")
                {
                    lblAdUyari.Text = "Boş geçilemez";
                }
            }
            //txtSoyad-------------------------------------------------------------------------------------------------
            else if (kontrol.KarakterKontrol(txtSoyad, 0, 2, lblSoyadUyari) == false || txtSoyad.Text == "Soyad")
            {
                if (string.IsNullOrEmpty(txtSoyad.Text) || txtSoyad.Text == "Soyad")
                {
                    lblSoyadUyari.Text = "Boş geçilemez";
                }
            }
            //cmbTarih-------------------------------------------------------------------------------------------------
            else if (kontrol.TarihKontrol(cmbGun,lblTarihUyari,"Gün") == false)
            {
                lblTarihUyari.Text = "Gün Seçiniz.";
            }
            else if (kontrol.TarihKontrol(cmbAy, lblTarihUyari, "Ay") == false)
            {
                lblTarihUyari.Text = "Ay Seçiniz.";
            }
            else if (kontrol.TarihKontrol(cmbYil, lblTarihUyari, "Yıl") == false)
            {
                lblTarihUyari.Text = "Yıl Seçiniz.";
            }
            //cmbCinsiyet----------------------------------------------------------------------------------------------

            else if (cmbCinsiyet.SelectedIndex == 0)
            {
                lblCinsiyetUyari.Text = "Cinsiyet Seçiniz";
            }
            //txtTelefonNo---------------------------------------------------------------------------------------------
            else if (kontrol.TelefonFormatKontrol(txtTelefonNo.Text) == false || txtTelefonNo.Text == "Telefon Numarası")
            {
                lblTelefonUyari.Text = "Geçersiz Numara";
                if (string.IsNullOrEmpty(txtTelefonNo.Text) || txtTelefonNo.Text == "Telefon Numarası")
                {
                    lblTelefonUyari.Text = "Boş Geçilmez";
                }
            }
            //txtEposta------------------------------------------------------------------------------------------------
            else if (kontrol.EpostaKontrol(txtEposta,lblEpostaUyari) == false || txtEposta.Text == "E-Posta")
            {
                lblEpostaUyari.Text = "Geçersiz E-Posta";
                if (string.IsNullOrEmpty(txtEposta.Text) || txtEposta.Text == "E-Posta")
                {
                    lblEpostaUyari.Text = "Boş Geçilmez";
                }
            }
            //txtKullaniciAid------------------------------------------------------------------------------------------
            else if (kontrol.KarakterKontrol(txtKullaniciAdi, 0, 4, lblKullaniciAdiUyari) == false || txtKullaniciAdi.Text == "Kullanıcı Adı")
            {

                if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || txtKullaniciAdi.Text == "Kullanıcı Adı")
                {
                    lblKullaniciAdiUyari.Text = "Boş geçilemez";
                }
            }
            else if (kontrol.KullaniciAdiKontrol(txtKullaniciAdi, lblKullaniciAdiUyari) == false)
            {
                lblKullaniciAdiUyari.Text = "Harf giriniz";
            }
            //txtSifre-------------------------------------------------------------------------------------------------
            else if (kontrol.KarakterKontrol(txtSifre, 0, 8, lblSifreUyari) == false || txtSifre.Text == "Şifre (En az 8 Haneli)")
            {
                if (string.IsNullOrEmpty(txtSifre.Text) || txtSifre.Text == "Şifre (En az 8 Haneli)")
                {
                    lblSifreUyari.Text = "Boş geçilemez";
                }
            }
            //txtSifreTekrar-------------------------------------------------------------------------------------------
            else if (txtSifre.Text != txtSifreTekrar.Text)
            {
                lblSifreUyari.Text = "Şifreler Eşleşmiyor";
            }
            //chxOnay------------------------------------------------------------------------------------------------------
            else if (chxOnay.Checked == false)
            {
                lblChxUyari.Text = "Sözleşmeyi kabul ediniz";
            }
            //----------------------VERİTABANI KODLARI-----------------------------------------------------------------
            else
            {
                Kullanici kullanici = new Kullanici();
                KullaniciYonetici kullaniciYonetici = new KullaniciYonetici();
                string dTarih = cmbYil.SelectedItem.ToString() + "-" + tarih.AyCevirme(cmbAy.SelectedItem.ToString()) + "-" + tarih.GunCevirme(cmbGun.SelectedItem.ToString());
                kullanici.getKullaniciAdi = txtAd.Text;
                kullanici.getKullaniciSoyadi = txtSoyad.Text;
                kullanici.getKullaniciDogumTarih = dTarih;
                kullanici.getKullaniciCinsiyet = cmbCinsiyet.SelectedItem.ToString();
                kullanici.getKullaniciTelefon = txtTelefonNo.Text;
                kullanici.getKullaniciEposta = txtEposta.Text;
                kullanici.getKullaniciKulAdi = txtKullaniciAdi.Text;
                kullanici.getKullaniciSifre = txtSifre.Text;

                if (kullaniciYonetici.HesapKontrol(kullanici) == true)
                {
                    if (kullaniciYonetici.KayitOl(kullanici) == true)
                    {
                        if (kullaniciYonetici.Giris(kullanici) == true)
                        {
                            frmKullaniciAnasayfa frmKullaniciAnasayfa = new frmKullaniciAnasayfa();
                            frmKullaniciAnasayfa.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
        //---------------------------------------btnExit---------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-------------------------------------btn Olaylar------------------------------------------
        private void btnKayit_MouseHover(object sender, EventArgs e)
        {
            btnKayit.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnKayit_MouseLeave(object sender, EventArgs e)
        {
            btnKayit.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void chxOnay_CheckedChanged(object sender, EventArgs e)
        {
            if(chxOnay.Checked == true)
            {
                lblChxUyari.Text = "";
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmGirisEkrani frmGirisEkrani = new frmGirisEkrani();
            frmGirisEkrani.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSozlesme frmSozlesme = new frmSozlesme();
            frmSozlesme.Show();
        }
    }
}
