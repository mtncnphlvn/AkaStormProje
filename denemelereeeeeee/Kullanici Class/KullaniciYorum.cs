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
    class KullaniciYorum
    {
        //--------------------------Kullanıcının yaptığı yorumları listler--------------------------------------------------------
        public void Yorumlar(DataGridView dataGridView)
        {
            try
            {
                VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
                string sorgu = "select kullanici.kul_kullaniciAdi as KullanıcıAdı, oyun.oyun_adi as OyunAdı, goruslerim.mesaj as Mesaj from goruslerim inner join kullanici on goruslerim.kul_id = kullanici.kul_id inner join oyun on goruslerim.oyun_id = oyun.oyun_id inner join firma on oyun.firma_id = firma.firma_id where firma.firma_id ='" + Firma.firmaID + "'";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MySqlDataReader reader;

                DataTable dTable;
                reader = komut.ExecuteReader();
                MyAdapter.SelectCommand = komut;
                veritabaniYonetici.CloseConnection();

                dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Mesajı : " + ex.Message );
            }
        }


        public void YorumEkle()
        {

        }
    }
}
