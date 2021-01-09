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
    public partial class frmGirisEkrani : Form
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void frmGirisEkrani_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void frmGirisEkrani_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }        
        private void frmGirisEkrani_MouseUp(object sender, MouseEventArgs e)
        {
                     move = false;
        }
        //---------------------formload--------------------------------------------
        private void frmGirisEkrani_Load(object sender, EventArgs e)
        {
          
        }
        //----------------------btnExi-t-----------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //--------------------------------kullanıcı olay---------------------------
        private void btnGiris_MouseHover(object sender, EventArgs e)
        {
            btnGiris.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnKayit_MouseHover(object sender, EventArgs e)
        {
            btnKayit.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnKayit_MouseLeave(object sender, EventArgs e)
        {
            btnKayit.BackgroundImage = Properties.Resources.BtnLeave;
        }
        //------------------------------------------firma olay------------------------------
        private void btnFGiris_MouseHover(object sender, EventArgs e)
        {
            btnFGiris.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnFGiris_MouseLeave(object sender, EventArgs e)
        {
            btnFGiris.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnFKayit_MouseHover(object sender, EventArgs e)
        {
            btnFKayit.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnFKayit_MouseLeave(object sender, EventArgs e)
        {
            btnFKayit.BackgroundImage = Properties.Resources.BtnLeave;
        }
        //-------------------------------kullanıcı--------------------------------
        private void btnGiris_Click(object sender, EventArgs e)
        {
            frmKullaniciGiris frmKullaniciGiris = new frmKullaniciGiris();
            frmKullaniciGiris.Show();
            this.Hide();
        }
        private void btnKayit_Click(object sender, EventArgs e)
        {
            frmKullaniciKayit frmKullaniciKayit = new frmKullaniciKayit();
            frmKullaniciKayit.Show();
            this.Hide();
        }
        //---------------------------firma----------------------------------
        private void btnFGiris_Click(object sender, EventArgs e)
        {
            frmFirmaGiris frmFirmaGiris = new frmFirmaGiris();
            frmFirmaGiris.Show();
            this.Hide();
        }
        private void btnFKayit_Click(object sender, EventArgs e)
        {
            frmFirmaKayit frmFirmaKayit = new frmFirmaKayit();
            frmFirmaKayit.Show();
            this.Hide();
        }
    }
}
