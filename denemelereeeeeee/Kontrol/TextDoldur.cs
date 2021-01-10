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

namespace AkaStormProje
{
    class TextDoldur
    {
        public  void TextEnter(TextBox text, string yazi)
        {
            if (text.Text == yazi)
            {
                text.Text = "";
                Color myRgbColor = new Color();
                myRgbColor = Color.FromArgb(50, 100, 150);
                text.ForeColor = myRgbColor;
            }
        }
        public void TextLeave(TextBox textBox, string yazi)
        {
            if (textBox.Text == "")
            {
                textBox.Text = yazi;
                textBox.ForeColor = Color.Silver;
            }
        }
        public void SifreEnter(TextBox textBox, string yazi)
        {
            if (textBox.Text == yazi)
            {
                textBox.Text = "";
                Color myRgbColor = new Color();
                myRgbColor = Color.FromArgb(50, 100, 150);
                textBox.ForeColor = myRgbColor;
                textBox.PasswordChar = '*';
            }
        }
        char? none = null;
        public void SifreLeave(TextBox textBox, string yazi)
        {
            if (textBox.Text == "")
            {
                textBox.Text = yazi;
                textBox.ForeColor = Color.Silver;
                textBox.PasswordChar = Convert.ToChar(none);
            }
        }
    }
}
