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
    public partial class frmOyunlarim : Form
    {
        public frmOyunlarim()
        {
            InitializeComponent();
        }
        private void btnGüncelle_MouseHover(object sender, EventArgs e)
        {
            btnGüncelle.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnGüncelle_MouseLeave(object sender, EventArgs e)
        {
            btnGüncelle.BackgroundImage = Properties.Resources.BtnLeave;
        }
        OyunYonetici oyunYonetici = new OyunYonetici();
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();

        private void FirmaBilgi()
        {

            try
            {
                MySqlCommand komut = new MySqlCommand("select firma_ad from firma where firma_id = '" + Firma.firmaID + "'", veritabaniYonetici.OpenConnection());

                MySqlDataReader reader;
                reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    lblFirmaAdi.Text = Convert.ToString(reader["firma_ad"]);

                }
                veritabaniYonetici.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var : ", ex.Message);
            }

        }
        public void DatagridSecim()
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            Oyun.oyunID = Convert.ToInt32(dataGridView1.Rows[sec].Cells[0].Value.ToString());
            oyunYonetici.OnizlemeResim(pbOyunResim);
            txtOyunAdi.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtKonu.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            oyunYonetici.KategoriDoldur(cmbKategori);
            txtFiyat.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString();
        }
        private void frmOyunlarim_Load(object sender, EventArgs e)
        {
            pbOyunResim.SizeMode = PictureBoxSizeMode.StretchImage;
            FirmaBilgi();
            oyunYonetici.Oyunlarım(dataGridView1);
            DatagridSecim();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridSecim();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex == 0)
            {
                lblonay.Text = "Kategori Seçiniz..";
            }
            else if(txtFiyat.Text == "")
            {
                lblonay.Text = "Fiyat boş geçilemez.";
            }
            else
            {
                oyunYonetici.OyunGuncelle(cmbKategori, txtFiyat, lblonay);
                oyunYonetici.Oyunlarım(dataGridView1);
                DatagridSecim();
            }

        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kontrol kontrol = new Kontrol();
            kontrol.SayiGir(e);

        }
    }
}
