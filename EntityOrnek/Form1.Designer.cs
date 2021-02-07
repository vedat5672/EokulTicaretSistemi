
namespace EntityOrnek
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOgrenciListele = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnBul = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.groupBoxOgrenci = new System.Windows.Forms.GroupBox();
            this.textBoxOgrFoto = new System.Windows.Forms.TextBox();
            this.labelFOTO = new System.Windows.Forms.Label();
            this.textBoxOgrSoyad = new System.Windows.Forms.TextBox();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.textBoxOgrAd = new System.Windows.Forms.TextBox();
            this.labelAD = new System.Windows.Forms.Label();
            this.textBoxOgrID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBoxDersler = new System.Windows.Forms.GroupBox();
            this.textBoxDersAd = new System.Windows.Forms.TextBox();
            this.labelDersAd = new System.Windows.Forms.Label();
            this.textBoxDersId = new System.Windows.Forms.TextBox();
            this.labelDersId = new System.Windows.Forms.Label();
            this.groupBoxNotlar = new System.Windows.Forms.GroupBox();
            this.textBoxDurum = new System.Windows.Forms.TextBox();
            this.labelDurum = new System.Windows.Forms.Label();
            this.textBoxOrtalama = new System.Windows.Forms.TextBox();
            this.labelOrtalama = new System.Windows.Forms.Label();
            this.textBoxSınav3 = new System.Windows.Forms.TextBox();
            this.labelSınav3 = new System.Windows.Forms.Label();
            this.textBoxSınav2 = new System.Windows.Forms.TextBox();
            this.labelSınav2 = new System.Windows.Forms.Label();
            this.textBoxSınav1 = new System.Windows.Forms.TextBox();
            this.labelSınav1 = new System.Windows.Forms.Label();
            this.buttonDersListele = new System.Windows.Forms.Button();
            this.buttonNotListele = new System.Windows.Forms.Button();
            this.buttonOrtHesap = new System.Windows.Forms.Button();
            this.JOIN = new System.Windows.Forms.Button();
            this.buttonProcedür = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonLinqExecute = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxOgrenci.SuspendLayout();
            this.groupBoxDersler.SuspendLayout();
            this.groupBoxNotlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonOgrenciListele
            // 
            this.buttonOgrenciListele.Location = new System.Drawing.Point(12, 199);
            this.buttonOgrenciListele.Name = "buttonOgrenciListele";
            this.buttonOgrenciListele.Size = new System.Drawing.Size(150, 23);
            this.buttonOgrenciListele.TabIndex = 1;
            this.buttonOgrenciListele.Text = "OgrenciListele";
            this.buttonOgrenciListele.UseVisualStyleBackColor = true;
            this.buttonOgrenciListele.Click += new System.EventHandler(this.buttonOgrenciListele_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(12, 257);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(150, 23);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(12, 228);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(150, 23);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(12, 317);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(150, 23);
            this.BtnBul.TabIndex = 4;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(12, 286);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(150, 23);
            this.BtnGüncelle.TabIndex = 5;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // groupBoxOgrenci
            // 
            this.groupBoxOgrenci.Controls.Add(this.textBoxOgrFoto);
            this.groupBoxOgrenci.Controls.Add(this.labelFOTO);
            this.groupBoxOgrenci.Controls.Add(this.textBoxOgrSoyad);
            this.groupBoxOgrenci.Controls.Add(this.labelSoyad);
            this.groupBoxOgrenci.Controls.Add(this.textBoxOgrAd);
            this.groupBoxOgrenci.Controls.Add(this.labelAD);
            this.groupBoxOgrenci.Controls.Add(this.textBoxOgrID);
            this.groupBoxOgrenci.Controls.Add(this.labelID);
            this.groupBoxOgrenci.Location = new System.Drawing.Point(214, 199);
            this.groupBoxOgrenci.Name = "groupBoxOgrenci";
            this.groupBoxOgrenci.Size = new System.Drawing.Size(200, 154);
            this.groupBoxOgrenci.TabIndex = 6;
            this.groupBoxOgrenci.TabStop = false;
            this.groupBoxOgrenci.Text = "Ogrenci";
            // 
            // textBoxOgrFoto
            // 
            this.textBoxOgrFoto.Location = new System.Drawing.Point(89, 112);
            this.textBoxOgrFoto.Name = "textBoxOgrFoto";
            this.textBoxOgrFoto.Size = new System.Drawing.Size(101, 20);
            this.textBoxOgrFoto.TabIndex = 21;
            // 
            // labelFOTO
            // 
            this.labelFOTO.Location = new System.Drawing.Point(10, 112);
            this.labelFOTO.Name = "labelFOTO";
            this.labelFOTO.Size = new System.Drawing.Size(73, 17);
            this.labelFOTO.TabIndex = 20;
            this.labelFOTO.Text = "FOTOGRAF:";
            // 
            // textBoxOgrSoyad
            // 
            this.textBoxOgrSoyad.Location = new System.Drawing.Point(89, 72);
            this.textBoxOgrSoyad.Name = "textBoxOgrSoyad";
            this.textBoxOgrSoyad.Size = new System.Drawing.Size(101, 20);
            this.textBoxOgrSoyad.TabIndex = 19;
            // 
            // labelSoyad
            // 
            this.labelSoyad.Location = new System.Drawing.Point(33, 75);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(50, 17);
            this.labelSoyad.TabIndex = 18;
            this.labelSoyad.Text = "SOYAD:";
            // 
            // textBoxOgrAd
            // 
            this.textBoxOgrAd.Location = new System.Drawing.Point(89, 37);
            this.textBoxOgrAd.Name = "textBoxOgrAd";
            this.textBoxOgrAd.Size = new System.Drawing.Size(101, 20);
            this.textBoxOgrAd.TabIndex = 17;
            // 
            // labelAD
            // 
            this.labelAD.Location = new System.Drawing.Point(58, 40);
            this.labelAD.Name = "labelAD";
            this.labelAD.Size = new System.Drawing.Size(25, 21);
            this.labelAD.TabIndex = 16;
            this.labelAD.Text = "AD:";
            // 
            // textBoxOgrID
            // 
            this.textBoxOgrID.Location = new System.Drawing.Point(89, 8);
            this.textBoxOgrID.Name = "textBoxOgrID";
            this.textBoxOgrID.Size = new System.Drawing.Size(101, 20);
            this.textBoxOgrID.TabIndex = 15;
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(58, 11);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(25, 17);
            this.labelID.TabIndex = 14;
            this.labelID.Text = "ID:";
            // 
            // groupBoxDersler
            // 
            this.groupBoxDersler.Controls.Add(this.textBoxDersAd);
            this.groupBoxDersler.Controls.Add(this.labelDersAd);
            this.groupBoxDersler.Controls.Add(this.textBoxDersId);
            this.groupBoxDersler.Controls.Add(this.labelDersId);
            this.groupBoxDersler.Location = new System.Drawing.Point(214, 359);
            this.groupBoxDersler.Name = "groupBoxDersler";
            this.groupBoxDersler.Size = new System.Drawing.Size(200, 74);
            this.groupBoxDersler.TabIndex = 7;
            this.groupBoxDersler.TabStop = false;
            this.groupBoxDersler.Text = "Dersler";
            // 
            // textBoxDersAd
            // 
            this.textBoxDersAd.Location = new System.Drawing.Point(89, 37);
            this.textBoxDersAd.Name = "textBoxDersAd";
            this.textBoxDersAd.Size = new System.Drawing.Size(101, 20);
            this.textBoxDersAd.TabIndex = 17;
            // 
            // labelDersAd
            // 
            this.labelDersAd.Location = new System.Drawing.Point(58, 40);
            this.labelDersAd.Name = "labelDersAd";
            this.labelDersAd.Size = new System.Drawing.Size(25, 21);
            this.labelDersAd.TabIndex = 16;
            this.labelDersAd.Text = "AD:";
            // 
            // textBoxDersId
            // 
            this.textBoxDersId.Location = new System.Drawing.Point(89, 8);
            this.textBoxDersId.Name = "textBoxDersId";
            this.textBoxDersId.Size = new System.Drawing.Size(101, 20);
            this.textBoxDersId.TabIndex = 15;
            // 
            // labelDersId
            // 
            this.labelDersId.Location = new System.Drawing.Point(58, 11);
            this.labelDersId.Name = "labelDersId";
            this.labelDersId.Size = new System.Drawing.Size(25, 17);
            this.labelDersId.TabIndex = 14;
            this.labelDersId.Text = "ID:";
            // 
            // groupBoxNotlar
            // 
            this.groupBoxNotlar.Controls.Add(this.textBoxDurum);
            this.groupBoxNotlar.Controls.Add(this.labelDurum);
            this.groupBoxNotlar.Controls.Add(this.textBoxOrtalama);
            this.groupBoxNotlar.Controls.Add(this.labelOrtalama);
            this.groupBoxNotlar.Controls.Add(this.textBoxSınav3);
            this.groupBoxNotlar.Controls.Add(this.labelSınav3);
            this.groupBoxNotlar.Controls.Add(this.textBoxSınav2);
            this.groupBoxNotlar.Controls.Add(this.labelSınav2);
            this.groupBoxNotlar.Controls.Add(this.textBoxSınav1);
            this.groupBoxNotlar.Controls.Add(this.labelSınav1);
            this.groupBoxNotlar.Location = new System.Drawing.Point(460, 207);
            this.groupBoxNotlar.Name = "groupBoxNotlar";
            this.groupBoxNotlar.Size = new System.Drawing.Size(200, 157);
            this.groupBoxNotlar.TabIndex = 8;
            this.groupBoxNotlar.TabStop = false;
            this.groupBoxNotlar.Text = "NOTLAR";
            // 
            // textBoxDurum
            // 
            this.textBoxDurum.Location = new System.Drawing.Point(89, 129);
            this.textBoxDurum.Name = "textBoxDurum";
            this.textBoxDurum.Size = new System.Drawing.Size(101, 20);
            this.textBoxDurum.TabIndex = 23;
            // 
            // labelDurum
            // 
            this.labelDurum.Location = new System.Drawing.Point(37, 129);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(39, 17);
            this.labelDurum.TabIndex = 22;
            this.labelDurum.Text = "Durum";
            // 
            // textBoxOrtalama
            // 
            this.textBoxOrtalama.Location = new System.Drawing.Point(89, 101);
            this.textBoxOrtalama.Name = "textBoxOrtalama";
            this.textBoxOrtalama.Size = new System.Drawing.Size(101, 20);
            this.textBoxOrtalama.TabIndex = 21;
            // 
            // labelOrtalama
            // 
            this.labelOrtalama.Location = new System.Drawing.Point(10, 101);
            this.labelOrtalama.Name = "labelOrtalama";
            this.labelOrtalama.Size = new System.Drawing.Size(73, 17);
            this.labelOrtalama.TabIndex = 20;
            this.labelOrtalama.Text = "ORTALAMA";
            // 
            // textBoxSınav3
            // 
            this.textBoxSınav3.Location = new System.Drawing.Point(89, 67);
            this.textBoxSınav3.Name = "textBoxSınav3";
            this.textBoxSınav3.Size = new System.Drawing.Size(101, 20);
            this.textBoxSınav3.TabIndex = 19;
            // 
            // labelSınav3
            // 
            this.labelSınav3.Location = new System.Drawing.Point(33, 70);
            this.labelSınav3.Name = "labelSınav3";
            this.labelSınav3.Size = new System.Drawing.Size(50, 17);
            this.labelSınav3.TabIndex = 18;
            this.labelSınav3.Text = "SINAV3";
            // 
            // textBoxSınav2
            // 
            this.textBoxSınav2.Location = new System.Drawing.Point(89, 37);
            this.textBoxSınav2.Name = "textBoxSınav2";
            this.textBoxSınav2.Size = new System.Drawing.Size(101, 20);
            this.textBoxSınav2.TabIndex = 17;
            // 
            // labelSınav2
            // 
            this.labelSınav2.Location = new System.Drawing.Point(36, 37);
            this.labelSınav2.Name = "labelSınav2";
            this.labelSınav2.Size = new System.Drawing.Size(47, 21);
            this.labelSınav2.TabIndex = 16;
            this.labelSınav2.Text = "SINAV2:";
            // 
            // textBoxSınav1
            // 
            this.textBoxSınav1.Location = new System.Drawing.Point(89, 8);
            this.textBoxSınav1.Name = "textBoxSınav1";
            this.textBoxSınav1.Size = new System.Drawing.Size(101, 20);
            this.textBoxSınav1.TabIndex = 15;
            // 
            // labelSınav1
            // 
            this.labelSınav1.Location = new System.Drawing.Point(37, 11);
            this.labelSınav1.Name = "labelSınav1";
            this.labelSınav1.Size = new System.Drawing.Size(46, 17);
            this.labelSınav1.TabIndex = 14;
            this.labelSınav1.Text = "SINAV1:";
            // 
            // buttonDersListele
            // 
            this.buttonDersListele.Location = new System.Drawing.Point(12, 346);
            this.buttonDersListele.Name = "buttonDersListele";
            this.buttonDersListele.Size = new System.Drawing.Size(150, 23);
            this.buttonDersListele.TabIndex = 9;
            this.buttonDersListele.Text = "DersListele";
            this.buttonDersListele.UseVisualStyleBackColor = true;
            this.buttonDersListele.Click += new System.EventHandler(this.buttonDersListele_Click);
            // 
            // buttonNotListele
            // 
            this.buttonNotListele.Location = new System.Drawing.Point(12, 380);
            this.buttonNotListele.Name = "buttonNotListele";
            this.buttonNotListele.Size = new System.Drawing.Size(150, 23);
            this.buttonNotListele.TabIndex = 10;
            this.buttonNotListele.Text = "NotListele";
            this.buttonNotListele.UseVisualStyleBackColor = true;
            this.buttonNotListele.Click += new System.EventHandler(this.buttonNotListele_Click);
            // 
            // buttonOrtHesap
            // 
            this.buttonOrtHesap.Location = new System.Drawing.Point(473, 373);
            this.buttonOrtHesap.Name = "buttonOrtHesap";
            this.buttonOrtHesap.Size = new System.Drawing.Size(190, 36);
            this.buttonOrtHesap.TabIndex = 11;
            this.buttonOrtHesap.Text = "Hesapla";
            this.buttonOrtHesap.UseVisualStyleBackColor = true;
            // 
            // JOIN
            // 
            this.JOIN.Location = new System.Drawing.Point(473, 415);
            this.JOIN.Name = "JOIN";
            this.JOIN.Size = new System.Drawing.Size(190, 36);
            this.JOIN.TabIndex = 12;
            this.JOIN.Text = "join ile getir";
            this.JOIN.UseVisualStyleBackColor = true;
            this.JOIN.Click += new System.EventHandler(this.JOIN_Click);
            // 
            // buttonProcedür
            // 
            this.buttonProcedür.Location = new System.Drawing.Point(12, 415);
            this.buttonProcedür.Name = "buttonProcedür";
            this.buttonProcedür.Size = new System.Drawing.Size(150, 23);
            this.buttonProcedür.TabIndex = 13;
            this.buttonProcedür.Text = "Procedür";
            this.buttonProcedür.UseVisualStyleBackColor = true;
            this.buttonProcedür.Click += new System.EventHandler(this.buttonProcedür_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(725, 69);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A \" ya göre Sıalama(A=>Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonLinqExecute
            // 
            this.buttonLinqExecute.Location = new System.Drawing.Point(742, 415);
            this.buttonLinqExecute.Name = "buttonLinqExecute";
            this.buttonLinqExecute.Size = new System.Drawing.Size(190, 36);
            this.buttonLinqExecute.TabIndex = 15;
            this.buttonLinqExecute.Text = "filter";
            this.buttonLinqExecute.UseVisualStyleBackColor = true;
            this.buttonLinqExecute.Click += new System.EventHandler(this.buttonLinqExecute_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(725, 103);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ilk3kayıt";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(725, 142);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(107, 17);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "SINAV1TOPLAM";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(725, 176);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 17);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ortalama";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 499);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.buttonLinqExecute);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonProcedür);
            this.Controls.Add(this.JOIN);
            this.Controls.Add(this.buttonOrtHesap);
            this.Controls.Add(this.buttonNotListele);
            this.Controls.Add(this.buttonDersListele);
            this.Controls.Add(this.groupBoxNotlar);
            this.Controls.Add(this.groupBoxDersler);
            this.Controls.Add(this.groupBoxOgrenci);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.buttonOgrenciListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxOgrenci.ResumeLayout(false);
            this.groupBoxOgrenci.PerformLayout();
            this.groupBoxDersler.ResumeLayout(false);
            this.groupBoxDersler.PerformLayout();
            this.groupBoxNotlar.ResumeLayout(false);
            this.groupBoxNotlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOgrenciListele;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.GroupBox groupBoxOgrenci;
        private System.Windows.Forms.TextBox textBoxOgrFoto;
        private System.Windows.Forms.Label labelFOTO;
        private System.Windows.Forms.TextBox textBoxOgrSoyad;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.TextBox textBoxOgrAd;
        private System.Windows.Forms.Label labelAD;
        private System.Windows.Forms.TextBox textBoxOgrID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupBoxDersler;
        private System.Windows.Forms.TextBox textBoxDersAd;
        private System.Windows.Forms.Label labelDersAd;
        private System.Windows.Forms.TextBox textBoxDersId;
        private System.Windows.Forms.Label labelDersId;
        private System.Windows.Forms.GroupBox groupBoxNotlar;
        private System.Windows.Forms.TextBox textBoxOrtalama;
        private System.Windows.Forms.Label labelOrtalama;
        private System.Windows.Forms.TextBox textBoxSınav3;
        private System.Windows.Forms.Label labelSınav3;
        private System.Windows.Forms.TextBox textBoxSınav2;
        private System.Windows.Forms.Label labelSınav2;
        private System.Windows.Forms.TextBox textBoxSınav1;
        private System.Windows.Forms.Label labelSınav1;
        private System.Windows.Forms.TextBox textBoxDurum;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.Button buttonDersListele;
        private System.Windows.Forms.Button buttonNotListele;
        private System.Windows.Forms.Button buttonOrtHesap;
        private System.Windows.Forms.Button JOIN;
        private System.Windows.Forms.Button buttonProcedür;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonLinqExecute;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

