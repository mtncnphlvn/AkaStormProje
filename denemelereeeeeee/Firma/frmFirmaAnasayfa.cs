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
        //----------------------------------Anasayfa Giren kişinin bilgilerini yazdırma-------------------------------------------
        private void FirmaBilgi()
        {
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
            lblTarih.Text = DateTime.Now.ToShortDateString();
            try
            {
                MySqlCommand komut = new MySqlCommand("select firma.firma_ad,SUM(firma_bakiye.firma_bakiye),firma_resim.firma_resim from firma inner join firma_bakiye on firma.firma_id = firma_bakiye.firma_id inner join firma_resim on firma.firma_id = firma_resim.firma_id where firma.firma_id = '" + Firma.firmaID + "'", veritabaniYonetici.OpenConnection());

                MySqlDataReader reader;
                reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    lblKullaniciAdi.Text = Convert.ToString(reader[0]);
                    lblBakiye.Text = Convert.ToString(reader[1]) + " TL";
                    pbResim.ImageLocation = Convert.ToString(reader[2]);
                }
                veritabaniYonetici.CloseConnection();
            }catch(Exception ex)
            {
                MessageBox.Show("Hata var : ",ex.Message);
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
            FirmaBilgi();
            Console.WriteLine(Firma.firmaID);


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
