
namespace Hastane_Otomasyon
{
    partial class Ana_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana_Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.H_giris_btn = new System.Windows.Forms.Button();
            this.P_giris_btn = new System.Windows.Forms.Button();
            this.Kayit_btn = new System.Windows.Forms.Button();
            this.duyuru_btn = new System.Windows.Forms.Button();
            this.duyuru_pnl = new System.Windows.Forms.Panel();
            this.duyuru_RTB = new System.Windows.Forms.RichTextBox();
            this.Duyurular = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baslik_TB = new System.Windows.Forms.TextBox();
            this.duyuruKpt_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.duyuru_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Duyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // H_giris_btn
            // 
            this.H_giris_btn.Location = new System.Drawing.Point(466, 49);
            this.H_giris_btn.Name = "H_giris_btn";
            this.H_giris_btn.Size = new System.Drawing.Size(142, 62);
            this.H_giris_btn.TabIndex = 6;
            this.H_giris_btn.Text = "Hasta Girişi";
            this.H_giris_btn.UseVisualStyleBackColor = true;
            this.H_giris_btn.Click += new System.EventHandler(this.H_giris_btn_Click);
            // 
            // P_giris_btn
            // 
            this.P_giris_btn.Location = new System.Drawing.Point(646, 49);
            this.P_giris_btn.Name = "P_giris_btn";
            this.P_giris_btn.Size = new System.Drawing.Size(142, 62);
            this.P_giris_btn.TabIndex = 7;
            this.P_giris_btn.Text = "Personel Girişi";
            this.P_giris_btn.UseVisualStyleBackColor = true;
            this.P_giris_btn.Click += new System.EventHandler(this.P_giris_btn_Click);
            // 
            // Kayit_btn
            // 
            this.Kayit_btn.Location = new System.Drawing.Point(693, 202);
            this.Kayit_btn.Name = "Kayit_btn";
            this.Kayit_btn.Size = new System.Drawing.Size(95, 62);
            this.Kayit_btn.TabIndex = 8;
            this.Kayit_btn.Text = "Kayıt Ol";
            this.Kayit_btn.UseVisualStyleBackColor = true;
            this.Kayit_btn.Click += new System.EventHandler(this.Kayit_btn_Click);
            // 
            // duyuru_btn
            // 
            this.duyuru_btn.Location = new System.Drawing.Point(466, 202);
            this.duyuru_btn.Name = "duyuru_btn";
            this.duyuru_btn.Size = new System.Drawing.Size(142, 62);
            this.duyuru_btn.TabIndex = 9;
            this.duyuru_btn.Text = "Duyurular";
            this.duyuru_btn.UseVisualStyleBackColor = true;
            this.duyuru_btn.Click += new System.EventHandler(this.duyuru_btn_Click);
            // 
            // duyuru_pnl
            // 
            this.duyuru_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duyuru_pnl.Controls.Add(this.label3);
            this.duyuru_pnl.Controls.Add(this.duyuruKpt_btn);
            this.duyuru_pnl.Controls.Add(this.duyuru_RTB);
            this.duyuru_pnl.Controls.Add(this.Duyurular);
            this.duyuru_pnl.Controls.Add(this.label2);
            this.duyuru_pnl.Controls.Add(this.label1);
            this.duyuru_pnl.Controls.Add(this.baslik_TB);
            this.duyuru_pnl.Location = new System.Drawing.Point(12, 12);
            this.duyuru_pnl.Name = "duyuru_pnl";
            this.duyuru_pnl.Size = new System.Drawing.Size(408, 426);
            this.duyuru_pnl.TabIndex = 10;
            this.duyuru_pnl.Visible = false;
            // 
            // duyuru_RTB
            // 
            this.duyuru_RTB.Location = new System.Drawing.Point(95, 230);
            this.duyuru_RTB.Name = "duyuru_RTB";
            this.duyuru_RTB.Size = new System.Drawing.Size(279, 149);
            this.duyuru_RTB.TabIndex = 5;
            this.duyuru_RTB.Text = "";
            // 
            // Duyurular
            // 
            this.Duyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Duyurular.Location = new System.Drawing.Point(30, 37);
            this.Duyurular.Name = "Duyurular";
            this.Duyurular.RowHeadersWidth = 51;
            this.Duyurular.RowTemplate.Height = 24;
            this.Duyurular.Size = new System.Drawing.Size(344, 147);
            this.Duyurular.TabIndex = 1;
            this.Duyurular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Duyurular_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duyuru:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlık:";
            // 
            // baslik_TB
            // 
            this.baslik_TB.Location = new System.Drawing.Point(95, 202);
            this.baslik_TB.Name = "baslik_TB";
            this.baslik_TB.Size = new System.Drawing.Size(279, 22);
            this.baslik_TB.TabIndex = 3;
            // 
            // duyuruKpt_btn
            // 
            this.duyuruKpt_btn.Location = new System.Drawing.Point(12, 391);
            this.duyuruKpt_btn.Name = "duyuruKpt_btn";
            this.duyuruKpt_btn.Size = new System.Drawing.Size(77, 23);
            this.duyuruKpt_btn.TabIndex = 6;
            this.duyuruKpt_btn.Text = "Kapat";
            this.duyuruKpt_btn.UseVisualStyleBackColor = true;
            this.duyuruKpt_btn.Click += new System.EventHandler(this.duyuruKpt_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(142, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duyurular";
            // 
            // Ana_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.duyuru_pnl);
            this.Controls.Add(this.duyuru_btn);
            this.Controls.Add(this.Kayit_btn);
            this.Controls.Add(this.P_giris_btn);
            this.Controls.Add(this.H_giris_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ana_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Bilgi Yönetim Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.duyuru_pnl.ResumeLayout(false);
            this.duyuru_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Duyurular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button H_giris_btn;
        private System.Windows.Forms.Button P_giris_btn;
        private System.Windows.Forms.Button Kayit_btn;
        private System.Windows.Forms.Button duyuru_btn;
        private System.Windows.Forms.Panel duyuru_pnl;
        private System.Windows.Forms.RichTextBox duyuru_RTB;
        private System.Windows.Forms.DataGridView Duyurular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox baslik_TB;
        private System.Windows.Forms.Button duyuruKpt_btn;
        private System.Windows.Forms.Label label3;
    }
}