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
    public partial class frmOyunListele : Form
    {
        public frmKullaniciAnasayfa frmKullaniciAnasayfa;
        public frmOyunListele()
        {
            InitializeComponent();
        }
        OyunYonetici oyunYonetici = new OyunYonetici();
        //---------------------form load-----------------------------------------
        private void frmOyunListele_Load(object sender, EventArgs e)
        {
            
            pbOyunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            panFiltre.Visible = false;          
            oyunYonetici.OyunListele(dataGridView1);
            oyunYonetici.KategoriDoldur(cmbKategoriFiltre);
            cmbGenel.SelectedIndex = 0;
            cmbFiyat1.SelectedIndex = 0;
            cmbFiyat2.SelectedIndex = 0;
            //DatagridSecim();

        }
        public void DatagridSecim()
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            Oyun.oyunID = Convert.ToInt32(dataGridView1.Rows[sec].Cells[0].Value.ToString());
            oyunYonetici.OnizlemeResim(pbOyunResim);
            txtOyunAdi.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtKonu.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            lblKategori.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            lblGelistirici.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            lblPuan.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            lblFiyat.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString() + " TL";
        }
        //--------------------btnFiltre------------------------------
        private void btnFiltre_Click(object sender, EventArgs e)
        {
            panFiltre.Visible = true;
        }
        //-------------------btnFitlre Olaylar---------------------------------
        private void btnFiltre_MouseHover(object sender, EventArgs e)
        {
            btnFiltre.BackgroundImage = Properties.Resources.btnFiltreHover;
        }
        private void btnFiltre_MouseLeave(object sender, EventArgs e)
        {
            btnFiltre.BackgroundImage = Properties.Resources.btnFiltre1;
        }
        //--------------------btnFiltreExi-------------------------------------
        private void btnFiltreExit_Click(object sender, EventArgs e)
        {
            panFiltre.Visible = false;
        }
        //-------------------------txtAdFiltre----------------------------------------------------
        TextDoldur textDoldur = new TextDoldur();
        private void txtAdFiltre_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtAdFiltre, "İsme göre ara");
        }
        private void txtAdFiltre_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtAdFiltre, "İsme göre ara");
        }
        private void txtAdFiltre_TextChanged(object sender, EventArgs e)
        {
            oyunYonetici.OyunListele(dataGridView1, txtAdFiltre);
            if (txtAdFiltre.Text == "İsme göre ara")
            {
                oyunYonetici.OyunListele(dataGridView1);
            }
        }
        //-----------------------------btnFiltre2 Olay
        private void btnFiltre2_MouseHover(object sender, EventArgs e)
        {
            btnFiltre2.BackgroundImage = Properties.Resources.btnFiltreHover;
        }
        private void btnFiltre2_MouseLeave(object sender, EventArgs e)
        {
            btnFiltre2.BackgroundImage = Properties.Resources.btnFiltre1;
        }
        private void btnAl_MouseHover(object sender, EventArgs e)
        {
            btnSatinAl.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnAl_MouseLeave(object sender, EventArgs e)
        {
            btnSatinAl.BackgroundImage = Properties.Resources.BtnLeave;
        }

        private void btnFiltre2_Click(object sender, EventArgs e)
        {
            if (cmbFiyat1.SelectedIndex == 0 && cmbFiyat2.SelectedIndex == 0 && cmbKategoriFiltre.SelectedIndex != 0)
            {
                oyunYonetici.OyunFiltreKategori(dataGridView1, cmbKategoriFiltre);
                cmbKategoriFiltre.SelectedIndex = 0;
            }
            else
            {
                oyunYonetici.FiyatAralik(dataGridView1, cmbFiyat1, cmbFiyat2);
            }
        }
        private void cmbKategoriFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFiyat1.SelectedIndex = 0;
            cmbFiyat2.SelectedIndex = 0;
        }
        private void cmbGenel_SelectedIndexChanged(object sender, EventArgs e)
        {
            oyunYonetici.Filtre(dataGridView1, cmbGenel);

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridSecim();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            KullaniciKutuphane kullaniciKutuphane = new KullaniciKutuphane();
            kullaniciKutuphane.SatinAl();

            frmKullaniciAnasayfa.KullaniciBilgi();
          
        }

    }
}
