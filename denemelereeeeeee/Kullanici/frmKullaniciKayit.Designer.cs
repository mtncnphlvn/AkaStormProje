namespace AkaStormProje
{
    partial class frmKullaniciKayit
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.cmbGun = new System.Windows.Forms.ComboBox();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lblAdUyari = new System.Windows.Forms.Label();
            this.lblSoyadUyari = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblTarihUyari = new System.Windows.Forms.Label();
            this.lblCinsiyetUyari = new System.Windows.Forms.Label();
            this.lblTelefonUyari = new System.Windows.Forms.Label();
            this.lblEpostaUyari = new System.Windows.Forms.Label();
            this.lblKullaniciAdiUyari = new System.Windows.Forms.Label();
            this.lblSifreUyari = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.chxOnay = new System.Windows.Forms.CheckBox();
            this.lblChxUyari = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAd.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.ForeColor = System.Drawing.Color.Silver;
            this.txtAd.Location = new System.Drawing.Point(89, 199);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(258, 22);
            this.txtAd.TabIndex = 1;
            this.txtAd.Text = "Ad";
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            this.txtAd.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.ForeColor = System.Drawing.Color.Silver;
            this.txtSoyad.Location = new System.Drawing.Point(89, 236);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(258, 22);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.Text = "Soyad";
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            this.txtSoyad.Enter += new System.EventHandler(this.txtSoyad_Enter);
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            this.txtSoyad.Leave += new System.EventHandler(this.txtSoyad_Leave);
            // 
            // cmbGun
            // 
            this.cmbGun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.cmbGun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGun.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.cmbGun.FormattingEnabled = true;
            this.cmbGun.Location = new System.Drawing.Point(89, 270);
            this.cmbGun.Name = "cmbGun";
            this.cmbGun.Size = new System.Drawing.Size(71, 23);
            this.cmbGun.TabIndex = 3;
            this.cmbGun.SelectedIndexChanged += new System.EventHandler(this.cmbGun_SelectedIndexChanged);
            // 
            // cmbAy
            // 
            this.cmbAy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.cmbAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAy.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Location = new System.Drawing.Point(182, 270);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(73, 23);
            this.cmbAy.TabIndex = 4;
            this.cmbAy.SelectedIndexChanged += new System.EventHandler(this.cmbAy_SelectedIndexChanged);
            // 
            // cmbYil
            // 
            this.cmbYil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.cmbYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYil.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Location = new System.Drawing.Point(273, 271);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(72, 23);
            this.cmbYil.TabIndex = 5;
            this.cmbYil.SelectedIndexChanged += new System.EventHandler(this.cmbYil_SelectedIndexChanged);
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtTelefonNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonNo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefonNo.ForeColor = System.Drawing.Color.Silver;
            this.txtTelefonNo.Location = new System.Drawing.Point(89, 339);
            this.txtTelefonNo.MaxLength = 11;
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(258, 22);
            this.txtTelefonNo.TabIndex = 7;
            this.txtTelefonNo.Text = "Telefon Numarası";
            this.txtTelefonNo.TextChanged += new System.EventHandler(this.txtTelefonNo_TextChanged);
            this.txtTelefonNo.Enter += new System.EventHandler(this.txtTelefonNo_Enter);
            this.txtTelefonNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonNo_KeyPress);
            this.txtTelefonNo.Leave += new System.EventHandler(this.txtTelefonNo_Leave);
            // 
            // txtEposta
            // 
            this.txtEposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtEposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEposta.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.ForeColor = System.Drawing.Color.Silver;
            this.txtEposta.Location = new System.Drawing.Point(89, 372);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(258, 22);
            this.txtEposta.TabIndex = 8;
            this.txtEposta.Text = "E-Posta";
            this.txtEposta.Enter += new System.EventHandler(this.txtEposta_Enter);
            this.txtEposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEposta_KeyPress);
            this.txtEposta.Leave += new System.EventHandler(this.txtEposta_Leave);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Silver;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(89, 408);
            this.txtKullaniciAdi.MaxLength = 10;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(258, 22);
            this.txtKullaniciAdi.TabIndex = 9;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı";
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            this.txtKullaniciAdi.Enter += new System.EventHandler(this.txtKullaniciAdi_Enter);
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            this.txtKullaniciAdi.Leave += new System.EventHandler(this.txtKullaniciAdi_Leave);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.Silver;
            this.txtSifre.Location = new System.Drawing.Point(88, 441);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(258, 22);
            this.txtSifre.TabIndex = 10;
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
            this.txtSifreTekrar.Location = new System.Drawing.Point(89, 475);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(258, 22);
            this.txtSifreTekrar.TabIndex = 11;
            this.txtSifreTekrar.Text = "Şifre Tekrar";
            this.txtSifreTekrar.TextChanged += new System.EventHandler(this.txtSifreTekrar_TextChanged);
            this.txtSifreTekrar.Enter += new System.EventHandler(this.txtSifreTekrar_Enter);
            this.txtSifreTekrar.Leave += new System.EventHandler(this.txtSifreTekrar_Leave);
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
            this.btnKayit.Location = new System.Drawing.Point(142, 559);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(160, 75);
            this.btnKayit.TabIndex = 12;
            this.btnKayit.Text = "Giriş";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            this.btnKayit.MouseLeave += new System.EventHandler(this.btnKayit_MouseLeave);
            this.btnKayit.MouseHover += new System.EventHandler(this.btnKayit_MouseHover);
            // 
            // lblAdUyari
            // 
            this.lblAdUyari.AutoSize = true;
            this.lblAdUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblAdUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdUyari.ForeColor = System.Drawing.Color.Black;
            this.lblAdUyari.Location = new System.Drawing.Point(369, 203);
            this.lblAdUyari.Name = "lblAdUyari";
            this.lblAdUyari.Size = new System.Drawing.Size(0, 19);
            this.lblAdUyari.TabIndex = 9;
            // 
            // lblSoyadUyari
            // 
            this.lblSoyadUyari.AutoSize = true;
            this.lblSoyadUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblSoyadUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyadUyari.ForeColor = System.Drawing.Color.Black;
            this.lblSoyadUyari.Location = new System.Drawing.Point(370, 241);
            this.lblSoyadUyari.Name = "lblSoyadUyari";
            this.lblSoyadUyari.Size = new System.Drawing.Size(0, 19);
            this.lblSoyadUyari.TabIndex = 9;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCinsiyet.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(87, 306);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(258, 23);
            this.cmbCinsiyet.TabIndex = 6;
            this.cmbCinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbCinsiyet_SelectedIndexChanged);
            // 
            // lblTarihUyari
            // 
            this.lblTarihUyari.AutoSize = true;
            this.lblTarihUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblTarihUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihUyari.ForeColor = System.Drawing.Color.Black;
            this.lblTarihUyari.Location = new System.Drawing.Point(370, 280);
            this.lblTarihUyari.Name = "lblTarihUyari";
            this.lblTarihUyari.Size = new System.Drawing.Size(0, 19);
            this.lblTarihUyari.TabIndex = 9;
            // 
            // lblCinsiyetUyari
            // 
            this.lblCinsiyetUyari.AutoSize = true;
            this.lblCinsiyetUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblCinsiyetUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyetUyari.Location = new System.Drawing.Point(370, 314);
            this.lblCinsiyetUyari.Name = "lblCinsiyetUyari";
            this.lblCinsiyetUyari.Size = new System.Drawing.Size(0, 19);
            this.lblCinsiyetUyari.TabIndex = 9;
            // 
            // lblTelefonUyari
            // 
            this.lblTelefonUyari.AutoSize = true;
            this.lblTelefonUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblTelefonUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefonUyari.ForeColor = System.Drawing.Color.Black;
            this.lblTelefonUyari.Location = new System.Drawing.Point(369, 341);
            this.lblTelefonUyari.Name = "lblTelefonUyari";
            this.lblTelefonUyari.Size = new System.Drawing.Size(0, 19);
            this.lblTelefonUyari.TabIndex = 9;
            // 
            // lblEpostaUyari
            // 
            this.lblEpostaUyari.AutoSize = true;
            this.lblEpostaUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblEpostaUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEpostaUyari.ForeColor = System.Drawing.Color.Black;
            this.lblEpostaUyari.Location = new System.Drawing.Point(370, 377);
            this.lblEpostaUyari.Name = "lblEpostaUyari";
            this.lblEpostaUyari.Size = new System.Drawing.Size(0, 19);
            this.lblEpostaUyari.TabIndex = 9;
            // 
            // lblKullaniciAdiUyari
            // 
            this.lblKullaniciAdiUyari.AutoSize = true;
            this.lblKullaniciAdiUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblKullaniciAdiUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdiUyari.ForeColor = System.Drawing.Color.Black;
            this.lblKullaniciAdiUyari.Location = new System.Drawing.Point(370, 413);
            this.lblKullaniciAdiUyari.Name = "lblKullaniciAdiUyari";
            this.lblKullaniciAdiUyari.Size = new System.Drawing.Size(0, 19);
            this.lblKullaniciAdiUyari.TabIndex = 9;
            // 
            // lblSifreUyari
            // 
            this.lblSifreUyari.AutoSize = true;
            this.lblSifreUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblSifreUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreUyari.ForeColor = System.Drawing.Color.Black;
            this.lblSifreUyari.Location = new System.Drawing.Point(370, 451);
            this.lblSifreUyari.Name = "lblSifreUyari";
            this.lblSifreUyari.Size = new System.Drawing.Size(0, 19);
            this.lblSifreUyari.TabIndex = 9;
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
            // chxOnay
            // 
            this.chxOnay.AutoSize = true;
            this.chxOnay.Location = new System.Drawing.Point(218, 507);
            this.chxOnay.Name = "chxOnay";
            this.chxOnay.Size = new System.Drawing.Size(145, 17);
            this.chxOnay.TabIndex = 13;
            this.chxOnay.Text = "Okudum Kabul Ediyorum.";
            this.chxOnay.UseVisualStyleBackColor = true;
            this.chxOnay.CheckedChanged += new System.EventHandler(this.chxOnay_CheckedChanged);
            // 
            // lblChxUyari
            // 
            this.lblChxUyari.AutoSize = true;
            this.lblChxUyari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.lblChxUyari.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChxUyari.ForeColor = System.Drawing.Color.Black;
            this.lblChxUyari.Location = new System.Drawing.Point(289, 527);
            this.lblChxUyari.Name = "lblChxUyari";
            this.lblChxUyari.Size = new System.Drawing.Size(0, 19);
            this.lblChxUyari.TabIndex = 9;
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
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmKullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AkaStormProje.Properties.Resources.FormBackgraound;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chxOnay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.lblChxUyari);
            this.Controls.Add(this.lblSifreUyari);
            this.Controls.Add(this.lblKullaniciAdiUyari);
            this.Controls.Add(this.lblEpostaUyari);
            this.Controls.Add(this.lblTelefonUyari);
            this.Controls.Add(this.lblCinsiyetUyari);
            this.Controls.Add(this.lblTarihUyari);
            this.Controls.Add(this.lblSoyadUyari);
            this.Controls.Add(this.lblAdUyari);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.cmbYil);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.cmbGun);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullaniciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Posta";
            this.Load += new System.EventHandler(this.frmKullaniciKayit_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmKullaniciKayit_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmKullaniciKayit_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmKullaniciKayit_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ComboBox cmbGun;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label lblAdUyari;
        private System.Windows.Forms.Label lblSoyadUyari;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label lblTarihUyari;
        private System.Windows.Forms.Label lblCinsiyetUyari;
        private System.Windows.Forms.Label lblTelefonUyari;
        private System.Windows.Forms.Label lblEpostaUyari;
        private System.Windows.Forms.Label lblKullaniciAdiUyari;
        private System.Windows.Forms.Label lblSifreUyari;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chxOnay;
        private System.Windows.Forms.Label lblChxUyari;
        private System.Windows.Forms.Button btnBack;
    }
}