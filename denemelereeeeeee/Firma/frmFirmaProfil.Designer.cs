namespace AkaStormProje
{
    partial class frmFirmaProfil
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
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.txtResimYolu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pbFirmaResim = new System.Windows.Forms.PictureBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCeo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblonay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirmaResim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 650);
            this.panel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 31F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(663, 552);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(259, 48);
            this.label12.TabIndex = 16;
            this.label12.Text = "Yorum Alanı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 426);
            this.dataGridView1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.panel2.Controls.Add(this.lblonay);
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Controls.Add(this.btnResimSec);
            this.panel2.Controls.Add(this.txtResimYolu);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.pbFirmaResim);
            this.panel2.Controls.Add(this.lblTelefon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblEposta);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblFirmaAdi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblCeo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblPuan);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 650);
            this.panel2.TabIndex = 14;
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = global::AkaStormProje.Properties.Resources.BtnLeave;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.btnEkle.Location = new System.Drawing.Point(92, 476);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(116, 51);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Güncelle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.MouseLeave += new System.EventHandler(this.btnEkle_MouseLeave);
            this.btnEkle.MouseHover += new System.EventHandler(this.btnEkle_MouseHover);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(244, 425);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(31, 22);
            this.btnResimSec.TabIndex = 16;
            this.btnResimSec.Text = "...";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // txtResimYolu
            // 
            this.txtResimYolu.BackColor = System.Drawing.SystemColors.Window;
            this.txtResimYolu.Location = new System.Drawing.Point(144, 426);
            this.txtResimYolu.Name = "txtResimYolu";
            this.txtResimYolu.ReadOnly = true;
            this.txtResimYolu.Size = new System.Drawing.Size(99, 20);
            this.txtResimYolu.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label11.Location = new System.Drawing.Point(67, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 28);
            this.label11.TabIndex = 14;
            this.label11.Text = "Resim :";
            // 
            // pbFirmaResim
            // 
            this.pbFirmaResim.BackColor = System.Drawing.Color.White;
            this.pbFirmaResim.Location = new System.Drawing.Point(39, 30);
            this.pbFirmaResim.Name = "pbFirmaResim";
            this.pbFirmaResim.Size = new System.Drawing.Size(240, 230);
            this.pbFirmaResim.TabIndex = 1;
            this.pbFirmaResim.TabStop = false;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lblTelefon.Location = new System.Drawing.Point(144, 372);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(49, 15);
            this.lblTelefon.TabIndex = 13;
            this.lblTelefon.Text = "label11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label2.Location = new System.Drawing.Point(34, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firma Adı :";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lblEposta.Location = new System.Drawing.Point(144, 344);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(50, 15);
            this.lblEposta.TabIndex = 12;
            this.lblEposta.Text = "label10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label3.Location = new System.Drawing.Point(87, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ceo :";
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lblFirmaAdi.Location = new System.Drawing.Point(144, 288);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(44, 15);
            this.lblFirmaAdi.TabIndex = 11;
            this.lblFirmaAdi.Text = "label9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label4.Location = new System.Drawing.Point(50, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-Posta :";
            // 
            // lblCeo
            // 
            this.lblCeo.AutoSize = true;
            this.lblCeo.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lblCeo.Location = new System.Drawing.Point(144, 316);
            this.lblCeo.Name = "lblCeo";
            this.lblCeo.Size = new System.Drawing.Size(44, 15);
            this.lblCeo.TabIndex = 10;
            this.lblCeo.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label5.Location = new System.Drawing.Point(57, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefon :";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.lblPuan.Location = new System.Drawing.Point(144, 400);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(44, 15);
            this.lblPuan.TabIndex = 7;
            this.lblPuan.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.label6.Location = new System.Drawing.Point(74, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Puan :";
            // 
            // lblonay
            // 
            this.lblonay.AutoSize = true;
            this.lblonay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblonay.Location = new System.Drawing.Point(89, 583);
            this.lblonay.Name = "lblonay";
            this.lblonay.Size = new System.Drawing.Size(0, 17);
            this.lblonay.TabIndex = 18;
            // 
            // frmFirmaProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFirmaProfil";
            this.Text = "frmFirmaProfil";
            this.Load += new System.EventHandler(this.frmFirmaProfil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirmaResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.Label lblCeo;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbFirmaResim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.TextBox txtResimYolu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblonay;
    }
}