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
    public partial class frmKullaniciAnasayfa : Form
    {
        public frmKullaniciAnasayfa()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void panUst_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void panUst_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void panUst_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        public void KullaniciBilgi()
        {
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
            lblTarih.Text = DateTime.Now.ToShortDateString();
            try
            {
                MySqlCommand komut = new MySqlCommand("select kullanici.kul_kullaniciAdi,SUM(kullanici_bakiye.kul_bakiye),kullanici_resim.kul_resim from kullanici inner join kullanici_bakiye on kullanici.kul_id = kullanici_bakiye.kul_id inner join kullanici_resim on kullanici.kul_id = kullanici_resim.kul_id where kullanici.kul_id = '" + Kullanici.kullaniciID + "'", veritabaniYonetici.OpenConnection());

                MySqlDataReader reader;
                reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    lblKullaniciAdi.Text = Convert.ToString(reader[0]);
                    lblBakiye.Text = Convert.ToString(reader[1]) + " TL";
                    pbResim.ImageLocation = Convert.ToString(reader[2]);
                }
                veritabaniYonetici.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var : ", ex.Message);
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
        //--------------------------form load--------------------------------------------------
        private void frmKullaniciAnasayfa_Load(object sender, EventArgs e)
        {
            frmOyunListele oyunListele = new frmOyunListele();
            oyunListele.frmKullaniciAnasayfa = this;
            KullaniciBilgi();            
            FormGetir(oyunListele);
            
        }
        //-----------------------------btnExit-------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //-------------------------------------------btn Olaylar--------------------------------
        private void btnAnasayfa_MouseHover(object sender, EventArgs e)
        {
            btnAnasayfa.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnAnasayfa_MouseLeave(object sender, EventArgs e)
        {
            btnAnasayfa.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnKutuphane_MouseHover(object sender, EventArgs e)
        {
            btnKutuphane.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnKutuphane_MouseLeave(object sender, EventArgs e)
        {
            btnKutuphane.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnGoruslerim_MouseHover(object sender, EventArgs e)
        {
            btnGoruslerim.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnGoruslerim_MouseLeave(object sender, EventArgs e)
        {
            btnGoruslerim.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnProfil_MouseHover(object sender, EventArgs e)
        {
            btnProfil.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnProfil_MouseLeave(object sender, EventArgs e)
        {
            btnProfil.BackgroundImage = Properties.Resources.BtnLeave;
        }
        //--------------------------------btnAnasayfa------------------------------------
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmOyunListele  frmOyunListele = new frmOyunListele();
            FormGetir(frmOyunListele);
        }     
        //---------------------------------btnKutuphane------------------------------------------
        private void btnKutuphane_Click(object sender, EventArgs e)
        {
            frmKullaniciKutuphane kullaniciKutuphane = new frmKullaniciKutuphane();
            FormGetir(kullaniciKutuphane);
        }
        //-----------------------btnGoruslerim-------------------------------
        private void btnGoruslerim_Click(object sender, EventArgs e)
        {
            frmKullaniciGoruslerim kullaniciGoruslerim = new frmKullaniciGoruslerim();
            FormGetir(kullaniciGoruslerim);
        }
        //--------------------------btnProfil----------------------
        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmKullaniciProfil kullaniciProfil = new frmKullaniciProfil();
            FormGetir(kullaniciProfil);
        }
        //--------------------------bakiye ekleme butonu---------------------------------------
        private void linkBakiye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciYonetici kullaniciYonetici = new KullaniciYonetici();
            kullaniciYonetici.BakiyeEkle();
            KullaniciBilgi();
        }
    }
}
