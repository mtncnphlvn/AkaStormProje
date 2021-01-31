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
    public partial class frmKullaniciKutuphane : Form
    {
        public frmKullaniciKutuphane()
        {
            InitializeComponent();
        }
        //--------------------------form load------------------------------
        KullaniciKutuphane kullaniciKutuphane = new KullaniciKutuphane();
        OyunYonetici oyunYonetici = new OyunYonetici();
        private void frmKullaniciKutuphane_Load(object sender, EventArgs e)
        {
            
            kullaniciKutuphane.KutuphaneListele(dataGridView1);
            pbOyunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            panFiltre.Visible = false;
            DatagridSecim();
            oyunYonetici.KategoriDoldur(cmbKategoriFiltre);
            cmbGenel.SelectedIndex = 0;

        }
        //-----------------------------txtAdFiltre--------------------------------------
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
        //-------------------------------------btnFiltre---------------------------------------------------
        private void btnFiltre_Click(object sender, EventArgs e)
        {
            panFiltre.Visible = true;
        }
        //------------------------btnFiltre Olay-----------------------------------------
        private void btnFiltre_MouseHover(object sender, EventArgs e)
        {
            btnFiltre.BackgroundImage = Properties.Resources.btnFiltreHover;
        }
        private void btnFiltre_MouseLeave(object sender, EventArgs e)
        {
            btnFiltre.BackgroundImage = Properties.Resources.btnFiltre1;
        }
        //------------------------------btnFitre2 olay--------------------------------------------
        private void btnFiltre2_MouseHover(object sender, EventArgs e)
        {
            btnFiltre2.BackgroundImage = Properties.Resources.btnFiltreHover;
        }
        private void btnFiltre2_MouseLeave(object sender, EventArgs e)
        {
            btnFiltre2.BackgroundImage = Properties.Resources.btnFiltre1;
        }
        //------------------------btnFiltreExit-------------------------------------------
        private void btnFiltreExit_Click(object sender, EventArgs e)
        {
            panFiltre.Visible = false;
        }
        private void btnPuan_MouseHover(object sender, EventArgs e)
        {
            btnPuan.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnPuan_MouseLeave(object sender, EventArgs e)
        {
            btnPuan.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnYorum_MouseHover(object sender, EventArgs e)
        {
            btnYorum.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnYorum_MouseLeave(object sender, EventArgs e)
        {
            btnYorum.BackgroundImage = Properties.Resources.BtnLeave;
        }
        public void DatagridSecim()
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            Oyun.oyunID = Convert.ToInt32(dataGridView1.Rows[sec].Cells[1].Value.ToString());
            oyunYonetici.OnizlemeResim(pbOyunResim);
            txtOyunAdi.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            txtKonu.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            lblKategori.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            lblGelistirici.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            lblPuan.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString();
        }

        private void cmbGenel_SelectedIndexChanged(object sender, EventArgs e)
        {
            kullaniciKutuphane.Filtre(dataGridView1,cmbGenel);
        }
        private void btnFiltre2_Click(object sender, EventArgs e)
        {
            if (cmbKategoriFiltre.SelectedIndex != 0)
            {
                oyunYonetici.OyunFiltreKategori(dataGridView1, cmbKategoriFiltre);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridSecim();
        }


    }
}
