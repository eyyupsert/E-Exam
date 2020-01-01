namespace ProjeSınamÖdevi
{
    partial class frm_OgretmenSoruEkleme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OgretmenSoruEkleme));
            this.btnSoruEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.drpdown_konular = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_soru = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtA = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtC = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtD = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.drpdown_doruCevap = new Bunifu.Framework.UI.BunifuDropdown();
            this.pcrebxCikis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcrebxCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.ActiveBorderThickness = 1;
            this.btnSoruEkle.ActiveCornerRadius = 20;
            this.btnSoruEkle.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSoruEkle.ActiveForecolor = System.Drawing.Color.White;
            this.btnSoruEkle.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSoruEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSoruEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSoruEkle.BackgroundImage")));
            this.btnSoruEkle.ButtonText = "Soru Ekle";
            this.btnSoruEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoruEkle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSoruEkle.IdleBorderThickness = 1;
            this.btnSoruEkle.IdleCornerRadius = 20;
            this.btnSoruEkle.IdleFillColor = System.Drawing.Color.White;
            this.btnSoruEkle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSoruEkle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSoruEkle.Location = new System.Drawing.Point(579, 295);
            this.btnSoruEkle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(299, 85);
            this.btnSoruEkle.TabIndex = 10;
            this.btnSoruEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click_1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // drpdown_konular
            // 
            this.drpdown_konular.BackColor = System.Drawing.Color.Transparent;
            this.drpdown_konular.BorderRadius = 3;
            this.drpdown_konular.DisabledColor = System.Drawing.Color.Gray;
            this.drpdown_konular.ForeColor = System.Drawing.Color.White;
            this.drpdown_konular.items = new string[0];
            this.drpdown_konular.Location = new System.Drawing.Point(286, 500);
            this.drpdown_konular.Name = "drpdown_konular";
            this.drpdown_konular.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpdown_konular.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpdown_konular.selectedIndex = -1;
            this.drpdown_konular.Size = new System.Drawing.Size(199, 31);
            this.drpdown_konular.TabIndex = 11;
            // 
            // txt_soru
            // 
            this.txt_soru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_soru.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txt_soru.BorderColorIdle = System.Drawing.Color.White;
            this.txt_soru.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txt_soru.BorderThickness = 3;
            this.txt_soru.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_soru.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soru.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soru.ForeColor = System.Drawing.Color.White;
            this.txt_soru.isPassword = false;
            this.txt_soru.Location = new System.Drawing.Point(61, 64);
            this.txt_soru.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soru.MaxLength = 200;
            this.txt_soru.Name = "txt_soru";
            this.txt_soru.Size = new System.Drawing.Size(424, 165);
            this.txt_soru.TabIndex = 12;
            this.txt_soru.Text = "Eklenecek Soruyu Yazınız";
            this.txt_soru.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_soru.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_soru_MouseClick);
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtA.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtA.BorderColorIdle = System.Drawing.Color.White;
            this.txtA.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtA.BorderThickness = 3;
            this.txtA.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtA.ForeColor = System.Drawing.Color.White;
            this.txtA.isPassword = false;
            this.txtA.Location = new System.Drawing.Point(61, 251);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.MaxLength = 100;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(424, 39);
            this.txtA.TabIndex = 13;
            this.txtA.Text = "A şıkkı";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtA.Enter += new System.EventHandler(this.txtA_Enter);
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtB.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtB.BorderColorIdle = System.Drawing.Color.White;
            this.txtB.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtB.BorderThickness = 3;
            this.txtB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtB.ForeColor = System.Drawing.Color.White;
            this.txtB.isPassword = false;
            this.txtB.Location = new System.Drawing.Point(61, 316);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.MaxLength = 100;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(424, 39);
            this.txtB.TabIndex = 14;
            this.txtB.Text = "B şıkkı";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtB.Enter += new System.EventHandler(this.txtB_Enter);
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtC.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtC.BorderColorIdle = System.Drawing.Color.White;
            this.txtC.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtC.BorderThickness = 3;
            this.txtC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtC.ForeColor = System.Drawing.Color.White;
            this.txtC.isPassword = false;
            this.txtC.Location = new System.Drawing.Point(61, 374);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.MaxLength = 100;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(424, 39);
            this.txtC.TabIndex = 15;
            this.txtC.Text = "C şıkkı";
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtC.Enter += new System.EventHandler(this.txtC_Enter);
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtD.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtD.BorderColorIdle = System.Drawing.Color.White;
            this.txtD.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtD.BorderThickness = 3;
            this.txtD.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtD.ForeColor = System.Drawing.Color.White;
            this.txtD.isPassword = false;
            this.txtD.Location = new System.Drawing.Point(61, 433);
            this.txtD.Margin = new System.Windows.Forms.Padding(4);
            this.txtD.MaxLength = 100;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(424, 39);
            this.txtD.TabIndex = 16;
            this.txtD.Text = "D şıkkı";
            this.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtD.Enter += new System.EventHandler(this.txtD_Enter);
            // 
            // drpdown_doruCevap
            // 
            this.drpdown_doruCevap.BackColor = System.Drawing.Color.Transparent;
            this.drpdown_doruCevap.BorderRadius = 3;
            this.drpdown_doruCevap.DisabledColor = System.Drawing.Color.Gray;
            this.drpdown_doruCevap.ForeColor = System.Drawing.Color.White;
            this.drpdown_doruCevap.items = new string[] {
        "A",
        "B",
        "C",
        "D"};
            this.drpdown_doruCevap.Location = new System.Drawing.Point(61, 500);
            this.drpdown_doruCevap.Name = "drpdown_doruCevap";
            this.drpdown_doruCevap.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drpdown_doruCevap.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drpdown_doruCevap.selectedIndex = -1;
            this.drpdown_doruCevap.Size = new System.Drawing.Size(199, 31);
            this.drpdown_doruCevap.TabIndex = 17;
            // 
            // pcrebxCikis
            // 
            this.pcrebxCikis.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.ErrorImage")));
            this.pcrebxCikis.Image = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.Image")));
            this.pcrebxCikis.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.InitialImage")));
            this.pcrebxCikis.Location = new System.Drawing.Point(923, -1);
            this.pcrebxCikis.Name = "pcrebxCikis";
            this.pcrebxCikis.Size = new System.Drawing.Size(32, 31);
            this.pcrebxCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrebxCikis.TabIndex = 21;
            this.pcrebxCikis.TabStop = false;
            this.pcrebxCikis.Click += new System.EventHandler(this.pcrebxCikis_Click);
            // 
            // frm_OgretmenSoruEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(955, 574);
            this.Controls.Add(this.pcrebxCikis);
            this.Controls.Add(this.drpdown_doruCevap);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txt_soru);
            this.Controls.Add(this.drpdown_konular);
            this.Controls.Add(this.btnSoruEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_OgretmenSoruEkleme";
            this.Text = "frm_OgretmenEkrani";
            this.Load += new System.EventHandler(this.frm_OgretmenEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcrebxCikis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnSoruEkle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDropdown drpdown_konular;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_soru;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtA;
        private Bunifu.Framework.UI.BunifuDropdown drpdown_doruCevap;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtD;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtC;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtB;
        private System.Windows.Forms.PictureBox pcrebxCikis;
    }
}