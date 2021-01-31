namespace AkaStormProje
{
    partial class frmOyunlarim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblonay = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.RichTextBox();
            this.txtOyunAdi = new System.Windows.Forms.RichTextBox();
            this.pbOyunResim = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOyunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblFirmaAdi);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 650);
            this.panel1.TabIndex = 1;
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 53F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaAdi.Location = new System.Drawing.Point(280, 55);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(339, 81);
            this.lblFirmaAdi.TabIndex = 1;
            this.lblFirmaAdi.Text = "Firma Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 440);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.panel2.Controls.Add(this.lblonay);
            this.panel2.Controls.Add(this.btnGüncelle);
            this.panel2.Controls.Add(this.cmbKategori);
            this.panel2.Controls.Add(this.txtFiyat);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtKonu);
            this.panel2.Controls.Add(this.txtOyunAdi);
            this.panel2.Controls.Add(this.pbOyunResim);
            this.panel2.Location = new System.Drawing.Point(950, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 650);
            this.panel2.TabIndex = 2;
            // 
            // lblonay
            // 
            this.lblonay.AutoSize = true;
            this.lblonay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblonay.Location = new System.Drawing.Point(31, 613);
            this.lblonay.Name = "lblonay";
            this.lblonay.Size = new System.Drawing.Size(0, 17);
            this.lblonay.TabIndex = 42;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackgroundImage = global::AkaStormProje.Properties.Resources.BtnLeave;
            this.btnGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGüncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnGüncelle.FlatAppearance.BorderSize = 0;
            this.btnGüncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnGüncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGüncelle.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btnGüncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnGüncelle.Location = new System.Drawing.Point(64, 528);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(117, 59);
            this.btnGüncelle.TabIndex = 41;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            this.btnGüncelle.MouseLeave += new System.EventHandler(this.btnGüncelle_MouseLeave);
            this.btnGüncelle.MouseHover += new System.EventHandler(this.btnGüncelle_MouseHover);
            // 
            // cmbKategori
            // 
            this.cmbKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(113, 420);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(99, 21);
            this.cmbKategori.TabIndex = 40;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(113, 457);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 39;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label6.Location = new System.Drawing.Point(44, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 28);
            this.label6.TabIndex = 38;
            this.label6.Text = "Fiyat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label2.Location = new System.Drawing.Point(16, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Kategori :";
            // 
            // txtKonu
            // 
            this.txtKonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.txtKonu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKonu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonu.Location = new System.Drawing.Point(34, 332);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(189, 75);
            this.txtKonu.TabIndex = 32;
            this.txtKonu.Text = "Konu : Mükemmel bir savaş Simulasyonu";
            // 
            // txtOyunAdi
            // 
            this.txtOyunAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.txtOyunAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOyunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOyunAdi.Location = new System.Drawing.Point(34, 224);
            this.txtOyunAdi.Name = "txtOyunAdi";
            this.txtOyunAdi.Size = new System.Drawing.Size(189, 102);
            this.txtOyunAdi.TabIndex = 31;
            this.txtOyunAdi.Text = "           Arma 3";
            // 
            // pbOyunResim
            // 
            this.pbOyunResim.BackColor = System.Drawing.Color.White;
            this.pbOyunResim.Location = new System.Drawing.Point(34, 34);
            this.pbOyunResim.Name = "pbOyunResim";
            this.pbOyunResim.Size = new System.Drawing.Size(189, 184);
            this.pbOyunResim.TabIndex = 30;
            this.pbOyunResim.TabStop = false;
            // 
            // frmOyunlarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOyunlarim";
            this.Text = "frmOyunlarim";
            this.Load += new System.EventHandler(this.frmOyunlarim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOyunResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtKonu;
        private System.Windows.Forms.RichTextBox txtOyunAdi;
        private System.Windows.Forms.PictureBox pbOyunResim;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.Label lblonay;
    }
}