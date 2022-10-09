
namespace Ornek1
{
    partial class FormEkstraMalzeme
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
            this.grpMalzemeEkle = new System.Windows.Forms.GroupBox();
            this.nudFiyati = new System.Windows.Forms.NumericUpDown();
            this.btnMenuyuKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMalzemeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMalzemeEkle
            // 
            this.grpMalzemeEkle.Controls.Add(this.nudFiyati);
            this.grpMalzemeEkle.Controls.Add(this.btnMenuyuKaydet);
            this.grpMalzemeEkle.Controls.Add(this.label2);
            this.grpMalzemeEkle.Controls.Add(this.txtMalzemeAdi);
            this.grpMalzemeEkle.Controls.Add(this.label1);
            this.grpMalzemeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMalzemeEkle.Location = new System.Drawing.Point(12, 12);
            this.grpMalzemeEkle.Name = "grpMalzemeEkle";
            this.grpMalzemeEkle.Size = new System.Drawing.Size(339, 188);
            this.grpMalzemeEkle.TabIndex = 1;
            this.grpMalzemeEkle.TabStop = false;
            this.grpMalzemeEkle.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // nudFiyati
            // 
            this.nudFiyati.DecimalPlaces = 2;
            this.nudFiyati.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudFiyati.Location = new System.Drawing.Point(131, 68);
            this.nudFiyati.Name = "nudFiyati";
            this.nudFiyati.Size = new System.Drawing.Size(187, 21);
            this.nudFiyati.TabIndex = 3;
            this.nudFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMenuyuKaydet
            // 
            this.btnMenuyuKaydet.Location = new System.Drawing.Point(131, 108);
            this.btnMenuyuKaydet.Name = "btnMenuyuKaydet";
            this.btnMenuyuKaydet.Size = new System.Drawing.Size(187, 57);
            this.btnMenuyuKaydet.TabIndex = 2;
            this.btnMenuyuKaydet.Text = "EKSTRA MALZEMEYİ KAYDET";
            this.btnMenuyuKaydet.UseVisualStyleBackColor = true;
            this.btnMenuyuKaydet.Click += new System.EventHandler(this.btnMenuyuKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyatı";
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(131, 38);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(187, 21);
            this.txtMalzemeAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Adı";
            // 
            // FormEkstraMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 220);
            this.Controls.Add(this.grpMalzemeEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEkstraMalzeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormEkstraMalzeme";
            this.grpMalzemeEkle.ResumeLayout(false);
            this.grpMalzemeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMalzemeEkle;
        private System.Windows.Forms.Button btnMenuyuKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFiyati;
    }
}