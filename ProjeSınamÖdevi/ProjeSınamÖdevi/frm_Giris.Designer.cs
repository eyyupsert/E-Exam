namespace ProjeSınamÖdevi
{
    partial class frm_Giris
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnOgrtmen = new System.Windows.Forms.Button();
            this.txtOgrtmnSifre = new System.Windows.Forms.TextBox();
            this.txtOgrtmnAd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(92, 183);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(165, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(92, 248);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(165, 20);
            this.txtSifre.TabIndex = 1;
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(43, 330);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(214, 46);
            this.btnOgrenci.TabIndex = 2;
            this.btnOgrenci.Text = "Ögrenci Giris";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnOgrtmen
            // 
            this.btnOgrtmen.Location = new System.Drawing.Point(81, 330);
            this.btnOgrtmen.Name = "btnOgrtmen";
            this.btnOgrtmen.Size = new System.Drawing.Size(214, 46);
            this.btnOgrtmen.TabIndex = 5;
            this.btnOgrtmen.Text = "Ögretmen Giris";
            this.btnOgrtmen.UseVisualStyleBackColor = true;
            this.btnOgrtmen.Click += new System.EventHandler(this.btnOgrtmen_Click);
            // 
            // txtOgrtmnSifre
            // 
            this.txtOgrtmnSifre.Location = new System.Drawing.Point(130, 248);
            this.txtOgrtmnSifre.Name = "txtOgrtmnSifre";
            this.txtOgrtmnSifre.PasswordChar = '*';
            this.txtOgrtmnSifre.Size = new System.Drawing.Size(165, 20);
            this.txtOgrtmnSifre.TabIndex = 4;
            // 
            // txtOgrtmnAd
            // 
            this.txtOgrtmnAd.Location = new System.Drawing.Point(130, 183);
            this.txtOgrtmnAd.Name = "txtOgrtmnAd";
            this.txtOgrtmnAd.Size = new System.Drawing.Size(165, 20);
            this.txtOgrtmnAd.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOgrenci);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Location = new System.Drawing.Point(39, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 408);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnOgrtmen);
            this.panel2.Controls.Add(this.txtOgrtmnSifre);
            this.panel2.Controls.Add(this.txtOgrtmnAd);
            this.panel2.Location = new System.Drawing.Point(417, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 407);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // frm_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Giris";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Giris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnOgrtmen;
        private System.Windows.Forms.TextBox txtOgrtmnSifre;
        private System.Windows.Forms.TextBox txtOgrtmnAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}

