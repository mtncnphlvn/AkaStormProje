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
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void frmKullaniciGiris_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmKullaniciGiris_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void frmKullaniciGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if(move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        Kontrol kontrol = new Kontrol();
        TextDoldur textDoldur = new TextDoldur();
        //--------------------------- txtKullaniciAdi ------------------------------------
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
            kontrol.Giris(txtKullaniciAdi,lblKullaniciAdiUyari,"Kullanıcı Adı");
        }
        //---------------------- txtSifre -------------------------------------------
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
        //----------------------------btnExit------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-------------------------------------------------btnGiris-------------------------------------------------------------
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || txtKullaniciAdi.Text == "Kullanıcı Adı")
            {
                lblKullaniciAdiUyari.Text = "Boş geçilemez";
            }
            else if (string.IsNullOrEmpty(txtSifre.Text) || txtSifre.Text == "Şifre")
            {
                lblSifreUyari.Text = "Boş geçilemez";
            }
            else
            {
                Console.WriteLine("Kayıt Olundu");
            }
        }
        //-------------------------------------------------btn Olaylar-------------------------------------------------------------
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
