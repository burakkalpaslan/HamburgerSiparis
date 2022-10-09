
namespace Ornek1
{
    partial class FormSiparisEkle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.grpBoyut = new System.Windows.Forms.GroupBox();
            this.rbtnBuyuk = new System.Windows.Forms.RadioButton();
            this.rbtnOrta = new System.Windows.Forms.RadioButton();
            this.rbtnKucuk = new System.Windows.Forms.RadioButton();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flpMalzeme = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ornek1.Properties.Resources.hamburger;
            this.pictureBox1.Location = new System.Drawing.Point(18, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÜ SEÇİN";
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(18, 191);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(238, 23);
            this.cmbMenu.TabIndex = 2;
            // 
            // grpBoyut
            // 
            this.grpBoyut.Controls.Add(this.rbtnBuyuk);
            this.grpBoyut.Controls.Add(this.rbtnOrta);
            this.grpBoyut.Controls.Add(this.rbtnKucuk);
            this.grpBoyut.Location = new System.Drawing.Point(18, 228);
            this.grpBoyut.Name = "grpBoyut";
            this.grpBoyut.Size = new System.Drawing.Size(237, 68);
            this.grpBoyut.TabIndex = 3;
            this.grpBoyut.TabStop = false;
            this.grpBoyut.Text = "BOYUT SEÇİNİZ";
            // 
            // rbtnBuyuk
            // 
            this.rbtnBuyuk.AutoSize = true;
            this.rbtnBuyuk.Location = new System.Drawing.Point(160, 34);
            this.rbtnBuyuk.Name = "rbtnBuyuk";
            this.rbtnBuyuk.Size = new System.Drawing.Size(63, 19);
            this.rbtnBuyuk.TabIndex = 0;
            this.rbtnBuyuk.TabStop = true;
            this.rbtnBuyuk.Text = "Büyük";
            this.rbtnBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbtnOrta
            // 
            this.rbtnOrta.AutoSize = true;
            this.rbtnOrta.Location = new System.Drawing.Point(88, 34);
            this.rbtnOrta.Name = "rbtnOrta";
            this.rbtnOrta.Size = new System.Drawing.Size(52, 19);
            this.rbtnOrta.TabIndex = 0;
            this.rbtnOrta.TabStop = true;
            this.rbtnOrta.Text = "Orta";
            this.rbtnOrta.UseVisualStyleBackColor = true;
            // 
            // rbtnKucuk
            // 
            this.rbtnKucuk.AutoSize = true;
            this.rbtnKucuk.Location = new System.Drawing.Point(6, 34);
            this.rbtnKucuk.Name = "rbtnKucuk";
            this.rbtnKucuk.Size = new System.Drawing.Size(64, 19);
            this.rbtnKucuk.TabIndex = 0;
            this.rbtnKucuk.TabStop = true;
            this.rbtnKucuk.Text = "Küçük";
            this.rbtnKucuk.UseVisualStyleBackColor = true;
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.ItemHeight = 15;
            this.lbxSiparisler.Location = new System.Drawing.Point(282, 15);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(488, 499);
            this.lbxSiparisler.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "MALZEME SEÇİN";
            // 
            // flpMalzeme
            // 
            this.flpMalzeme.Location = new System.Drawing.Point(19, 331);
            this.flpMalzeme.Name = "flpMalzeme";
            this.flpMalzeme.Size = new System.Drawing.Size(236, 183);
            this.flpMalzeme.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "ADET";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(106, 530);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(149, 21);
            this.nudAdet.TabIndex = 8;
            this.nudAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(18, 567);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(237, 60);
            this.btnSiparisEkle.TabIndex = 9;
            this.btnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "TOPLAM TUTAR:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.lblToplamTutar.Location = new System.Drawing.Point(402, 567);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(43, 15);
            this.lblToplamTutar.TabIndex = 11;
            this.lblToplamTutar.Text = "₺0,00";
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(562, 548);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(208, 79);
            this.btnSiparisiTamamla.TabIndex = 12;
            this.btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // FormSiparisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 639);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flpMalzeme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxSiparisler);
            this.Controls.Add(this.grpBoyut);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSiparisEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormSiparisEkle";
            this.Load += new System.EventHandler(this.FormSiparisEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoyut.ResumeLayout(false);
            this.grpBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.GroupBox grpBoyut;
        private System.Windows.Forms.RadioButton rbtnOrta;
        private System.Windows.Forms.RadioButton rbtnKucuk;
        private System.Windows.Forms.RadioButton rbtnBuyuk;
        private System.Windows.Forms.ListBox lbxSiparisler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpMalzeme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisiTamamla;
    }
}