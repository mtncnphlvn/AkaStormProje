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
            this.panAlt = new System.Windows.Forms.Panel();
            this.panUst = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOyunEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOyunlarim = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.panUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // panAlt
            // 
            this.panAlt.BackColor = System.Drawing.Color.White;
            this.panAlt.Location = new System.Drawing.Point(0, 150);
            this.panAlt.Name = "panAlt";
            this.panAlt.Size = new System.Drawing.Size(1200, 650);
            this.panAlt.TabIndex = 13;
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.linkLabel1.Location = new System.Drawing.Point(406, 126);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 12);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bakiye Yükle";
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
            this.btnProfil.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfil.Image = ((System.Drawing.Image)(resources.GetObject("btnProfil.Image")));
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProfil.Location = new System.Drawing.Point(1019, 38);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(154, 79);
            this.btnProfil.TabIndex = 9;
            this.btnProfil.Text = "Profil";
            this.btnProfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            this.btnProfil.MouseLeave += new System.EventHandler(this.btnProfil_MouseLeave);
            this.btnProfil.MouseHover += new System.EventHandler(this.btnProfil_MouseHover);
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
            this.btnExit.Location = new System.Drawing.Point(1161, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 30);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnOyunEkle.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyunEkle.Image = global::AkaStormProje.Properties.Resources.GameAdd;
            this.btnOyunEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOyunEkle.Location = new System.Drawing.Point(849, 38);
            this.btnOyunEkle.Name = "btnOyunEkle";
            this.btnOyunEkle.Size = new System.Drawing.Size(154, 79);
            this.btnOyunEkle.TabIndex = 8;
            this.btnOyunEkle.Text = "Oyun Ekle";
            this.btnOyunEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOyunEkle.UseVisualStyleBackColor = false;
            this.btnOyunEkle.Click += new System.EventHandler(this.btnOyunEkle_Click);
            this.btnOyunEkle.MouseLeave += new System.EventHandler(this.btnOyunEkle_MouseLeave);
            this.btnOyunEkle.MouseHover += new System.EventHandler(this.btnOyunEkle_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
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
            this.btnOyunlarim.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyunlarim.Image = global::AkaStormProje.Properties.Resources.Game;
            this.btnOyunlarim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOyunlarim.Location = new System.Drawing.Point(681, 38);
            this.btnOyunlarim.Name = "btnOyunlarim";
            this.btnOyunlarim.Size = new System.Drawing.Size(154, 79);
            this.btnOyunlarim.TabIndex = 7;
            this.btnOyunlarim.Text = "Oyunlarım";
            this.btnOyunlarim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOyunlarim.UseVisualStyleBackColor = false;
            this.btnOyunlarim.Click += new System.EventHandler(this.btnOyunlarim_Click);
            this.btnOyunlarim.MouseLeave += new System.EventHandler(this.btnOyunlarim_MouseLeave);
            this.btnOyunlarim.MouseHover += new System.EventHandler(this.btnOyunlarim_MouseHover);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(250, 70);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(44, 15);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "label4";
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
            this.btnAnasayfa.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.Image = global::AkaStormProje.Properties.Resources.Home;
            this.btnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnasayfa.Location = new System.Drawing.Point(512, 38);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(154, 79);
            this.btnAnasayfa.TabIndex = 6;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.MouseLeave += new System.EventHandler(this.btnAnasayfa_MouseLeave);
            this.btnAnasayfa.MouseHover += new System.EventHandler(this.btnAnasayfa_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(347, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih :";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(403, 31);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(44, 15);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(346, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bakiye :";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.lblBakiye.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(405, 108);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(44, 15);
            this.lblBakiye.TabIndex = 5;
            this.lblBakiye.Text = "label4";
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