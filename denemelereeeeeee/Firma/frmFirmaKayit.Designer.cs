
namespace AkaStormProje
{
    partial class frmFirmaKayit
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtCeo = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.lblFirmaAdiUyari = new System.Windows.Forms.Label();
            this.lblCeoUyari = new System.Windows.Forms.Label();
            this.lblEpostaUyari = new System.Windows.Forms.Label();
            this.lblTelefonUyari = new System.Windows.Forms.Label();
            this.lblSifreUyari = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lblChxUyari = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chxOnay = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(439, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtFirmaAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirmaAdi.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaAdi.ForeColor = System.Drawing.Color.Silver;
            this.txtFirmaAdi.Location = new System.Drawing.Point(77, 209);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(261, 22);
            this.txtFirmaAdi.TabIndex = 1;
            this.txtFirmaAdi.Text = "Firma Adı";
            this.txtFirmaAdi.TextChanged += new System.EventHandler(this.txtFirmaAdi_TextChanged);
            this.txtFirmaAdi.Enter += new System.EventHandler(this.txtFirmaAdi_Enter);
            this.txtFirmaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirmaAdi_KeyPress);
            this.txtFirmaAdi.Leave += new System.EventHandler(this.txtFirmaAdi_Leave);
            // 
            // txtCeo
            // 
            this.txtCeo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtCeo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCeo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCeo.ForeColor = System.Drawing.Color.Silver;
            this.txtCeo.Location = new System.Drawing.Point(78, 253);
            this.txtCeo.Name = "txtCeo";
            this.txtCeo.Size = new System.Drawing.Size(261, 22);
            this.txtCeo.TabIndex = 2;
            this.txtCeo.Text = "Ceo";
            this.txtCeo.TextChanged += new System.EventHandler(this.txtCeo_TextChanged);
            this.txtCeo.Enter += new System.EventHandler(this.txtCeo_Enter);
            this.txtCeo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCeo_KeyPress);
            this.txtCeo.Leave += new System.EventHandler(this.txtCeo_Leave);
            // 
            // txtEposta
            // 
            this.txtEposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtEposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEposta.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.ForeColor = System.Drawing.Color.Silver;
            this.txtEposta.Location = new System.Drawing.Point(78, 294);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(261, 22);
            this.txtEposta.TabIndex = 3;
            this.txtEposta.Text = "E-Posta";
            this.txtEposta.Enter += new System.EventHandler(this.txtEposta_Enter);
            this.txtEposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEposta_KeyPress);
            this.txtEposta.Leave += new System.EventHandler(this.txtEposta_Leave);
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtTelefonNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonNo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefonNo.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefonNo.Location = new System.Drawing.Point(77, 335);
            this.txtTelefonNo.MaxLength = 11;
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(261, 22);
            this.txtTelefonNo.TabIndex = 4;
            this.txtTelefonNo.Text = "Telefon Numarası";
            this.txtTelefonNo.TextChanged += new System.EventHandler(this.txtTelefonNo_TextChanged);
            this.txtTelefonNo.Enter += new System.EventHandler(this.txtTelefonNo_Enter);
            this.txtTelefonNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonNo_KeyPress);
            this.txtTelefonNo.Leave += new System.EventHandler(this.txtTelefonNo_Leave);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.Silver;
            this.txtSifre.Location = new System.Drawing.Point(77, 380);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(261, 22);
            this.txtSifre.TabIndex = 5;
            this.txtSifre.Text = "Şifre (En az 8 Haneli)";
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtSifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifreTekrar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreTekrar.ForeColor = System.Drawing.Color.Silver;
            this.txtSifreTekrar.Location = new System.Drawing.Point(77, 424);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(261, 22);
            this.txtSifreTekrar.TabIndex = 6;
            this.txtSifreTekrar.Text = "Şifre Tekrar";
            this.txtSifreTekrar.TextChanged += new System.EventHandler(this.txtSifreTekrar_TextChanged);
            this.txtSifreTekrar.Enter += new System.EventHandler(this.txtSifreTekrar_Enter);
            this.txtSifreTekrar.Leave += new System.EventHandler(this.txtSifreTekrar_Leave);
            // 
            // lblFirmaAdiUyari
            // 
            this.lblFirmaAdiUyari.AutoSize = true;
            this.lblFirmaAdiUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblFirmaAdiUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaAdiUyari.ForeColor = System.Drawing.Color.Black;
            this.lblFirmaAdiUyari.Location = new System.Drawing.Point(361, 212);
            this.lblFirmaAdiUyari.Name = "lblFirmaAdiUyari";
            this.lblFirmaAdiUyari.Size = new System.Drawing.Size(0, 19);
            this.lblFirmaAdiUyari.TabIndex = 7;
            // 
            // lblCeoUyari
            // 
            this.lblCeoUyari.AutoSize = true;
            this.lblCeoUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblCeoUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCeoUyari.ForeColor = System.Drawing.Color.Black;
            this.lblCeoUyari.Location = new System.Drawing.Point(361, 256);
            this.lblCeoUyari.Name = "lblCeoUyari";
            this.lblCeoUyari.Size = new System.Drawing.Size(0, 19);
            this.lblCeoUyari.TabIndex = 8;
            // 
            // lblEpostaUyari
            // 
            this.lblEpostaUyari.AutoSize = true;
            this.lblEpostaUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblEpostaUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEpostaUyari.ForeColor = System.Drawing.Color.Black;
            this.lblEpostaUyari.Location = new System.Drawing.Point(361, 297);
            this.lblEpostaUyari.Name = "lblEpostaUyari";
            this.lblEpostaUyari.Size = new System.Drawing.Size(0, 19);
            this.lblEpostaUyari.TabIndex = 9;
            // 
            // lblTelefonUyari
            // 
            this.lblTelefonUyari.AutoSize = true;
            this.lblTelefonUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblTelefonUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefonUyari.ForeColor = System.Drawing.Color.Black;
            this.lblTelefonUyari.Location = new System.Drawing.Point(361, 338);
            this.lblTelefonUyari.Name = "lblTelefonUyari";
            this.lblTelefonUyari.Size = new System.Drawing.Size(0, 19);
            this.lblTelefonUyari.TabIndex = 10;
            // 
            // lblSifreUyari
            // 
            this.lblSifreUyari.AutoSize = true;
            this.lblSifreUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblSifreUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreUyari.ForeColor = System.Drawing.Color.Black;
            this.lblSifreUyari.Location = new System.Drawing.Point(361, 383);
            this.lblSifreUyari.Name = "lblSifreUyari";
            this.lblSifreUyari.Size = new System.Drawing.Size(0, 19);
            this.lblSifreUyari.TabIndex = 11;
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnKayit.BackgroundImage = global::AkaStormProje.Properties.Resources.BtnLeave;
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnKayit.FlatAppearance.BorderSize = 0;
            this.btnKayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnKayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnKayit.Location = new System.Drawing.Point(122, 551);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(160, 75);
            this.btnKayit.TabIndex = 13;
            this.btnKayit.Text = "GİRİŞ";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            this.btnKayit.MouseLeave += new System.EventHandler(this.btnKayit_MouseLeave);
            this.btnKayit.MouseHover += new System.EventHandler(this.btnKayit_MouseHover);
            // 
            // lblChxUyari
            // 
            this.lblChxUyari.AutoSize = true;
            this.lblChxUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblChxUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChxUyari.ForeColor = System.Drawing.Color.Black;
            this.lblChxUyari.Location = new System.Drawing.Point(288, 551);
            this.lblChxUyari.Name = "lblChxUyari";
            this.lblChxUyari.Size = new System.Drawing.Size(0, 19);
            this.lblChxUyari.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(32, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 62);
            this.label1.TabIndex = 15;
            this.label1.Text = "Geliştirici Kayıt";
            // 
            // chxOnay
            // 
            this.chxOnay.AutoSize = true;
            this.chxOnay.BackColor = System.Drawing.Color.Transparent;
            this.chxOnay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chxOnay.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chxOnay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.chxOnay.Location = new System.Drawing.Point(288, 490);
            this.chxOnay.Name = "chxOnay";
            this.chxOnay.Size = new System.Drawing.Size(169, 23);
            this.chxOnay.TabIndex = 16;
            this.chxOnay.Text = "KABUL EDİYORUM!!";
            this.chxOnay.UseVisualStyleBackColor = false;
            this.chxOnay.CheckedChanged += new System.EventHandler(this.chxOnay_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.linkLabel1.Location = new System.Drawing.Point(19, 489);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(271, 21);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Geliştirici Sözleşmesini Okudum..";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::AkaStormProje.Properties.Resources.BackLeave;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 32);
            this.btnBack.TabIndex = 19;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmFirmaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AkaStormProje.Properties.Resources.FirmaBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.chxOnay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.lblChxUyari);
            this.Controls.Add(this.lblSifreUyari);
            this.Controls.Add(this.lblTelefonUyari);
            this.Controls.Add(this.lblEpostaUyari);
            this.Controls.Add(this.lblCeoUyari);
            this.Controls.Add(this.lblFirmaAdiUyari);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtCeo);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFirmaKayit";
            this.Text = "frmFirmaKayit";
            this.Load += new System.EventHandler(this.frmFirmaKayit_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmFirmaKayit_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmFirmaKayit_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmFirmaKayit_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.TextBox txtCeo;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Label lblFirmaAdiUyari;
        private System.Windows.Forms.Label lblCeoUyari;
        private System.Windows.Forms.Label lblEpostaUyari;
        private System.Windows.Forms.Label lblTelefonUyari;
        private System.Windows.Forms.Label lblSifreUyari;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label lblChxUyari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chxOnay;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnBack;
    }
}