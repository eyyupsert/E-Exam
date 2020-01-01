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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Giris));
            this.bnf_txtKullaniciAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bnf_txtKullaniciSifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bnf_btnGirisYap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pcrebxCikis = new System.Windows.Forms.PictureBox();
            this.mtrdibtnOgretmen = new MetroFramework.Controls.MetroRadioButton();
            this.mtrbtnOgrenci = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcrebxCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // bnf_txtKullaniciAd
            // 
            this.bnf_txtKullaniciAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnf_txtKullaniciAd.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.bnf_txtKullaniciAd.BorderColorIdle = System.Drawing.Color.White;
            this.bnf_txtKullaniciAd.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.bnf_txtKullaniciAd.BorderThickness = 3;
            this.bnf_txtKullaniciAd.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bnf_txtKullaniciAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnf_txtKullaniciAd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnf_txtKullaniciAd.ForeColor = System.Drawing.Color.White;
            this.bnf_txtKullaniciAd.isPassword = false;
            this.bnf_txtKullaniciAd.Location = new System.Drawing.Point(51, 144);
            this.bnf_txtKullaniciAd.Margin = new System.Windows.Forms.Padding(4);
            this.bnf_txtKullaniciAd.MaxLength = 32767;
            this.bnf_txtKullaniciAd.Name = "bnf_txtKullaniciAd";
            this.bnf_txtKullaniciAd.Size = new System.Drawing.Size(303, 37);
            this.bnf_txtKullaniciAd.TabIndex = 10;
            this.bnf_txtKullaniciAd.Text = "Kullanıcı Adınız";
            this.bnf_txtKullaniciAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnf_txtKullaniciAd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bnf_txtOgradi_MouseClick);
            // 
            // bnf_txtKullaniciSifre
            // 
            this.bnf_txtKullaniciSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnf_txtKullaniciSifre.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.bnf_txtKullaniciSifre.BorderColorIdle = System.Drawing.Color.White;
            this.bnf_txtKullaniciSifre.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.bnf_txtKullaniciSifre.BorderThickness = 3;
            this.bnf_txtKullaniciSifre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bnf_txtKullaniciSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnf_txtKullaniciSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnf_txtKullaniciSifre.ForeColor = System.Drawing.Color.White;
            this.bnf_txtKullaniciSifre.isPassword = true;
            this.bnf_txtKullaniciSifre.Location = new System.Drawing.Point(51, 207);
            this.bnf_txtKullaniciSifre.Margin = new System.Windows.Forms.Padding(4);
            this.bnf_txtKullaniciSifre.MaxLength = 32767;
            this.bnf_txtKullaniciSifre.Name = "bnf_txtKullaniciSifre";
            this.bnf_txtKullaniciSifre.Size = new System.Drawing.Size(303, 37);
            this.bnf_txtKullaniciSifre.TabIndex = 11;
            this.bnf_txtKullaniciSifre.Text = "Parola";
            this.bnf_txtKullaniciSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnf_txtKullaniciSifre.Enter += new System.EventHandler(this.bnf_txtOgrparola_Enter);
            // 
            // bnf_btnGirisYap
            // 
            this.bnf_btnGirisYap.ActiveBorderThickness = 1;
            this.bnf_btnGirisYap.ActiveCornerRadius = 20;
            this.bnf_btnGirisYap.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bnf_btnGirisYap.ActiveForecolor = System.Drawing.Color.White;
            this.bnf_btnGirisYap.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bnf_btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnf_btnGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnf_btnGirisYap.BackgroundImage")));
            this.bnf_btnGirisYap.ButtonText = "Giriş Yap";
            this.bnf_btnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnf_btnGirisYap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnf_btnGirisYap.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnf_btnGirisYap.IdleBorderThickness = 1;
            this.bnf_btnGirisYap.IdleCornerRadius = 20;
            this.bnf_btnGirisYap.IdleFillColor = System.Drawing.Color.White;
            this.bnf_btnGirisYap.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnf_btnGirisYap.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnf_btnGirisYap.Location = new System.Drawing.Point(51, 346);
            this.bnf_btnGirisYap.Margin = new System.Windows.Forms.Padding(5);
            this.bnf_btnGirisYap.Name = "bnf_btnGirisYap";
            this.bnf_btnGirisYap.Size = new System.Drawing.Size(303, 41);
            this.bnf_btnGirisYap.TabIndex = 12;
            this.bnf_btnGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnf_btnGirisYap.Click += new System.EventHandler(this.bnf_btnGirisYap_Click);
            // 
            // pcrebxCikis
            // 
            this.pcrebxCikis.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.ErrorImage")));
            this.pcrebxCikis.Image = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.Image")));
            this.pcrebxCikis.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.InitialImage")));
            this.pcrebxCikis.Location = new System.Drawing.Point(384, 2);
            this.pcrebxCikis.Name = "pcrebxCikis";
            this.pcrebxCikis.Size = new System.Drawing.Size(32, 31);
            this.pcrebxCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrebxCikis.TabIndex = 20;
            this.pcrebxCikis.TabStop = false;
            this.pcrebxCikis.Click += new System.EventHandler(this.pcrebxCikis_Click);
            // 
            // mtrdibtnOgretmen
            // 
            this.mtrdibtnOgretmen.AutoSize = true;
            this.mtrdibtnOgretmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtrdibtnOgretmen.ForeColor = System.Drawing.Color.White;
            this.mtrdibtnOgretmen.Location = new System.Drawing.Point(64, 285);
            this.mtrdibtnOgretmen.Name = "mtrdibtnOgretmen";
            this.mtrdibtnOgretmen.Size = new System.Drawing.Size(106, 15);
            this.mtrdibtnOgretmen.Style = MetroFramework.MetroColorStyle.Green;
            this.mtrdibtnOgretmen.TabIndex = 21;
            this.mtrdibtnOgretmen.Text = "Öğretmen Girişi";
            this.mtrdibtnOgretmen.UseCustomBackColor = true;
            this.mtrdibtnOgretmen.UseCustomForeColor = true;
            this.mtrdibtnOgretmen.UseSelectable = true;
            this.mtrdibtnOgretmen.UseStyleColors = true;
            this.mtrdibtnOgretmen.MouseLeave += new System.EventHandler(this.mtrdibtnOgretmen_MouseLeave);
            this.mtrdibtnOgretmen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mtrdibtnOgretmen_MouseMove);
            // 
            // mtrbtnOgrenci
            // 
            this.mtrbtnOgrenci.AutoSize = true;
            this.mtrbtnOgrenci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtrbtnOgrenci.ForeColor = System.Drawing.Color.White;
            this.mtrbtnOgrenci.Location = new System.Drawing.Point(232, 285);
            this.mtrbtnOgrenci.Name = "mtrbtnOgrenci";
            this.mtrbtnOgrenci.Size = new System.Drawing.Size(94, 15);
            this.mtrbtnOgrenci.Style = MetroFramework.MetroColorStyle.Green;
            this.mtrbtnOgrenci.TabIndex = 22;
            this.mtrbtnOgrenci.Text = "Öğrenci Girişi";
            this.mtrbtnOgrenci.UseCustomBackColor = true;
            this.mtrbtnOgrenci.UseCustomForeColor = true;
            this.mtrbtnOgrenci.UseSelectable = true;
            this.mtrbtnOgrenci.MouseLeave += new System.EventHandler(this.mtrbtnOgrenci_MouseLeave);
            this.mtrbtnOgrenci.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mtrbtnOgrenci_MouseMove);
            // 
            // frm_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(417, 451);
            this.Controls.Add(this.mtrbtnOgrenci);
            this.Controls.Add(this.mtrdibtnOgretmen);
            this.Controls.Add(this.pcrebxCikis);
            this.Controls.Add(this.bnf_btnGirisYap);
            this.Controls.Add(this.bnf_txtKullaniciSifre);
            this.Controls.Add(this.bnf_txtKullaniciAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Giris";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcrebxCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox bnf_txtKullaniciAd;
        private Bunifu.Framework.UI.BunifuMetroTextbox bnf_txtKullaniciSifre;
        private Bunifu.Framework.UI.BunifuThinButton2 bnf_btnGirisYap;
        private System.Windows.Forms.PictureBox pcrebxCikis;
        private MetroFramework.Controls.MetroRadioButton mtrdibtnOgretmen;
        private MetroFramework.Controls.MetroRadioButton mtrbtnOgrenci;
    }
}

