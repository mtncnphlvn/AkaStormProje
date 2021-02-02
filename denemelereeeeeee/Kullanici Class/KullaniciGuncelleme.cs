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
    class KullaniciGuncelleme
    {
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
        public void KullaniciAdiDegis(TextBox textBox)
        {
            string sorgu = "update kullanici set kul_kullaniciAdi='"+ textBox.Text +"' where kul_id = '"+ Kullanici.kullaniciID +"'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

            object sonuc = komut.ExecuteReader();
            if (sonuc != null)
            {
                MessageBox.Show("Güncelleme Başarılı");
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız");

            }
            veritabaniYonetici.CloseConnection();
        }
        public void SifreDegis(TextBox textBox)
        {
            string sorgu = "update kullanici set kul_sifre='" + textBox.Text + "' where kul_id = '" + Kullanici.kullaniciID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

            object sonuc = komut.ExecuteReader();
            if (sonuc != null)
            {
                MessageBox.Show("Güncelleme Başarılı");
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız");

            }
            veritabaniYonetici.CloseConnection();

        }
        public void EpostaDegis(TextBox textBox)
        {
            string sorgu = "update kullanici set kul_eposta='" + textBox.Text + "' where kul_id = '" + Kullanici.kullaniciID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

            object sonuc = komut.ExecuteReader();
            if (sonuc != null)
            {
                MessageBox.Show("Güncelleme Başarılı");
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız");

            }
            veritabaniYonetici.CloseConnection();

        }
        public void TelefonDegis(TextBox textBox)
        {
            string sorgu = "update kullanici set kul_telefon='" + textBox.Text + "' where kul_id = '" + Kullanici.kullaniciID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

            object sonuc = komut.ExecuteReader();
            if (sonuc != null)
            {
                MessageBox.Show("Güncelleme Başarılı");
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız");

            }
            veritabaniYonetici.CloseConnection();

        }
        public void ResimDegis(TextBox textBox)
        {
            string sorgu = "update kullanici_resim set kul_resim='" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(textBox.Text) + "' where kul_id='" + Kullanici.kullaniciID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

            object sonuc = komut.ExecuteReader();
            if (sonuc != null)
            {
                MessageBox.Show("Güncelleme Başarılı");
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız");

            }
            veritabaniYonetici.CloseConnection();

        }
        public void HesapSil()
        {
            string sorgu = "delete from kullanici where kul_id='" + Kullanici.kullaniciID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

            object sonuc = komut.ExecuteReader();
            if (sonuc != null)
            {
                MessageBox.Show("Hoşçakal :'(");
            }
            else
            {
                MessageBox.Show("Bir hata meydana geldi");

            }
            veritabaniYonetici.CloseConnection();
        }

    }
}
