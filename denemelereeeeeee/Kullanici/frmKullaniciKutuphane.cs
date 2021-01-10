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
    public partial class frmKullaniciKutuphane : Form
    {
        public frmKullaniciKutuphane()
        {
            InitializeComponent();
        }
        //--------------------------form load------------------------------
        private void frmKullaniciKutuphane_Load(object sender, EventArgs e)
        {
            panFiltre.Visible = false;
        }
        //-----------------------------txtAd--------------------------------------
        TextDoldur textDoldur = new TextDoldur();
        private void txtAdFiltre_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtAdFiltre, "İsme göre ara");
        }
        private void txtAdFiltre_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtAdFiltre, "İsme göre ara");
        }
        //-------------------------------------btnFiltre---------------------------------------------------
        private void btnFiltre_Click(object sender, EventArgs e)
        {
            panFiltre.Visible = true;
        }
        //------------------------btnFiltre Olay-----------------------------------------
        private void btnFiltre_MouseHover(object sender, EventArgs e)
        {
            btnFiltre.BackgroundImage = Properties.Resources.btnFiltreHover;
        }
        private void btnFiltre_MouseLeave(object sender, EventArgs e)
        {
            btnFiltre.BackgroundImage = Properties.Resources.btnFiltre1;
        }
        //------------------------------btnFitre2 olay--------------------------------------------
        private void btnFiltre2_MouseHover(object sender, EventArgs e)
        {
            btnFiltre2.BackgroundImage = Properties.Resources.btnFiltreHover;
        }
        private void btnFiltre2_MouseLeave(object sender, EventArgs e)
        {
            btnFiltre2.BackgroundImage = Properties.Resources.btnFiltre1;
        }
        //------------------------btnFiltreExit-------------------------------------------
        private void btnFiltreExit_Click(object sender, EventArgs e)
        {
            panFiltre.Visible = false;
        }
        private void btnPuan_MouseHover(object sender, EventArgs e)
        {
            btnPuan.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnPuan_MouseLeave(object sender, EventArgs e)
        {
            btnPuan.BackgroundImage = Properties.Resources.BtnLeave;
        }
        private void btnYorum_MouseHover(object sender, EventArgs e)
        {
            btnYorum.BackgroundImage = Properties.Resources.BtnHvr;
        }
        private void btnYorum_MouseLeave(object sender, EventArgs e)
        {
            btnYorum.BackgroundImage = Properties.Resources.BtnLeave;
        }
    }
}
