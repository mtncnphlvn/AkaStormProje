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
    class KullaniciKutuphane
    {
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();
        public void SatinAl()
        {

            try
            {
                string sorguListe = "select * from kutuphane where kul_id='" + Kullanici.kullaniciID + "' and oyun_id='" + Oyun.oyunID + "'";
                MySqlCommand komutListe = new MySqlCommand(sorguListe, veritabaniYonetici.OpenConnection());
                MySqlDataReader reader;
                reader = komutListe.ExecuteReader();

                if (reader.Read())
                {

                    MessageBox.Show("Bu oyuna zaten sahipsiniz.");
                }
                else
                {
                    veritabaniYonetici.CloseConnection();
                    string sorguFiyat = "select * from oyun where oyun_id='"+Oyun.oyunID+"'";
                    MySqlCommand komutFiyat = new MySqlCommand(sorguFiyat, veritabaniYonetici.OpenConnection());
                    MySqlDataReader readerFiyat;
                    readerFiyat = komutFiyat.ExecuteReader();

                    if (readerFiyat.Read())
                    {
                        int fiyat = Convert.ToInt32(readerFiyat[6]);
                        int firmaID = Convert.ToInt32(readerFiyat[4]);
                        veritabaniYonetici.CloseConnection();

                        string sorgu = "insert into kutuphane(kul_id, oyun_id) values('" + Kullanici.kullaniciID + "','" + Oyun.oyunID + "')";
                        MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

                        object sonuc = komut.ExecuteReader();
                        if (sonuc != null)
                        {
                            veritabaniYonetici.CloseConnection();
                            MessageBox.Show("Satın alma başarılı.");

                            string sorguPara = "insert into kullanici_bakiye(kul_id,kul_bakiye) values('" + Kullanici.kullaniciID + "',-" + fiyat + ")";
                            MySqlCommand komutPara = new MySqlCommand(sorguPara, veritabaniYonetici.OpenConnection());
                            object sonucPara = komutPara.ExecuteReader();
                            if (sonucPara != null)
                            {
                                Console.WriteLine("para alındı.");
                                veritabaniYonetici.CloseConnection();
                                int sonFiyat = (fiyat * 90) / 100;
                                string sorguFirmaPara = "insert into firma_bakiye(firma_id,firma_bakiye) values("+firmaID+","+sonFiyat+")";
                                MySqlCommand komutFirmaPara = new MySqlCommand(sorguFirmaPara, veritabaniYonetici.OpenConnection());
                                object sonucFirmaPara = komutFirmaPara.ExecuteReader();
                                if (sonucFirmaPara != null)
                                {
                                    Console.WriteLine("para firmaya gitti.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Satın alma başarısız.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("deneme");
                    }
                                     
                    veritabaniYonetici.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var :" + ex.Message);
            }
        }

        public void KutuphaneListele(DataGridView dataGridView)
        {
            string sorgu = "select kutuphane.kul_id as KullanıcıID,oyun.oyun_id as OyunID ,oyun.oyun_adi as OyunAdı, oyun.oyun_konu as Konu, kategori.kat_adi as Kategori, firma.firma_ad as Geliştirici, AVG(puan.puan) as Puan from kutuphane inner join oyun on kutuphane.oyun_id = oyun.oyun_id inner join kategori on kategori.kat_id = oyun.kat_id inner join firma on firma.firma_id = oyun.firma_id inner join puan on puan.oyun_id = oyun.oyun_id where kutuphane.kul_id = '" + Kullanici.kullaniciID+"' group by oyun.oyun_adi order by oyun.oyun_adi";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataReader reader;
            reader = komut.ExecuteReader();

            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();

            DataTable dTable;
            MyAdapter.SelectCommand = komut;
            veritabaniYonetici.CloseConnection();

            dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView.DataSource = dTable;
            veritabaniYonetici.CloseConnection();
        }
        public void KutuphaneFiltre(DataGridView dataGridView,string sirala)
        {
            string sorgu = "select kutuphane.kul_id as KullanıcıID,oyun.oyun_id as OyunID ,oyun.oyun_adi as OyunAdı, oyun.oyun_konu as Konu, kategori.kat_adi as Kategori, firma.firma_ad as Geliştirici, AVG(puan.puan) as Puan from kutuphane inner join oyun on kutuphane.oyun_id = oyun.oyun_id inner join kategori on kategori.kat_id = oyun.kat_id inner join firma on firma.firma_id = oyun.firma_id inner join puan on puan.oyun_id = oyun.oyun_id where kutuphane.kul_id = '"+Kullanici.kullaniciID+"' group by oyun.oyun_adi order by oyun.oyun_adi "+sirala+"";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataReader reader;
            reader = komut.ExecuteReader();

            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();

            DataTable dTable;
            MyAdapter.SelectCommand = komut;
            veritabaniYonetici.CloseConnection();

            dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView.DataSource = dTable;
            veritabaniYonetici.CloseConnection();
        }
        public void Filtre(DataGridView datagridview, ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == 0) //A-Z
            {
                KutuphaneFiltre(datagridview,"asc");
            }
            else if (comboBox.SelectedIndex == 1) //Z-A
            {
                KutuphaneFiltre(datagridview,"desc");
            }
        }
    }
}
