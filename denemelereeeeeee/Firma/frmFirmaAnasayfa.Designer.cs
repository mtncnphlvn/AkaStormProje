namespace AkaStormProje
{
    partial class frmFirmaAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirmaAnasayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panUst = new System.Windows.Forms.Panel();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnOyunEkle = new System.Windows.Forms.Button();
            this.btnOyunlarim = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.panAlt = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bakiye :";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(228, 71);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(35, 13);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "label4";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(389, 32);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(35, 13);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "label4";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(389, 109);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(35, 13);
            this.lblBakiye.TabIndex = 5;
            this.lblBakiye.Text = "label4";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1173, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 29);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panUst
            // 
            this.panUst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panUst.BackgroundImage")));
            this.panUst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panUst.Controls.Add(this.linkLabel1);
            this.panUst.Controls.Add(this.pbResim);
            this.panUst.Controls.Add(this.btnProfil);
            this.panUst.Controls.Add(this.btnExit);
            this.panUst.Controls.Add(this.btnOyunEkle);
            this.panUst.Controls.Add(this.label1);
            this.panUst.Controls.Add(this.btnOyunlarim);
            this.panUst.Controls.Add(this.lblKullaniciAdi);
            this.panUst.Controls.Add(this.btnAnasayfa);
            this.panUst.Controls.Add(this.label2);
            this.panUst.Controls.Add(this.lblTarih);
            this.panUst.Controls.Add(this.label3);
            this.panUst.Controls.Add(this.lblBakiye);
            this.panUst.Location = new System.Drawing.Point(0, 0);
            this.panUst.Name = "panUst";
            this.panUst.Size = new System.Drawing.Size(1200, 150);
            this.panUst.TabIndex = 12;
            this.panUst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panUst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panUst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(26, 17);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(110, 117);
            this.pbResim.TabIndex = 11;
            this.pbResim.TabStop = false;
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.Transparent;
            this.btnProfil.BackgroundImage = global::AkaStormProje.Properties.Resources.BtnLeave;
            this.btnProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnProfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Location = new System.Drawing.Point(1019, 38);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(154, 79);
            this.btnProfil.TabIndex = 9;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            this.btnProfil.MouseLeave += new System.EventHandler(this.btnProfil_MouseLeave);
            this.btnProfil.MouseHover += new System.EventHandler(this.btnProfil_MouseHover);
            // 
            // btnOyunEkle
            // 
            this.btnOyunEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnOyunEkle.BackgroundImage = global::AkaStormProje.Properties.Resources.BtnLeave;
            this.btnOyunEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOyunEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnOyunEkle.FlatAppearance.BorderSize = 0;
            this.btnOyunEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnOyunEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnOyunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOyunEkle.Location = new System.Drawing.Point(849, 38);
            this.btnOyunEkle.Name = "btnOyunEkle";
            this.btnOyunEkle.Size = new System.Drawing.Size(154, 79);
            this.btnOyunEkle.TabIndex = 8;
            this.btnOyunEkle.Text = "Oyun Ekle";
            this.btnOyunEkle.UseVisualStyleBackColor = false;
            this.btnOyunEkle.Click += new System.EventHandler(this.btnOyunEkle_Click);
            this.btnOyunEkle.MouseLeave += new System.EventHandler(this.btnOyunEkle_MouseLeave);
            this.btnOyunEkle.MouseHover += new System.EventHandler(this.btnOyunEkle_MouseHover);
            // 
            // btnOyunlarim
            // 
            this.btnOyunlarim.BackColor = System.Drawing.Color.Transparent;
            this.btnOyunlarim.BackgroundImage = global::AkaStormProje.Properties.Resources.BtnLeave;
            this.btnOyunlarim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOyunlarim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnOyunlarim.FlatAppearance.BorderSize = 0;
            this.btnOyunlarim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnOyunlarim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnOyunlarim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOyunlarim.Location = new System.Drawing.Point(681, 38);
            this.btnOyunlarim.Name = "btnOyunlarim";
            this.btnOyunlarim.Size = new System.Drawing.Size(154, 79);
            this.btnOyunlarim.TabIndex = 7;
            this.btnOyunlarim.Text = "Oyunlarım";
            this.btnOyunlarim.UseVisualStyleBackColor = false;
            this.btnOyunlarim.Click += new System.EventHandler(this.btnOyunlarim_Click);
            this.btnOyunlarim.MouseLeave += new System.EventHandler(this.btnOyunlarim_MouseLeave);
            this.btnOyunlarim.MouseHover += new System.EventHandler(this.btnOyunlarim_MouseHover);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.btnAnasayfa.BackgroundImage = global::AkaStormProje.Properties.Resources.BtnLeave;
            this.btnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnasayfa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnAnasayfa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Location = new System.Drawing.Point(510, 38);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(154, 79);
            this.btnAnasayfa.TabIndex = 6;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.MouseLeave += new System.EventHandler(this.btnAnasayfa_MouseLeave);
            this.btnAnasayfa.MouseHover += new System.EventHandler(this.btnAnasayfa_MouseHover);
            // 
            // panAlt
            // 
            this.panAlt.BackColor = System.Drawing.Color.White;
            this.panAlt.Location = new System.Drawing.Point(0, 150);
            this.panAlt.Name = "panAlt";
            this.panAlt.Size = new System.Drawing.Size(1200, 650);
            this.panAlt.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(420, 126);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "TL Yükle";
            // 
            // frmFirmaAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panAlt);
            this.Controls.Add(this.panUst);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmFirmaAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFirmaAnasayfa";
            this.Load += new System.EventHandler(this.frmFirmaAnasayfa_Load);
            this.panUst.ResumeLayout(false);
            this.panUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Button btnOyunlarim;
        private System.Windows.Forms.Button btnOyunEkle;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Panel panUst;
        private System.Windows.Forms.Panel panAlt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblKullaniciAdi;
    }
}