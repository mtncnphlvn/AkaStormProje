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
    public partial class frmFirmaGiris : Form
    {
        public frmFirmaGiris()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void frmFirmaGiris_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmFirmaGiris_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void frmFirmaGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        TextDoldur textDoldur = new TextDoldur();
        Kontrol kontrol = new Kontrol();
        //---------------------txtE-Posta---------------------
        private void txtEposta_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtEposta, "E-Posta");
        }
        private void txtEposta_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtEposta, "E-Posta");
        }
        private void txtEposta_TextChanged(object sender, EventArgs e)
        {
            kontrol.Giris(txtEposta,lblEpostaUyari,"E-Posta");
        }
        //---------------------txtSifre---------------------
        private void txtSifre_Enter(object sender, EventArgs e)
        {
            textDoldur.SifreEnter(txtSifre,"Şifre");
        }
        private void txtSifre_Leave(object sender, EventArgs e)
        {
            textDoldur.SifreLeave(txtSifre, "Şifre");
        }   
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            kontrol.Giris(txtSifre, lblSifreUyari, "Şifre");
        }
        //---------------------------------------btnkayit---------------------------------
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (kontrol.EpostaKontrol(txtEposta, lblEpostaUyari) == false || txtEposta.Text == "E-Posta")
            {
                lblEpostaUyari.Text = "Geçersiz E-Posta";
                if (string.IsNullOrEmpty(txtEposta.Text) || txtEposta.Text == "E-Posta")
                {
                    lblEpostaUyari.Text = "Boş geçilemez";
                }
            }
            else if (string.IsNullOrEmpty(txtSifre.Text) || txtSifre.Text == "Şifre")
            {
                lblSifreUyari.Text = "Boş geçilemez";
            }
            else
            {

                Firma firma = new Firma();
                FirmaYonetici firmaYonetici = new FirmaYonetici();

                firma.getFirmaEposta = txtEposta.Text;
                firma.getFirmaSifre = txtSifre.Text;

                if (firmaYonetici.Giris(firma) == true)
                {
                    frmFirmaAnasayfa frmFirmaAnasayfa = new frmFirmaAnasayfa();
                    frmFirmaAnasayfa.Show();
                    this.Hide();
                }


            }
        }
        //---------------------btnExit---------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //------------------------------btn Olaylar ------------------------------
        private void btnGiris_MouseHover(object sender, EventArgs e)
        {
            btnGiris.BackgroundImage = Properties.Resources.BtnHvr;
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackgroundImage = Properties.Resources.BtnLeave;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmGirisEkrani frmGirisEkrani = new frmGirisEkrani();
            frmGirisEkrani.Show();
            this.Hide();
        }
    }
}
