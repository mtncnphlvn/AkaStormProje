using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AkaStormProje
{
    class KullaniciYonetici:Kullanici
    {
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
        public bool KayitOl(Kullanici kullanici)
        {
            
            bool kayit = false;

            try
            {
                string sorgu = "insert into kullanici(kul_ad,kul_soyad,kul_kullaniciAdi,kul_eposta,kul_telefon,kul_cinsiyet,kul_dogumTarih,kul_sifre) values('"+kullanici.getKullaniciAdi+"','"+ kullanici.getKullaniciSoyadi +"','"+ kullanici.getKullaniciKulAdi +"','"+ kullanici.getKullaniciEposta +"','"+ kullanici.getKullaniciTelefon +"','"+ kullanici.getKullaniciCinsiyet +"','"+kullanici.getKullaniciDogumTarih+"','"+ kullanici.getKullaniciSifre +"')";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

                object sonuc = komut.ExecuteReader();               
                if(sonuc != null)
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
            catch(Exception ex)
            {
                MessageBox.Show("Hata var :"+ ex.Message);
            }
            return kayit;
        }


        public bool Giris(Kullanici kullanici)
        {
            bool giris = false;
            try
            {
                string sorgu = "select * from kullanici where kul_kullaniciAdi='" + kullanici.getKullaniciKulAdi + "'and kul_sifre='" + kullanici.getKullaniciSifre + "'";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                MySqlDataReader reader;
                reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    giris = true;
                    Kullanici.kullaniciID = Convert.ToInt32(reader[0]);
                    MessageBox.Show("Giriş Başarılı ..");
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız ..");
                }
                veritabaniYonetici.CloseConnection();

            }catch (Exception ex)
            {
                MessageBox.Show("Hata var : ", ex.Message);
            }
            return giris;


        }
                            
    }   
}
