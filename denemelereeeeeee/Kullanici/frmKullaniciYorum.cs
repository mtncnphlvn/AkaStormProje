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
    public partial class frmKullaniciYorum : Form
    {
        public frmKullaniciYorum()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnYorum_MouseHover(object sender, EventArgs e)
        {
            btnYorum.BackgroundImage = Properties.Resources.BtnHvr;

        }

        private void btnYorum_MouseLeave(object sender, EventArgs e)
        {
            btnYorum.BackgroundImage = Properties.Resources.BtnLeave;
        }

        private void btnYorum_Click(object sender, EventArgs e)
        {
            KullaniciYorum kullaniciYorum = new KullaniciYorum();
            string mesaj = rtxtMesaj.Text;

            if (rtxtMesaj.Text != "" && kullaniciYorum.YorumEkle(mesaj) == true)
            {
                this.Hide();
 
            }
        }
    }
}
