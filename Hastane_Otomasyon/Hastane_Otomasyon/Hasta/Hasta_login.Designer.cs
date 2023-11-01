
namespace Hastane_Otomasyon
{
    partial class Hasta_login
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
            this.giris_btn = new System.Windows.Forms.Button();
            this.TC_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sifre_TB = new System.Windows.Forms.TextBox();
            this.geri_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giris_btn
            // 
            this.giris_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.giris_btn.Location = new System.Drawing.Point(72, 164);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(147, 38);
            this.giris_btn.TabIndex = 0;
            this.giris_btn.Text = "Giriş Yap";
            this.giris_btn.UseVisualStyleBackColor = false;
            this.giris_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TC_TB
            // 
            this.TC_TB.Location = new System.Drawing.Point(89, 38);
            this.TC_TB.Name = "TC_TB";
            this.TC_TB.Size = new System.Drawing.Size(121, 22);
            this.TC_TB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // Sifre_TB
            // 
            this.Sifre_TB.Location = new System.Drawing.Point(89, 115);
            this.Sifre_TB.Name = "Sifre_TB";
            this.Sifre_TB.PasswordChar = '*';
            this.Sifre_TB.Size = new System.Drawing.Size(121, 22);
            this.Sifre_TB.TabIndex = 4;
            // 
            // geri_btn
            // 
            this.geri_btn.BackColor = System.Drawing.Color.Yellow;
            this.geri_btn.Location = new System.Drawing.Point(124, 217);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(95, 31);
            this.geri_btn.TabIndex = 5;
            this.geri_btn.Text = "Geri";
            this.geri_btn.UseVisualStyleBackColor = false;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // Hasta_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 274);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.Sifre_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TC_TB);
            this.Controls.Add(this.giris_btn);
            this.Name = "Hasta_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.TextBox TC_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Sifre_TB;
        private System.Windows.Forms.Button geri_btn;
    }
}

