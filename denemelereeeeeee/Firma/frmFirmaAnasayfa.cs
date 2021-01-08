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
    public partial class frmFirmaAnasayfa : Form
    {
        public frmFirmaAnasayfa()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        //-----------------------------Diğer formları aynı form içinde açma methodu -------------------------------------------------
        private void FormGetir(Form frm)
        {
            panAlt.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panAlt.Controls.Add(frm);
            frm.Show();
        }
        //--------------------------------------frmFirmaAnasayfa load-------------------------------------------------------
        private void frmFirmaAnasayfa_Load(object sender, EventArgs e)
        {
            frmFirmaOyunListele firmaOyunListele = new frmFirmaOyunListele();
            FormGetir(firmaOyunListele);

        }
        //------------------------------btn Olaylar ------------------------------------------------------------
        private void btnAnasayfa_MouseHover(object sender, EventArgs e)
        {
            btnAnasayfa.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnAnasayfa_MouseLeave(object sender, EventArgs e)
        {
            btnAnasayfa.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnOyunlarim_MouseHover(object sender, EventArgs e)
        {
            btnOyunlarim.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnOyunlarim_MouseLeave(object sender, EventArgs e)
        {
            btnOyunlarim.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnOyunEkle_MouseHover(object sender, EventArgs e)
        {
            btnOyunEkle.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnOyunEkle_MouseLeave(object sender, EventArgs e)
        {
            btnOyunEkle.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnProfil_MouseHover(object sender, EventArgs e)
        {
            btnProfil.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnProfil_MouseLeave(object sender, EventArgs e)
        {
            btnProfil.BackgroundImage = Properties.Resources.BtnLeave;
        }
        //--------------------btnExit------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-------------------------btnAnasayfa------------------------------------
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmFirmaOyunListele firmaOyunListele = new frmFirmaOyunListele();
            FormGetir(firmaOyunListele);         
        }
        //-----------------------btnOyunlarim-------------------------------
        private void btnOyunlarim_Click(object sender, EventArgs e)
        {
            frmOyunlarim oyunlarim = new frmOyunlarim();
            FormGetir(oyunlarim);
        }
        //-----------------------------btnOyunEkle--------------------------------------
        private void btnOyunEkle_Click(object sender, EventArgs e)
        {
            frmOyunEkle oyunEkle = new frmOyunEkle();          
            FormGetir(oyunEkle);
        }
        //------------------------------btnProfil---------------------------------------------
        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmFirmaProfil firmaProfil = new frmFirmaProfil();
            FormGetir(firmaProfil);
        }
    }
}
