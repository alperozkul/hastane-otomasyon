
namespace Hastane_Otomasyon
{
    partial class Görevli
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sonuc_TB = new System.Windows.Forms.RichTextBox();
            this.blgGetir_btn = new System.Windows.Forms.Button();
            this.Test_TB = new System.Windows.Forms.TextBox();
            this.randevu_TB = new System.Windows.Forms.TextBox();
            this.randevuTahlil_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doktorGönder_btn = new System.Windows.Forms.Button();
            this.gecmisTest_btn = new System.Windows.Forms.Button();
            this.bekleyenTest_btn = new System.Windows.Forms.Button();
            this.Testler_DGW = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Randevu_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tahliltur_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tahlildurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Testler_DGW)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cikis_btn);
            this.tabPage2.Controls.Add(this.sonuc_TB);
            this.tabPage2.Controls.Add(this.blgGetir_btn);
            this.tabPage2.Controls.Add(this.Test_TB);
            this.tabPage2.Controls.Add(this.randevu_TB);
            this.tabPage2.Controls.Add(this.randevuTahlil_TB);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.doktorGönder_btn);
            this.tabPage2.Controls.Add(this.gecmisTest_btn);
            this.tabPage2.Controls.Add(this.bekleyenTest_btn);
            this.tabPage2.Controls.Add(this.Testler_DGW);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Laboratuvar Testleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sonuc_TB
            // 
            this.sonuc_TB.Location = new System.Drawing.Point(310, 237);
            this.sonuc_TB.Name = "sonuc_TB";
            this.sonuc_TB.Size = new System.Drawing.Size(306, 96);
            this.sonuc_TB.TabIndex = 12;
            this.sonuc_TB.Text = "";
            // 
            // blgGetir_btn
            // 
            this.blgGetir_btn.BackColor = System.Drawing.Color.Peru;
            this.blgGetir_btn.Location = new System.Drawing.Point(9, 205);
            this.blgGetir_btn.Name = "blgGetir_btn";
            this.blgGetir_btn.Size = new System.Drawing.Size(127, 26);
            this.blgGetir_btn.TabIndex = 11;
            this.blgGetir_btn.Text = "Bilgileri getir";
            this.blgGetir_btn.UseVisualStyleBackColor = false;
            this.blgGetir_btn.Click += new System.EventHandler(this.blgGetir_btn_Click);
            // 
            // Test_TB
            // 
            this.Test_TB.Location = new System.Drawing.Point(53, 311);
            this.Test_TB.Name = "Test_TB";
            this.Test_TB.Size = new System.Drawing.Size(155, 22);
            this.Test_TB.TabIndex = 10;
            // 
            // randevu_TB
            // 
            this.randevu_TB.Location = new System.Drawing.Point(108, 274);
            this.randevu_TB.Name = "randevu_TB";
            this.randevu_TB.Size = new System.Drawing.Size(100, 22);
            this.randevu_TB.TabIndex = 9;
            // 
            // randevuTahlil_TB
            // 
            this.randevuTahlil_TB.Location = new System.Drawing.Point(108, 237);
            this.randevuTahlil_TB.Name = "randevuTahlil_TB";
            this.randevuTahlil_TB.Size = new System.Drawing.Size(100, 22);
            this.randevuTahlil_TB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sonuç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "RandevuID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test";
            // 
            // doktorGönder_btn
            // 
            this.doktorGönder_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.doktorGönder_btn.Location = new System.Drawing.Point(622, 348);
            this.doktorGönder_btn.Name = "doktorGönder_btn";
            this.doktorGönder_btn.Size = new System.Drawing.Size(140, 43);
            this.doktorGönder_btn.TabIndex = 3;
            this.doktorGönder_btn.Text = "Sonuçları Doktora Gönder";
            this.doktorGönder_btn.UseVisualStyleBackColor = false;
            this.doktorGönder_btn.Click += new System.EventHandler(this.doktorGönder_btn_Click);
            // 
            // gecmisTest_btn
            // 
            this.gecmisTest_btn.BackColor = System.Drawing.Color.Red;
            this.gecmisTest_btn.Location = new System.Drawing.Point(622, 55);
            this.gecmisTest_btn.Name = "gecmisTest_btn";
            this.gecmisTest_btn.Size = new System.Drawing.Size(140, 43);
            this.gecmisTest_btn.TabIndex = 2;
            this.gecmisTest_btn.Text = "Geçmiş Testler";
            this.gecmisTest_btn.UseVisualStyleBackColor = false;
            this.gecmisTest_btn.Click += new System.EventHandler(this.gecmisTest_btn_Click);
            // 
            // bekleyenTest_btn
            // 
            this.bekleyenTest_btn.BackColor = System.Drawing.Color.Gold;
            this.bekleyenTest_btn.Location = new System.Drawing.Point(622, 6);
            this.bekleyenTest_btn.Name = "bekleyenTest_btn";
            this.bekleyenTest_btn.Size = new System.Drawing.Size(140, 43);
            this.bekleyenTest_btn.TabIndex = 1;
            this.bekleyenTest_btn.Text = "Bekleyen Testler";
            this.bekleyenTest_btn.UseVisualStyleBackColor = false;
            this.bekleyenTest_btn.Click += new System.EventHandler(this.bekleyenTest_btn_Click);
            // 
            // Testler_DGW
            // 
            this.Testler_DGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Testler_DGW.ColumnHeadersHeight = 29;
            this.Testler_DGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Randevu_Id,
            this.Tahliltur_id,
            this.Tahlildurum});
            this.Testler_DGW.Location = new System.Drawing.Point(6, 6);
            this.Testler_DGW.Name = "Testler_DGW";
            this.Testler_DGW.RowHeadersWidth = 51;
            this.Testler_DGW.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Testler_DGW.RowTemplate.Height = 24;
            this.Testler_DGW.Size = new System.Drawing.Size(610, 193);
            this.Testler_DGW.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Randevu_Id
            // 
            this.Randevu_Id.DataPropertyName = "Randevu_Id";
            this.Randevu_Id.HeaderText = "Randevu ID";
            this.Randevu_Id.MinimumWidth = 6;
            this.Randevu_Id.Name = "Randevu_Id";
            this.Randevu_Id.Width = 111;
            // 
            // Tahliltur_id
            // 
            this.Tahliltur_id.DataPropertyName = "Tahliltur_id";
            this.Tahliltur_id.HeaderText = "Tahlil Tür ID";
            this.Tahliltur_id.MinimumWidth = 6;
            this.Tahliltur_id.Name = "Tahliltur_id";
            this.Tahliltur_id.Width = 114;
            // 
            // Tahlildurum
            // 
            this.Tahlildurum.DataPropertyName = "Tahlildurum";
            this.Tahlildurum.HeaderText = "Durum";
            this.Tahlildurum.MinimumWidth = 6;
            this.Tahlildurum.Name = "Tahlildurum";
            this.Tahlildurum.Width = 79;
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.Red;
            this.cikis_btn.Location = new System.Drawing.Point(476, 348);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(140, 43);
            this.cikis_btn.TabIndex = 13;
            this.cikis_btn.Text = "Çıkış Yap";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // Görevli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.tabControl1);
            this.Name = "Görevli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görevli";
            this.Load += new System.EventHandler(this.Görevli_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Testler_DGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button gecmisTest_btn;
        private System.Windows.Forms.Button bekleyenTest_btn;
        private System.Windows.Forms.DataGridView Testler_DGW;
        private System.Windows.Forms.Button doktorGönder_btn;
        private System.Windows.Forms.RichTextBox sonuc_TB;
        private System.Windows.Forms.Button blgGetir_btn;
        private System.Windows.Forms.TextBox Test_TB;
        private System.Windows.Forms.TextBox randevu_TB;
        private System.Windows.Forms.TextBox randevuTahlil_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Randevu_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tahliltur_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tahlildurum;
        private System.Windows.Forms.Button cikis_btn;
    }
}