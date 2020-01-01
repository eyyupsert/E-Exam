namespace ProjeSınamÖdevi
{
    partial class frm_OgrenciSinavSonuc
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OgrenciSinavSonuc));
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_GenelOranTablosu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnSonuclar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcrebxCikis = new System.Windows.Forms.PictureBox();
            this.lbl_ograd = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGenelSonuclar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSinavBilgi = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_GenelOranTablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrebxCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Gray;
            this.chart2.BorderlineColor = System.Drawing.Color.Gray;
            chartArea9.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart2.Legends.Add(legend9);
            this.chart2.Location = new System.Drawing.Point(62, 341);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "BASARIORANLARI";
            this.chart2.Series.Add(series9);
            this.chart2.Size = new System.Drawing.Size(742, 336);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.grid_GenelOranTablosu);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.bunifuDropdown1);
            this.groupBox1.Controls.Add(this.btnSonuclar);
            this.groupBox1.Controls.Add(this.chart2);
            this.groupBox1.Location = new System.Drawing.Point(0, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 755);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // grid_GenelOranTablosu
            // 
            this.grid_GenelOranTablosu.AllowUserToAddRows = false;
            this.grid_GenelOranTablosu.AllowUserToDeleteRows = false;
            this.grid_GenelOranTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_GenelOranTablosu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grid_GenelOranTablosu.Location = new System.Drawing.Point(211, 82);
            this.grid_GenelOranTablosu.Name = "grid_GenelOranTablosu";
            this.grid_GenelOranTablosu.ReadOnly = true;
            this.grid_GenelOranTablosu.Size = new System.Drawing.Size(443, 224);
            this.grid_GenelOranTablosu.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sınav Bilgi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Toplam Doğru Sayısı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Toplam Yanlış Sayısı";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Başarı Yüzdesi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gray;
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(139, 352);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Genel Sonuçlar";
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(609, 281);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuDropdown1.items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(292, 95);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(253, 28);
            this.bunifuDropdown1.TabIndex = 6;
            // 
            // btnSonuclar
            // 
            this.btnSonuclar.ActiveBorderThickness = 1;
            this.btnSonuclar.ActiveCornerRadius = 20;
            this.btnSonuclar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSonuclar.ActiveForecolor = System.Drawing.Color.White;
            this.btnSonuclar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSonuclar.BackColor = System.Drawing.Color.Gray;
            this.btnSonuclar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSonuclar.BackgroundImage")));
            this.btnSonuclar.ButtonText = "Sonuçlar";
            this.btnSonuclar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSonuclar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSonuclar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSonuclar.IdleBorderThickness = 1;
            this.btnSonuclar.IdleCornerRadius = 20;
            this.btnSonuclar.IdleFillColor = System.Drawing.Color.White;
            this.btnSonuclar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSonuclar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSonuclar.Location = new System.Drawing.Point(317, 144);
            this.btnSonuclar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSonuclar.Name = "btnSonuclar";
            this.btnSonuclar.Size = new System.Drawing.Size(213, 50);
            this.btnSonuclar.TabIndex = 5;
            this.btnSonuclar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSonuclar.Click += new System.EventHandler(this.btnSonuclar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pcrebxCikis);
            this.panel1.Controls.Add(this.lbl_ograd);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnGenelSonuclar);
            this.panel1.Controls.Add(this.btnSinavBilgi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(866, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 747);
            this.panel1.TabIndex = 8;
            // 
            // pcrebxCikis
            // 
            this.pcrebxCikis.ErrorImage = null;
            this.pcrebxCikis.Image = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.Image")));
            this.pcrebxCikis.InitialImage = null;
            this.pcrebxCikis.Location = new System.Drawing.Point(326, 0);
            this.pcrebxCikis.Name = "pcrebxCikis";
            this.pcrebxCikis.Size = new System.Drawing.Size(32, 31);
            this.pcrebxCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrebxCikis.TabIndex = 34;
            this.pcrebxCikis.TabStop = false;
            this.pcrebxCikis.Click += new System.EventHandler(this.pcrebxCikis_Click);
            // 
            // lbl_ograd
            // 
            this.lbl_ograd.AutoSize = true;
            this.lbl_ograd.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ograd.ForeColor = System.Drawing.Color.White;
            this.lbl_ograd.Location = new System.Drawing.Point(114, 296);
            this.lbl_ograd.Name = "lbl_ograd";
            this.lbl_ograd.Size = new System.Drawing.Size(0, 26);
            this.lbl_ograd.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(92, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // btnGenelSonuclar
            // 
            this.btnGenelSonuclar.Active = false;
            this.btnGenelSonuclar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenelSonuclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenelSonuclar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenelSonuclar.BorderRadius = 0;
            this.btnGenelSonuclar.ButtonText = "Genel Sonuçlar";
            this.btnGenelSonuclar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenelSonuclar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenelSonuclar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenelSonuclar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGenelSonuclar.Iconimage")));
            this.btnGenelSonuclar.Iconimage_right = null;
            this.btnGenelSonuclar.Iconimage_right_Selected = null;
            this.btnGenelSonuclar.Iconimage_Selected = null;
            this.btnGenelSonuclar.IconMarginLeft = 0;
            this.btnGenelSonuclar.IconMarginRight = 0;
            this.btnGenelSonuclar.IconRightVisible = true;
            this.btnGenelSonuclar.IconRightZoom = 0D;
            this.btnGenelSonuclar.IconVisible = true;
            this.btnGenelSonuclar.IconZoom = 90D;
            this.btnGenelSonuclar.IsTab = false;
            this.btnGenelSonuclar.Location = new System.Drawing.Point(-10, 557);
            this.btnGenelSonuclar.Name = "btnGenelSonuclar";
            this.btnGenelSonuclar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenelSonuclar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGenelSonuclar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenelSonuclar.selected = false;
            this.btnGenelSonuclar.Size = new System.Drawing.Size(368, 155);
            this.btnGenelSonuclar.TabIndex = 15;
            this.btnGenelSonuclar.Text = "Genel Sonuçlar";
            this.btnGenelSonuclar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenelSonuclar.Textcolor = System.Drawing.Color.White;
            this.btnGenelSonuclar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenelSonuclar.Click += new System.EventHandler(this.btnGenelSonuclar_Click_1);
            // 
            // btnSinavBilgi
            // 
            this.btnSinavBilgi.Active = false;
            this.btnSinavBilgi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSinavBilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSinavBilgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSinavBilgi.BorderRadius = 0;
            this.btnSinavBilgi.ButtonText = "Sınav Sonuçları";
            this.btnSinavBilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinavBilgi.DisabledColor = System.Drawing.Color.Gray;
            this.btnSinavBilgi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSinavBilgi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSinavBilgi.Iconimage")));
            this.btnSinavBilgi.Iconimage_right = null;
            this.btnSinavBilgi.Iconimage_right_Selected = null;
            this.btnSinavBilgi.Iconimage_Selected = null;
            this.btnSinavBilgi.IconMarginLeft = 0;
            this.btnSinavBilgi.IconMarginRight = 0;
            this.btnSinavBilgi.IconRightVisible = true;
            this.btnSinavBilgi.IconRightZoom = 0D;
            this.btnSinavBilgi.IconVisible = true;
            this.btnSinavBilgi.IconZoom = 90D;
            this.btnSinavBilgi.IsTab = false;
            this.btnSinavBilgi.Location = new System.Drawing.Point(-10, 371);
            this.btnSinavBilgi.Name = "btnSinavBilgi";
            this.btnSinavBilgi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSinavBilgi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSinavBilgi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSinavBilgi.selected = false;
            this.btnSinavBilgi.Size = new System.Drawing.Size(368, 156);
            this.btnSinavBilgi.TabIndex = 14;
            this.btnSinavBilgi.Text = "Sınav Sonuçları";
            this.btnSinavBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinavBilgi.Textcolor = System.Drawing.Color.White;
            this.btnSinavBilgi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinavBilgi.Click += new System.EventHandler(this.btnSinavBilgi_Click);
            // 
            // frm_OgrenciSinavSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 747);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_OgrenciSinavSonuc";
            this.Text = "frm_SinavBilgileri";
            this.Load += new System.EventHandler(this.frm_SinavBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_GenelOranTablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrebxCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSinavBilgi;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenelSonuclar;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSonuclar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView grid_GenelOranTablosu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_ograd;
        private System.Windows.Forms.PictureBox pcrebxCikis;
    }
}