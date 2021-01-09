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
    public partial class frmOyunEkle : Form
    {
       

        public frmOyunEkle()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void btnEkle_MouseHover(object sender, EventArgs e)
        {
            btnEkle.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            btnEkle.BackgroundImage = Properties.Resources.BtnLeave;
        }
    }
}
