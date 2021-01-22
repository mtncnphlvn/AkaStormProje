using System;
using System.Collections.Generic;
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

        public void OyunEkle(Oyun oyun)
        {
            //oyun ekleme kodları
        }

        public void Kategori(ComboBox comboBox)
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

    }
}
