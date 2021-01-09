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
    public partial class frmSozlesme : Form
    {
        public frmSozlesme()
        {
            InitializeComponent();
        }

        private void btnOkudum_MouseHover(object sender, EventArgs e)
        {
            btnOkudum.BackgroundImage = Properties.Resources.BtnHvr;
        }

        private void btnOkudum_MouseLeave(object sender, EventArgs e)
        {
            btnOkudum.BackgroundImage = Properties.Resources.BtnLeave;
        }

        private void btnOkudum_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void frmSozlesme_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmSozlesme_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void frmSozlesme_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
