namespace Project
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
            this.GirisKaydol = new System.Windows.Forms.TabControl();
            this.tab_GirisYap = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SifreDegistir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Giris_UyeOl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.txt_Giris_Parola = new System.Windows.Forms.TextBox();
            this.txt_Giris_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_Kaydol = new System.Windows.Forms.TabPage();
            this.bttnOnayla = new System.Windows.Forms.Button();
            this.grp_Musteri = new System.Windows.Forms.GroupBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.cmb_Kaydol_GuvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.btn_Kaydol = new System.Windows.Forms.Button();
            this.txt_Kaydol_Cevap = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_Kaydol_Parola = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Kaydol_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Kaydol_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_Kaydol_Ad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_KullaniciTuru = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tab_SifreDegistir = new System.Windows.Forms.TabPage();
            this.lblDegistirSifre = new System.Windows.Forms.Label();
            this.grp_SifreDegistir = new System.Windows.Forms.GroupBox();
            this.btn_Degistir = new System.Windows.Forms.Button();
            this.txt_YeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_YeniSifre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_GuvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.txt_SifreDegistir_Cevap = new System.Windows.Forms.TextBox();
            this.txt_SifreDegistir_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.GirisKaydol.SuspendLayout();
            this.tab_GirisYap.SuspendLayout();
            this.tab_Kaydol.SuspendLayout();
            this.grp_Musteri.SuspendLayout();
            this.tab_SifreDegistir.SuspendLayout();
            this.grp_SifreDegistir.SuspendLayout();
            this.SuspendLayout();
            // 
            // GirisKaydol
            // 
            this.GirisKaydol.Controls.Add(this.tab_GirisYap);
            this.GirisKaydol.Controls.Add(this.tab_Kaydol);
            this.GirisKaydol.Controls.Add(this.tab_SifreDegistir);
            this.GirisKaydol.Location = new System.Drawing.Point(24, 0);
            this.GirisKaydol.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GirisKaydol.Name = "GirisKaydol";
            this.GirisKaydol.SelectedIndex = 0;
            this.GirisKaydol.Size = new System.Drawing.Size(1318, 1313);
            this.GirisKaydol.TabIndex = 0;
            // 
            // tab_GirisYap
            // 
            this.tab_GirisYap.Controls.Add(this.label5);
            this.tab_GirisYap.Controls.Add(this.btn_SifreDegistir);
            this.tab_GirisYap.Controls.Add(this.label4);
            this.tab_GirisYap.Controls.Add(this.btn_Giris_UyeOl);
            this.tab_GirisYap.Controls.Add(this.label3);
            this.tab_GirisYap.Controls.Add(this.btn_GirisYap);
            this.tab_GirisYap.Controls.Add(this.txt_Giris_Parola);
            this.tab_GirisYap.Controls.Add(this.txt_Giris_kullaniciAdi);
            this.tab_GirisYap.Controls.Add(this.label2);
            this.tab_GirisYap.Controls.Add(this.label1);
            this.tab_GirisYap.Location = new System.Drawing.Point(8, 39);
            this.tab_GirisYap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_GirisYap.Name = "tab_GirisYap";
            this.tab_GirisYap.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_GirisYap.Size = new System.Drawing.Size(1302, 1266);
            this.tab_GirisYap.TabIndex = 0;
            this.tab_GirisYap.Text = "GirisYap";
            this.tab_GirisYap.UseVisualStyleBackColor = true;
            this.tab_GirisYap.Click += new System.EventHandler(this.tab_GirisYap_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(504, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 63);
            this.label5.TabIndex = 9;
            this.label5.Text = "PROJECT";
            // 
            // btn_SifreDegistir
            // 
            this.btn_SifreDegistir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_SifreDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SifreDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SifreDegistir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SifreDegistir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_SifreDegistir.Location = new System.Drawing.Point(618, 513);
            this.btn_SifreDegistir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_SifreDegistir.Name = "btn_SifreDegistir";
            this.btn_SifreDegistir.Size = new System.Drawing.Size(184, 44);
            this.btn_SifreDegistir.TabIndex = 5;
            this.btn_SifreDegistir.Text = "Şifreni Değiştir";
            this.btn_SifreDegistir.UseVisualStyleBackColor = false;
            this.btn_SifreDegistir.Click += new System.EventHandler(this.btn_SifreDegistir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(612, 483);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifreni mi unuttun ? ";
            // 
            // btn_Giris_UyeOl
            // 
            this.btn_Giris_UyeOl.BackColor = System.Drawing.Color.Salmon;
            this.btn_Giris_UyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Giris_UyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris_UyeOl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Giris_UyeOl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Giris_UyeOl.Location = new System.Drawing.Point(618, 754);
            this.btn_Giris_UyeOl.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Giris_UyeOl.Name = "btn_Giris_UyeOl";
            this.btn_Giris_UyeOl.Size = new System.Drawing.Size(184, 44);
            this.btn_Giris_UyeOl.TabIndex = 4;
            this.btn_Giris_UyeOl.Text = "Üye Ol";
            this.btn_Giris_UyeOl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Giris_UyeOl.UseCompatibleTextRendering = true;
            this.btn_Giris_UyeOl.UseVisualStyleBackColor = false;
            this.btn_Giris_UyeOl.Click += new System.EventHandler(this.btn_Giris_UyeOl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(550, 706);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Henüz üye değil misin ? ";
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_GirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GirisYap.Location = new System.Drawing.Point(618, 621);
            this.btn_GirisYap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(184, 44);
            this.btn_GirisYap.TabIndex = 3;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = false;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // txt_Giris_Parola
            // 
            this.txt_Giris_Parola.Location = new System.Drawing.Point(480, 438);
            this.txt_Giris_Parola.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Giris_Parola.MaxLength = 12;
            this.txt_Giris_Parola.Name = "txt_Giris_Parola";
            this.txt_Giris_Parola.Size = new System.Drawing.Size(470, 31);
            this.txt_Giris_Parola.TabIndex = 2;
            this.txt_Giris_Parola.TextChanged += new System.EventHandler(this.txt_Giris_Parola_TextChanged);
            this.txt_Giris_Parola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Giris_Parola_KeyPress);
            // 
            // txt_Giris_kullaniciAdi
            // 
            this.txt_Giris_kullaniciAdi.Location = new System.Drawing.Point(480, 350);
            this.txt_Giris_kullaniciAdi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Giris_kullaniciAdi.Name = "txt_Giris_kullaniciAdi";
            this.txt_Giris_kullaniciAdi.ShortcutsEnabled = false;
            this.txt_Giris_kullaniciAdi.Size = new System.Drawing.Size(470, 31);
            this.txt_Giris_kullaniciAdi.TabIndex = 1;
            this.txt_Giris_kullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Giris_kullaniciAdi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola           :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 356);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı  :";
            // 
            // tab_Kaydol
            // 
            this.tab_Kaydol.Controls.Add(this.bttnOnayla);
            this.tab_Kaydol.Controls.Add(this.grp_Musteri);
            this.tab_Kaydol.Controls.Add(this.cmb_KullaniciTuru);
            this.tab_Kaydol.Controls.Add(this.label10);
            this.tab_Kaydol.Location = new System.Drawing.Point(8, 39);
            this.tab_Kaydol.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_Kaydol.Name = "tab_Kaydol";
            this.tab_Kaydol.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_Kaydol.Size = new System.Drawing.Size(1302, 1266);
            this.tab_Kaydol.TabIndex = 1;
            this.tab_Kaydol.Text = "Kaydol";
            this.tab_Kaydol.UseVisualStyleBackColor = true;
            // 
            // bttnOnayla
            // 
            this.bttnOnayla.Location = new System.Drawing.Point(634, 102);
            this.bttnOnayla.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bttnOnayla.Name = "bttnOnayla";
            this.bttnOnayla.Size = new System.Drawing.Size(150, 44);
            this.bttnOnayla.TabIndex = 2;
            this.bttnOnayla.Text = "ONAYLA";
            this.bttnOnayla.UseVisualStyleBackColor = true;
            this.bttnOnayla.Click += new System.EventHandler(this.bttnOnayla_Click_1);
            // 
            // grp_Musteri
            // 
            this.grp_Musteri.Controls.Add(this.lblKullaniciAdi);
            this.grp_Musteri.Controls.Add(this.lblSifre);
            this.grp_Musteri.Controls.Add(this.cmb_Kaydol_GuvenlikSorusu);
            this.grp_Musteri.Controls.Add(this.btn_Kaydol);
            this.grp_Musteri.Controls.Add(this.txt_Kaydol_Cevap);
            this.grp_Musteri.Controls.Add(this.label18);
            this.grp_Musteri.Controls.Add(this.label19);
            this.grp_Musteri.Controls.Add(this.txt_Kaydol_Parola);
            this.grp_Musteri.Controls.Add(this.label7);
            this.grp_Musteri.Controls.Add(this.label6);
            this.grp_Musteri.Controls.Add(this.txt_Kaydol_Soyad);
            this.grp_Musteri.Controls.Add(this.txt_Kaydol_kullaniciAdi);
            this.grp_Musteri.Controls.Add(this.txt_Kaydol_Ad);
            this.grp_Musteri.Controls.Add(this.label9);
            this.grp_Musteri.Controls.Add(this.label8);
            this.grp_Musteri.Enabled = false;
            this.grp_Musteri.Location = new System.Drawing.Point(194, 158);
            this.grp_Musteri.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grp_Musteri.Name = "grp_Musteri";
            this.grp_Musteri.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grp_Musteri.Size = new System.Drawing.Size(990, 740);
            this.grp_Musteri.TabIndex = 16;
            this.grp_Musteri.TabStop = false;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(780, 244);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(0, 25);
            this.lblKullaniciAdi.TabIndex = 15;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(780, 319);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(0, 25);
            this.lblSifre.TabIndex = 14;
            // 
            // cmb_Kaydol_GuvenlikSorusu
            // 
            this.cmb_Kaydol_GuvenlikSorusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Kaydol_GuvenlikSorusu.FormattingEnabled = true;
            this.cmb_Kaydol_GuvenlikSorusu.Items.AddRange(new object[] {
            "İlk evcil hayvanınız",
            "Annenizin kızlık soyadı",
            "İlkokul öğretmeninizin adı",
            "İlk şehirdışı seyahatiniz"});
            this.cmb_Kaydol_GuvenlikSorusu.Location = new System.Drawing.Point(270, 410);
            this.cmb_Kaydol_GuvenlikSorusu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmb_Kaydol_GuvenlikSorusu.Name = "cmb_Kaydol_GuvenlikSorusu";
            this.cmb_Kaydol_GuvenlikSorusu.Size = new System.Drawing.Size(470, 33);
            this.cmb_Kaydol_GuvenlikSorusu.TabIndex = 7;
            // 
            // btn_Kaydol
            // 
            this.btn_Kaydol.Enabled = false;
            this.btn_Kaydol.Location = new System.Drawing.Point(594, 635);
            this.btn_Kaydol.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Kaydol.Name = "btn_Kaydol";
            this.btn_Kaydol.Size = new System.Drawing.Size(150, 44);
            this.btn_Kaydol.TabIndex = 9;
            this.btn_Kaydol.Text = "KAYDOL";
            this.btn_Kaydol.UseVisualStyleBackColor = true;
            this.btn_Kaydol.Click += new System.EventHandler(this.btn_Kaydol_Click_1);
            // 
            // txt_Kaydol_Cevap
            // 
            this.txt_Kaydol_Cevap.Location = new System.Drawing.Point(270, 513);
            this.txt_Kaydol_Cevap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Kaydol_Cevap.Name = "txt_Kaydol_Cevap";
            this.txt_Kaydol_Cevap.ShortcutsEnabled = false;
            this.txt_Kaydol_Cevap.Size = new System.Drawing.Size(470, 31);
            this.txt_Kaydol_Cevap.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(100, 513);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 25);
            this.label18.TabIndex = 13;
            this.label18.Text = "Cevap          :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(100, 415);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 50);
            this.label19.TabIndex = 12;
            this.label19.Text = "Güvenlik\r\nSorusu          :";
            // 
            // txt_Kaydol_Parola
            // 
            this.txt_Kaydol_Parola.Location = new System.Drawing.Point(270, 319);
            this.txt_Kaydol_Parola.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Kaydol_Parola.MaxLength = 12;
            this.txt_Kaydol_Parola.Name = "txt_Kaydol_Parola";
            this.txt_Kaydol_Parola.ShortcutsEnabled = false;
            this.txt_Kaydol_Parola.Size = new System.Drawing.Size(470, 31);
            this.txt_Kaydol_Parola.TabIndex = 6;
            this.txt_Kaydol_Parola.TextChanged += new System.EventHandler(this.txt_Kaydol_Parola_TextChanged);
            this.txt_Kaydol_Parola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Kaydol_Parola_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "KullanıcıAdı   :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Parola           :";
            // 
            // txt_Kaydol_Soyad
            // 
            this.txt_Kaydol_Soyad.Location = new System.Drawing.Point(270, 148);
            this.txt_Kaydol_Soyad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Kaydol_Soyad.Name = "txt_Kaydol_Soyad";
            this.txt_Kaydol_Soyad.ShortcutsEnabled = false;
            this.txt_Kaydol_Soyad.Size = new System.Drawing.Size(470, 31);
            this.txt_Kaydol_Soyad.TabIndex = 4;
            this.txt_Kaydol_Soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Kaydol_Soyad_KeyPress);
            // 
            // txt_Kaydol_kullaniciAdi
            // 
            this.txt_Kaydol_kullaniciAdi.Location = new System.Drawing.Point(270, 231);
            this.txt_Kaydol_kullaniciAdi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Kaydol_kullaniciAdi.Name = "txt_Kaydol_kullaniciAdi";
            this.txt_Kaydol_kullaniciAdi.ShortcutsEnabled = false;
            this.txt_Kaydol_kullaniciAdi.Size = new System.Drawing.Size(470, 31);
            this.txt_Kaydol_kullaniciAdi.TabIndex = 5;
            this.txt_Kaydol_kullaniciAdi.TextChanged += new System.EventHandler(this.txt_Kaydol_kullaniciAdi_TextChanged);
            this.txt_Kaydol_kullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Kaydol_kullaniciAdi_KeyPress);
            // 
            // txt_Kaydol_Ad
            // 
            this.txt_Kaydol_Ad.Location = new System.Drawing.Point(270, 60);
            this.txt_Kaydol_Ad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Kaydol_Ad.Name = "txt_Kaydol_Ad";
            this.txt_Kaydol_Ad.ShortcutsEnabled = false;
            this.txt_Kaydol_Ad.Size = new System.Drawing.Size(470, 31);
            this.txt_Kaydol_Ad.TabIndex = 3;
            this.txt_Kaydol_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Kaydol_Ad_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ad                 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Soyad           :";
            // 
            // cmb_KullaniciTuru
            // 
            this.cmb_KullaniciTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_KullaniciTuru.FormattingEnabled = true;
            this.cmb_KullaniciTuru.Items.AddRange(new object[] {
            "Müşteri",
            "Geliştirici",
            "Proje Yönetici"});
            this.cmb_KullaniciTuru.Location = new System.Drawing.Point(596, 31);
            this.cmb_KullaniciTuru.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmb_KullaniciTuru.Name = "cmb_KullaniciTuru";
            this.cmb_KullaniciTuru.Size = new System.Drawing.Size(238, 33);
            this.cmb_KullaniciTuru.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Kullanıcı Türü:";
            // 
            // tab_SifreDegistir
            // 
            this.tab_SifreDegistir.Controls.Add(this.lblDegistirSifre);
            this.tab_SifreDegistir.Controls.Add(this.grp_SifreDegistir);
            this.tab_SifreDegistir.Controls.Add(this.cmb_GuvenlikSorusu);
            this.tab_SifreDegistir.Controls.Add(this.txt_SifreDegistir_Cevap);
            this.tab_SifreDegistir.Controls.Add(this.txt_SifreDegistir_kullaniciAdi);
            this.tab_SifreDegistir.Controls.Add(this.label15);
            this.tab_SifreDegistir.Controls.Add(this.label14);
            this.tab_SifreDegistir.Controls.Add(this.label13);
            this.tab_SifreDegistir.Location = new System.Drawing.Point(8, 39);
            this.tab_SifreDegistir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_SifreDegistir.Name = "tab_SifreDegistir";
            this.tab_SifreDegistir.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_SifreDegistir.Size = new System.Drawing.Size(1302, 1266);
            this.tab_SifreDegistir.TabIndex = 2;
            this.tab_SifreDegistir.Text = "Şifre Değiştir";
            this.tab_SifreDegistir.UseVisualStyleBackColor = true;
            // 
            // lblDegistirSifre
            // 
            this.lblDegistirSifre.AutoSize = true;
            this.lblDegistirSifre.Location = new System.Drawing.Point(1056, 692);
            this.lblDegistirSifre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDegistirSifre.Name = "lblDegistirSifre";
            this.lblDegistirSifre.Size = new System.Drawing.Size(0, 25);
            this.lblDegistirSifre.TabIndex = 8;
            // 
            // grp_SifreDegistir
            // 
            this.grp_SifreDegistir.Controls.Add(this.btn_Degistir);
            this.grp_SifreDegistir.Controls.Add(this.txt_YeniSifreTekrar);
            this.grp_SifreDegistir.Controls.Add(this.label17);
            this.grp_SifreDegistir.Controls.Add(this.txt_YeniSifre);
            this.grp_SifreDegistir.Controls.Add(this.label16);
            this.grp_SifreDegistir.Location = new System.Drawing.Point(248, 573);
            this.grp_SifreDegistir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grp_SifreDegistir.Name = "grp_SifreDegistir";
            this.grp_SifreDegistir.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grp_SifreDegistir.Size = new System.Drawing.Size(796, 325);
            this.grp_SifreDegistir.TabIndex = 7;
            this.grp_SifreDegistir.TabStop = false;
            // 
            // btn_Degistir
            // 
            this.btn_Degistir.Location = new System.Drawing.Point(420, 269);
            this.btn_Degistir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Degistir.Name = "btn_Degistir";
            this.btn_Degistir.Size = new System.Drawing.Size(150, 44);
            this.btn_Degistir.TabIndex = 7;
            this.btn_Degistir.Text = "Değiştir";
            this.btn_Degistir.UseVisualStyleBackColor = true;
            this.btn_Degistir.Click += new System.EventHandler(this.btn_Degistir_Click);
            // 
            // txt_YeniSifreTekrar
            // 
            this.txt_YeniSifreTekrar.Location = new System.Drawing.Point(310, 169);
            this.txt_YeniSifreTekrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_YeniSifreTekrar.MaxLength = 12;
            this.txt_YeniSifreTekrar.Name = "txt_YeniSifreTekrar";
            this.txt_YeniSifreTekrar.ShortcutsEnabled = false;
            this.txt_YeniSifreTekrar.Size = new System.Drawing.Size(404, 31);
            this.txt_YeniSifreTekrar.TabIndex = 6;
            this.txt_YeniSifreTekrar.TextChanged += new System.EventHandler(this.txt_YeniSifreTekrar_TextChanged);
            this.txt_YeniSifreTekrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YeniSifreTekrar_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 169);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(194, 25);
            this.label17.TabIndex = 10;
            this.label17.Text = "Yeni Şifre(Tekrar) :";
            // 
            // txt_YeniSifre
            // 
            this.txt_YeniSifre.Location = new System.Drawing.Point(310, 73);
            this.txt_YeniSifre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_YeniSifre.MaxLength = 12;
            this.txt_YeniSifre.Name = "txt_YeniSifre";
            this.txt_YeniSifre.ShortcutsEnabled = false;
            this.txt_YeniSifre.Size = new System.Drawing.Size(404, 31);
            this.txt_YeniSifre.TabIndex = 5;
            this.txt_YeniSifre.TextChanged += new System.EventHandler(this.txt_YeniSifre_TextChanged);
            this.txt_YeniSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YeniSifre_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 73);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 25);
            this.label16.TabIndex = 8;
            this.label16.Text = "Yeni Şifre            :";
            // 
            // cmb_GuvenlikSorusu
            // 
            this.cmb_GuvenlikSorusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_GuvenlikSorusu.FormattingEnabled = true;
            this.cmb_GuvenlikSorusu.Items.AddRange(new object[] {
            "İlk evcil hayvanınız",
            "Annenizin kızlık soyadı",
            "İlkokul öğretmeninizin adı",
            "İlk şehirdışı seyahatiniz"});
            this.cmb_GuvenlikSorusu.Location = new System.Drawing.Point(558, 265);
            this.cmb_GuvenlikSorusu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmb_GuvenlikSorusu.Name = "cmb_GuvenlikSorusu";
            this.cmb_GuvenlikSorusu.Size = new System.Drawing.Size(404, 33);
            this.cmb_GuvenlikSorusu.TabIndex = 2;
            // 
            // txt_SifreDegistir_Cevap
            // 
            this.txt_SifreDegistir_Cevap.Location = new System.Drawing.Point(558, 369);
            this.txt_SifreDegistir_Cevap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_SifreDegistir_Cevap.Name = "txt_SifreDegistir_Cevap";
            this.txt_SifreDegistir_Cevap.ShortcutsEnabled = false;
            this.txt_SifreDegistir_Cevap.Size = new System.Drawing.Size(404, 31);
            this.txt_SifreDegistir_Cevap.TabIndex = 3;
            this.txt_SifreDegistir_Cevap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SifreDegistir_Cevap_KeyPress);
            // 
            // txt_SifreDegistir_kullaniciAdi
            // 
            this.txt_SifreDegistir_kullaniciAdi.Location = new System.Drawing.Point(558, 150);
            this.txt_SifreDegistir_kullaniciAdi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_SifreDegistir_kullaniciAdi.Name = "txt_SifreDegistir_kullaniciAdi";
            this.txt_SifreDegistir_kullaniciAdi.ShortcutsEnabled = false;
            this.txt_SifreDegistir_kullaniciAdi.Size = new System.Drawing.Size(404, 31);
            this.txt_SifreDegistir_kullaniciAdi.TabIndex = 1;
            this.txt_SifreDegistir_kullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SifreDegistir_kullaniciAdi_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 375);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Cevap                :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(280, 277);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "Güvenlik Sorusu :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 150);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Kullanıcı Adı       :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 875);
            this.Controls.Add(this.GirisKaydol);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GirisKaydol.ResumeLayout(false);
            this.tab_GirisYap.ResumeLayout(false);
            this.tab_GirisYap.PerformLayout();
            this.tab_Kaydol.ResumeLayout(false);
            this.tab_Kaydol.PerformLayout();
            this.grp_Musteri.ResumeLayout(false);
            this.grp_Musteri.PerformLayout();
            this.tab_SifreDegistir.ResumeLayout(false);
            this.tab_SifreDegistir.PerformLayout();
            this.grp_SifreDegistir.ResumeLayout(false);
            this.grp_SifreDegistir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl GirisKaydol;
        private System.Windows.Forms.TabPage tab_GirisYap;
        private System.Windows.Forms.Button btn_SifreDegistir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Giris_UyeOl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_GirisYap;
        private System.Windows.Forms.TextBox txt_Giris_Parola;
        private System.Windows.Forms.TextBox txt_Giris_kullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_Kaydol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Kaydol_Soyad;
        private System.Windows.Forms.TextBox txt_Kaydol_Ad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Kaydol_Parola;
        private System.Windows.Forms.TextBox txt_Kaydol_kullaniciAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grp_Musteri;
        private System.Windows.Forms.ComboBox cmb_KullaniciTuru;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Kaydol;
        private System.Windows.Forms.Button bttnOnayla;
        private System.Windows.Forms.TabPage tab_SifreDegistir;
        private System.Windows.Forms.GroupBox grp_SifreDegistir;
        private System.Windows.Forms.Button btn_Degistir;
        private System.Windows.Forms.TextBox txt_YeniSifreTekrar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_YeniSifre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_GuvenlikSorusu;
        private System.Windows.Forms.TextBox txt_SifreDegistir_Cevap;
        private System.Windows.Forms.TextBox txt_SifreDegistir_kullaniciAdi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_Kaydol_GuvenlikSorusu;
        private System.Windows.Forms.TextBox txt_Kaydol_Cevap;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblDegistirSifre;
    }
}

