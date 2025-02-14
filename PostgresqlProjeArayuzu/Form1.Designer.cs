namespace PostgresqlProjeArayuzu
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ad_textbox1 = new System.Windows.Forms.TextBox();
            this.soyad_textbox1 = new System.Windows.Forms.TextBox();
            this.telefon_textbox1 = new System.Windows.Forms.TextBox();
            this.meslek_textbox1 = new System.Windows.Forms.TextBox();
            this.ekle_buton1 = new System.Windows.Forms.Button();
            this.sil_buton1 = new System.Windows.Forms.Button();
            this.arama_buton1 = new System.Windows.Forms.Button();
            this.guncelle_buton1 = new System.Windows.Forms.Button();
            this.personelsayisi_textbox1 = new System.Windows.Forms.Button();
            this.listele_buton1 = new System.Windows.Forms.Button();
            this.personelsayisi_label1 = new System.Windows.Forms.Label();
            this.soneklenenpersonel_button1 = new System.Windows.Forms.Button();
            this.adlistele_button1 = new System.Windows.Forms.Button();
            this.meslekgruppersonel_textbox1 = new System.Windows.Forms.Button();
            this.harfgirin_textbox1 = new System.Windows.Forms.TextBox();
            this.arama_buton2 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.arama_buton2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.Controls.Add(this.harfgirin_textbox1);
            this.tabPage1.Controls.Add(this.meslek_textbox1);
            this.tabPage1.Controls.Add(this.telefon_textbox1);
            this.tabPage1.Controls.Add(this.soyad_textbox1);
            this.tabPage1.Controls.Add(this.ad_textbox1);
            this.tabPage1.Controls.Add(this.meslekgruppersonel_textbox1);
            this.tabPage1.Controls.Add(this.adlistele_button1);
            this.tabPage1.Controls.Add(this.soneklenenpersonel_button1);
            this.tabPage1.Controls.Add(this.personelsayisi_label1);
            this.tabPage1.Controls.Add(this.listele_buton1);
            this.tabPage1.Controls.Add(this.personelsayisi_textbox1);
            this.tabPage1.Controls.Add(this.guncelle_buton1);
            this.tabPage1.Controls.Add(this.arama_buton1);
            this.tabPage1.Controls.Add(this.sil_buton1);
            this.tabPage1.Controls.Add(this.ekle_buton1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1326, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(717, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(768, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(774, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Meslek:";
            // 
            // ad_textbox1
            // 
            this.ad_textbox1.Location = new System.Drawing.Point(914, 22);
            this.ad_textbox1.Name = "ad_textbox1";
            this.ad_textbox1.Size = new System.Drawing.Size(176, 28);
            this.ad_textbox1.TabIndex = 6;
            // 
            // soyad_textbox1
            // 
            this.soyad_textbox1.Location = new System.Drawing.Point(914, 75);
            this.soyad_textbox1.Name = "soyad_textbox1";
            this.soyad_textbox1.Size = new System.Drawing.Size(176, 28);
            this.soyad_textbox1.TabIndex = 7;
            // 
            // telefon_textbox1
            // 
            this.telefon_textbox1.Location = new System.Drawing.Point(914, 130);
            this.telefon_textbox1.Name = "telefon_textbox1";
            this.telefon_textbox1.Size = new System.Drawing.Size(176, 28);
            this.telefon_textbox1.TabIndex = 8;
            // 
            // meslek_textbox1
            // 
            this.meslek_textbox1.Location = new System.Drawing.Point(914, 184);
            this.meslek_textbox1.Name = "meslek_textbox1";
            this.meslek_textbox1.Size = new System.Drawing.Size(176, 28);
            this.meslek_textbox1.TabIndex = 10;
            // 
            // ekle_buton1
            // 
            this.ekle_buton1.Location = new System.Drawing.Point(767, 235);
            this.ekle_buton1.Name = "ekle_buton1";
            this.ekle_buton1.Size = new System.Drawing.Size(72, 33);
            this.ekle_buton1.TabIndex = 11;
            this.ekle_buton1.Text = "EKLE";
            this.ekle_buton1.UseVisualStyleBackColor = true;
            this.ekle_buton1.Click += new System.EventHandler(this.ekle_buton1_Click);
            // 
            // sil_buton1
            // 
            this.sil_buton1.Location = new System.Drawing.Point(845, 235);
            this.sil_buton1.Name = "sil_buton1";
            this.sil_buton1.Size = new System.Drawing.Size(77, 33);
            this.sil_buton1.TabIndex = 12;
            this.sil_buton1.Text = "SİL";
            this.sil_buton1.UseVisualStyleBackColor = true;
            this.sil_buton1.Click += new System.EventHandler(this.sil_buton1_Click);
            // 
            // arama_buton1
            // 
            this.arama_buton1.Location = new System.Drawing.Point(931, 235);
            this.arama_buton1.Name = "arama_buton1";
            this.arama_buton1.Size = new System.Drawing.Size(86, 33);
            this.arama_buton1.TabIndex = 13;
            this.arama_buton1.Text = "ARAMA";
            this.arama_buton1.UseVisualStyleBackColor = true;
            this.arama_buton1.Click += new System.EventHandler(this.arama_buton1_Click);
            // 
            // guncelle_buton1
            // 
            this.guncelle_buton1.Location = new System.Drawing.Point(1023, 236);
            this.guncelle_buton1.Name = "guncelle_buton1";
            this.guncelle_buton1.Size = new System.Drawing.Size(129, 32);
            this.guncelle_buton1.TabIndex = 14;
            this.guncelle_buton1.Text = "GÜNCELLE";
            this.guncelle_buton1.UseVisualStyleBackColor = true;
            this.guncelle_buton1.Click += new System.EventHandler(this.guncelle_buton1_Click);
            // 
            // personelsayisi_textbox1
            // 
            this.personelsayisi_textbox1.Location = new System.Drawing.Point(778, 377);
            this.personelsayisi_textbox1.Name = "personelsayisi_textbox1";
            this.personelsayisi_textbox1.Size = new System.Drawing.Size(239, 29);
            this.personelsayisi_textbox1.TabIndex = 16;
            this.personelsayisi_textbox1.Text = "Personel Sayısı:";
            this.personelsayisi_textbox1.UseVisualStyleBackColor = true;
            this.personelsayisi_textbox1.Click += new System.EventHandler(this.personelsayisi_textbox1_Click);
            // 
            // listele_buton1
            // 
            this.listele_buton1.Location = new System.Drawing.Point(1158, 238);
            this.listele_buton1.Name = "listele_buton1";
            this.listele_buton1.Size = new System.Drawing.Size(97, 30);
            this.listele_buton1.TabIndex = 17;
            this.listele_buton1.Text = "LİSTELE";
            this.listele_buton1.UseVisualStyleBackColor = true;
            this.listele_buton1.Click += new System.EventHandler(this.listele_buton1_Click);
            // 
            // personelsayisi_label1
            // 
            this.personelsayisi_label1.AutoSize = true;
            this.personelsayisi_label1.Location = new System.Drawing.Point(1079, 377);
            this.personelsayisi_label1.Name = "personelsayisi_label1";
            this.personelsayisi_label1.Size = new System.Drawing.Size(45, 22);
            this.personelsayisi_label1.TabIndex = 18;
            this.personelsayisi_label1.Text = "Sayı";
            // 
            // soneklenenpersonel_button1
            // 
            this.soneklenenpersonel_button1.Location = new System.Drawing.Point(914, 423);
            this.soneklenenpersonel_button1.Name = "soneklenenpersonel_button1";
            this.soneklenenpersonel_button1.Size = new System.Drawing.Size(239, 30);
            this.soneklenenpersonel_button1.TabIndex = 19;
            this.soneklenenpersonel_button1.Text = "Son Eklenen Personel";
            this.soneklenenpersonel_button1.UseVisualStyleBackColor = true;
            this.soneklenenpersonel_button1.Click += new System.EventHandler(this.soneklenenpersonel_button1_Click);
            // 
            // adlistele_button1
            // 
            this.adlistele_button1.Location = new System.Drawing.Point(914, 333);
            this.adlistele_button1.Name = "adlistele_button1";
            this.adlistele_button1.Size = new System.Drawing.Size(406, 29);
            this.adlistele_button1.TabIndex = 20;
            this.adlistele_button1.Text = "Belirtilen Harfla Başlayan Personeller";
            this.adlistele_button1.UseVisualStyleBackColor = true;
            this.adlistele_button1.Click += new System.EventHandler(this.adlistele_button1_Click);
            // 
            // meslekgruppersonel_textbox1
            // 
            this.meslekgruppersonel_textbox1.Location = new System.Drawing.Point(810, 283);
            this.meslekgruppersonel_textbox1.Name = "meslekgruppersonel_textbox1";
            this.meslekgruppersonel_textbox1.Size = new System.Drawing.Size(389, 34);
            this.meslekgruppersonel_textbox1.TabIndex = 21;
            this.meslekgruppersonel_textbox1.Text = "Her Meslekten Çalışan Sayısı Öğren";
            this.meslekgruppersonel_textbox1.UseVisualStyleBackColor = true;
            this.meslekgruppersonel_textbox1.Click += new System.EventHandler(this.meslekgruppersonel_textbox1_Click_1);
            // 
            // harfgirin_textbox1
            // 
            this.harfgirin_textbox1.Location = new System.Drawing.Point(778, 334);
            this.harfgirin_textbox1.Name = "harfgirin_textbox1";
            this.harfgirin_textbox1.Size = new System.Drawing.Size(110, 28);
            this.harfgirin_textbox1.TabIndex = 22;
            this.harfgirin_textbox1.Text = "Harf Girin";
            // 
            // arama_buton2
            // 
            this.arama_buton2.Controls.Add(this.tabPage1);
            this.arama_buton2.Location = new System.Drawing.Point(0, 0);
            this.arama_buton2.Name = "arama_buton2";
            this.arama_buton2.SelectedIndex = 0;
            this.arama_buton2.Size = new System.Drawing.Size(1334, 504);
            this.arama_buton2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1346, 525);
            this.Controls.Add(this.arama_buton2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.arama_buton2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox harfgirin_textbox1;
        private System.Windows.Forms.TextBox meslek_textbox1;
        private System.Windows.Forms.TextBox telefon_textbox1;
        private System.Windows.Forms.TextBox soyad_textbox1;
        private System.Windows.Forms.TextBox ad_textbox1;
        private System.Windows.Forms.Button meslekgruppersonel_textbox1;
        private System.Windows.Forms.Button adlistele_button1;
        private System.Windows.Forms.Button soneklenenpersonel_button1;
        private System.Windows.Forms.Label personelsayisi_label1;
        private System.Windows.Forms.Button listele_buton1;
        private System.Windows.Forms.Button personelsayisi_textbox1;
        private System.Windows.Forms.Button guncelle_buton1;
        private System.Windows.Forms.Button arama_buton1;
        private System.Windows.Forms.Button sil_buton1;
        private System.Windows.Forms.Button ekle_buton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl arama_buton2;
    }
}

