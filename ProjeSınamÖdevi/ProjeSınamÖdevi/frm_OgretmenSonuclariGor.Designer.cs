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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.grid_GenelSonuclar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chr_SonucGrafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grid_GenelSonuclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_SonucGrafik)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(92, 265);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(191, 68);
            this.btnGoruntule.TabIndex = 1;
            this.btnGoruntule.Text = "Sonuçlarını Gör";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // grid_GenelSonuclar
            // 
            this.grid_GenelSonuclar.AllowUserToAddRows = false;
            this.grid_GenelSonuclar.AllowUserToDeleteRows = false;
            this.grid_GenelSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_GenelSonuclar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grid_GenelSonuclar.Location = new System.Drawing.Point(364, 22);
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
            chartArea1.Name = "ChartArea1";
            this.chr_SonucGrafik.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chr_SonucGrafik.Legends.Add(legend1);
            this.chr_SonucGrafik.Location = new System.Drawing.Point(429, 324);
            this.chr_SonucGrafik.Name = "chr_SonucGrafik";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Başarı Oranları";
            this.chr_SonucGrafik.Series.Add(series1);
            this.chr_SonucGrafik.Size = new System.Drawing.Size(460, 171);
            this.chr_SonucGrafik.TabIndex = 3;
            this.chr_SonucGrafik.Text = "chart1";
            // 
            // frm_OgretmenSonuclariGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 540);
            this.Controls.Add(this.chr_SonucGrafik);
            this.Controls.Add(this.grid_GenelSonuclar);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.comboBox1);
            this.Name = "frm_OgretmenSonuclariGor";
            this.Text = "frm_OgretmenSonuclariGor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_OgretmenSonuclariGor_FormClosing);
            this.Load += new System.EventHandler(this.frm_OgretmenSonuclariGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_GenelSonuclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_SonucGrafik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.DataGridView grid_GenelSonuclar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_SonucGrafik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}