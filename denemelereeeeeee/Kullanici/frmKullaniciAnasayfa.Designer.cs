namespace AkaStormProje
{
    partial class frmKullaniciAnasayfa
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
            this.panAlt = new System.Windows.Forms.Panel();
            this.panUst = new System.Windows.Forms.Panel();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnGoruslerim = new System.Windows.Forms.Button();
            this.btnKutuphane = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.linkBakiye = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.panUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // panAlt
            // 
            this.panAlt.Location = new System.Drawing.Point(0, 150);
            this.panAlt.Name = "panAlt";
            this.panAlt.Size = new System.Drawing.Size(1200, 650);
            this.panAlt.TabIndex = 2;
            // 
            // panUst
            // 
            this.panUst.BackgroundImage = global::AkaStormProje.Properties.Resources.KullaniciVeFirmaAnasayfa;
            this.panUst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panUst.Controls.Add(this.lblBakiye);
            this.panUst.Controls.Add(this.lblKullaniciAdi);
            this.panUst.Controls.Add(this.lblTarih);
            this.panUst.Controls.Add(this.btnProfil);
            this.panUst.Controls.Add(this.btnGoruslerim);
            this.panUst.Controls.Add(this.btnKutuphane);
            this.panUst.Controls.Add(this.btnAnasayfa);
            this.panUst.Controls.Add(this.btnExit);
            this.panUst.Controls.Add(this.linkBakiye);
            this.panUst.Controls.Add(this.label4);
            this.panUst.Controls.Add(this.label10);
            this.panUst.Controls.Add(this.label1);
            this.panUst.Controls.Add(this.pbResim);
            this.panUst.Location = new System.Drawing.Point(0, 0);
            this.panUst.Name = "panUst";
            this.panUst.Size = new System.Drawing.Size(1200, 150);
            this.panUst.TabIndex = 0;
            this.panUst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panUst_MouseDown);
            this.panUst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panUst_MouseMove);
            this.panUst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panUst_MouseUp);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.lblBakiye.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lblBakiye.Location = new System.Drawing.Point(412, 108);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(44, 15);
            this.lblBakiye.TabIndex = 16;
            this.lblBakiye.Text = "label6";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(250, 70);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(44, 15);
            this.lblKullaniciAdi.TabIndex = 15;
            this.lblKullaniciAdi.Text = "label5";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lblTarih.Location = new System.Drawing.Point(405, 31);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(44, 15);
            this.lblTarih.TabIndex = 14;
            this.lblTarih.Text = "label4";
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
            this.btnProfil.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.btnProfil.Image = global::AkaStormProje.Properties.Resources.Profil1;
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProfil.Location = new System.Drawing.Point(1019, 36);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(154, 79);
            this.btnProfil.TabIndex = 13;
            this.btnProfil.Text = "Profil";
            this.btnProfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            this.btnProfil.MouseLeave += new System.EventHandler(this.btnProfil_MouseLeave);
            this.btnProfil.MouseHover += new System.EventHandler(this.btnProfil_MouseHover);
            // 
            // btnGoruslerim
            // 
            this.btnGoruslerim.BackColor = System.Drawing.Color.Transparent;
            this.btnGoruslerim.BackgroundImage = global::AkaStormProje.Properties.Resources.BtnLeave;
            this.btnGoruslerim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoruslerim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnGoruslerim.FlatAppearance.BorderSize = 0;
            this.btnGoruslerim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnGoruslerim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnGoruslerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoruslerim.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.btnGoruslerim.Image = global::AkaStormProje.Properties.Resources.Like;
            this.btnGoruslerim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGoruslerim.Location = new System.Drawing.Point(849, 36);
            this.btnGoruslerim.Name = "btnGoruslerim";
            this.btnGoruslerim.Size = new System.Drawing.Size(154, 79);
            this.btnGoruslerim.TabIndex = 12;
            this.btnGoruslerim.Text = "Görüşlerim";
            this.btnGoruslerim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGoruslerim.UseVisualStyleBackColor = false;
            this.btnGoruslerim.Click += new System.EventHandler(this.btnGoruslerim_Click);
            this.btnGoruslerim.MouseLeave += new System.EventHandler(this.btnGoruslerim_MouseLeave);
            this.btnGoruslerim.MouseHover += new System.EventHandler(this.btnGoruslerim_MouseHover);
            // 
            // btnKutuphane
            // 
            this.btnKutuphane.BackColor = System.Drawing.Color.Transparent;
            this.btnKutuphane.BackgroundImage = global::AkaStormProje.Properties.Resources.BtnLeave;
            this.btnKutuphane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKutuphane.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnKutuphane.FlatAppearance.BorderSize = 0;
            this.btnKutuphane.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnKutuphane.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnKutuphane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKutuphane.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.btnKutuphane.Image = global::AkaStormProje.Properties.Resources.Library;
            this.btnKutuphane.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKutuphane.Location = new System.Drawing.Point(681, 36);
            this.btnKutuphane.Name = "btnKutuphane";
            this.btnKutuphane.Size = new System.Drawing.Size(154, 79);
            this.btnKutuphane.TabIndex = 11;
            this.btnKutuphane.Text = "Kütüphane";
            this.btnKutuphane.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKutuphane.UseVisualStyleBackColor = false;
            this.btnKutuphane.Click += new System.EventHandler(this.btnKutuphane_Click);
            this.btnKutuphane.MouseLeave += new System.EventHandler(this.btnKutuphane_MouseLeave);
            this.btnKutuphane.MouseHover += new System.EventHandler(this.btnKutuphane_MouseHover);
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
            this.btnAnasayfa.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.btnAnasayfa.Image = global::AkaStormProje.Properties.Resources.Home;
            this.btnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnasayfa.Location = new System.Drawing.Point(510, 36);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(154, 79);
            this.btnAnasayfa.TabIndex = 10;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.MouseLeave += new System.EventHandler(this.btnAnasayfa_MouseLeave);
            this.btnAnasayfa.MouseHover += new System.EventHandler(this.btnAnasayfa_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::AkaStormProje.Properties.Resources.çarpı;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1161, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // linkBakiye
            // 
            this.linkBakiye.AutoSize = true;
            this.linkBakiye.BackColor = System.Drawing.Color.Transparent;
            this.linkBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold);
            this.linkBakiye.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.linkBakiye.Location = new System.Drawing.Point(401, 127);
            this.linkBakiye.Name = "linkBakiye";
            this.linkBakiye.Size = new System.Drawing.Size(69, 12);
            this.linkBakiye.TabIndex = 4;
            this.linkBakiye.TabStop = true;
            this.linkBakiye.Text = "Bakiye Yükle";
            this.linkBakiye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBakiye_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(348, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bakiye :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(349, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tarih :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(151, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(25, 17);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(110, 117);
            this.pbResim.TabIndex = 0;
            this.pbResim.TabStop = false;
            // 
            // frmKullaniciAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panAlt);
            this.Controls.Add(this.panUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmKullaniciAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKullaniciAnasayfa";
            this.Load += new System.EventHandler(this.frmKullaniciAnasayfa_Load);
            this.panUst.ResumeLayout(false);
            this.panUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panUst;
        private System.Windows.Forms.Panel panAlt;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkBakiye;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnGoruslerim;
        private System.Windows.Forms.Button btnKutuphane;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblTarih;
    }
}