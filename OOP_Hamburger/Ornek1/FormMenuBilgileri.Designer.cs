
namespace Ornek1
{
    partial class FormMenuBilgileri
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
            this.grpMenuBilgileri = new System.Windows.Forms.GroupBox();
            this.nudFiyati = new System.Windows.Forms.NumericUpDown();
            this.btnMenuyuKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMenuBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuBilgileri
            // 
            this.grpMenuBilgileri.Controls.Add(this.nudFiyati);
            this.grpMenuBilgileri.Controls.Add(this.btnMenuyuKaydet);
            this.grpMenuBilgileri.Controls.Add(this.label2);
            this.grpMenuBilgileri.Controls.Add(this.txtMenuAdi);
            this.grpMenuBilgileri.Controls.Add(this.label1);
            this.grpMenuBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenuBilgileri.Location = new System.Drawing.Point(13, 13);
            this.grpMenuBilgileri.Name = "grpMenuBilgileri";
            this.grpMenuBilgileri.Size = new System.Drawing.Size(319, 182);
            this.grpMenuBilgileri.TabIndex = 0;
            this.grpMenuBilgileri.TabStop = false;
            this.grpMenuBilgileri.Text = "MENÜ BİLGİLERİ";
            // 
            // nudFiyati
            // 
            this.nudFiyati.DecimalPlaces = 2;
            this.nudFiyati.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudFiyati.Location = new System.Drawing.Point(122, 59);
            this.nudFiyati.Name = "nudFiyati";
            this.nudFiyati.Size = new System.Drawing.Size(170, 21);
            this.nudFiyati.TabIndex = 3;
            this.nudFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMenuyuKaydet
            // 
            this.btnMenuyuKaydet.Location = new System.Drawing.Point(122, 99);
            this.btnMenuyuKaydet.Name = "btnMenuyuKaydet";
            this.btnMenuyuKaydet.Size = new System.Drawing.Size(170, 57);
            this.btnMenuyuKaydet.TabIndex = 2;
            this.btnMenuyuKaydet.Text = "MENÜYÜ KAYDET";
            this.btnMenuyuKaydet.UseVisualStyleBackColor = true;
            this.btnMenuyuKaydet.Click += new System.EventHandler(this.btnMenuyuKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyatı";
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(122, 29);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(170, 21);
            this.txtMenuAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı";
            // 
            // FormMenuBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 216);
            this.Controls.Add(this.grpMenuBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormMenuBilgileri";
            this.grpMenuBilgileri.ResumeLayout(false);
            this.grpMenuBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuBilgileri;
        private System.Windows.Forms.Button btnMenuyuKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFiyati;
    }
}