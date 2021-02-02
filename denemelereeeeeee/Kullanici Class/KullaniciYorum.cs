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
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
        public void Yorumlar(DataGridView dataGridView)
        {
            try
            {
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
                MessageBox.Show("Hata Mesajı : " + ex.Message);
            }
        }


        public void YorumlarKullanici(DataGridView dataGridView)
        {
            try
            {
                string sorgu = "select kullanici.kul_kullaniciAdi as KullanıcıAdı, oyun.oyun_adi as OyunAdı, goruslerim.mesaj as Mesaj from goruslerim inner join kullanici on goruslerim.kul_id = kullanici.kul_id inner join oyun on goruslerim.oyun_id = oyun.oyun_id inner join firma on oyun.firma_id = firma.firma_id where kullanici.kul_id ='" + Kullanici.kullaniciID + "'";
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
                MessageBox.Show("Hata Mesajı : " + ex.Message);
            }
        }
        public bool YorumEkle(string mesaj)
        {
            bool durum = false;
            try
            {
                string sorgu = "insert into goruslerim(kul_id, oyun_id, mesaj) values('" + Kullanici.kullaniciID + "','" + Oyun.oyunID + "','" + mesaj + "')";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                object sonuc = komut.ExecuteReader();
                if(sonuc != null)
                {
                    durum = true;
                    MessageBox.Show("Yorum eklendi.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
            return durum;
        }
        public void PuanVer(int puan)
        {
            try
            {
                string sorgu = "insert into puan(kul_id, oyun_id, puan) values('" + Kullanici.kullaniciID + "','" + Oyun.oyunID + "','" + puan + "')";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                object sonuc = komut.ExecuteReader();
                if (sonuc != null)
                {
                    MessageBox.Show("Puan eklendi.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
        }
    }
}
