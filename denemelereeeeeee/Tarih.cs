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
    }
}
