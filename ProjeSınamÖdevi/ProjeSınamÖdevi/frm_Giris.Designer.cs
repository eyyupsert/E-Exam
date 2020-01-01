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
            this.bnf_txtOgradi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bnf_txtOgrparola = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bnf_btnOgrGiris = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnf_txtOgrtmenAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bnf_txtOgrtmenSifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_btnOgrtmenGir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bnf_txtOgradi
            // 
            this.bnf_txtOgradi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnf_txtOgradi.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.bnf_txtOgradi.BorderColorIdle = System.Drawing.Color.White;
            this.bnf_txtOgradi.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.bnf_txtOgradi.BorderThickness = 3;
            this.bnf_txtOgradi.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bnf_txtOgradi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnf_txtOgradi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnf_txtOgradi.ForeColor = System.Drawing.Color.White;
            this.bnf_txtOgradi.isPassword = false;
            this.bnf_txtOgradi.Location = new System.Drawing.Point(50, 100);
            this.bnf_txtOgradi.Margin = new System.Windows.Forms.Padding(4);
            this.bnf_txtOgradi.MaxLength = 32767;
            this.bnf_txtOgradi.Name = "bnf_txtOgradi";
            this.bnf_txtOgradi.Size = new System.Drawing.Size(303, 37);
            this.bnf_txtOgradi.TabIndex = 10;
            this.bnf_txtOgradi.Text = "Kullanıcı Adınız";
            this.bnf_txtOgradi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnf_txtOgradi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bnf_txtOgradi_MouseClick);
            // 
            // bnf_txtOgrparola
            // 
            this.bnf_txtOgrparola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnf_txtOgrparola.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.bnf_txtOgrparola.BorderColorIdle = System.Drawing.Color.White;
            this.bnf_txtOgrparola.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.bnf_txtOgrparola.BorderThickness = 3;
            this.bnf_txtOgrparola.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bnf_txtOgrparola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnf_txtOgrparola.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnf_txtOgrparola.ForeColor = System.Drawing.Color.White;
            this.bnf_txtOgrparola.isPassword = true;
            this.bnf_txtOgrparola.Location = new System.Drawing.Point(50, 163);
            this.bnf_txtOgrparola.Margin = new System.Windows.Forms.Padding(4);
            this.bnf_txtOgrparola.MaxLength = 32767;
            this.bnf_txtOgrparola.Name = "bnf_txtOgrparola";
            this.bnf_txtOgrparola.Size = new System.Drawing.Size(303, 37);
            this.bnf_txtOgrparola.TabIndex = 11;
            this.bnf_txtOgrparola.Text = "Parola";
            this.bnf_txtOgrparola.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnf_txtOgrparola.Enter += new System.EventHandler(this.bnf_txtOgrparola_Enter);
            // 
            // bnf_btnOgrGiris
            // 
            this.bnf_btnOgrGiris.ActiveBorderThickness = 1;
            this.bnf_btnOgrGiris.ActiveCornerRadius = 20;
            this.bnf_btnOgrGiris.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bnf_btnOgrGiris.ActiveForecolor = System.Drawing.Color.White;
            this.bnf_btnOgrGiris.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bnf_btnOgrGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnf_btnOgrGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnf_btnOgrGiris.BackgroundImage")));
            this.bnf_btnOgrGiris.ButtonText = "Öğrenci Girişi";
            this.bnf_btnOgrGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnf_btnOgrGiris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnf_btnOgrGiris.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnf_btnOgrGiris.IdleBorderThickness = 1;
            this.bnf_btnOgrGiris.IdleCornerRadius = 20;
            this.bnf_btnOgrGiris.IdleFillColor = System.Drawing.Color.White;
            this.bnf_btnOgrGiris.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnf_btnOgrGiris.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnf_btnOgrGiris.Location = new System.Drawing.Point(50, 269);
            this.bnf_btnOgrGiris.Margin = new System.Windows.Forms.Padding(5);
            this.bnf_btnOgrGiris.Name = "bnf_btnOgrGiris";
            this.bnf_btnOgrGiris.Size = new System.Drawing.Size(303, 41);
            this.bnf_btnOgrGiris.TabIndex = 12;
            this.bnf_btnOgrGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnf_btnOgrGiris.Click += new System.EventHandler(this.bnf_btnOgrGiris_Click);
            // 
            // bnf_txtOgrtmenAd
            // 
            this.bnf_txtOgrtmenAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnf_txtOgrtmenAd.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.bnf_txtOgrtmenAd.BorderColorIdle = System.Drawing.Color.White;
            this.bnf_txtOgrtmenAd.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.bnf_txtOgrtmenAd.BorderThickness = 3;
            this.bnf_txtOgrtmenAd.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bnf_txtOgrtmenAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnf_txtOgrtmenAd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnf_txtOgrtmenAd.ForeColor = System.Drawing.Color.White;
            this.bnf_txtOgrtmenAd.isPassword = false;
            this.bnf_txtOgrtmenAd.Location = new System.Drawing.Point(418, 100);
            this.bnf_txtOgrtmenAd.Margin = new System.Windows.Forms.Padding(4);
            this.bnf_txtOgrtmenAd.MaxLength = 32767;
            this.bnf_txtOgrtmenAd.Name = "bnf_txtOgrtmenAd";
            this.bnf_txtOgrtmenAd.Size = new System.Drawing.Size(303, 37);
            this.bnf_txtOgrtmenAd.TabIndex = 17;
            this.bnf_txtOgrtmenAd.Text = "Kullanıcı Adınız";
            this.bnf_txtOgrtmenAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnf_txtOgrtmenAd.Enter += new System.EventHandler(this.bnf_txtOgrtmenAd_Enter);
            // 
            // bnf_txtOgrtmenSifre
            // 
            this.bnf_txtOgrtmenSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnf_txtOgrtmenSifre.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.bnf_txtOgrtmenSifre.BorderColorIdle = System.Drawing.Color.White;
            this.bnf_txtOgrtmenSifre.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.bnf_txtOgrtmenSifre.BorderThickness = 3;
            this.bnf_txtOgrtmenSifre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bnf_txtOgrtmenSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnf_txtOgrtmenSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnf_txtOgrtmenSifre.ForeColor = System.Drawing.Color.White;
            this.bnf_txtOgrtmenSifre.isPassword = true;
            this.bnf_txtOgrtmenSifre.Location = new System.Drawing.Point(418, 163);
            this.bnf_txtOgrtmenSifre.Margin = new System.Windows.Forms.Padding(4);
            this.bnf_txtOgrtmenSifre.MaxLength = 32767;
            this.bnf_txtOgrtmenSifre.Name = "bnf_txtOgrtmenSifre";
            this.bnf_txtOgrtmenSifre.Size = new System.Drawing.Size(303, 37);
            this.bnf_txtOgrtmenSifre.TabIndex = 18;
            this.bnf_txtOgrtmenSifre.Text = "Parola";
            this.bnf_txtOgrtmenSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnf_txtOgrtmenSifre.Enter += new System.EventHandler(this.bnf_txtOgrtmenSifre_Enter);
            // 
            // btn_btnOgrtmenGir
            // 
            this.btn_btnOgrtmenGir.ActiveBorderThickness = 1;
            this.btn_btnOgrtmenGir.ActiveCornerRadius = 20;
            this.btn_btnOgrtmenGir.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_btnOgrtmenGir.ActiveForecolor = System.Drawing.Color.White;
            this.btn_btnOgrtmenGir.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_btnOgrtmenGir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_btnOgrtmenGir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_btnOgrtmenGir.BackgroundImage")));
            this.btn_btnOgrtmenGir.ButtonText = "Öğretmen Girişi";
            this.btn_btnOgrtmenGir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_btnOgrtmenGir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_btnOgrtmenGir.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_btnOgrtmenGir.IdleBorderThickness = 1;
            this.btn_btnOgrtmenGir.IdleCornerRadius = 20;
            this.btn_btnOgrtmenGir.IdleFillColor = System.Drawing.Color.White;
            this.btn_btnOgrtmenGir.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_btnOgrtmenGir.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_btnOgrtmenGir.Location = new System.Drawing.Point(418, 269);
            this.btn_btnOgrtmenGir.Margin = new System.Windows.Forms.Padding(5);
            this.btn_btnOgrtmenGir.Name = "btn_btnOgrtmenGir";
            this.btn_btnOgrtmenGir.Size = new System.Drawing.Size(303, 41);
            this.btn_btnOgrtmenGir.TabIndex = 19;
            this.btn_btnOgrtmenGir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_btnOgrtmenGir.Click += new System.EventHandler(this.btn_btnOgrtmenGir_Click);
            // 
            // frm_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_btnOgrtmenGir);
            this.Controls.Add(this.bnf_txtOgrtmenSifre);
            this.Controls.Add(this.bnf_txtOgrtmenAd);
            this.Controls.Add(this.bnf_btnOgrGiris);
            this.Controls.Add(this.bnf_txtOgrparola);
            this.Controls.Add(this.bnf_txtOgradi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Giris";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox bnf_txtOgradi;
        private Bunifu.Framework.UI.BunifuMetroTextbox bnf_txtOgrparola;
        private Bunifu.Framework.UI.BunifuThinButton2 bnf_btnOgrGiris;
        private Bunifu.Framework.UI.BunifuMetroTextbox bnf_txtOgrtmenAd;
        private Bunifu.Framework.UI.BunifuMetroTextbox bnf_txtOgrtmenSifre;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_btnOgrtmenGir;
    }
}

