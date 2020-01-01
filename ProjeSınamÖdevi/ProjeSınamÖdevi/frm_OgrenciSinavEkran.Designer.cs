namespace ProjeSınamÖdevi
{
    partial class frm_OgrenciSinavEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OgrenciSinavEkran));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfprgrsbar_süre = new Bunifu.Framework.UI.BunifuProgressBar();
            this.pcrebxCikis = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bfnbtn_basla = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbl_ad = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_soruSayisi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bnftxt_Soru = new Bunifu.Framework.BunifuCustomTextbox();
            this.A = new Bunifu.Framework.UI.BunifuFlatButton();
            this.B = new Bunifu.Framework.UI.BunifuFlatButton();
            this.C = new Bunifu.Framework.UI.BunifuFlatButton();
            this.D = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblsinavId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcrebxCikis)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 15;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 16;
            this.label5.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bnfprgrsbar_süre
            // 
            this.bnfprgrsbar_süre.BackColor = System.Drawing.Color.Silver;
            this.bnfprgrsbar_süre.BorderRadius = 5;
            this.bnfprgrsbar_süre.Location = new System.Drawing.Point(12, 574);
            this.bnfprgrsbar_süre.MaximumValue = 200;
            this.bnfprgrsbar_süre.Name = "bnfprgrsbar_süre";
            this.bnfprgrsbar_süre.ProgressColor = System.Drawing.Color.YellowGreen;
            this.bnfprgrsbar_süre.Size = new System.Drawing.Size(698, 23);
            this.bnfprgrsbar_süre.TabIndex = 0;
            this.bnfprgrsbar_süre.Value = 200;
            // 
            // pcrebxCikis
            // 
            this.pcrebxCikis.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.ErrorImage")));
            this.pcrebxCikis.Image = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.Image")));
            this.pcrebxCikis.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.InitialImage")));
            this.pcrebxCikis.Location = new System.Drawing.Point(906, 0);
            this.pcrebxCikis.Name = "pcrebxCikis";
            this.pcrebxCikis.Size = new System.Drawing.Size(32, 31);
            this.pcrebxCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrebxCikis.TabIndex = 21;
            this.pcrebxCikis.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblsinavId);
            this.panel1.Controls.Add(this.bfnbtn_basla);
            this.panel1.Controls.Add(this.lbl_ad);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_soruSayisi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(730, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 620);
            this.panel1.TabIndex = 22;
            // 
            // bfnbtn_basla
            // 
            this.bfnbtn_basla.BackColor = System.Drawing.Color.White;
            this.bfnbtn_basla.color = System.Drawing.Color.White;
            this.bfnbtn_basla.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bfnbtn_basla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfnbtn_basla.Enabled = false;
            this.bfnbtn_basla.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bfnbtn_basla.ForeColor = System.Drawing.Color.SeaGreen;
            this.bfnbtn_basla.Image = ((System.Drawing.Image)(resources.GetObject("bfnbtn_basla.Image")));
            this.bfnbtn_basla.ImagePosition = 21;
            this.bfnbtn_basla.ImageZoom = 50;
            this.bfnbtn_basla.LabelPosition = 43;
            this.bfnbtn_basla.LabelText = "Başla";
            this.bfnbtn_basla.Location = new System.Drawing.Point(9, 412);
            this.bfnbtn_basla.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bfnbtn_basla.Name = "bfnbtn_basla";
            this.bfnbtn_basla.Size = new System.Drawing.Size(225, 58);
            this.bfnbtn_basla.TabIndex = 33;
            this.bfnbtn_basla.Click += new System.EventHandler(this.bfnbtn_basla_Click_1);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(52, 198);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(0, 24);
            this.lbl_ad.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(67, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_soruSayisi
            // 
            this.lbl_soruSayisi.AutoSize = true;
            this.lbl_soruSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soruSayisi.Location = new System.Drawing.Point(63, 355);
            this.lbl_soruSayisi.Name = "lbl_soruSayisi";
            this.lbl_soruSayisi.Size = new System.Drawing.Size(0, 24);
            this.lbl_soruSayisi.TabIndex = 20;
            // 
            // bnftxt_Soru
            // 
            this.bnftxt_Soru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnftxt_Soru.BorderColor = System.Drawing.Color.SeaGreen;
            this.bnftxt_Soru.Cursor = System.Windows.Forms.Cursors.Default;
            this.bnftxt_Soru.Enabled = false;
            this.bnftxt_Soru.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bnftxt_Soru.Location = new System.Drawing.Point(40, 54);
            this.bnftxt_Soru.Multiline = true;
            this.bnftxt_Soru.Name = "bnftxt_Soru";
            this.bnftxt_Soru.Size = new System.Drawing.Size(640, 177);
            this.bnftxt_Soru.TabIndex = 25;
            this.bnftxt_Soru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A
            // 
            this.A.Active = false;
            this.A.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.A.BackColor = System.Drawing.Color.Silver;
            this.A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.A.BorderRadius = 0;
            this.A.ButtonText = "";
            this.A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A.DisabledColor = System.Drawing.Color.Gray;
            this.A.Iconcolor = System.Drawing.Color.Transparent;
            this.A.Iconimage = ((System.Drawing.Image)(resources.GetObject("A.Iconimage")));
            this.A.Iconimage_right = null;
            this.A.Iconimage_right_Selected = null;
            this.A.Iconimage_Selected = null;
            this.A.IconMarginLeft = 0;
            this.A.IconMarginRight = 0;
            this.A.IconRightVisible = true;
            this.A.IconRightZoom = 0D;
            this.A.IconVisible = true;
            this.A.IconZoom = 90D;
            this.A.IsTab = false;
            this.A.Location = new System.Drawing.Point(201, 297);
            this.A.Name = "A";
            this.A.Normalcolor = System.Drawing.Color.Silver;
            this.A.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.A.OnHoverTextColor = System.Drawing.Color.Navy;
            this.A.selected = false;
            this.A.Size = new System.Drawing.Size(312, 29);
            this.A.TabIndex = 26;
            this.A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.A.Textcolor = System.Drawing.Color.Black;
            this.A.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A.Click += new System.EventHandler(this.A_Click_1);
            // 
            // B
            // 
            this.B.Active = false;
            this.B.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.B.BackColor = System.Drawing.Color.Silver;
            this.B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B.BorderRadius = 0;
            this.B.ButtonText = "";
            this.B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B.DisabledColor = System.Drawing.Color.Gray;
            this.B.Iconcolor = System.Drawing.Color.Transparent;
            this.B.Iconimage = ((System.Drawing.Image)(resources.GetObject("B.Iconimage")));
            this.B.Iconimage_right = null;
            this.B.Iconimage_right_Selected = null;
            this.B.Iconimage_Selected = null;
            this.B.IconMarginLeft = 0;
            this.B.IconMarginRight = 0;
            this.B.IconRightVisible = true;
            this.B.IconRightZoom = 0D;
            this.B.IconVisible = true;
            this.B.IconZoom = 90D;
            this.B.IsTab = false;
            this.B.Location = new System.Drawing.Point(201, 355);
            this.B.Name = "B";
            this.B.Normalcolor = System.Drawing.Color.Silver;
            this.B.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.B.OnHoverTextColor = System.Drawing.Color.Navy;
            this.B.selected = false;
            this.B.Size = new System.Drawing.Size(312, 29);
            this.B.TabIndex = 27;
            this.B.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B.Textcolor = System.Drawing.Color.Black;
            this.B.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B.Click += new System.EventHandler(this.B_Click_1);
            // 
            // C
            // 
            this.C.Active = false;
            this.C.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.C.BackColor = System.Drawing.Color.Silver;
            this.C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.C.BorderRadius = 0;
            this.C.ButtonText = "";
            this.C.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C.DisabledColor = System.Drawing.Color.Gray;
            this.C.Iconcolor = System.Drawing.Color.Transparent;
            this.C.Iconimage = ((System.Drawing.Image)(resources.GetObject("C.Iconimage")));
            this.C.Iconimage_right = null;
            this.C.Iconimage_right_Selected = null;
            this.C.Iconimage_Selected = null;
            this.C.IconMarginLeft = 0;
            this.C.IconMarginRight = 0;
            this.C.IconRightVisible = true;
            this.C.IconRightZoom = 0D;
            this.C.IconVisible = true;
            this.C.IconZoom = 90D;
            this.C.IsTab = false;
            this.C.Location = new System.Drawing.Point(201, 412);
            this.C.Name = "C";
            this.C.Normalcolor = System.Drawing.Color.Silver;
            this.C.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.C.OnHoverTextColor = System.Drawing.Color.Navy;
            this.C.selected = false;
            this.C.Size = new System.Drawing.Size(312, 29);
            this.C.TabIndex = 28;
            this.C.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.C.Textcolor = System.Drawing.Color.Black;
            this.C.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.C.Click += new System.EventHandler(this.C_Click_1);
            // 
            // D
            // 
            this.D.Active = false;
            this.D.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.D.BackColor = System.Drawing.Color.Silver;
            this.D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.D.BorderRadius = 0;
            this.D.ButtonText = "";
            this.D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.D.DisabledColor = System.Drawing.Color.Gray;
            this.D.Enabled = false;
            this.D.Iconcolor = System.Drawing.Color.Transparent;
            this.D.Iconimage = ((System.Drawing.Image)(resources.GetObject("D.Iconimage")));
            this.D.Iconimage_right = null;
            this.D.Iconimage_right_Selected = null;
            this.D.Iconimage_Selected = null;
            this.D.IconMarginLeft = 0;
            this.D.IconMarginRight = 0;
            this.D.IconRightVisible = true;
            this.D.IconRightZoom = 0D;
            this.D.IconVisible = true;
            this.D.IconZoom = 90D;
            this.D.IsTab = false;
            this.D.Location = new System.Drawing.Point(201, 467);
            this.D.Name = "D";
            this.D.Normalcolor = System.Drawing.Color.Silver;
            this.D.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.D.OnHoverTextColor = System.Drawing.Color.Navy;
            this.D.selected = false;
            this.D.Size = new System.Drawing.Size(312, 29);
            this.D.TabIndex = 29;
            this.D.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.D.Textcolor = System.Drawing.Color.Black;
            this.D.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.D.Click += new System.EventHandler(this.D_Click_1);
            // 
            // lblsinavId
            // 
            this.lblsinavId.AutoSize = true;
            this.lblsinavId.Location = new System.Drawing.Point(140, 529);
            this.lblsinavId.Name = "lblsinavId";
            this.lblsinavId.Size = new System.Drawing.Size(0, 13);
            this.lblsinavId.TabIndex = 34;
            this.lblsinavId.Visible = false;
            // 
            // frm_OgrenciSinavEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(971, 620);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.bnftxt_Soru);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcrebxCikis);
            this.Controls.Add(this.bnfprgrsbar_süre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_OgrenciSinavEkran";
            this.Text = "SinavEkrani";
            this.Load += new System.EventHandler(this.frm_SinavEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcrebxCikis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuProgressBar bnfprgrsbar_süre;
        private System.Windows.Forms.PictureBox pcrebxCikis;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_soruSayisi;
        private Bunifu.Framework.BunifuCustomTextbox bnftxt_Soru;
        private Bunifu.Framework.UI.BunifuFlatButton D;
        private Bunifu.Framework.UI.BunifuFlatButton C;
        private Bunifu.Framework.UI.BunifuFlatButton B;
        private Bunifu.Framework.UI.BunifuFlatButton A;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_ad;
        private Bunifu.Framework.UI.BunifuTileButton bfnbtn_basla;
        private System.Windows.Forms.Label lblsinavId;
    }
}