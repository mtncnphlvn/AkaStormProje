using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AkaStormProje
{
    class FirmaYonetici
    {
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();

        public bool KayitOl(Firma firma)
        {
            bool kayit = false;

            try
            {
                string sorgu = "insert into firma(firma_ad,firma_ceo,firma_eposta,firma_telefon,firma_sifre) values('"+firma.getFirmaAdi+"','"+firma.getFirmaCeo+"','"+firma.getFirmaEposta+"','"+firma.getFirmaTelefon+"','"+firma.getFirmaSifre+"')";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

                object sonuc = komut.ExecuteReader();
                if (sonuc != null)
                {
                    MessageBox.Show("Kayıt Olundu");
                    kayit = true;
                }
                else
                {
                    MessageBox.Show("Kayıt Başarız");
                }

                veritabaniYonetici.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var :" + ex.Message);
            }
            return kayit;
        }

        public bool Giris(Firma firma)
        {

            bool giris = false;
            try
            {
                string sorgu = "select * from firma where firma_eposta='" + firma.getFirmaEposta + "'and firma_sifre='" + firma.getFirmaSifre + "'";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                MySqlDataReader reader;
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    giris = true;
                    Firma.firmaID = Convert.ToInt32(reader[0]);
                    MessageBox.Show("Giriş Başarılı ..");
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız ..");
                }
                veritabaniYonetici.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var : ", ex.Message);
            }
            return giris;
        }
        public bool HesapKontrol(Firma firma)
        {

            bool giris = false;
            try
            {
                string sorgu = "select * from firma where firma_eposta='" + firma.getFirmaEposta + "'";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                MySqlDataReader reader;
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    giris = false;
                    MessageBox.Show("Firma sisteme kayıtlı");
                }
                else
                {
                    giris = true;
                }
                veritabaniYonetici.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var : ", ex.Message);
            }
            return giris;
        }
        public void ResimGuncelle(string resim, Label label)
        {
            string sorgu = "update firma_resim set firma_resim='" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(resim) + "' where firma_id='"+Firma.firmaID+"'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataReader reader;
            reader = komut.ExecuteReader();
            label.Text = "Başarıyla Günellendi.";
            veritabaniYonetici.CloseConnection();
        }
        public void BakiyeEkle()
        {
            string sorgu = "insert into firma_bakiye(firma_id,firma_bakiye) values ('"+Firma.firmaID+"',100)";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            komut.ExecuteReader();
            veritabaniYonetici.CloseConnection();          
        }

    }
}
