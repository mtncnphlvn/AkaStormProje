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
    public partial class frmOyunlarim : Form
    {
        public frmOyunlarim()
        {
            InitializeComponent();
        }
        private void btnGüncelle_MouseHover(object sender, EventArgs e)
        {
            btnGüncelle.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnGüncelle_MouseLeave(object sender, EventArgs e)
        {
            btnGüncelle.BackgroundImage = Properties.Resources.BtnLeave;
        }
    }
}
