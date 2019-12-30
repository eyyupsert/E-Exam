namespace ProjeSınamÖdevi
{
    partial class frm_OgrenciMenu
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
            this.btnSinavOl = new System.Windows.Forms.Button();
            this.btnIstatistikGor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSinavOl
            // 
            this.btnSinavOl.Location = new System.Drawing.Point(191, 182);
            this.btnSinavOl.Name = "btnSinavOl";
            this.btnSinavOl.Size = new System.Drawing.Size(148, 57);
            this.btnSinavOl.TabIndex = 0;
            this.btnSinavOl.Text = "Sınav Ol";
            this.btnSinavOl.UseVisualStyleBackColor = true;
            this.btnSinavOl.Click += new System.EventHandler(this.btnSinavOl_Click);
            // 
            // btnIstatistikGor
            // 
            this.btnIstatistikGor.Location = new System.Drawing.Point(456, 182);
            this.btnIstatistikGor.Name = "btnIstatistikGor";
            this.btnIstatistikGor.Size = new System.Drawing.Size(154, 55);
            this.btnIstatistikGor.TabIndex = 1;
            this.btnIstatistikGor.Text = "İstatistikler";
            this.btnIstatistikGor.UseVisualStyleBackColor = true;
            this.btnIstatistikGor.Click += new System.EventHandler(this.btnIstatistikGor_Click);
            // 
            // frm_OgrenciMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIstatistikGor);
            this.Controls.Add(this.btnSinavOl);
            this.Name = "frm_OgrenciMenu";
            this.Text = "frm_OgrenciMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_OgrenciMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSinavOl;
        private System.Windows.Forms.Button btnIstatistikGor;
    }
}