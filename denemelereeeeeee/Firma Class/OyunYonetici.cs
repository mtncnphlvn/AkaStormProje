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
    class OyunYonetici
    {
        VeritabaniYonetici veritabaniYonetici = new VeritabaniYonetici();

        public bool OyunEkle(Oyun oyun)
        {

            bool kayit = false;

            try
            {
                string sorgu = "insert into oyun(oyun_adi,oyun_konu,kat_id,oyun_fiyat,firma_id,oyun_resim) values('"+oyun.getOyunAdi+"','"+oyun.getOyunKonusu+"','"+oyun.getOyunKategori+"','"+oyun.getOyunFiyat+"','"+Firma.firmaID+"','"+ MySql.Data.MySqlClient.MySqlHelper.EscapeString(oyun.getOyunResim) + "')";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());

                object sonuc = komut.ExecuteReader();
                if (sonuc != null)
                {
                    MessageBox.Show("Oyun Eklendi");
                    kayit = true;
                }
                else
                {
                    MessageBox.Show("Oyun Eklenemedi !");
                }

                veritabaniYonetici.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var :" + ex.Message);
            }
            return kayit;
        }
        public void Oyunlarım(DataGridView dataGridView)
        {
            string sorgu = "select oyun.oyun_id as ID, oyun.oyun_adi as OyunAdı,oyun.oyun_konu as Konu, kategori.kat_adi as Kategori,AVG(puan.puan) as Puan, firma.firma_ad as Firma, oyun.oyun_fiyat as Fiyat from oyun inner join kategori on oyun.kat_id = kategori.kat_id inner join puan on oyun.oyun_id = puan.oyun_id  inner join firma on oyun.firma_id = firma.firma_id where firma.firma_id ='"+Firma.firmaID+"' group by oyun.oyun_adi order by oyun.oyun_adi;";
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
        public void OyunListele(DataGridView dataGridView)
        {
            string sorgu = "select oyun.oyun_id as ID, oyun.oyun_adi as OyunAdı,oyun.oyun_konu as Konu, kategori.kat_adi as Kategori,AVG(puan.puan) as Puan, firma.firma_ad as Firma, oyun.oyun_fiyat as Fiyat from oyun inner join kategori on oyun.kat_id = kategori.kat_id inner join puan on oyun.oyun_id = puan.oyun_id  inner join firma on oyun.firma_id = firma.firma_id group by oyun.oyun_adi order by oyun.oyun_adi;";
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
        public void OyunListele(DataGridView dataGridView,TextBox textBox)
        {
            string sorgu = "select oyun.oyun_id as ID,oyun.oyun_adi as OyunAdı,oyun.oyun_konu as Konu, kategori.kat_adi as Kategori,AVG(puan.puan) as Puan, firma.firma_ad as Firma, oyun.oyun_fiyat as Fiyat from oyun inner join kategori on oyun.kat_id = kategori.kat_id inner join puan on oyun.oyun_id = puan.oyun_id  inner join firma on oyun.firma_id = firma.firma_id where oyun.oyun_adi like '" + "%" + textBox.Text + "%" + "' group by oyun.oyun_adi order by oyun.oyun_adi;";
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

        public void KategoriDoldur(ComboBox comboBox)
        {
            try
            {
                string sorgu = "select * from kategori order by kat_adi asc";
                MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
                MySqlDataReader reader;

                comboBox.Items.Add("--Kategori Seçiniz--");
                comboBox.SelectedIndex = 0;

                reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    comboBox.Items.Add(reader["kat_adi"]);
                }
                veritabaniYonetici.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Mesjı : " , ex.Message);
            }
        }
        public int KategoriSec(ComboBox comboBox)
        {
            int secim = 0;

            string sorgu = "select * from kategori where kat_adi='"+comboBox.SelectedItem.ToString()+"'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataReader reader;

            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                secim = Convert.ToInt32(reader["kat_id"]);
            }
            veritabaniYonetici.CloseConnection();

            return secim;
        }
        public void OnizlemeResim(PictureBox pictureBox)
        {
            string sorgu = "select oyun_resim from oyun where oyun_id='" +Oyun.oyunID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataReader reader;

            reader = komut.ExecuteReader();
            if (reader.Read())
            {
               pictureBox.ImageLocation  = reader["oyun_resim"].ToString();
            }
            veritabaniYonetici.CloseConnection();
        }
        public void OyunFiltre(DataGridView dataGridView, string sirala,string sirala2)
        {
            string sorgu = "select oyun.oyun_id as ID, oyun.oyun_adi as OyunAdı,oyun.oyun_konu as Konu, kategori.kat_adi as Kategori,AVG(puan.puan) as Puan, firma.firma_ad as Firma, oyun.oyun_fiyat as Fiyat from oyun inner join kategori on oyun.kat_id = kategori.kat_id inner join puan on oyun.oyun_id = puan.oyun_id  inner join firma on oyun.firma_id = firma.firma_id group by oyun.oyun_adi order by "+sirala+" "+sirala2+";";
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
        public void OyunFiltreKategori(DataGridView dataGridView, ComboBox comboBox)
        {
            try
            {
                string sorgu = "select oyun.oyun_id as ID, oyun.oyun_adi as OyunAdı,oyun.oyun_konu as Konu, kategori.kat_adi as Kategori,AVG(puan.puan) as Puan, firma.firma_ad as Firma, oyun.oyun_fiyat as Fiyat from oyun inner join kategori on oyun.kat_id = kategori.kat_id inner join puan on oyun.oyun_id = puan.oyun_id  inner join firma on oyun.firma_id = firma.firma_id where kat_adi='" + comboBox.SelectedItem.ToString() + "' group by oyun.oyun_adi order by oyun_adi";
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
                MessageBox.Show("Hata Mesajı : ",ex.Message);
            }

        }
        public void Filtre(DataGridView datagridview, ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == 0) //A-Z
            {
                OyunFiltre(datagridview, "OyunAdı","asc");
            }
            else if (comboBox.SelectedIndex == 1) //Z-A
            {
                OyunFiltre(datagridview, "OyunAdı", "desc");
            }
            else if (comboBox.SelectedIndex == 2) // Fiyat Yüksek
            {
                OyunFiltre(datagridview, "Fiyat", "desc");
            }
            else if (comboBox.SelectedIndex == 3) // Fiyat Düşük
            {
                OyunFiltre(datagridview, "Fiyat", "asc");
            }
            else if (comboBox.SelectedIndex == 4) // Puan Yüksek        
            {
                OyunFiltre(datagridview, "Puan", "desc");
            }
            else if (comboBox.SelectedIndex == 5) // Puan Düşük
            {
                OyunFiltre(datagridview, "Puan", "asc");

            }
        }
        public void FiyatAralik(DataGridView dataGridView,ComboBox fiyat1, ComboBox fiyat2)
        {
            string sorgu = "select oyun.oyun_id as ID, oyun.oyun_adi as OyunAdı,oyun.oyun_konu as Konu, kategori.kat_adi as Kategori,AVG(puan.puan) as Puan, firma.firma_ad as Firma, oyun.oyun_fiyat as Fiyat from oyun inner join kategori on oyun.kat_id = kategori.kat_id inner join puan on oyun.oyun_id = puan.oyun_id  inner join firma on oyun.firma_id = firma.firma_id where oyun.oyun_fiyat between '"+Convert.ToInt32(fiyat1.SelectedItem)+"' and '"+Convert.ToInt32(fiyat2.SelectedItem)+"' group by oyun.oyun_adi order by oyun.oyun_adi;";
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
        public void OyunGuncelle(ComboBox comboBox, TextBox textBox,Label label)
        {
            string sorgu = "update oyun set kat_id='" + KategoriSec(comboBox) + "',oyun_fiyat='" + textBox.Text + "' where oyun_id = '" + Oyun.oyunID + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, veritabaniYonetici.OpenConnection());
            MySqlDataReader reader;
            reader = komut.ExecuteReader();
            label.Text = "Oyun başarıyla güncellendi.";
            veritabaniYonetici.CloseConnection();
        }
    }
}
