namespace yapayzekadenemeleri1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnDosyaOku = new System.Windows.Forms.Button();
            this.lblBilgiAlani = new System.Windows.Forms.Label();
            this.ofpDosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.btnSatirYazdir = new System.Windows.Forms.Button();
            this.btnIrisListesiOlustur = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgiCalistir = new System.Windows.Forms.Button();
            this.pbarhHesaplama = new System.Windows.Forms.ProgressBar();
            this.btnAgiEgit = new System.Windows.Forms.Button();
            this.btnAgiTestEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbYaklasimMax = new System.Windows.Forms.TextBox();
            this.tbYaklasimNormal = new System.Windows.Forms.TextBox();
            this.btnYaklasimDegistir = new System.Windows.Forms.Button();
            this.dgwTestSonuclari = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEgitimAlgoritmasi = new System.Windows.Forms.ComboBox();
            this.btnTumAgIslemleri = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aaAlgoritmalariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsAa3Yapilandirmasi = new System.Windows.Forms.ToolStripMenuItem();
            this.ağTipleriYapılandırmalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbAgTipleri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolsBasitAgYapilandirmasi = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTestSonuclari)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDosyaOku
            // 
            this.btnDosyaOku.Location = new System.Drawing.Point(22, 31);
            this.btnDosyaOku.Name = "btnDosyaOku";
            this.btnDosyaOku.Size = new System.Drawing.Size(75, 23);
            this.btnDosyaOku.TabIndex = 0;
            this.btnDosyaOku.Text = "dosya oku";
            this.btnDosyaOku.UseVisualStyleBackColor = true;
            this.btnDosyaOku.Click += new System.EventHandler(this.btnDosyaOku_Click);
            // 
            // lblBilgiAlani
            // 
            this.lblBilgiAlani.AutoSize = true;
            this.lblBilgiAlani.Location = new System.Drawing.Point(4, 403);
            this.lblBilgiAlani.Name = "lblBilgiAlani";
            this.lblBilgiAlani.Size = new System.Drawing.Size(50, 13);
            this.lblBilgiAlani.TabIndex = 1;
            this.lblBilgiAlani.Text = "bilgi alanı";
            // 
            // ofpDosyaAc
            // 
            this.ofpDosyaAc.FileName = "ofpDosyaAc";
            // 
            // btnSatirYazdir
            // 
            this.btnSatirYazdir.Location = new System.Drawing.Point(7, 60);
            this.btnSatirYazdir.Name = "btnSatirYazdir";
            this.btnSatirYazdir.Size = new System.Drawing.Size(90, 23);
            this.btnSatirYazdir.TabIndex = 2;
            this.btnSatirYazdir.Text = "satirlari yazdir";
            this.btnSatirYazdir.UseVisualStyleBackColor = true;
            this.btnSatirYazdir.Click += new System.EventHandler(this.btnSatirYazdir_Click);
            // 
            // btnIrisListesiOlustur
            // 
            this.btnIrisListesiOlustur.Location = new System.Drawing.Point(4, 90);
            this.btnIrisListesiOlustur.Name = "btnIrisListesiOlustur";
            this.btnIrisListesiOlustur.Size = new System.Drawing.Size(111, 23);
            this.btnIrisListesiOlustur.TabIndex = 3;
            this.btnIrisListesiOlustur.Text = "iris listesi oluştur";
            this.btnIrisListesiOlustur.UseVisualStyleBackColor = true;
            this.btnIrisListesiOlustur.Click += new System.EventHandler(this.btnIrisListesiOlustur_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ağı oluştur eğitim verilerini ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgiCalistir
            // 
            this.btnAgiCalistir.Location = new System.Drawing.Point(7, 176);
            this.btnAgiCalistir.Name = "btnAgiCalistir";
            this.btnAgiCalistir.Size = new System.Drawing.Size(194, 23);
            this.btnAgiCalistir.TabIndex = 5;
            this.btnAgiCalistir.Text = "ağı çalıştır";
            this.btnAgiCalistir.UseVisualStyleBackColor = true;
            this.btnAgiCalistir.Click += new System.EventHandler(this.btnAgiCalistir_Click);
            // 
            // pbarhHesaplama
            // 
            this.pbarhHesaplama.Location = new System.Drawing.Point(-3, 445);
            this.pbarhHesaplama.Name = "pbarhHesaplama";
            this.pbarhHesaplama.Size = new System.Drawing.Size(100, 23);
            this.pbarhHesaplama.TabIndex = 6;
            // 
            // btnAgiEgit
            // 
            this.btnAgiEgit.Location = new System.Drawing.Point(7, 229);
            this.btnAgiEgit.Name = "btnAgiEgit";
            this.btnAgiEgit.Size = new System.Drawing.Size(194, 23);
            this.btnAgiEgit.TabIndex = 7;
            this.btnAgiEgit.Text = "Ağı eğit";
            this.btnAgiEgit.UseVisualStyleBackColor = true;
            this.btnAgiEgit.Click += new System.EventHandler(this.btnAgiEgit_Click);
            // 
            // btnAgiTestEt
            // 
            this.btnAgiTestEt.Location = new System.Drawing.Point(7, 258);
            this.btnAgiTestEt.Name = "btnAgiTestEt";
            this.btnAgiTestEt.Size = new System.Drawing.Size(194, 23);
            this.btnAgiTestEt.TabIndex = 8;
            this.btnAgiTestEt.Text = "Ağı Test Et";
            this.btnAgiTestEt.UseVisualStyleBackColor = true;
            this.btnAgiTestEt.Click += new System.EventHandler(this.btnAgiTestEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "yaklasim max :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "yaklaşım normal :";
            // 
            // tbYaklasimMax
            // 
            this.tbYaklasimMax.Location = new System.Drawing.Point(392, 40);
            this.tbYaklasimMax.Name = "tbYaklasimMax";
            this.tbYaklasimMax.Size = new System.Drawing.Size(100, 20);
            this.tbYaklasimMax.TabIndex = 11;
            // 
            // tbYaklasimNormal
            // 
            this.tbYaklasimNormal.Location = new System.Drawing.Point(392, 60);
            this.tbYaklasimNormal.Name = "tbYaklasimNormal";
            this.tbYaklasimNormal.Size = new System.Drawing.Size(100, 20);
            this.tbYaklasimNormal.TabIndex = 12;
            // 
            // btnYaklasimDegistir
            // 
            this.btnYaklasimDegistir.Location = new System.Drawing.Point(392, 86);
            this.btnYaklasimDegistir.Name = "btnYaklasimDegistir";
            this.btnYaklasimDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnYaklasimDegistir.TabIndex = 13;
            this.btnYaklasimDegistir.Text = "degistir";
            this.btnYaklasimDegistir.UseVisualStyleBackColor = true;
            this.btnYaklasimDegistir.Click += new System.EventHandler(this.btnYaklasimDegistir_Click);
            // 
            // dgwTestSonuclari
            // 
            this.dgwTestSonuclari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTestSonuclari.Location = new System.Drawing.Point(228, 137);
            this.dgwTestSonuclari.Name = "dgwTestSonuclari";
            this.dgwTestSonuclari.Size = new System.Drawing.Size(616, 291);
            this.dgwTestSonuclari.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Eğitim :";
            // 
            // cbEgitimAlgoritmasi
            // 
            this.cbEgitimAlgoritmasi.FormattingEnabled = true;
            this.cbEgitimAlgoritmasi.Items.AddRange(new object[] {
            "aa1",
            "aa2"});
            this.cbEgitimAlgoritmasi.Location = new System.Drawing.Point(52, 202);
            this.cbEgitimAlgoritmasi.Name = "cbEgitimAlgoritmasi";
            this.cbEgitimAlgoritmasi.Size = new System.Drawing.Size(141, 21);
            this.cbEgitimAlgoritmasi.TabIndex = 16;
            // 
            // btnTumAgIslemleri
            // 
            this.btnTumAgIslemleri.Location = new System.Drawing.Point(7, 288);
            this.btnTumAgIslemleri.Name = "btnTumAgIslemleri";
            this.btnTumAgIslemleri.Size = new System.Drawing.Size(194, 23);
            this.btnTumAgIslemleri.TabIndex = 17;
            this.btnTumAgIslemleri.Text = "Ağı çalıştır,eğit ve test et";
            this.btnTumAgIslemleri.UseVisualStyleBackColor = true;
            this.btnTumAgIslemleri.Click += new System.EventHandler(this.btnTumAgIslemleri_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.ağTipleriYapılandırmalarıToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "ayarlar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaAlgoritmalariToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(215, 22);
            this.toolStripMenuItem2.Text = "Algoritma yapılandırmaları";
            // 
            // aaAlgoritmalariToolStripMenuItem
            // 
            this.aaAlgoritmalariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsAa3Yapilandirmasi});
            this.aaAlgoritmalariToolStripMenuItem.Name = "aaAlgoritmalariToolStripMenuItem";
            this.aaAlgoritmalariToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aaAlgoritmalariToolStripMenuItem.Text = "aa algoritmalari";
            this.aaAlgoritmalariToolStripMenuItem.Click += new System.EventHandler(this.aaAlgoritmalariToolStripMenuItem_Click);
            // 
            // toolsAa3Yapilandirmasi
            // 
            this.toolsAa3Yapilandirmasi.Name = "toolsAa3Yapilandirmasi";
            this.toolsAa3Yapilandirmasi.Size = new System.Drawing.Size(180, 22);
            this.toolsAa3Yapilandirmasi.Text = "aa3 yapılandırması";
            this.toolsAa3Yapilandirmasi.Click += new System.EventHandler(this.toolsAa3Yapilandirmasi_Click);
            // 
            // ağTipleriYapılandırmalarıToolStripMenuItem
            // 
            this.ağTipleriYapılandırmalarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsBasitAgYapilandirmasi});
            this.ağTipleriYapılandırmalarıToolStripMenuItem.Name = "ağTipleriYapılandırmalarıToolStripMenuItem";
            this.ağTipleriYapılandırmalarıToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.ağTipleriYapılandırmalarıToolStripMenuItem.Text = "ağ tipleri Yapılandırmaları";
            // 
            // cbAgTipleri
            // 
            this.cbAgTipleri.FormattingEnabled = true;
            this.cbAgTipleri.Items.AddRange(new object[] {
            "Basit Ağ"});
            this.cbAgTipleri.Location = new System.Drawing.Point(52, 116);
            this.cbAgTipleri.Name = "cbAgTipleri";
            this.cbAgTipleri.Size = new System.Drawing.Size(141, 21);
            this.cbAgTipleri.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ağ Tipi :";
            // 
            // toolsBasitAgYapilandirmasi
            // 
            this.toolsBasitAgYapilandirmasi.Name = "toolsBasitAgYapilandirmasi";
            this.toolsBasitAgYapilandirmasi.Size = new System.Drawing.Size(197, 22);
            this.toolsBasitAgYapilandirmasi.Text = "basit Ağ yapılandırmasi";
            this.toolsBasitAgYapilandirmasi.Click += new System.EventHandler(this.toolsBasitAgYapilandirmasi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(856, 472);
            this.Controls.Add(this.cbAgTipleri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnTumAgIslemleri);
            this.Controls.Add(this.cbEgitimAlgoritmasi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwTestSonuclari);
            this.Controls.Add(this.btnYaklasimDegistir);
            this.Controls.Add(this.tbYaklasimNormal);
            this.Controls.Add(this.tbYaklasimMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgiTestEt);
            this.Controls.Add(this.btnAgiEgit);
            this.Controls.Add(this.pbarhHesaplama);
            this.Controls.Add(this.btnAgiCalistir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIrisListesiOlustur);
            this.Controls.Add(this.btnSatirYazdir);
            this.Controls.Add(this.lblBilgiAlani);
            this.Controls.Add(this.btnDosyaOku);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Yapay Zeka Algoritma Testleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTestSonuclari)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDosyaOku;
        private System.Windows.Forms.Label lblBilgiAlani;
        private System.Windows.Forms.OpenFileDialog ofpDosyaAc;
        private System.Windows.Forms.Button btnSatirYazdir;
        private System.Windows.Forms.Button btnIrisListesiOlustur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgiCalistir;
        private System.Windows.Forms.ProgressBar pbarhHesaplama;
        private System.Windows.Forms.Button btnAgiEgit;
        private System.Windows.Forms.Button btnAgiTestEt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbYaklasimMax;
        private System.Windows.Forms.TextBox tbYaklasimNormal;
        private System.Windows.Forms.Button btnYaklasimDegistir;
        private System.Windows.Forms.DataGridView dgwTestSonuclari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEgitimAlgoritmasi;
        private System.Windows.Forms.Button btnTumAgIslemleri;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aaAlgoritmalariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsAa3Yapilandirmasi;
        private System.Windows.Forms.ToolStripMenuItem ağTipleriYapılandırmalarıToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbAgTipleri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem toolsBasitAgYapilandirmasi;
    }
}

