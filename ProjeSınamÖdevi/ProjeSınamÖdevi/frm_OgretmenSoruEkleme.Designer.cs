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
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.cmbCevap = new System.Windows.Forms.ComboBox();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.cmbKonu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(158, 71);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(340, 123);
            this.txtSoru.TabIndex = 1;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(158, 221);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(340, 20);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(158, 277);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(340, 20);
            this.txtB.TabIndex = 3;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(158, 339);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(340, 20);
            this.txtC.TabIndex = 4;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(158, 396);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(340, 20);
            this.txtD.TabIndex = 5;
            // 
            // cmbCevap
            // 
            this.cmbCevap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCevap.FormattingEnabled = true;
            this.cmbCevap.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbCevap.Location = new System.Drawing.Point(158, 459);
            this.cmbCevap.Name = "cmbCevap";
            this.cmbCevap.Size = new System.Drawing.Size(340, 21);
            this.cmbCevap.TabIndex = 7;
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Location = new System.Drawing.Point(652, 221);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(206, 111);
            this.btnSoruEkle.TabIndex = 8;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = true;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // cmbKonu
            // 
            this.cmbKonu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKonu.FormattingEnabled = true;
            this.cmbKonu.Location = new System.Drawing.Point(158, 32);
            this.cmbKonu.Name = "cmbKonu";
            this.cmbKonu.Size = new System.Drawing.Size(340, 21);
            this.cmbKonu.TabIndex = 9;
            // 
            // frm_OgretmenEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 574);
            this.Controls.Add(this.cmbKonu);
            this.Controls.Add(this.btnSoruEkle);
            this.Controls.Add(this.cmbCevap);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtSoru);
            this.Name = "frm_OgretmenEkrani";
            this.Text = "frm_OgretmenEkrani";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_OgretmenEkrani_FormClosing);
            this.Load += new System.EventHandler(this.frm_OgretmenEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.ComboBox cmbCevap;
        private System.Windows.Forms.Button btnSoruEkle;
        private System.Windows.Forms.ComboBox cmbKonu;
    }
}