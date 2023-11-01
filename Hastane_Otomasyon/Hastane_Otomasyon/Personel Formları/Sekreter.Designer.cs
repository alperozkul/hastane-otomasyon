
namespace Hastane_Otomasyon
{
    partial class Sekreter
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.duyuruTarih_DTP = new System.Windows.Forms.DateTimePicker();
            this.Duyuru_RTB = new System.Windows.Forms.RichTextBox();
            this.duyuruOlstr_btn = new System.Windows.Forms.Button();
            this.duyuruBaslik_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 467);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hasta Kabul";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.duyuruBaslik_TB);
            this.tabPage2.Controls.Add(this.duyuruOlstr_btn);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.duyuruTarih_DTP);
            this.tabPage2.Controls.Add(this.Duyuru_RTB);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Duyuru Oluştur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarih";
            // 
            // duyuruTarih_DTP
            // 
            this.duyuruTarih_DTP.CustomFormat = "yyyy-MM-dd";
            this.duyuruTarih_DTP.Enabled = false;
            this.duyuruTarih_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.duyuruTarih_DTP.Location = new System.Drawing.Point(462, 41);
            this.duyuruTarih_DTP.Name = "duyuruTarih_DTP";
            this.duyuruTarih_DTP.Size = new System.Drawing.Size(113, 22);
            this.duyuruTarih_DTP.TabIndex = 1;
            // 
            // Duyuru_RTB
            // 
            this.Duyuru_RTB.Location = new System.Drawing.Point(9, 105);
            this.Duyuru_RTB.Name = "Duyuru_RTB";
            this.Duyuru_RTB.Size = new System.Drawing.Size(378, 188);
            this.Duyuru_RTB.TabIndex = 0;
            this.Duyuru_RTB.Text = "";
            // 
            // duyuruOlstr_btn
            // 
            this.duyuruOlstr_btn.Location = new System.Drawing.Point(453, 89);
            this.duyuruOlstr_btn.Name = "duyuruOlstr_btn";
            this.duyuruOlstr_btn.Size = new System.Drawing.Size(142, 55);
            this.duyuruOlstr_btn.TabIndex = 4;
            this.duyuruOlstr_btn.Text = "Duyuru Oluştur";
            this.duyuruOlstr_btn.UseVisualStyleBackColor = true;
            this.duyuruOlstr_btn.Click += new System.EventHandler(this.duyuruOlstr_btn_Click);
            // 
            // duyuruBaslik_TB
            // 
            this.duyuruBaslik_TB.Location = new System.Drawing.Point(128, 23);
            this.duyuruBaslik_TB.Name = "duyuruBaslik_TB";
            this.duyuruBaslik_TB.Size = new System.Drawing.Size(259, 22);
            this.duyuruBaslik_TB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Duyuru Başlığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duyuru Açıklaması";
            // 
            // Sekreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 512);
            this.Controls.Add(this.tabControl1);
            this.Name = "Sekreter";
            this.Text = "Sekreter";
            this.Load += new System.EventHandler(this.Sekreter_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker duyuruTarih_DTP;
        private System.Windows.Forms.RichTextBox Duyuru_RTB;
        private System.Windows.Forms.Button duyuruOlstr_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox duyuruBaslik_TB;
    }
}