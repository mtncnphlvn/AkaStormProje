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
    public partial class frmFirmaProfil : Form
    {
        public frmFirmaProfil()
        {
            InitializeComponent();
        }
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();

        private void FirmaBilgi()
        {
            pbFirmaResim.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                MySqlCommand komut = new MySqlCommand("select firma.firma_ad, firma.firma_ceo, firma.firma_eposta, firma.firma_telefon,firma_resim.firma_resim from firma inner join firma_resim on firma_resim.firma_id = firma.firma_id where firma.firma_id='"+Firma.firmaID+"'", veritabaniYonetici.OpenConnection());

                MySqlDataReader reader;
                reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    lblFirmaAdi.Text = reader["firma_ad"].ToString();
                    lblCeo.Text = reader["firma_ceo"].ToString();
                    lblEposta.Text = reader["firma_eposta"].ToString();
                    lblTelefon.Text = reader["firma_telefon"].ToString();
                    lblPuan.Text = "";
                    pbFirmaResim.ImageLocation = Convert.ToString(reader["firma_resim"]);
                }
                veritabaniYonetici.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var : ", ex.Message);
            }
        }
        public void PuanBilgisi()
        {
            try
            {
                MySqlCommand komut = new MySqlCommand("select AVG(puan.puan) from puan inner join oyun on oyun.oyun_id = puan.oyun_id inner join firma on oyun.firma_id = firma.firma_id where firma.firma_id='" + Firma.firmaID + "'", veritabaniYonetici.OpenConnection());

                MySqlDataReader reader;
                reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    lblPuan.Text = reader[0].ToString();

                }
                veritabaniYonetici.CloseConnection();
            }
            catch 
            {
                lblPuan.Text = "0";
            }
        }
        private void frmFirmaProfil_Load(object sender, EventArgs e)
        {
            FirmaBilgi();
            PuanBilgisi();
        }
    }
}