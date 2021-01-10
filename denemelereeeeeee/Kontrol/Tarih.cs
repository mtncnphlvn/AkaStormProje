using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkaStormProje
{
    class Tarih
    {
        public void Gun(ComboBox comboBoxGun, ComboBox comboBoxAy)
        {
            if (comboBoxAy.Text == "Nisan" || comboBoxAy.Text == "Haziran" || comboBoxAy.Text == "Eylül" || comboBoxAy.Text == "Kasım")
            {
                comboBoxGun.Items.Clear();
                comboBoxGun.Items.Add("Gün");
                for (int gun = 1; gun <= 30; gun++)
                {                   
                    comboBoxGun.Items.Add(gun);
                }
            }
            else if (comboBoxAy.Text == "Şubat")
            {
                comboBoxGun.Items.Clear();
                comboBoxGun.Items.Add("Gün");
                for (int gun = 1; gun <= 29; gun++)
                {
                    comboBoxGun.Items.Add(gun);
                }
            }
            else
            {
                comboBoxGun.Items.Clear();
                comboBoxGun.Items.Add("Gün");
                for (int gun = 1; gun <= 31; gun++)
                {
                    comboBoxGun.Items.Add(gun);
                }
            }
            comboBoxGun.SelectedIndex = 0;
        }
        public void Ay(ComboBox comboBox)
        {
            string[] aylar = new string[13];
            aylar[0] = "Ay";
            aylar[1] = "Ocak";
            aylar[2] = "Şubat";
            aylar[3] = "Mart";
            aylar[4] = "Nisan";
            aylar[5] = "Mayıs";
            aylar[6] = "Haziran";
            aylar[7] = "Temmuz";
            aylar[8] = "Ağustos";
            aylar[9] = "Eylül";
            aylar[10] = "Ekim";
            aylar[11] = "Kasım";
            aylar[12] = "Aralık";

            foreach (string ay in aylar)
            {
                comboBox.Items.Add(ay);
            }
            comboBox.SelectedIndex = 0;
        }
        public void Yil(ComboBox comboBox)
        {
            int yil = DateTime.Now.Year;
            comboBox.Items.Add("Yıl");
            for (int i = yil-18; i >= 1920; i--)
            {
                comboBox.Items.Add(i);        
            }
            comboBox.SelectedIndex = 0;
        }
        public void TarihRenk(ComboBox comboBox)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(50, 100, 150);
            comboBox.ForeColor = myRgbColor;
        }

        public string AyCevirme(string ay)
        {
            string  aySayi = "";
            
            switch (ay)
            {
                case "Ocak":
                    aySayi = "01";
                    break;
                case "Şubat":
                    aySayi = "02";
                    break;
                case "Mart":
                    aySayi = "03";
                    break;
                case "Nisan":
                    aySayi = "04";
                    break;
                case "Mayıs":
                    aySayi = "05";
                    break;
                case "Haziran":
                    aySayi = "06";
                    break;
                case "Temmuz":
                    aySayi = "07";
                    break;
                case "Ağustos":
                    aySayi = "08";
                    break;
                case "Eylül":
                    aySayi = "09";
                    break;
                case "Ekim":
                    aySayi = "10";
                    break;
                case "Kasım":
                    aySayi = "11";
                    break;
                case "Aralık":
                    aySayi = "12";
                    break;
            }

            return aySayi;
        }
        public string GunCevirme(string gun)
        {
            string gunSayi = "";

            switch (gun)
            {
                case "1":
                    gunSayi = "01";
                    break;
                case "2":
                    gunSayi = "02";
                    break;
                case "3":
                    gunSayi = "03";
                    break;
                case "4":
                    gunSayi = "04";
                    break;
                case "5":
                    gunSayi = "05";
                    break;
                case "6":
                    gunSayi = "06";
                    break;
                case "7":
                    gunSayi = "07";
                    break;
                case "8":
                    gunSayi = "08";
                    break;
                case "9":
                    gunSayi = "09";
                    break;
                default:
                    gunSayi = gun;
                    break;

            }

            return gunSayi;
        }
    }
}
