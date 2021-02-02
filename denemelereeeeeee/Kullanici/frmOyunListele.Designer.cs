namespace AkaStormProje
{
    partial class frmOyunListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOyunListele));
            this.panSol = new System.Windows.Forms.Panel();
            this.panFiltre = new System.Windows.Forms.Panel();
            this.btnFiltreExit = new System.Windows.Forms.Button();
            this.btnFiltre2 = new System.Windows.Forms.Button();
            this.cmbFiyat2 = new System.Windows.Forms.ComboBox();
            this.cmbFiyat1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbKategoriFiltre = new System.Windows.Forms.ComboBox();
            this.cmbGenel = new System.Windows.Forms.ComboBox();
            this.txtAdFiltre = new System.Windows.Forms.TextBox();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panSag = new System.Windows.Forms.Panel();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.RichTextBox();
            this.txtOyunAdi = new System.Windows.Forms.RichTextBox();
            this.lblGelistirici = new System.Windows.Forms.Label();
            this.pbOyunResim = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panSol.SuspendLayout();
            this.panFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panSag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOyunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // panSol
            // 
            this.panSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.panSol.BackgroundImage = global::AkaStormProje.Properties.Resources.OyunListeleArka;
            this.panSol.Controls.Add(this.panFiltre);
            this.panSol.Controls.Add(this.txtAdFiltre);
            this.panSol.Controls.Add(this.btnFiltre);
            this.panSol.Controls.Add(this.dataGridView1);
            this.panSol.Location = new System.Drawing.Point(0, 0);
            this.panSol.Name = "panSol";
            this.panSol.Size = new System.Drawing.Size(950, 650);
            this.panSol.TabIndex = 2;
            // 
            // panFiltre
            // 
            this.panFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.panFiltre.Controls.Add(this.btnFiltreExit);
            this.panFiltre.Controls.Add(this.btnFiltre2);
            this.panFiltre.Controls.Add(this.cmbFiyat2);
            this.panFiltre.Controls.Add(this.cmbFiyat1);
            this.panFiltre.Controls.Add(this.label11);
            this.panFiltre.Controls.Add(this.label10);
            this.panFiltre.Controls.Add(this.label8);
            this.panFiltre.Controls.Add(this.label12);
            this.panFiltre.Controls.Add(this.cmbKategoriFiltre);
            this.panFiltre.Controls.Add(this.cmbGenel);
            this.panFiltre.Location = new System.Drawing.Point(650, 51);
            this.panFiltre.Name = "panFiltre";
            this.panFiltre.Size = new System.Drawing.Size(232, 133);
            this.panFiltre.TabIndex = 9;
            // 
            // btnFiltreExit
            // 
            this.btnFiltreExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnFiltreExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnFiltreExit.FlatAppearance.BorderSize = 0;
            this.btnFiltreExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnFiltreExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnFiltreExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltreExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFiltreExit.Location = new System.Drawing.Point(206, 2);
            this.btnFiltreExit.Name = "btnFiltreExit";
            this.btnFiltreExit.Size = new System.Drawing.Size(18, 23);
            this.btnFiltreExit.TabIndex = 10;
            this.btnFiltreExit.Text = "X";
            this.btnFiltreExit.UseVisualStyleBackColor = false;
            this.btnFiltreExit.Click += new System.EventHandler(this.btnFiltreExit_Click);
            // 
            // btnFiltre2
            // 
            this.btnFiltre2.BackgroundImage = global::AkaStormProje.Properties.Resources.btnFiltre1;
            this.btnFiltre2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltre2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnFiltre2.FlatAppearance.BorderSize = 0;
            this.btnFiltre2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnFiltre2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnFiltre2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltre2.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiltre2.Location = new System.Drawing.Point(63, 95);
            this.btnFiltre2.Name = "btnFiltre2";
            this.btnFiltre2.Size = new System.Drawing.Size(89, 34);
            this.btnFiltre2.TabIndex = 4;
            this.btnFiltre2.Text = "Filtrele";
            this.btnFiltre2.UseVisualStyleBackColor = true;
            this.btnFiltre2.Click += new System.EventHandler(this.btnFiltre2_Click);
            this.btnFiltre2.MouseLeave += new System.EventHandler(this.btnFiltre2_MouseLeave);
            this.btnFiltre2.MouseHover += new System.EventHandler(this.btnFiltre2_MouseHover);
            // 
            // cmbFiyat2
            // 
            this.cmbFiyat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.cmbFiyat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiyat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiyat2.FormattingEnabled = true;
            this.cmbFiyat2.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "50",
            "100",
            "200",
            "500"});
            this.cmbFiyat2.Location = new System.Drawing.Point(159, 65);
            this.cmbFiyat2.Name = "cmbFiyat2";
            this.cmbFiyat2.Size = new System.Drawing.Size(57, 21);
            this.cmbFiyat2.TabIndex = 3;
            // 
            // cmbFiyat1
            // 
            this.cmbFiyat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.cmbFiyat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiyat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiyat1.FormattingEnabled = true;
            this.cmbFiyat1.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "50",
            "100",
            "200",
            "500"});
            this.cmbFiyat1.Location = new System.Drawing.Point(79, 65);
            this.cmbFiyat1.Name = "cmbFiyat1";
            this.cmbFiyat1.Size = new System.Drawing.Size(57, 21);
            this.cmbFiyat1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(135, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 31);
            this.label11.TabIndex = 2;
            this.label11.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(25, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fiyat :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kategori :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(23, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Filtre :";
            // 
            // cmbKategoriFiltre
            // 
            this.cmbKategoriFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.cmbKategoriFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKategoriFiltre.FormattingEnabled = true;
            this.cmbKategoriFiltre.Location = new System.Drawing.Point(79, 35);
            this.cmbKategoriFiltre.Name = "cmbKategoriFiltre";
            this.cmbKategoriFiltre.Size = new System.Drawing.Size(93, 21);
            this.cmbKategoriFiltre.TabIndex = 0;
            this.cmbKategoriFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriFiltre_SelectedIndexChanged);
            // 
            // cmbGenel
            // 
            this.cmbGenel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.cmbGenel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGenel.FormattingEnabled = true;
            this.cmbGenel.Items.AddRange(new object[] {
            "İsim (A-Z)",
            "İsim (Z-A)",
            "Fiyat (En Yüksek)",
            "Fiyat (En Düşük)",
            "Puan (En Yüksek)",
            "Puan (En Düşük)"});
            this.cmbGenel.Location = new System.Drawing.Point(79, 5);
            this.cmbGenel.Name = "cmbGenel";
            this.cmbGenel.Size = new System.Drawing.Size(93, 21);
            this.cmbGenel.TabIndex = 0;
            this.cmbGenel.SelectedIndexChanged += new System.EventHandler(this.cmbGenel_SelectedIndexChanged);
            // 
            // txtAdFiltre
            // 
            this.txtAdFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.txtAdFiltre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdFiltre.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.txtAdFiltre.ForeColor = System.Drawing.Color.Silver;
            this.txtAdFiltre.Location = new System.Drawing.Point(79, 159);
            this.txtAdFiltre.Name = "txtAdFiltre";
            this.txtAdFiltre.Size = new System.Drawing.Size(226, 22);
            this.txtAdFiltre.TabIndex = 8;
            this.txtAdFiltre.Text = "İsme göre ara";
            this.txtAdFiltre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdFiltre.TextChanged += new System.EventHandler(this.txtAdFiltre_TextChanged);
            this.txtAdFiltre.Enter += new System.EventHandler(this.txtAdFiltre_Enter);
            this.txtAdFiltre.Leave += new System.EventHandler(this.txtAdFiltre_Leave);
            // 
            // btnFiltre
            // 
            this.btnFiltre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltre.BackgroundImage")));
            this.btnFiltre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnFiltre.FlatAppearance.BorderSize = 0;
            this.btnFiltre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnFiltre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.btnFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltre.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiltre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltre.Location = new System.Drawing.Point(778, 137);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(96, 44);
            this.btnFiltre.TabIndex = 6;
            this.btnFiltre.Text = "Filtrele";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            this.btnFiltre.MouseLeave += new System.EventHandler(this.btnFiltre_MouseLeave);
            this.btnFiltre.MouseHover += new System.EventHandler(this.btnFiltre_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.Location = new System.Drawing.Point(69, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(812, 440);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panSag
            // 
            this.panSag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.panSag.Controls.Add(this.lblFiyat);
            this.panSag.Controls.Add(this.btnSatinAl);
            this.panSag.Controls.Add(this.lblPuan);
            this.panSag.Controls.Add(this.lblKategori);
            this.panSag.Controls.Add(this.label6);
            this.panSag.Controls.Add(this.label2);
            this.panSag.Controls.Add(this.label4);
            this.panSag.Controls.Add(this.txtKonu);
            this.panSag.Controls.Add(this.txtOyunAdi);
            this.panSag.Controls.Add(this.lblGelistirici);
            this.panSag.Controls.Add(this.pbOyunResim);
            this.panSag.Controls.Add(this.label3);
            this.panSag.Location = new System.Drawing.Point(950, 0);
            this.panSag.Name = "panSag";
            this.panSag.Size = new System.Drawing.Size(250, 650);
            this.panSag.TabIndex = 1;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lblFiyat.Location = new System.Drawing.Point(119, 504);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(50, 15);
            this.lblFiyat.TabIndex = 15;
            this.lblFiyat.Text = "label10";
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.BackgroundImage = global::AkaStormProje.Properties.Resources.BtnLeave;
            this.btnSatinAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSatinAl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnSatinAl.FlatAppearance.BorderSize = 0;
            this.btnSatinAl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnSatinAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnSatinAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatinAl.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.btnSatinAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnSatinAl.Image = ((System.Drawing.Image)(resources.GetObject("btnSatinAl.Image")));
            this.btnSatinAl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatinAl.Location = new System.Drawing.Point(69, 564);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(110, 70);
            this.btnSatinAl.TabIndex = 11;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            this.btnSatinAl.MouseLeave += new System.EventHandler(this.btnAl_MouseLeave);
            this.btnSatinAl.MouseHover += new System.EventHandler(this.btnAl_MouseHover);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lblPuan.Location = new System.Drawing.Point(119, 477);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(44, 15);
            this.lblPuan.TabIndex = 14;
            this.lblPuan.Text = "label9";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lblKategori.Location = new System.Drawing.Point(119, 422);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(44, 15);
            this.lblKategori.TabIndex = 6;
            this.lblKategori.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label6.Location = new System.Drawing.Point(50, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fiyat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label2.Location = new System.Drawing.Point(22, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label4.Location = new System.Drawing.Point(49, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Puan :";
            // 
            // txtKonu
            // 
            this.txtKonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.txtKonu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKonu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonu.Location = new System.Drawing.Point(31, 326);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(189, 75);
            this.txtKonu.TabIndex = 4;
            this.txtKonu.Text = "Konu : Mükemmel bir savaş Simulasyonu";
            // 
            // txtOyunAdi
            // 
            this.txtOyunAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.txtOyunAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOyunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOyunAdi.Location = new System.Drawing.Point(31, 218);
            this.txtOyunAdi.Name = "txtOyunAdi";
            this.txtOyunAdi.Size = new System.Drawing.Size(189, 102);
            this.txtOyunAdi.TabIndex = 2;
            this.txtOyunAdi.Text = "           Arma 3";
            // 
            // lblGelistirici
            // 
            this.lblGelistirici.AutoSize = true;
            this.lblGelistirici.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lblGelistirici.Location = new System.Drawing.Point(119, 450);
            this.lblGelistirici.Name = "lblGelistirici";
            this.lblGelistirici.Size = new System.Drawing.Size(44, 15);
            this.lblGelistirici.TabIndex = 12;
            this.lblGelistirici.Text = "label7";
            // 
            // pbOyunResim
            // 
            this.pbOyunResim.BackColor = System.Drawing.Color.White;
            this.pbOyunResim.Location = new System.Drawing.Point(31, 28);
            this.pbOyunResim.Name = "pbOyunResim";
            this.pbOyunResim.Size = new System.Drawing.Size(189, 184);
            this.pbOyunResim.TabIndex = 1;
            this.pbOyunResim.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label3.Location = new System.Drawing.Point(14, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Geliştirici :";
            // 
            // frmOyunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panSol);
            this.Controls.Add(this.panSag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOyunListele";
            this.Text = "frmOyunListele";
            this.Load += new System.EventHandler(this.frmOyunListele_Load);
            this.panSol.ResumeLayout(false);
            this.panSol.PerformLayout();
            this.panFiltre.ResumeLayout(false);
            this.panFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panSag.ResumeLayout(false);
            this.panSag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOyunResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panSol;
        private System.Windows.Forms.Panel panSag;
        private System.Windows.Forms.RichTextBox txtOyunAdi;
        private System.Windows.Forms.PictureBox pbOyunResim;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtKonu;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblGelistirici;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.TextBox txtAdFiltre;
        private System.Windows.Forms.Panel panFiltre;
        private System.Windows.Forms.Button btnFiltre2;
        private System.Windows.Forms.ComboBox cmbFiyat2;
        private System.Windows.Forms.ComboBox cmbFiyat1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbGenel;
        private System.Windows.Forms.Button btnFiltreExit;
        private System.Windows.Forms.ComboBox cmbKategoriFiltre;
    }
}