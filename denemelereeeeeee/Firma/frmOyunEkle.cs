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
        //------------------------------Olaylar--------------------------------
        Kontrol kontrol = new Kontrol();
        private void txtOyunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.OyunOzel(e);
        }
        private void txtKonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.OyunOzel(e);
        }
        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrol.SayiGir(e);
        }

        //--------------------------load-----------------------------------
        private void frmOyunEkle_Load(object sender, EventArgs e)
        {
            OyunYonetici oyunYonetici = new OyunYonetici();
            oyunYonetici.Kategori(cmbKategori);
            
            //cmbKategori.SelectedIndex = 0;
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
    }
}
