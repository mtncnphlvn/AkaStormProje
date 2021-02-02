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
    public partial class frmKullaniciGoruslerim : Form
    {
        public frmKullaniciGoruslerim()
        {
            InitializeComponent();
        }

        private void frmKullaniciGoruslerim_Load(object sender, EventArgs e)
        {
            KullaniciYorum kullaniciYorum = new KullaniciYorum();
            kullaniciYorum.YorumlarKullanici(dataGridView1);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
