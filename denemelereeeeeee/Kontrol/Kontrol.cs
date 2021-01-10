using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace AkaStormProje
{
    class Kontrol
    {   
        //------------------------------------------------------- TARİH --------------------------------------------------------------------------
        public bool TarihKontrol(ComboBox comboBox, Label label, string yazi)
        {
            bool sonuc = false;
            
            if(comboBox.SelectedIndex == 0)
            {             
                label.Text = yazi+" seçiniz";
            }
            else
            {
                label.Text = "";
                sonuc = true;
            }
            return sonuc;
        }

        //------------------------------------------------------- HARF SAYI KONTROL ------------------------------------------------------------------
        public void HarfGir(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);       
        }
        public void SayiGir(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void KullaniciHarf(KeyPressEventArgs e)//Kullanici Adi Özel
        {
            e.Handled = !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_';
        }
        public void EpostaHarf(KeyPressEventArgs e)//E-Posta Özel
        {
            e.Handled = !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '@' && e.KeyChar != '-' && e.KeyChar != '_';
        }

        //------------------------------------------------------- KARAKTER KONTROL ------------------------------------------------------------------
        public bool KarakterKontrol(TextBox textBox, int x, int y, Label label)
        {
            bool sonuc = false;

            if (textBox.Text.Length > x && textBox.Text.Length < y)
            {
                label.Text = "Eksik Karakter!";
            }          
            else
            {
                label.Text = "";
                sonuc = true;
            }
            return sonuc;
        }
   
        //------------------------------------------------------- TELEFON KONTROL -----------------------------------------------------------------------
        public  bool TelefonFormatKontrol(string Telefon)
        {
            string RegexDesen = @"^(05(\d{9}))$";
            Match Eslesme = Regex.Match(Telefon, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success; // bool değer döner
        }
        public bool TelefonFormatKontrolFirma(string Telefon)
        {
            string RegexDesen = @"^(0(\d{10}))$";
            Match Eslesme = Regex.Match(Telefon, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success; // bool değer döner
        }
        //------------------------------------------------------------E-POSTA KONTROL --------------------------------------------------------------------------
        public static bool epostaTest(string eposta)
        {
            try
            {
                MailAddress mail = new MailAddress(eposta);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EpostaKontrol(TextBox textBox, Label label)
        {
            bool sonuc = false;

            if (epostaTest(textBox.Text) == true)
            {
                label.Text = "";
                sonuc = true;
            }
            else
            {
                label.Text = "Geçersiz E-Posta";
            }
            return sonuc;
        }
        //-------------------------------------------------------------------------------------------------------------
        public bool KullaniciAdiKontrol(TextBox textBox,Label label)
        {
            bool sonuc = false;
            var m = Regex.Match(textBox.Text, @"((?=.*[a-z]))");
            if (!string.IsNullOrEmpty(textBox.Text) && !m.Success)
            {
                label.Text = "Harf giriniz";
                sonuc = false;
            }
            else
            {
                sonuc = true;
            }
            return sonuc;
        }
        public void Giris(TextBox textBox, Label label, string yazi)
        {
            if (string.IsNullOrEmpty(textBox.Text) || textBox.Text == yazi)
            {
                label.Text = "";
            }
        }
    }
}
