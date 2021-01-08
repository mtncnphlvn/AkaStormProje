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
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnGoruslerim = new System.Windows.Forms.Button();
            this.btnKutuphane = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panUst.Controls.Add(this.btnProfil);
            this.panUst.Controls.Add(this.btnGoruslerim);
            this.panUst.Controls.Add(this.btnKutuphane);
            this.panUst.Controls.Add(this.btnAnasayfa);
            this.panUst.Controls.Add(this.btnExit);
            this.panUst.Controls.Add(this.linkLabel1);
            this.panUst.Controls.Add(this.label3);
            this.panUst.Controls.Add(this.label2);
            this.panUst.Controls.Add(this.label1);
            this.panUst.Controls.Add(this.pictureBox1);
            this.panUst.Location = new System.Drawing.Point(0, 0);
            this.panUst.Name = "panUst";
            this.panUst.Size = new System.Drawing.Size(1200, 150);
            this.panUst.TabIndex = 0;
            this.panUst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panUst_MouseDown);
            this.panUst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panUst_MouseMove);
            this.panUst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panUst_MouseUp);
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
            this.btnProfil.Location = new System.Drawing.Point(1019, 36);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(154, 79);
            this.btnProfil.TabIndex = 13;
            this.btnProfil.Text = "Profil";
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
            this.btnGoruslerim.Location = new System.Drawing.Point(849, 36);
            this.btnGoruslerim.Name = "btnGoruslerim";
            this.btnGoruslerim.Size = new System.Drawing.Size(154, 79);
            this.btnGoruslerim.TabIndex = 12;
            this.btnGoruslerim.Text = "Görüşlerim";
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
            this.btnKutuphane.Location = new System.Drawing.Point(681, 36);
            this.btnKutuphane.Name = "btnKutuphane";
            this.btnKutuphane.Size = new System.Drawing.Size(154, 79);
            this.btnKutuphane.TabIndex = 11;
            this.btnKutuphane.Text = "Kütüphane";
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
            this.btnAnasayfa.Location = new System.Drawing.Point(510, 36);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(154, 79);
            this.btnAnasayfa.TabIndex = 10;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.MouseLeave += new System.EventHandler(this.btnAnasayfa_MouseLeave);
            this.btnAnasayfa.MouseHover += new System.EventHandler(this.btnAnasayfa_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1164, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(415, 126);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "TL Yükle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bakiye :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panUst;
        private System.Windows.Forms.Panel panAlt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnGoruslerim;
        private System.Windows.Forms.Button btnKutuphane;
        private System.Windows.Forms.Button btnAnasayfa;
    }
}