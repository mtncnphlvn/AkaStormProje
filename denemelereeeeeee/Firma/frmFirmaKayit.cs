using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkaStormProje
{
    public partial class frmFirmaKayit : Form
    {
        public frmFirmaKayit()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void frmFirmaKayit_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void frmFirmaKayit_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void frmFirmaKayit_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        //----------------------------------------------- Form Load -----------------------------------------------------------------------------
        private void frmFirmaKayit_Load(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Kontrol kontrol = new Kontrol();
        TextDoldur textDoldur = new TextDoldur();
        //------------------------------- txtFirmaAdi-------------------------------------------
        private void txtFirmaAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.HarfGir(e);
        }
        private void txtFirmaAdi_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtFirmaAdi,"Firma Adı");
        }
        private void txtFirmaAdi_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtFirmaAdi,"Firma Adı");
        }
        private void txtFirmaAdi_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtFirmaAdi, 0, 2, lblFirmaAdiUyari);
        }
        //------------------------------- txtCeo ----------------------------------------
        private void txtCeo_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.HarfGir(e);
        }
        private void txtCeo_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtCeo,"Ceo");
        }
        private void txtCeo_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtCeo, "Ceo");
        }
        private void txtCeo_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtCeo, 0, 2, lblCeoUyari);
        }
        //--------------------------------------txtEposta-----------------------------------------------
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
        //--------------------------------txtTelefonNo ---------------------------------------------
        private void txtTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.SayiGir(e);
        }
        private void txtTelefonNo_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtTelefonNo, "Telefon Numarası");
        }
        private void txtTelefonNo_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtTelefonNo, "Telefon Numarası");
        }
        private void txtTelefonNo_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtTelefonNo, 0, 11, lblTelefonUyari);
            if (txtTelefonNo.TextLength == 11 && kontrol.TelefonFormatKontrol(txtTelefonNo.Text) == false)
            {
                lblTelefonUyari.Text = "Geçersiz Numara";
            }
        }
        //----------------------------------------txtSifre ----------------------------------------------
        private void txtSifre_Enter(object sender, EventArgs e)
        {
            textDoldur.SifreEnter(txtSifre, "Şifre (En az 8 Haneli)");
        }
        private void txtSifre_Leave(object sender, EventArgs e)
        {
            textDoldur.SifreLeave(txtSifre, "Şifre (En az 8 Haneli)");
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            kontrol.KarakterKontrol(txtSifre, 0, 8, lblSifreUyari);
        }
        //--------------------------------------txtSifreTekrar-----------------------------------------------
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
        //------------------------------btnKayit---------------------------------------------------
        private void btnKayit_Click(object sender, EventArgs e)
        {
            //txtFirmaAdi-------------------------------------------------------------------------------------------
            if (kontrol.KarakterKontrol(txtFirmaAdi, 0, 2, lblFirmaAdiUyari) == false || txtFirmaAdi.Text == "Firma Adı")
            {
                if (string.IsNullOrEmpty(txtFirmaAdi.Text) || txtFirmaAdi.Text == "Firma Adı")
                {
                    lblFirmaAdiUyari.Text = "Boş geçilemez";
                }
            }
            //txtCeo-------------------------------------------------------------------------------------------

            else if (kontrol.KarakterKontrol(txtCeo, 0, 2, lblCeoUyari) == false || txtCeo.Text == "Ceo")
            {
                if (string.IsNullOrEmpty(txtCeo.Text) || txtCeo.Text == "Ceo")
                {
                    lblCeoUyari.Text = "Boş geçilemez";
                }
            }
            //txtEposta-------------------------------------------------------------------------------------------
            else if (kontrol.EpostaKontrol(txtEposta, lblEpostaUyari) == false || txtEposta.Text == "E-Posta")
            {
                lblEpostaUyari.Text = "Geçersiz E-Posta";
                if (string.IsNullOrEmpty(txtEposta.Text) || txtEposta.Text == "E-Posta")
                {
                    lblEpostaUyari.Text = "Boş Geçilmez";
                }
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
            else if(chxOnay.Checked == false)
            {
                lblChxUyari.Text = "Sözleşmeyi kabul ediniz";
            }
            //----------------------VERİTABANI KODLARI-----------------------------------------------------------------
            else
            {
                Console.WriteLine("!! Kayıt Olundu !!");
            }
        }

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
            if (chxOnay.Checked == true)
            {
                lblChxUyari.Text = "";
            }
        }
    }
}
