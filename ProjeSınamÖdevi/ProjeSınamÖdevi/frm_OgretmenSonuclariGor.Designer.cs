namespace ProjeSınamÖdevi
{
    partial class frm_OgretmenSonuclariGor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OgretmenSonuclariGor));
            this.grid_GenelSonuclar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chr_SonucGrafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnGoruntule = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pcrebxCikis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_GenelSonuclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_SonucGrafik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrebxCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_GenelSonuclar
            // 
            this.grid_GenelSonuclar.AllowUserToAddRows = false;
            this.grid_GenelSonuclar.AllowUserToDeleteRows = false;
            this.grid_GenelSonuclar.BackgroundColor = System.Drawing.Color.Gray;
            this.grid_GenelSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_GenelSonuclar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grid_GenelSonuclar.Location = new System.Drawing.Point(381, 34);
            this.grid_GenelSonuclar.Name = "grid_GenelSonuclar";
            this.grid_GenelSonuclar.ReadOnly = true;
            this.grid_GenelSonuclar.Size = new System.Drawing.Size(543, 267);
            this.grid_GenelSonuclar.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Öğrenci Numarası";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sınav";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Doğru Sayısı";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Yanlış Sayısı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Başar Yüzdesi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // chr_SonucGrafik
            // 
            this.chr_SonucGrafik.BackColor = System.Drawing.Color.Gray;
            this.chr_SonucGrafik.BorderlineColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.chr_SonucGrafik.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chr_SonucGrafik.Legends.Add(legend1);
            this.chr_SonucGrafik.Location = new System.Drawing.Point(425, 339);
            this.chr_SonucGrafik.Name = "chr_SonucGrafik";
            this.chr_SonucGrafik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Başarı Oranları";
            this.chr_SonucGrafik.Series.Add(series1);
            this.chr_SonucGrafik.Size = new System.Drawing.Size(460, 171);
            this.chr_SonucGrafik.TabIndex = 3;
            this.chr_SonucGrafik.Text = "chart1";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuDropdown1.items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(39, 210);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.SeaGreen;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.SeaGreen;
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(271, 42);
            this.bunifuDropdown1.TabIndex = 4;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.ActiveBorderThickness = 1;
            this.btnGoruntule.ActiveCornerRadius = 20;
            this.btnGoruntule.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGoruntule.ActiveForecolor = System.Drawing.Color.White;
            this.btnGoruntule.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGoruntule.BackColor = System.Drawing.Color.Gray;
            this.btnGoruntule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoruntule.BackgroundImage")));
            this.btnGoruntule.ButtonText = "Sonuçları Gör";
            this.btnGoruntule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoruntule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoruntule.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGoruntule.IdleBorderThickness = 1;
            this.btnGoruntule.IdleCornerRadius = 20;
            this.btnGoruntule.IdleFillColor = System.Drawing.Color.White;
            this.btnGoruntule.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGoruntule.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGoruntule.Location = new System.Drawing.Point(63, 282);
            this.btnGoruntule.Margin = new System.Windows.Forms.Padding(5);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(221, 50);
            this.btnGoruntule.TabIndex = 5;
            this.btnGoruntule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click_1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pcrebxCikis
            // 
            this.pcrebxCikis.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.ErrorImage")));
            this.pcrebxCikis.Image = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.Image")));
            this.pcrebxCikis.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcrebxCikis.InitialImage")));
            this.pcrebxCikis.Location = new System.Drawing.Point(932, -1);
            this.pcrebxCikis.Name = "pcrebxCikis";
            this.pcrebxCikis.Size = new System.Drawing.Size(32, 31);
            this.pcrebxCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrebxCikis.TabIndex = 21;
            this.pcrebxCikis.TabStop = false;
            this.pcrebxCikis.Click += new System.EventHandler(this.pcrebxCikis_Click);
            // 
            // frm_OgretmenSonuclariGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(963, 540);
            this.Controls.Add(this.pcrebxCikis);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.chr_SonucGrafik);
            this.Controls.Add(this.grid_GenelSonuclar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_OgretmenSonuclariGor";
            this.Text = "frm_OgretmenSonuclariGor";
            this.Load += new System.EventHandler(this.frm_OgretmenSonuclariGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_GenelSonuclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_SonucGrafik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrebxCikis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_GenelSonuclar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_SonucGrafik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGoruntule;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pcrebxCikis;
    }
}