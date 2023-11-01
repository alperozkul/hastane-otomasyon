
namespace Hastane_Otomasyon
{
    partial class Yönetici
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
            this.cikis_btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bilgileri_getir = new System.Windows.Forms.Button();
            this.hasta_kayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TC_arama_TB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.Personel_CB = new System.Windows.Forms.ComboBox();
            this.Kaydet_btn = new System.Windows.Forms.Button();
            this.Kan_CB = new System.Windows.Forms.ComboBox();
            this.Cinsiyet_CB = new System.Windows.Forms.ComboBox();
            this.Dogum_DTP = new System.Windows.Forms.DateTimePicker();
            this.Adres_TB = new System.Windows.Forms.TextBox();
            this.İlce_TB = new System.Windows.Forms.TextBox();
            this.İl_TB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Mail_TB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Soyad_TB = new System.Windows.Forms.TextBox();
            this.Ad_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.Parola_TB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Tel_TB = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TC_TB = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.Hemsire_CB = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Doktor_CB = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.secilipersonel_btn = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.personelList_CB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.personel_sil = new System.Windows.Forms.Button();
            this.personeller_btn = new System.Windows.Forms.Button();
            this.Personel_DGW = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genelbilgi_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personeltur_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dogum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kan_grubu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Personel_DGW)).BeginInit();
            this.SuspendLayout();
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.Red;
            this.cikis_btn.Location = new System.Drawing.Point(14, 754);
            this.cikis_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(102, 56);
            this.cikis_btn.TabIndex = 2;
            this.cikis_btn.Text = "Çıkış Yap";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 24);
            this.tabControl1.Location = new System.Drawing.Point(14, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 741);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.bilgileri_getir);
            this.tabPage1.Controls.Add(this.hasta_kayit);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TC_arama_TB);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1276, 709);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hasta İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bilgileri_getir
            // 
            this.bilgileri_getir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bilgileri_getir.Location = new System.Drawing.Point(1045, 120);
            this.bilgileri_getir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bilgileri_getir.Name = "bilgileri_getir";
            this.bilgileri_getir.Size = new System.Drawing.Size(217, 146);
            this.bilgileri_getir.TabIndex = 13;
            this.bilgileri_getir.Text = "Tüm Bilgileri Getir\r\nGüncelle/Sil";
            this.bilgileri_getir.UseVisualStyleBackColor = false;
            this.bilgileri_getir.Click += new System.EventHandler(this.hasta_kayit_Click);
            // 
            // hasta_kayit
            // 
            this.hasta_kayit.BackColor = System.Drawing.Color.YellowGreen;
            this.hasta_kayit.Location = new System.Drawing.Point(1045, 274);
            this.hasta_kayit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hasta_kayit.Name = "hasta_kayit";
            this.hasta_kayit.Size = new System.Drawing.Size(217, 146);
            this.hasta_kayit.TabIndex = 12;
            this.hasta_kayit.Text = "Kayıt Oluştur";
            this.hasta_kayit.UseVisualStyleBackColor = false;
            this.hasta_kayit.Click += new System.EventHandler(this.bilgileri_getir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1041, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "TC ile arama yap:";
            // 
            // TC_arama_TB
            // 
            this.TC_arama_TB.Location = new System.Drawing.Point(1045, 69);
            this.TC_arama_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TC_arama_TB.Name = "TC_arama_TB";
            this.TC_arama_TB.Size = new System.Drawing.Size(217, 26);
            this.TC_arama_TB.TabIndex = 10;
            this.TC_arama_TB.TextChanged += new System.EventHandler(this.TC_arama_TB_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 650);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.Personel_CB);
            this.tabPage2.Controls.Add(this.Kaydet_btn);
            this.tabPage2.Controls.Add(this.Kan_CB);
            this.tabPage2.Controls.Add(this.Cinsiyet_CB);
            this.tabPage2.Controls.Add(this.Dogum_DTP);
            this.tabPage2.Controls.Add(this.Adres_TB);
            this.tabPage2.Controls.Add(this.İlce_TB);
            this.tabPage2.Controls.Add(this.İl_TB);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.Mail_TB);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Soyad_TB);
            this.tabPage2.Controls.Add(this.Ad_TB);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1276, 709);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personel Kaydı";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(54, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(186, 26);
            this.label16.TabIndex = 121;
            this.label16.Text = "Personel Seçimi";
            // 
            // Personel_CB
            // 
            this.Personel_CB.FormattingEnabled = true;
            this.Personel_CB.Items.AddRange(new object[] {
            "Doktor",
            "Hemşire",
            "Sekreter",
            "Laboratuvar Görevlisi"});
            this.Personel_CB.Location = new System.Drawing.Point(273, 31);
            this.Personel_CB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Personel_CB.Name = "Personel_CB";
            this.Personel_CB.Size = new System.Drawing.Size(136, 28);
            this.Personel_CB.TabIndex = 120;
            this.Personel_CB.SelectedIndexChanged += new System.EventHandler(this.Personel_CB_SelectedIndexChanged);
            // 
            // Kaydet_btn
            // 
            this.Kaydet_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.Kaydet_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kaydet_btn.Location = new System.Drawing.Point(720, 531);
            this.Kaydet_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Kaydet_btn.Name = "Kaydet_btn";
            this.Kaydet_btn.Size = new System.Drawing.Size(336, 92);
            this.Kaydet_btn.TabIndex = 114;
            this.Kaydet_btn.Text = "Kaydet";
            this.Kaydet_btn.UseVisualStyleBackColor = false;
            this.Kaydet_btn.Click += new System.EventHandler(this.Kaydet_btn_Click);
            // 
            // Kan_CB
            // 
            this.Kan_CB.FormattingEnabled = true;
            this.Kan_CB.Items.AddRange(new object[] {
            "A(+)",
            "A(-)",
            "B(+)",
            "B(-)",
            "AB(+)",
            "AB(-)",
            "0(+)",
            "0(-)"});
            this.Kan_CB.Location = new System.Drawing.Point(213, 572);
            this.Kan_CB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Kan_CB.Name = "Kan_CB";
            this.Kan_CB.Size = new System.Drawing.Size(112, 28);
            this.Kan_CB.TabIndex = 113;
            // 
            // Cinsiyet_CB
            // 
            this.Cinsiyet_CB.FormattingEnabled = true;
            this.Cinsiyet_CB.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.Cinsiyet_CB.Location = new System.Drawing.Point(213, 492);
            this.Cinsiyet_CB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cinsiyet_CB.Name = "Cinsiyet_CB";
            this.Cinsiyet_CB.Size = new System.Drawing.Size(112, 28);
            this.Cinsiyet_CB.TabIndex = 112;
            // 
            // Dogum_DTP
            // 
            this.Dogum_DTP.CustomFormat = "yyyy-MM-dd";
            this.Dogum_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dogum_DTP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Dogum_DTP.Location = new System.Drawing.Point(213, 419);
            this.Dogum_DTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dogum_DTP.Name = "Dogum_DTP";
            this.Dogum_DTP.Size = new System.Drawing.Size(112, 26);
            this.Dogum_DTP.TabIndex = 111;
            this.Dogum_DTP.Value = new System.DateTime(2022, 7, 28, 11, 39, 48, 0);
            // 
            // Adres_TB
            // 
            this.Adres_TB.Location = new System.Drawing.Point(511, 492);
            this.Adres_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Adres_TB.Multiline = true;
            this.Adres_TB.Name = "Adres_TB";
            this.Adres_TB.Size = new System.Drawing.Size(177, 109);
            this.Adres_TB.TabIndex = 110;
            // 
            // İlce_TB
            // 
            this.İlce_TB.Location = new System.Drawing.Point(511, 429);
            this.İlce_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.İlce_TB.Name = "İlce_TB";
            this.İlce_TB.Size = new System.Drawing.Size(177, 26);
            this.İlce_TB.TabIndex = 109;
            // 
            // İl_TB
            // 
            this.İl_TB.Location = new System.Drawing.Point(511, 370);
            this.İl_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.İl_TB.Name = "İl_TB";
            this.İl_TB.Size = new System.Drawing.Size(177, 26);
            this.İl_TB.TabIndex = 108;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(410, 490);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 26);
            this.label14.TabIndex = 107;
            this.label14.Text = "Adres:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(410, 429);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 26);
            this.label13.TabIndex = 106;
            this.label13.Text = "İlçe:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(410, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 26);
            this.label12.TabIndex = 105;
            this.label12.Text = "İl:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(410, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 26);
            this.label11.TabIndex = 104;
            this.label11.Text = "Mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(410, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 26);
            this.label10.TabIndex = 103;
            this.label10.Text = "Telefon:";
            // 
            // Mail_TB
            // 
            this.Mail_TB.Location = new System.Drawing.Point(524, 235);
            this.Mail_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mail_TB.Name = "Mail_TB";
            this.Mail_TB.Size = new System.Drawing.Size(164, 26);
            this.Mail_TB.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(479, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 26);
            this.label9.TabIndex = 101;
            this.label9.Text = "Adres Bilgileri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(479, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 26);
            this.label8.TabIndex = 100;
            this.label8.Text = "İletişim Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(104, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 26);
            this.label7.TabIndex = 99;
            this.label7.Text = "Kimlik Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 26);
            this.label3.TabIndex = 98;
            this.label3.Text = "TC:";
            // 
            // Soyad_TB
            // 
            this.Soyad_TB.Location = new System.Drawing.Point(213, 265);
            this.Soyad_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Soyad_TB.Name = "Soyad_TB";
            this.Soyad_TB.Size = new System.Drawing.Size(112, 26);
            this.Soyad_TB.TabIndex = 97;
            // 
            // Ad_TB
            // 
            this.Ad_TB.Location = new System.Drawing.Point(213, 188);
            this.Ad_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ad_TB.Name = "Ad_TB";
            this.Ad_TB.Size = new System.Drawing.Size(112, 26);
            this.Ad_TB.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(42, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 26);
            this.label6.TabIndex = 95;
            this.label6.Text = "Kan Grubu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(42, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 94;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 26);
            this.label4.TabIndex = 93;
            this.label4.Text = "Dogum Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 92;
            this.label2.Text = "Soyad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Silver;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(43, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 26);
            this.label15.TabIndex = 91;
            this.label15.Text = "Ad:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.Parola_TB);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(720, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 92);
            this.panel2.TabIndex = 115;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Silver;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label20.Location = new System.Drawing.Point(120, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 26);
            this.label20.TabIndex = 77;
            this.label20.Text = "Parola:";
            // 
            // Parola_TB
            // 
            this.Parola_TB.Location = new System.Drawing.Point(34, 46);
            this.Parola_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Parola_TB.Name = "Parola_TB";
            this.Parola_TB.PasswordChar = '*';
            this.Parola_TB.Size = new System.Drawing.Size(266, 26);
            this.Parola_TB.TabIndex = 78;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Tel_TB);
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel3.Location = new System.Drawing.Point(393, 88);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 218);
            this.panel3.TabIndex = 116;
            // 
            // Tel_TB
            // 
            this.Tel_TB.Location = new System.Drawing.Point(130, 71);
            this.Tel_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tel_TB.Name = "Tel_TB";
            this.Tel_TB.Size = new System.Drawing.Size(164, 26);
            this.Tel_TB.TabIndex = 92;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel4.Location = new System.Drawing.Point(393, 314);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 310);
            this.panel4.TabIndex = 118;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.TC_TB);
            this.panel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel5.Location = new System.Drawing.Point(36, 88);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 536);
            this.panel5.TabIndex = 119;
            // 
            // TC_TB
            // 
            this.TC_TB.Location = new System.Drawing.Point(176, 246);
            this.TC_TB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TC_TB.Name = "TC_TB";
            this.TC_TB.Size = new System.Drawing.Size(112, 26);
            this.TC_TB.TabIndex = 91;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.Hemsire_CB);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.Doktor_CB);
            this.panel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel6.Location = new System.Drawing.Point(720, 188);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(336, 118);
            this.panel6.TabIndex = 117;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(19, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 26);
            this.label19.TabIndex = 124;
            this.label19.Text = "Sekreter";
            this.label19.Visible = false;
            // 
            // Hemsire_CB
            // 
            this.Hemsire_CB.FormattingEnabled = true;
            this.Hemsire_CB.Location = new System.Drawing.Point(34, 71);
            this.Hemsire_CB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Hemsire_CB.Name = "Hemsire_CB";
            this.Hemsire_CB.Size = new System.Drawing.Size(266, 28);
            this.Hemsire_CB.TabIndex = 88;
            this.Hemsire_CB.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(19, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 26);
            this.label17.TabIndex = 122;
            this.label17.Text = "Doktor Branş:";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label18.Location = new System.Drawing.Point(18, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 26);
            this.label18.TabIndex = 123;
            this.label18.Text = "Hemşire Alan";
            this.label18.Visible = false;
            // 
            // Doktor_CB
            // 
            this.Doktor_CB.FormattingEnabled = true;
            this.Doktor_CB.Location = new System.Drawing.Point(34, 71);
            this.Doktor_CB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Doktor_CB.Name = "Doktor_CB";
            this.Doktor_CB.Size = new System.Drawing.Size(266, 28);
            this.Doktor_CB.TabIndex = 86;
            this.Doktor_CB.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.secilipersonel_btn);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.personelList_CB);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.personel_sil);
            this.tabPage3.Controls.Add(this.personeller_btn);
            this.tabPage3.Controls.Add(this.Personel_DGW);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(1276, 709);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Personeller";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // secilipersonel_btn
            // 
            this.secilipersonel_btn.BackColor = System.Drawing.Color.Yellow;
            this.secilipersonel_btn.Location = new System.Drawing.Point(252, 588);
            this.secilipersonel_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secilipersonel_btn.Name = "secilipersonel_btn";
            this.secilipersonel_btn.Size = new System.Drawing.Size(191, 45);
            this.secilipersonel_btn.TabIndex = 10;
            this.secilipersonel_btn.Text = "Seçili personelleri listele";
            this.secilipersonel_btn.UseVisualStyleBackColor = false;
            this.secilipersonel_btn.Click += new System.EventHandler(this.secilipersonel_btn_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(249, 559);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 20);
            this.label21.TabIndex = 9;
            this.label21.Text = "Personel:";
            // 
            // personelList_CB
            // 
            this.personelList_CB.FormattingEnabled = true;
            this.personelList_CB.Location = new System.Drawing.Point(332, 550);
            this.personelList_CB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personelList_CB.Name = "personelList_CB";
            this.personelList_CB.Size = new System.Drawing.Size(136, 28);
            this.personelList_CB.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(997, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 95);
            this.button1.TabIndex = 7;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // personel_sil
            // 
            this.personel_sil.BackColor = System.Drawing.Color.Yellow;
            this.personel_sil.Location = new System.Drawing.Point(997, 110);
            this.personel_sil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personel_sil.Name = "personel_sil";
            this.personel_sil.Size = new System.Drawing.Size(191, 95);
            this.personel_sil.TabIndex = 6;
            this.personel_sil.Text = "Kaydı sil";
            this.personel_sil.UseVisualStyleBackColor = false;
            // 
            // personeller_btn
            // 
            this.personeller_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.personeller_btn.Location = new System.Drawing.Point(7, 538);
            this.personeller_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personeller_btn.Name = "personeller_btn";
            this.personeller_btn.Size = new System.Drawing.Size(191, 95);
            this.personeller_btn.TabIndex = 1;
            this.personeller_btn.Text = "Tüm personelleri görüntüle";
            this.personeller_btn.UseVisualStyleBackColor = false;
            this.personeller_btn.Click += new System.EventHandler(this.personeller_btn_Click);
            // 
            // Personel_DGW
            // 
            this.Personel_DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Personel_DGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Genelbilgi_Id,
            this.Personeltur_Id,
            this.Ad,
            this.Soyad,
            this.Tc,
            this.Dogum,
            this.Cinsiyet,
            this.Kan_grubu});
            this.Personel_DGW.Location = new System.Drawing.Point(7, 8);
            this.Personel_DGW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Personel_DGW.Name = "Personel_DGW";
            this.Personel_DGW.RowHeadersWidth = 51;
            this.Personel_DGW.RowTemplate.Height = 24;
            this.Personel_DGW.Size = new System.Drawing.Size(983, 522);
            this.Personel_DGW.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Personel ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Genelbilgi_Id
            // 
            this.Genelbilgi_Id.DataPropertyName = "genelbilgi_id";
            this.Genelbilgi_Id.HeaderText = "Genel Bilgi ID";
            this.Genelbilgi_Id.MinimumWidth = 6;
            this.Genelbilgi_Id.Name = "Genelbilgi_Id";
            this.Genelbilgi_Id.Width = 125;
            // 
            // Personeltur_Id
            // 
            this.Personeltur_Id.DataPropertyName = "Tur";
            this.Personeltur_Id.HeaderText = "Personel Tür";
            this.Personeltur_Id.MinimumWidth = 6;
            this.Personeltur_Id.Name = "Personeltur_Id";
            this.Personeltur_Id.Width = 125;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.Width = 125;
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.MinimumWidth = 6;
            this.Soyad.Name = "Soyad";
            this.Soyad.Width = 125;
            // 
            // Tc
            // 
            this.Tc.DataPropertyName = "Tc";
            this.Tc.HeaderText = "Tc";
            this.Tc.MinimumWidth = 6;
            this.Tc.Name = "Tc";
            this.Tc.Width = 125;
            // 
            // Dogum
            // 
            this.Dogum.DataPropertyName = "Dogum";
            this.Dogum.HeaderText = "Dogum";
            this.Dogum.MinimumWidth = 6;
            this.Dogum.Name = "Dogum";
            this.Dogum.Width = 125;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.DataPropertyName = "Cinsiyet";
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.MinimumWidth = 6;
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Width = 125;
            // 
            // Kan_grubu
            // 
            this.Kan_grubu.DataPropertyName = "Kan_grubu";
            this.Kan_grubu.HeaderText = "Kan  Grubu";
            this.Kan_grubu.MinimumWidth = 6;
            this.Kan_grubu.Name = "Kan_grubu";
            this.Kan_grubu.Width = 125;
            // 
            // Yönetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1311, 821);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cikis_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Yönetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici";
            this.Load += new System.EventHandler(this.Yönetici_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Personel_DGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bilgileri_getir;
        private System.Windows.Forms.Button hasta_kayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TC_arama_TB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox Personel_CB;
        private System.Windows.Forms.Button Kaydet_btn;
        private System.Windows.Forms.ComboBox Kan_CB;
        private System.Windows.Forms.ComboBox Cinsiyet_CB;
        private System.Windows.Forms.DateTimePicker Dogum_DTP;
        private System.Windows.Forms.TextBox Adres_TB;
        private System.Windows.Forms.TextBox İlce_TB;
        private System.Windows.Forms.TextBox İl_TB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Mail_TB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Soyad_TB;
        private System.Windows.Forms.TextBox Ad_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Parola_TB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Tel_TB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TC_TB;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox Hemsire_CB;
        private System.Windows.Forms.ComboBox Doktor_CB;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button personel_sil;
        private System.Windows.Forms.Button personeller_btn;
        private System.Windows.Forms.DataGridView Personel_DGW;
        private System.Windows.Forms.Button secilipersonel_btn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox personelList_CB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genelbilgi_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personeltur_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dogum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kan_grubu;
    }
}