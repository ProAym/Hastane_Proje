﻿namespace Hastane_Proje
{
    partial class FrmHastaDetay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LnkGuncelle = new System.Windows.Forms.LinkLabel();
            this.LblAdsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnRandevu = new System.Windows.Forms.Button();
            this.RchSikayet = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.LnkGuncelle);
            this.groupBox1.Controls.Add(this.LblAdsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // LnkGuncelle
            // 
            this.LnkGuncelle.AutoSize = true;
            this.LnkGuncelle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkGuncelle.ForeColor = System.Drawing.Color.White;
            this.LnkGuncelle.LinkColor = System.Drawing.Color.White;
            this.LnkGuncelle.Location = new System.Drawing.Point(89, 135);
            this.LnkGuncelle.Name = "LnkGuncelle";
            this.LnkGuncelle.Size = new System.Drawing.Size(189, 19);
            this.LnkGuncelle.TabIndex = 19;
            this.LnkGuncelle.TabStop = true;
            this.LnkGuncelle.Text = "Kişisel Bilgilerimi Güncelle";
            this.LnkGuncelle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkGuncelle_LinkClicked);
            // 
            // LblAdsoyad
            // 
            this.LblAdsoyad.AutoSize = true;
            this.LblAdsoyad.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdsoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LblAdsoyad.Location = new System.Drawing.Point(186, 51);
            this.LblAdsoyad.Name = "LblAdsoyad";
            this.LblAdsoyad.Size = new System.Drawing.Size(53, 23);
            this.LblAdsoyad.TabIndex = 11;
            this.LblAdsoyad.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(74, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ad Soyad :";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LblTc.Location = new System.Drawing.Point(186, 91);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(153, 23);
            this.LblTc.TabIndex = 9;
            this.LblTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(32, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "TC Kimlik No :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox2.Controls.Add(this.BtnCikis);
            this.groupBox2.Controls.Add(this.BtnRandevu);
            this.groupBox2.Controls.Add(this.RchSikayet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CmbDoktor);
            this.groupBox2.Controls.Add(this.CmbBrans);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(13, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 445);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Alma Paneli";
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Red;
            this.BtnCikis.ForeColor = System.Drawing.Color.Black;
            this.BtnCikis.Location = new System.Drawing.Point(201, 374);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(138, 53);
            this.BtnCikis.TabIndex = 21;
            this.BtnCikis.Text = "Cikis yap";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click_1);
            // 
            // BtnRandevu
            // 
            this.BtnRandevu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRandevu.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.BtnRandevu.Location = new System.Drawing.Point(23, 374);
            this.BtnRandevu.Name = "BtnRandevu";
            this.BtnRandevu.Size = new System.Drawing.Size(164, 53);
            this.BtnRandevu.TabIndex = 18;
            this.BtnRandevu.Text = "Randevu Al";
            this.BtnRandevu.UseVisualStyleBackColor = false;
            this.BtnRandevu.Click += new System.EventHandler(this.BtnRandevu_Click);
            // 
            // RchSikayet
            // 
            this.RchSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchSikayet.Location = new System.Drawing.Point(123, 149);
            this.RchSikayet.Name = "RchSikayet";
            this.RchSikayet.Size = new System.Drawing.Size(229, 193);
            this.RchSikayet.TabIndex = 17;
            this.RchSikayet.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(25, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Şikayet :";
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(123, 99);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(229, 37);
            this.CmbDoktor.TabIndex = 15;
            this.CmbDoktor.SelectedIndexChanged += new System.EventHandler(this.CmbDoktor_SelectedIndexChanged);
            // 
            // CmbBrans
            // 
            this.CmbBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(123, 53);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(229, 37);
            this.CmbBrans.TabIndex = 14;
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(25, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Doktor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Branş :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Location = new System.Drawing.Point(390, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(867, 326);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(861, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox4.Location = new System.Drawing.Point(390, 368);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(867, 286);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(861, 258);
            this.dataGridView2.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.CheckedState.Parent = this.BtnClose;
            this.BtnClose.CustomImages.Parent = this.BtnClose;
            this.BtnClose.FillColor = System.Drawing.Color.Red;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.HoverState.Parent = this.BtnClose;
            this.BtnClose.Location = new System.Drawing.Point(1215, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(43, 28);
            this.BtnClose.TabIndex = 17;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1270, 695);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Ana Ekran";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RchSikayet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel LnkGuncelle;
        private System.Windows.Forms.Button BtnRandevu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnCikis;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
    }
}