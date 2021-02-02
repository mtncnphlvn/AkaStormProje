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
    public partial class frmKullaniciPuan : Form
    {
        public frmKullaniciPuan()
        {
            InitializeComponent();
        }
        KullaniciYorum kullaniciYorum = new KullaniciYorum();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kullaniciYorum.PuanVer(1);
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kullaniciYorum.PuanVer(2);
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            kullaniciYorum.PuanVer(3);
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            kullaniciYorum.PuanVer(4);
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            kullaniciYorum.PuanVer(5);
            this.Hide();

        }
    }
}
