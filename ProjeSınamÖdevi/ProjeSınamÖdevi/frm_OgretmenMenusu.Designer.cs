namespace ProjeSınamÖdevi
{
    partial class frm_OgretmenMenusu
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
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.btnSonuclariGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Location = new System.Drawing.Point(139, 164);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(143, 60);
            this.btnSoruEkle.TabIndex = 0;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = true;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // btnSonuclariGoster
            // 
            this.btnSonuclariGoster.Location = new System.Drawing.Point(439, 164);
            this.btnSonuclariGoster.Name = "btnSonuclariGoster";
            this.btnSonuclariGoster.Size = new System.Drawing.Size(143, 60);
            this.btnSonuclariGoster.TabIndex = 1;
            this.btnSonuclariGoster.Text = "Sonuçları Görüntüle";
            this.btnSonuclariGoster.UseVisualStyleBackColor = true;
            this.btnSonuclariGoster.Click += new System.EventHandler(this.btnSonuclariGoster_Click);
            // 
            // frm_OgretmenMenusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 396);
            this.Controls.Add(this.btnSonuclariGoster);
            this.Controls.Add(this.btnSoruEkle);
            this.Name = "frm_OgretmenMenusu";
            this.Text = "frm_OgretmenMenusu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_OgretmenMenusu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSoruEkle;
        private System.Windows.Forms.Button btnSonuclariGoster;
    }
}