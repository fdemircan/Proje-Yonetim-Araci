namespace Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tb_Project = new System.Windows.Forms.TabControl();
            this.tab_Anasayfa = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab_Ekle = new System.Windows.Forms.TabPage();
            this.grp_ekle = new System.Windows.Forms.GroupBox();
            this.lbl_ProjeAdi = new System.Windows.Forms.Label();
            this.btn_projeEkle = new System.Windows.Forms.Button();
            this.txt_ProjeAdi = new System.Windows.Forms.TextBox();
            this.cmb_projeYoneticisi = new System.Windows.Forms.ComboBox();
            this.lbl_BasTarihi = new System.Windows.Forms.Label();
            this.lbl_ProjeYoneticisi = new System.Windows.Forms.Label();
            this.lbl_BitTarihi = new System.Windows.Forms.Label();
            this.lbl_Butce = new System.Windows.Forms.Label();
            this.date_Baslangic = new System.Windows.Forms.DateTimePicker();
            this.txt_Butce = new System.Windows.Forms.TextBox();
            this.date_Bitis = new System.Windows.Forms.DateTimePicker();
            this.tab_Guncelle = new System.Windows.Forms.TabPage();
            this.grp_guncelle = new System.Windows.Forms.GroupBox();
            this.lbl_Gun_ProjeAdi = new System.Windows.Forms.Label();
            this.cmb_Gun_ProjeAdi = new System.Windows.Forms.ComboBox();
            this.lbl_Gun_Baslangic = new System.Windows.Forms.Label();
            this.btn_Gun_Proje = new System.Windows.Forms.Button();
            this.lbl_Gun_Bitis = new System.Windows.Forms.Label();
            this.cmb_Gun_PtojeYoneticisi = new System.Windows.Forms.ComboBox();
            this.date_Gun_Baslangic = new System.Windows.Forms.DateTimePicker();
            this.lbl_Gun_ProjeYoneticisi = new System.Windows.Forms.Label();
            this.date_Gun_Bitis = new System.Windows.Forms.DateTimePicker();
            this.lbl_Gun_Butce = new System.Windows.Forms.Label();
            this.txt_Gun_Butce = new System.Windows.Forms.TextBox();
            this.tb_gorevlerim = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Surec = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.tb_Project.SuspendLayout();
            this.tab_Anasayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_Ekle.SuspendLayout();
            this.grp_ekle.SuspendLayout();
            this.tab_Guncelle.SuspendLayout();
            this.grp_guncelle.SuspendLayout();
            this.tb_gorevlerim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Project
            // 
            this.tb_Project.Controls.Add(this.tab_Anasayfa);
            this.tb_Project.Controls.Add(this.tab_Ekle);
            this.tb_Project.Controls.Add(this.tab_Guncelle);
            this.tb_Project.Controls.Add(this.tb_gorevlerim);
            this.tb_Project.Location = new System.Drawing.Point(60, 271);
            this.tb_Project.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_Project.Name = "tb_Project";
            this.tb_Project.SelectedIndex = 0;
            this.tb_Project.Size = new System.Drawing.Size(1904, 925);
            this.tb_Project.TabIndex = 0;
            // 
            // tab_Anasayfa
            // 
            this.tab_Anasayfa.Controls.Add(this.dataGridView1);
            this.tab_Anasayfa.Location = new System.Drawing.Point(8, 39);
            this.tab_Anasayfa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_Anasayfa.Name = "tab_Anasayfa";
            this.tab_Anasayfa.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_Anasayfa.Size = new System.Drawing.Size(1888, 878);
            this.tab_Anasayfa.TabIndex = 0;
            this.tab_Anasayfa.Text = "Anasayfa";
            this.tab_Anasayfa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1892, 875);
            this.dataGridView1.TabIndex = 0;
            // 
            // tab_Ekle
            // 
            this.tab_Ekle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tab_Ekle.Controls.Add(this.grp_ekle);
            this.tab_Ekle.Location = new System.Drawing.Point(8, 39);
            this.tab_Ekle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_Ekle.Name = "tab_Ekle";
            this.tab_Ekle.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_Ekle.Size = new System.Drawing.Size(1888, 878);
            this.tab_Ekle.TabIndex = 1;
            this.tab_Ekle.Text = "Ekle";
            this.tab_Ekle.Click += new System.EventHandler(this.tab_Ekle_Click);
            // 
            // grp_ekle
            // 
            this.grp_ekle.Controls.Add(this.lbl_ProjeAdi);
            this.grp_ekle.Controls.Add(this.btn_projeEkle);
            this.grp_ekle.Controls.Add(this.txt_ProjeAdi);
            this.grp_ekle.Controls.Add(this.cmb_projeYoneticisi);
            this.grp_ekle.Controls.Add(this.lbl_BasTarihi);
            this.grp_ekle.Controls.Add(this.lbl_ProjeYoneticisi);
            this.grp_ekle.Controls.Add(this.lbl_BitTarihi);
            this.grp_ekle.Controls.Add(this.lbl_Butce);
            this.grp_ekle.Controls.Add(this.date_Baslangic);
            this.grp_ekle.Controls.Add(this.txt_Butce);
            this.grp_ekle.Controls.Add(this.date_Bitis);
            this.grp_ekle.Location = new System.Drawing.Point(396, 88);
            this.grp_ekle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grp_ekle.Name = "grp_ekle";
            this.grp_ekle.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grp_ekle.Size = new System.Drawing.Size(1134, 598);
            this.grp_ekle.TabIndex = 10;
            this.grp_ekle.TabStop = false;
            // 
            // lbl_ProjeAdi
            // 
            this.lbl_ProjeAdi.AutoSize = true;
            this.lbl_ProjeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProjeAdi.Location = new System.Drawing.Point(62, 119);
            this.lbl_ProjeAdi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ProjeAdi.Name = "lbl_ProjeAdi";
            this.lbl_ProjeAdi.Size = new System.Drawing.Size(113, 26);
            this.lbl_ProjeAdi.TabIndex = 0;
            this.lbl_ProjeAdi.Text = "Proje Adı: ";
            // 
            // btn_projeEkle
            // 
            this.btn_projeEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_projeEkle.BackgroundImage")));
            this.btn_projeEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_projeEkle.FlatAppearance.BorderSize = 0;
            this.btn_projeEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_projeEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_projeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_projeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_projeEkle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_projeEkle.Location = new System.Drawing.Point(456, 429);
            this.btn_projeEkle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_projeEkle.Name = "btn_projeEkle";
            this.btn_projeEkle.Size = new System.Drawing.Size(236, 127);
            this.btn_projeEkle.TabIndex = 6;
            this.btn_projeEkle.Text = "EKLE";
            this.btn_projeEkle.UseVisualStyleBackColor = true;
            this.btn_projeEkle.Click += new System.EventHandler(this.btn_projeEkle_Click);
            // 
            // txt_ProjeAdi
            // 
            this.txt_ProjeAdi.Location = new System.Drawing.Point(266, 106);
            this.txt_ProjeAdi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_ProjeAdi.Name = "txt_ProjeAdi";
            this.txt_ProjeAdi.ShortcutsEnabled = false;
            this.txt_ProjeAdi.Size = new System.Drawing.Size(718, 31);
            this.txt_ProjeAdi.TabIndex = 1;
            this.txt_ProjeAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProjeAdi_KeyPress);
            // 
            // cmb_projeYoneticisi
            // 
            this.cmb_projeYoneticisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_projeYoneticisi.FormattingEnabled = true;
            this.cmb_projeYoneticisi.Location = new System.Drawing.Point(746, 335);
            this.cmb_projeYoneticisi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmb_projeYoneticisi.Name = "cmb_projeYoneticisi";
            this.cmb_projeYoneticisi.Size = new System.Drawing.Size(238, 33);
            this.cmb_projeYoneticisi.TabIndex = 5;
            this.cmb_projeYoneticisi.SelectedIndexChanged += new System.EventHandler(this.cmb_projeYoneticisi_SelectedIndexChanged);
            // 
            // lbl_BasTarihi
            // 
            this.lbl_BasTarihi.AutoSize = true;
            this.lbl_BasTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BasTarihi.Location = new System.Drawing.Point(62, 240);
            this.lbl_BasTarihi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_BasTarihi.Name = "lbl_BasTarihi";
            this.lbl_BasTarihi.Size = new System.Drawing.Size(178, 26);
            this.lbl_BasTarihi.TabIndex = 2;
            this.lbl_BasTarihi.Text = "Başlangıç Tarihi :";
            // 
            // lbl_ProjeYoneticisi
            // 
            this.lbl_ProjeYoneticisi.AutoSize = true;
            this.lbl_ProjeYoneticisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProjeYoneticisi.Location = new System.Drawing.Point(564, 342);
            this.lbl_ProjeYoneticisi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ProjeYoneticisi.Name = "lbl_ProjeYoneticisi";
            this.lbl_ProjeYoneticisi.Size = new System.Drawing.Size(176, 26);
            this.lbl_ProjeYoneticisi.TabIndex = 8;
            this.lbl_ProjeYoneticisi.Text = "Proje Yöneticisi: ";
            // 
            // lbl_BitTarihi
            // 
            this.lbl_BitTarihi.AutoSize = true;
            this.lbl_BitTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BitTarihi.Location = new System.Drawing.Point(608, 240);
            this.lbl_BitTarihi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_BitTarihi.Name = "lbl_BitTarihi";
            this.lbl_BitTarihi.Size = new System.Drawing.Size(125, 26);
            this.lbl_BitTarihi.TabIndex = 3;
            this.lbl_BitTarihi.Text = "Bitiş Tarihi: ";
            // 
            // lbl_Butce
            // 
            this.lbl_Butce.AutoSize = true;
            this.lbl_Butce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Butce.Location = new System.Drawing.Point(62, 342);
            this.lbl_Butce.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Butce.Name = "lbl_Butce";
            this.lbl_Butce.Size = new System.Drawing.Size(80, 26);
            this.lbl_Butce.TabIndex = 7;
            this.lbl_Butce.Text = "Bütce: ";
            // 
            // date_Baslangic
            // 
            this.date_Baslangic.Location = new System.Drawing.Point(266, 229);
            this.date_Baslangic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.date_Baslangic.Name = "date_Baslangic";
            this.date_Baslangic.Size = new System.Drawing.Size(234, 31);
            this.date_Baslangic.TabIndex = 2;
            this.date_Baslangic.ValueChanged += new System.EventHandler(this.date_Baslangic_ValueChanged);
            // 
            // txt_Butce
            // 
            this.txt_Butce.Location = new System.Drawing.Point(266, 337);
            this.txt_Butce.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Butce.Name = "txt_Butce";
            this.txt_Butce.Size = new System.Drawing.Size(234, 31);
            this.txt_Butce.TabIndex = 4;
            this.txt_Butce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Butce_KeyPress);
            // 
            // date_Bitis
            // 
            this.date_Bitis.Location = new System.Drawing.Point(746, 231);
            this.date_Bitis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.date_Bitis.Name = "date_Bitis";
            this.date_Bitis.Size = new System.Drawing.Size(238, 31);
            this.date_Bitis.TabIndex = 5;
            // 
            // tab_Guncelle
            // 
            this.tab_Guncelle.Controls.Add(this.grp_guncelle);
            this.tab_Guncelle.Location = new System.Drawing.Point(8, 39);
            this.tab_Guncelle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_Guncelle.Name = "tab_Guncelle";
            this.tab_Guncelle.Size = new System.Drawing.Size(1888, 878);
            this.tab_Guncelle.TabIndex = 2;
            this.tab_Guncelle.Text = "Güncelle";
            this.tab_Guncelle.UseVisualStyleBackColor = true;
            // 
            // grp_guncelle
            // 
            this.grp_guncelle.Controls.Add(this.lbl_Gun_ProjeAdi);
            this.grp_guncelle.Controls.Add(this.cmb_Gun_ProjeAdi);
            this.grp_guncelle.Controls.Add(this.lbl_Gun_Baslangic);
            this.grp_guncelle.Controls.Add(this.btn_Gun_Proje);
            this.grp_guncelle.Controls.Add(this.lbl_Gun_Bitis);
            this.grp_guncelle.Controls.Add(this.cmb_Gun_PtojeYoneticisi);
            this.grp_guncelle.Controls.Add(this.date_Gun_Baslangic);
            this.grp_guncelle.Controls.Add(this.lbl_Gun_ProjeYoneticisi);
            this.grp_guncelle.Controls.Add(this.date_Gun_Bitis);
            this.grp_guncelle.Controls.Add(this.lbl_Gun_Butce);
            this.grp_guncelle.Controls.Add(this.txt_Gun_Butce);
            this.grp_guncelle.Location = new System.Drawing.Point(458, 94);
            this.grp_guncelle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grp_guncelle.Name = "grp_guncelle";
            this.grp_guncelle.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grp_guncelle.Size = new System.Drawing.Size(1050, 579);
            this.grp_guncelle.TabIndex = 22;
            this.grp_guncelle.TabStop = false;
            // 
            // lbl_Gun_ProjeAdi
            // 
            this.lbl_Gun_ProjeAdi.AutoSize = true;
            this.lbl_Gun_ProjeAdi.Location = new System.Drawing.Point(12, 67);
            this.lbl_Gun_ProjeAdi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Gun_ProjeAdi.Name = "lbl_Gun_ProjeAdi";
            this.lbl_Gun_ProjeAdi.Size = new System.Drawing.Size(111, 25);
            this.lbl_Gun_ProjeAdi.TabIndex = 10;
            this.lbl_Gun_ProjeAdi.Text = "Proje Adı: ";
            // 
            // cmb_Gun_ProjeAdi
            // 
            this.cmb_Gun_ProjeAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gun_ProjeAdi.FormattingEnabled = true;
            this.cmb_Gun_ProjeAdi.Location = new System.Drawing.Point(216, 60);
            this.cmb_Gun_ProjeAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Gun_ProjeAdi.Name = "cmb_Gun_ProjeAdi";
            this.cmb_Gun_ProjeAdi.Size = new System.Drawing.Size(718, 33);
            this.cmb_Gun_ProjeAdi.TabIndex = 1;
            // 
            // lbl_Gun_Baslangic
            // 
            this.lbl_Gun_Baslangic.AutoSize = true;
            this.lbl_Gun_Baslangic.Location = new System.Drawing.Point(12, 188);
            this.lbl_Gun_Baslangic.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Gun_Baslangic.Name = "lbl_Gun_Baslangic";
            this.lbl_Gun_Baslangic.Size = new System.Drawing.Size(178, 25);
            this.lbl_Gun_Baslangic.TabIndex = 12;
            this.lbl_Gun_Baslangic.Text = "Başlangıç Tarihi :";
            // 
            // btn_Gun_Proje
            // 
            this.btn_Gun_Proje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Gun_Proje.BackgroundImage")));
            this.btn_Gun_Proje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Gun_Proje.FlatAppearance.BorderSize = 0;
            this.btn_Gun_Proje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Gun_Proje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Gun_Proje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gun_Proje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gun_Proje.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Gun_Proje.Location = new System.Drawing.Point(446, 388);
            this.btn_Gun_Proje.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Gun_Proje.Name = "btn_Gun_Proje";
            this.btn_Gun_Proje.Size = new System.Drawing.Size(210, 115);
            this.btn_Gun_Proje.TabIndex = 6;
            this.btn_Gun_Proje.Text = "GÜNCELLE";
            this.btn_Gun_Proje.UseVisualStyleBackColor = true;
            this.btn_Gun_Proje.Click += new System.EventHandler(this.btn_Gun_Proje_Click);
            // 
            // lbl_Gun_Bitis
            // 
            this.lbl_Gun_Bitis.AutoSize = true;
            this.lbl_Gun_Bitis.Location = new System.Drawing.Point(534, 190);
            this.lbl_Gun_Bitis.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Gun_Bitis.Name = "lbl_Gun_Bitis";
            this.lbl_Gun_Bitis.Size = new System.Drawing.Size(125, 25);
            this.lbl_Gun_Bitis.TabIndex = 13;
            this.lbl_Gun_Bitis.Text = "Bitiş Tarihi: ";
            // 
            // cmb_Gun_PtojeYoneticisi
            // 
            this.cmb_Gun_PtojeYoneticisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gun_PtojeYoneticisi.FormattingEnabled = true;
            this.cmb_Gun_PtojeYoneticisi.Location = new System.Drawing.Point(674, 292);
            this.cmb_Gun_PtojeYoneticisi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmb_Gun_PtojeYoneticisi.Name = "cmb_Gun_PtojeYoneticisi";
            this.cmb_Gun_PtojeYoneticisi.Size = new System.Drawing.Size(238, 33);
            this.cmb_Gun_PtojeYoneticisi.TabIndex = 5;
            // 
            // date_Gun_Baslangic
            // 
            this.date_Gun_Baslangic.Location = new System.Drawing.Point(216, 177);
            this.date_Gun_Baslangic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.date_Gun_Baslangic.Name = "date_Gun_Baslangic";
            this.date_Gun_Baslangic.Size = new System.Drawing.Size(234, 31);
            this.date_Gun_Baslangic.TabIndex = 2;
            this.date_Gun_Baslangic.ValueChanged += new System.EventHandler(this.date_Gun_Baslangic_ValueChanged);
            // 
            // lbl_Gun_ProjeYoneticisi
            // 
            this.lbl_Gun_ProjeYoneticisi.AutoSize = true;
            this.lbl_Gun_ProjeYoneticisi.Location = new System.Drawing.Point(506, 298);
            this.lbl_Gun_ProjeYoneticisi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Gun_ProjeYoneticisi.Name = "lbl_Gun_ProjeYoneticisi";
            this.lbl_Gun_ProjeYoneticisi.Size = new System.Drawing.Size(174, 25);
            this.lbl_Gun_ProjeYoneticisi.TabIndex = 19;
            this.lbl_Gun_ProjeYoneticisi.Text = "Proje Yöneticisi: ";
            // 
            // date_Gun_Bitis
            // 
            this.date_Gun_Bitis.Location = new System.Drawing.Point(674, 187);
            this.date_Gun_Bitis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.date_Gun_Bitis.Name = "date_Gun_Bitis";
            this.date_Gun_Bitis.Size = new System.Drawing.Size(238, 31);
            this.date_Gun_Bitis.TabIndex = 3;
            // 
            // lbl_Gun_Butce
            // 
            this.lbl_Gun_Butce.AutoSize = true;
            this.lbl_Gun_Butce.Location = new System.Drawing.Point(12, 290);
            this.lbl_Gun_Butce.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Gun_Butce.Name = "lbl_Gun_Butce";
            this.lbl_Gun_Butce.Size = new System.Drawing.Size(79, 25);
            this.lbl_Gun_Butce.TabIndex = 18;
            this.lbl_Gun_Butce.Text = "Bütce: ";
            // 
            // txt_Gun_Butce
            // 
            this.txt_Gun_Butce.Location = new System.Drawing.Point(216, 285);
            this.txt_Gun_Butce.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Gun_Butce.Name = "txt_Gun_Butce";
            this.txt_Gun_Butce.Size = new System.Drawing.Size(234, 31);
            this.txt_Gun_Butce.TabIndex = 4;
            this.txt_Gun_Butce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Gun_Butce_KeyPress);
            // 
            // tb_gorevlerim
            // 
            this.tb_gorevlerim.Controls.Add(this.dataGridView2);
            this.tb_gorevlerim.Location = new System.Drawing.Point(8, 39);
            this.tb_gorevlerim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_gorevlerim.Name = "tb_gorevlerim";
            this.tb_gorevlerim.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_gorevlerim.Size = new System.Drawing.Size(1888, 878);
            this.tb_gorevlerim.TabIndex = 3;
            this.tb_gorevlerim.Text = "Görevlerim";
            this.tb_gorevlerim.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1864, 852);
            this.dataGridView2.TabIndex = 0;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.BackgroundImage")));
            this.btn_Ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Ekle.FlatAppearance.BorderSize = 0;
            this.btn_Ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Ekle.Location = new System.Drawing.Point(616, 137);
            this.btn_Ekle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(182, 123);
            this.btn_Ekle.TabIndex = 1;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.BackgroundImage")));
            this.btn_Guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Guncelle.FlatAppearance.BorderSize = 0;
            this.btn_Guncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.Location = new System.Drawing.Point(836, 137);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(178, 123);
            this.btn_Guncelle.TabIndex = 2;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.BackgroundImage")));
            this.btn_Sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sil.FlatAppearance.BorderSize = 0;
            this.btn_Sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Sil.Location = new System.Drawing.Point(1054, 137);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(178, 123);
            this.btn_Sil.TabIndex = 3;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Surec
            // 
            this.btn_Surec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Surec.BackgroundImage")));
            this.btn_Surec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Surec.FlatAppearance.BorderSize = 0;
            this.btn_Surec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Surec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Surec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Surec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Surec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Surec.Location = new System.Drawing.Point(1284, 137);
            this.btn_Surec.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Surec.Name = "btn_Surec";
            this.btn_Surec.Size = new System.Drawing.Size(292, 123);
            this.btn_Surec.TabIndex = 4;
            this.btn_Surec.Text = "Süreçler";
            this.btn_Surec.UseVisualStyleBackColor = true;
            this.btn_Surec.Click += new System.EventHandler(this.btn_Surec_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cikis.BackgroundImage")));
            this.btn_Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cikis.FlatAppearance.BorderSize = 0;
            this.btn_Cikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Cikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.Location = new System.Drawing.Point(1862, 23);
            this.btn_Cikis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(108, 96);
            this.btn_Cikis.TabIndex = 5;
            this.btn_Cikis.Text = "ÇIKIŞ";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2026, 1315);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.btn_Surec);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.tb_Project);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form2";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tb_Project.ResumeLayout(false);
            this.tab_Anasayfa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_Ekle.ResumeLayout(false);
            this.grp_ekle.ResumeLayout(false);
            this.grp_ekle.PerformLayout();
            this.tab_Guncelle.ResumeLayout(false);
            this.grp_guncelle.ResumeLayout(false);
            this.grp_guncelle.PerformLayout();
            this.tb_gorevlerim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_Project;
        private System.Windows.Forms.TabPage tab_Anasayfa;
        private System.Windows.Forms.TabPage tab_Ekle;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TabPage tab_Guncelle;
        private System.Windows.Forms.Button btn_Surec;
        private System.Windows.Forms.Label lbl_Butce;
        private System.Windows.Forms.TextBox txt_Butce;
        private System.Windows.Forms.DateTimePicker date_Bitis;
        private System.Windows.Forms.DateTimePicker date_Baslangic;
        private System.Windows.Forms.Label lbl_BitTarihi;
        private System.Windows.Forms.Label lbl_BasTarihi;
        private System.Windows.Forms.TextBox txt_ProjeAdi;
        private System.Windows.Forms.Label lbl_ProjeAdi;
        private System.Windows.Forms.Label lbl_ProjeYoneticisi;
        private System.Windows.Forms.ComboBox cmb_projeYoneticisi;
        private System.Windows.Forms.Button btn_projeEkle;
        private System.Windows.Forms.Button btn_Gun_Proje;
        private System.Windows.Forms.ComboBox cmb_Gun_PtojeYoneticisi;
        private System.Windows.Forms.Label lbl_Gun_ProjeYoneticisi;
        private System.Windows.Forms.Label lbl_Gun_Butce;
        private System.Windows.Forms.TextBox txt_Gun_Butce;
        private System.Windows.Forms.DateTimePicker date_Gun_Bitis;
        private System.Windows.Forms.DateTimePicker date_Gun_Baslangic;
        private System.Windows.Forms.Label lbl_Gun_Bitis;
        private System.Windows.Forms.Label lbl_Gun_Baslangic;
        private System.Windows.Forms.Label lbl_Gun_ProjeAdi;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_Gun_ProjeAdi;
        private System.Windows.Forms.GroupBox grp_ekle;
        private System.Windows.Forms.GroupBox grp_guncelle;
        private System.Windows.Forms.TabPage tb_gorevlerim;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_Cikis;
    }
}