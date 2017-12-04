namespace Project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.tb_Project2 = new System.Windows.Forms.TabControl();
            this.tab_SurecAnasayfa = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab_SurecEkle = new System.Windows.Forms.TabPage();
            this.cmb_Surec_Gelistirici = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SurecAdi = new System.Windows.Forms.TextBox();
            this.date_Bitis = new System.Windows.Forms.DateTimePicker();
            this.date_Baslama = new System.Windows.Forms.DateTimePicker();
            this.txt_Notlar = new System.Windows.Forms.TextBox();
            this.txt_Detay = new System.Windows.Forms.TextBox();
            this.txt_Priority = new System.Windows.Forms.TextBox();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tab_SurecGuncelle = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_Gun_Gelistirici = new System.Windows.Forms.ComboBox();
            this.date_Gun_Bit = new System.Windows.Forms.DateTimePicker();
            this.date_Gun_Bas = new System.Windows.Forms.DateTimePicker();
            this.txt_Gun_Notlar = new System.Windows.Forms.TextBox();
            this.txt_Gun_Detaylar = new System.Windows.Forms.TextBox();
            this.txt_Gun_Tamamlanma = new System.Windows.Forms.TextBox();
            this.txt_Gun_Oncelik = new System.Windows.Forms.TextBox();
            this.txt_Gun_Aciklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Surec_Guncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_surecler = new System.Windows.Forms.Label();
            this.cmb_Gun_Surecler = new System.Windows.Forms.ComboBox();
            this.btn_AltSurecler_Alt = new System.Windows.Forms.Button();
            this.btn_GeriDon = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.lblOncelik = new System.Windows.Forms.Label();
            this.lblYuzde = new System.Windows.Forms.Label();
            this.tb_Project2.SuspendLayout();
            this.tab_SurecAnasayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_SurecEkle.SuspendLayout();
            this.tab_SurecGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.BackgroundImage")));
            this.btn_Sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sil.FlatAppearance.BorderSize = 0;
            this.btn_Sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sil.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Sil.Location = new System.Drawing.Point(1086, 108);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(182, 123);
            this.btn_Sil.TabIndex = 7;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.BackgroundImage")));
            this.btn_Guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Guncelle.FlatAppearance.BorderSize = 0;
            this.btn_Guncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guncelle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.Location = new System.Drawing.Point(862, 108);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(182, 123);
            this.btn_Guncelle.TabIndex = 6;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.BackgroundImage")));
            this.btn_Ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ekle.FlatAppearance.BorderSize = 0;
            this.btn_Ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Ekle.Location = new System.Drawing.Point(640, 108);
            this.btn_Ekle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(182, 123);
            this.btn_Ekle.TabIndex = 5;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // tb_Project2
            // 
            this.tb_Project2.Controls.Add(this.tab_SurecAnasayfa);
            this.tb_Project2.Controls.Add(this.tab_SurecEkle);
            this.tb_Project2.Controls.Add(this.tab_SurecGuncelle);
            this.tb_Project2.Location = new System.Drawing.Point(72, 258);
            this.tb_Project2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_Project2.Name = "tb_Project2";
            this.tb_Project2.SelectedIndex = 0;
            this.tb_Project2.Size = new System.Drawing.Size(1888, 875);
            this.tb_Project2.TabIndex = 8;
            // 
            // tab_SurecAnasayfa
            // 
            this.tab_SurecAnasayfa.Controls.Add(this.dataGridView1);
            this.tab_SurecAnasayfa.Location = new System.Drawing.Point(8, 39);
            this.tab_SurecAnasayfa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_SurecAnasayfa.Name = "tab_SurecAnasayfa";
            this.tab_SurecAnasayfa.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_SurecAnasayfa.Size = new System.Drawing.Size(1872, 828);
            this.tab_SurecAnasayfa.TabIndex = 0;
            this.tab_SurecAnasayfa.Text = "Anasayfa";
            this.tab_SurecAnasayfa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-8, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1892, 875);
            this.dataGridView1.TabIndex = 0;
            // 
            // tab_SurecEkle
            // 
            this.tab_SurecEkle.Controls.Add(this.cmb_Surec_Gelistirici);
            this.tab_SurecEkle.Controls.Add(this.label11);
            this.tab_SurecEkle.Controls.Add(this.txt_SurecAdi);
            this.tab_SurecEkle.Controls.Add(this.date_Bitis);
            this.tab_SurecEkle.Controls.Add(this.date_Baslama);
            this.tab_SurecEkle.Controls.Add(this.txt_Notlar);
            this.tab_SurecEkle.Controls.Add(this.txt_Detay);
            this.tab_SurecEkle.Controls.Add(this.txt_Priority);
            this.tab_SurecEkle.Controls.Add(this.txt_Aciklama);
            this.tab_SurecEkle.Controls.Add(this.label8);
            this.tab_SurecEkle.Controls.Add(this.label9);
            this.tab_SurecEkle.Controls.Add(this.label10);
            this.tab_SurecEkle.Controls.Add(this.button1);
            this.tab_SurecEkle.Controls.Add(this.label12);
            this.tab_SurecEkle.Controls.Add(this.label13);
            this.tab_SurecEkle.Controls.Add(this.label14);
            this.tab_SurecEkle.Controls.Add(this.label15);
            this.tab_SurecEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tab_SurecEkle.Location = new System.Drawing.Point(8, 39);
            this.tab_SurecEkle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_SurecEkle.Name = "tab_SurecEkle";
            this.tab_SurecEkle.Size = new System.Drawing.Size(1872, 828);
            this.tab_SurecEkle.TabIndex = 2;
            this.tab_SurecEkle.Text = "Ekle";
            this.tab_SurecEkle.UseVisualStyleBackColor = true;
            // 
            // cmb_Surec_Gelistirici
            // 
            this.cmb_Surec_Gelistirici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Surec_Gelistirici.FormattingEnabled = true;
            this.cmb_Surec_Gelistirici.Location = new System.Drawing.Point(1006, 275);
            this.cmb_Surec_Gelistirici.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmb_Surec_Gelistirici.Name = "cmb_Surec_Gelistirici";
            this.cmb_Surec_Gelistirici.Size = new System.Drawing.Size(212, 34);
            this.cmb_Surec_Gelistirici.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(892, 288);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 26);
            this.label11.TabIndex = 37;
            this.label11.Text = "Geliştirici:";
            // 
            // txt_SurecAdi
            // 
            this.txt_SurecAdi.Location = new System.Drawing.Point(758, 60);
            this.txt_SurecAdi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_SurecAdi.Name = "txt_SurecAdi";
            this.txt_SurecAdi.ShortcutsEnabled = false;
            this.txt_SurecAdi.Size = new System.Drawing.Size(384, 32);
            this.txt_SurecAdi.TabIndex = 1;
            this.txt_SurecAdi.TextChanged += new System.EventHandler(this.txt_SurecAdi_TextChanged);
            this.txt_SurecAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SurecAdi_KeyPress);
            // 
            // date_Bitis
            // 
            this.date_Bitis.Location = new System.Drawing.Point(1006, 181);
            this.date_Bitis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.date_Bitis.Name = "date_Bitis";
            this.date_Bitis.Size = new System.Drawing.Size(208, 32);
            this.date_Bitis.TabIndex = 3;
            // 
            // date_Baslama
            // 
            this.date_Baslama.Location = new System.Drawing.Point(640, 181);
            this.date_Baslama.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.date_Baslama.Name = "date_Baslama";
            this.date_Baslama.Size = new System.Drawing.Size(210, 32);
            this.date_Baslama.TabIndex = 2;
            this.date_Baslama.ValueChanged += new System.EventHandler(this.date_Baslama_ValueChanged);
            // 
            // txt_Notlar
            // 
            this.txt_Notlar.Location = new System.Drawing.Point(1254, 458);
            this.txt_Notlar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Notlar.Multiline = true;
            this.txt_Notlar.Name = "txt_Notlar";
            this.txt_Notlar.ShortcutsEnabled = false;
            this.txt_Notlar.Size = new System.Drawing.Size(342, 156);
            this.txt_Notlar.TabIndex = 8;
            this.txt_Notlar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Notlar_KeyPress);
            // 
            // txt_Detay
            // 
            this.txt_Detay.Location = new System.Drawing.Point(194, 458);
            this.txt_Detay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Detay.Multiline = true;
            this.txt_Detay.Name = "txt_Detay";
            this.txt_Detay.ShortcutsEnabled = false;
            this.txt_Detay.Size = new System.Drawing.Size(350, 156);
            this.txt_Detay.TabIndex = 6;
            this.txt_Detay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Detay_KeyPress);
            // 
            // txt_Priority
            // 
            this.txt_Priority.Location = new System.Drawing.Point(640, 275);
            this.txt_Priority.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Priority.MaxLength = 10;
            this.txt_Priority.Name = "txt_Priority";
            this.txt_Priority.ShortcutsEnabled = false;
            this.txt_Priority.Size = new System.Drawing.Size(210, 32);
            this.txt_Priority.TabIndex = 4;
            this.txt_Priority.TextChanged += new System.EventHandler(this.txt_Priority_TextChanged);
            this.txt_Priority.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Priority_KeyPress);
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(730, 458);
            this.txt_Aciklama.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.ShortcutsEnabled = false;
            this.txt_Aciklama.Size = new System.Drawing.Size(344, 156);
            this.txt_Aciklama.TabIndex = 7;
            this.txt_Aciklama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Aciklama_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1130, 463);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "NOTLAR:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(592, 473);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 26);
            this.label9.TabIndex = 25;
            this.label9.Text = "Açıklama:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 463);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 26);
            this.label10.TabIndex = 24;
            this.label10.Text = "Detaylar:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(814, 654);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 131);
            this.button1.TabIndex = 9;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(474, 263);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 52);
            this.label12.TabIndex = 21;
            this.label12.Text = "     Öncelik:\r\n(1-10 arasında)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(890, 181);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 26);
            this.label13.TabIndex = 20;
            this.label13.Text = "Bit. Tarihi: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(506, 181);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 26);
            this.label14.TabIndex = 19;
            this.label14.Text = "Baş. Tarihi: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(622, 60);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 26);
            this.label15.TabIndex = 18;
            this.label15.Text = "Süreç Adı : ";
            // 
            // tab_SurecGuncelle
            // 
            this.tab_SurecGuncelle.Controls.Add(this.lblYuzde);
            this.tab_SurecGuncelle.Controls.Add(this.lblOncelik);
            this.tab_SurecGuncelle.Controls.Add(this.label16);
            this.tab_SurecGuncelle.Controls.Add(this.cmb_Gun_Gelistirici);
            this.tab_SurecGuncelle.Controls.Add(this.date_Gun_Bit);
            this.tab_SurecGuncelle.Controls.Add(this.date_Gun_Bas);
            this.tab_SurecGuncelle.Controls.Add(this.txt_Gun_Notlar);
            this.tab_SurecGuncelle.Controls.Add(this.txt_Gun_Detaylar);
            this.tab_SurecGuncelle.Controls.Add(this.txt_Gun_Tamamlanma);
            this.tab_SurecGuncelle.Controls.Add(this.txt_Gun_Oncelik);
            this.tab_SurecGuncelle.Controls.Add(this.txt_Gun_Aciklama);
            this.tab_SurecGuncelle.Controls.Add(this.label7);
            this.tab_SurecGuncelle.Controls.Add(this.label6);
            this.tab_SurecGuncelle.Controls.Add(this.label5);
            this.tab_SurecGuncelle.Controls.Add(this.btn_Surec_Guncelle);
            this.tab_SurecGuncelle.Controls.Add(this.label4);
            this.tab_SurecGuncelle.Controls.Add(this.label3);
            this.tab_SurecGuncelle.Controls.Add(this.label2);
            this.tab_SurecGuncelle.Controls.Add(this.label1);
            this.tab_SurecGuncelle.Controls.Add(this.lbl_surecler);
            this.tab_SurecGuncelle.Controls.Add(this.cmb_Gun_Surecler);
            this.tab_SurecGuncelle.Location = new System.Drawing.Point(8, 39);
            this.tab_SurecGuncelle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_SurecGuncelle.Name = "tab_SurecGuncelle";
            this.tab_SurecGuncelle.Size = new System.Drawing.Size(1872, 828);
            this.tab_SurecGuncelle.TabIndex = 3;
            this.tab_SurecGuncelle.Text = "Güncelle";
            this.tab_SurecGuncelle.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1026, 298);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "Gelişticiler";
            // 
            // cmb_Gun_Gelistirici
            // 
            this.cmb_Gun_Gelistirici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gun_Gelistirici.FormattingEnabled = true;
            this.cmb_Gun_Gelistirici.Location = new System.Drawing.Point(1162, 290);
            this.cmb_Gun_Gelistirici.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmb_Gun_Gelistirici.Name = "cmb_Gun_Gelistirici";
            this.cmb_Gun_Gelistirici.Size = new System.Drawing.Size(238, 33);
            this.cmb_Gun_Gelistirici.TabIndex = 6;
            // 
            // date_Gun_Bit
            // 
            this.date_Gun_Bit.Location = new System.Drawing.Point(976, 163);
            this.date_Gun_Bit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.date_Gun_Bit.Name = "date_Gun_Bit";
            this.date_Gun_Bit.Size = new System.Drawing.Size(208, 31);
            this.date_Gun_Bit.TabIndex = 3;
            // 
            // date_Gun_Bas
            // 
            this.date_Gun_Bas.Location = new System.Drawing.Point(568, 163);
            this.date_Gun_Bas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.date_Gun_Bas.Name = "date_Gun_Bas";
            this.date_Gun_Bas.Size = new System.Drawing.Size(210, 31);
            this.date_Gun_Bas.TabIndex = 2;
            this.date_Gun_Bas.ValueChanged += new System.EventHandler(this.date_Gun_Bas_ValueChanged);
            // 
            // txt_Gun_Notlar
            // 
            this.txt_Gun_Notlar.Location = new System.Drawing.Point(1232, 448);
            this.txt_Gun_Notlar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Gun_Notlar.Multiline = true;
            this.txt_Gun_Notlar.Name = "txt_Gun_Notlar";
            this.txt_Gun_Notlar.ShortcutsEnabled = false;
            this.txt_Gun_Notlar.Size = new System.Drawing.Size(350, 156);
            this.txt_Gun_Notlar.TabIndex = 9;
            this.txt_Gun_Notlar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Gun_Notlar_KeyPress);
            // 
            // txt_Gun_Detaylar
            // 
            this.txt_Gun_Detaylar.Location = new System.Drawing.Point(170, 448);
            this.txt_Gun_Detaylar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Gun_Detaylar.Multiline = true;
            this.txt_Gun_Detaylar.Name = "txt_Gun_Detaylar";
            this.txt_Gun_Detaylar.ShortcutsEnabled = false;
            this.txt_Gun_Detaylar.Size = new System.Drawing.Size(350, 156);
            this.txt_Gun_Detaylar.TabIndex = 7;
            this.txt_Gun_Detaylar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Gun_Detaylar_KeyPress);
            // 
            // txt_Gun_Tamamlanma
            // 
            this.txt_Gun_Tamamlanma.Location = new System.Drawing.Point(724, 292);
            this.txt_Gun_Tamamlanma.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Gun_Tamamlanma.MaxLength = 100;
            this.txt_Gun_Tamamlanma.Name = "txt_Gun_Tamamlanma";
            this.txt_Gun_Tamamlanma.ShortcutsEnabled = false;
            this.txt_Gun_Tamamlanma.Size = new System.Drawing.Size(238, 31);
            this.txt_Gun_Tamamlanma.TabIndex = 5;
            this.txt_Gun_Tamamlanma.TextChanged += new System.EventHandler(this.txt_Gun_Tamamlanma_TextChanged);
            this.txt_Gun_Tamamlanma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Gun_Tamamlanma_KeyPress);
            // 
            // txt_Gun_Oncelik
            // 
            this.txt_Gun_Oncelik.Location = new System.Drawing.Point(300, 287);
            this.txt_Gun_Oncelik.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Gun_Oncelik.MaxLength = 10;
            this.txt_Gun_Oncelik.Name = "txt_Gun_Oncelik";
            this.txt_Gun_Oncelik.ShortcutsEnabled = false;
            this.txt_Gun_Oncelik.Size = new System.Drawing.Size(196, 31);
            this.txt_Gun_Oncelik.TabIndex = 4;
            this.txt_Gun_Oncelik.TextChanged += new System.EventHandler(this.txt_Gun_Oncelik_TextChanged);
            this.txt_Gun_Oncelik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Gun_Oncelik_KeyPress);
            // 
            // txt_Gun_Aciklama
            // 
            this.txt_Gun_Aciklama.Location = new System.Drawing.Point(702, 448);
            this.txt_Gun_Aciklama.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Gun_Aciklama.Multiline = true;
            this.txt_Gun_Aciklama.Name = "txt_Gun_Aciklama";
            this.txt_Gun_Aciklama.ShortcutsEnabled = false;
            this.txt_Gun_Aciklama.Size = new System.Drawing.Size(350, 156);
            this.txt_Gun_Aciklama.TabIndex = 8;
            this.txt_Gun_Aciklama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Gun_Aciklama_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1112, 454);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "NOTLAR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 463);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 454);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Detaylar:";
            // 
            // btn_Surec_Guncelle
            // 
            this.btn_Surec_Guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Surec_Guncelle.BackgroundImage")));
            this.btn_Surec_Guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Surec_Guncelle.FlatAppearance.BorderSize = 0;
            this.btn_Surec_Guncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Surec_Guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Surec_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Surec_Guncelle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Surec_Guncelle.Location = new System.Drawing.Point(782, 654);
            this.btn_Surec_Guncelle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Surec_Guncelle.Name = "btn_Surec_Guncelle";
            this.btn_Surec_Guncelle.Size = new System.Drawing.Size(234, 131);
            this.btn_Surec_Guncelle.TabIndex = 10;
            this.btn_Surec_Guncelle.Text = "GÜNCELLE";
            this.btn_Surec_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Surec_Guncelle.Click += new System.EventHandler(this.btn_Surec_Guncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tamamlanma\r\nDurumu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öncelik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(850, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bit. Tarihi: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Baş. Tarihi: ";
            // 
            // lbl_surecler
            // 
            this.lbl_surecler.AutoSize = true;
            this.lbl_surecler.Location = new System.Drawing.Point(548, 67);
            this.lbl_surecler.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_surecler.Name = "lbl_surecler";
            this.lbl_surecler.Size = new System.Drawing.Size(104, 25);
            this.lbl_surecler.TabIndex = 1;
            this.lbl_surecler.Text = "Süreçler: ";
            // 
            // cmb_Gun_Surecler
            // 
            this.cmb_Gun_Surecler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gun_Surecler.FormattingEnabled = true;
            this.cmb_Gun_Surecler.Location = new System.Drawing.Point(668, 52);
            this.cmb_Gun_Surecler.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmb_Gun_Surecler.Name = "cmb_Gun_Surecler";
            this.cmb_Gun_Surecler.Size = new System.Drawing.Size(384, 33);
            this.cmb_Gun_Surecler.TabIndex = 1;
            // 
            // btn_AltSurecler_Alt
            // 
            this.btn_AltSurecler_Alt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AltSurecler_Alt.BackgroundImage")));
            this.btn_AltSurecler_Alt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AltSurecler_Alt.FlatAppearance.BorderSize = 0;
            this.btn_AltSurecler_Alt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_AltSurecler_Alt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AltSurecler_Alt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AltSurecler_Alt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AltSurecler_Alt.ForeColor = System.Drawing.Color.Navy;
            this.btn_AltSurecler_Alt.Location = new System.Drawing.Point(1334, 123);
            this.btn_AltSurecler_Alt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_AltSurecler_Alt.Name = "btn_AltSurecler_Alt";
            this.btn_AltSurecler_Alt.Size = new System.Drawing.Size(216, 123);
            this.btn_AltSurecler_Alt.TabIndex = 9;
            this.btn_AltSurecler_Alt.Text = "         \r\n           Alt \r\n           Süreçler";
            this.btn_AltSurecler_Alt.UseVisualStyleBackColor = true;
            this.btn_AltSurecler_Alt.Click += new System.EventHandler(this.btn_AltSurecler_Alt_Click);
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GeriDon.BackgroundImage")));
            this.btn_GeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GeriDon.FlatAppearance.BorderSize = 0;
            this.btn_GeriDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_GeriDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GeriDon.ForeColor = System.Drawing.Color.Navy;
            this.btn_GeriDon.Location = new System.Drawing.Point(324, 123);
            this.btn_GeriDon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(216, 123);
            this.btn_GeriDon.TabIndex = 10;
            this.btn_GeriDon.Text = "Projelere \r\nGeri\r\nDön";
            this.btn_GeriDon.UseVisualStyleBackColor = true;
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.FlatAppearance.BorderSize = 0;
            this.btn_cikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(1852, 42);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(112, 100);
            this.btn_cikis.TabIndex = 11;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // lblOncelik
            // 
            this.lblOncelik.AutoSize = true;
            this.lblOncelik.Location = new System.Drawing.Point(300, 328);
            this.lblOncelik.Name = "lblOncelik";
            this.lblOncelik.Size = new System.Drawing.Size(0, 25);
            this.lblOncelik.TabIndex = 21;
            // 
            // lblYuzde
            // 
            this.lblYuzde.AutoSize = true;
            this.lblYuzde.Location = new System.Drawing.Point(684, 295);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(31, 25);
            this.lblYuzde.TabIndex = 22;
            this.lblYuzde.Text = "%";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2026, 1315);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_GeriDon);
            this.Controls.Add(this.btn_AltSurecler_Alt);
            this.Controls.Add(this.tb_Project2);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form3";
            this.Text = "Process";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tb_Project2.ResumeLayout(false);
            this.tab_SurecAnasayfa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_SurecEkle.ResumeLayout(false);
            this.tab_SurecEkle.PerformLayout();
            this.tab_SurecGuncelle.ResumeLayout(false);
            this.tab_SurecGuncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TabControl tb_Project2;
        private System.Windows.Forms.TabPage tab_SurecAnasayfa;
        private System.Windows.Forms.TabPage tab_SurecEkle;
        private System.Windows.Forms.TabPage tab_SurecGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Surec_Guncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_surecler;
        private System.Windows.Forms.ComboBox cmb_Gun_Surecler;
        private System.Windows.Forms.DateTimePicker date_Gun_Bit;
        private System.Windows.Forms.DateTimePicker date_Gun_Bas;
        private System.Windows.Forms.TextBox txt_Gun_Notlar;
        private System.Windows.Forms.TextBox txt_Gun_Detaylar;
        private System.Windows.Forms.TextBox txt_Gun_Tamamlanma;
        private System.Windows.Forms.TextBox txt_Gun_Oncelik;
        private System.Windows.Forms.TextBox txt_Gun_Aciklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SurecAdi;
        private System.Windows.Forms.DateTimePicker date_Bitis;
        private System.Windows.Forms.DateTimePicker date_Baslama;
        private System.Windows.Forms.TextBox txt_Notlar;
        private System.Windows.Forms.TextBox txt_Detay;
        private System.Windows.Forms.TextBox txt_Priority;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_AltSurecler_Alt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_Surec_Gelistirici;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_Gun_Gelistirici;
        private System.Windows.Forms.Button btn_GeriDon;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label lblYuzde;
        private System.Windows.Forms.Label lblOncelik;
    }
}