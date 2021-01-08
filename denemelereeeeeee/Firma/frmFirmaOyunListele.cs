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
    public partial class frmFirmaOyunListele : Form
    {
        public frmFirmaOyunListele()
        {
            InitializeComponent();
        }       
        //--------------------------------load----------------------------
        private void frmFirmaOyunListele_Load(object sender, EventArgs e)
        {
            panFiltre.Visible = false;
        }
        //----------------------------------txtAdFiltre----------------------------------
        TextDoldur textDoldur = new TextDoldur();
        private void txtAdFiltre_Enter(object sender, EventArgs e)
        {
            textDoldur.TextEnter(txtAdFiltre, "İsme göre ara");
        }
        private void txtAdFiltre_Leave(object sender, EventArgs e)
        {
            textDoldur.TextLeave(txtAdFiltre, "İsme göre ara");
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            panFiltre.Visible = true;
        }
        //-----------------------btnFiltre Olaylar----------------------------------------
        private void btnFiltre_MouseHover(object sender, EventArgs e)
        {
            btnFiltre.BackgroundImage = Properties.Resources.btnFiltreHover;
        }
        private void btnFiltre_MouseLeave(object sender, EventArgs e)
        {
            btnFiltre.BackgroundImage = Properties.Resources.btnFiltre1;
        }
        //-----------------------btnFiltre2 Olaylar----------------------------------------
        private void btnFiltre2_MouseHover(object sender, EventArgs e)
        {
            btnFiltre2.BackgroundImage = Properties.Resources.btnFiltreHover;
        }
        private void btnFiltre2_MouseLeave(object sender, EventArgs e)
        {
            btnFiltre2.BackgroundImage = Properties.Resources.btnFiltre1;
        }
        //----------------------------btnFiltreExit--------------------
        private void btnFiltreExit_Click(object sender, EventArgs e)
        {
            panFiltre.Visible = true;
        }
    }
}
