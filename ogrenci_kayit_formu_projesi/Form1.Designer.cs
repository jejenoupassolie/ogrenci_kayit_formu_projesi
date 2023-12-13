namespace ogrenci_kayit_formu_projesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelkayitsayisi = new System.Windows.Forms.Label();
            this.textBoxtelefonno = new System.Windows.Forms.TextBox();
            this.textBoxdogumyeri = new System.Windows.Forms.TextBox();
            this.textBoxyas = new System.Windows.Forms.TextBox();
            this.textBoxadsoyad = new System.Windows.Forms.TextBox();
            this.textBoxtc = new System.Windows.Forms.TextBox();
            this.comboBoxmezuniyet = new System.Windows.Forms.ComboBox();
            this.radioButtonara = new System.Windows.Forms.RadioButton();
            this.radioButtonerkek = new System.Windows.Forms.RadioButton();
            this.radioButtonkadin = new System.Windows.Forms.RadioButton();
            this.radioButtonekle = new System.Windows.Forms.RadioButton();
            this.radioButtonsilchkbx = new System.Windows.Forms.RadioButton();
            this.radioButtonsilnrml = new System.Windows.Forms.RadioButton();
            this.radioButtontümünüsil = new System.Windows.Forms.RadioButton();
            this.radioButtonyenikyt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC KİMLİK NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADI SOYADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "YAŞI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "MEZUNİYETİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1058, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOĞUM YERİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1058, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "TELEFON NO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1058, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "KAYIT SAYISI";
            // 
            // labelkayitsayisi
            // 
            this.labelkayitsayisi.AutoSize = true;
            this.labelkayitsayisi.ForeColor = System.Drawing.Color.Red;
            this.labelkayitsayisi.Location = new System.Drawing.Point(1200, 309);
            this.labelkayitsayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelkayitsayisi.Name = "labelkayitsayisi";
            this.labelkayitsayisi.Size = new System.Drawing.Size(109, 24);
            this.labelkayitsayisi.TabIndex = 7;
            this.labelkayitsayisi.Text = "_________";
            // 
            // textBoxtelefonno
            // 
            this.textBoxtelefonno.Location = new System.Drawing.Point(1204, 267);
            this.textBoxtelefonno.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxtelefonno.Name = "textBoxtelefonno";
            this.textBoxtelefonno.Size = new System.Drawing.Size(215, 28);
            this.textBoxtelefonno.TabIndex = 8;
            // 
            // textBoxdogumyeri
            // 
            this.textBoxdogumyeri.Location = new System.Drawing.Point(1204, 213);
            this.textBoxdogumyeri.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxdogumyeri.Name = "textBoxdogumyeri";
            this.textBoxdogumyeri.Size = new System.Drawing.Size(215, 28);
            this.textBoxdogumyeri.TabIndex = 9;
            // 
            // textBoxyas
            // 
            this.textBoxyas.Location = new System.Drawing.Point(166, 158);
            this.textBoxyas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxyas.Name = "textBoxyas";
            this.textBoxyas.Size = new System.Drawing.Size(232, 28);
            this.textBoxyas.TabIndex = 10;
            // 
            // textBoxadsoyad
            // 
            this.textBoxadsoyad.Location = new System.Drawing.Point(166, 105);
            this.textBoxadsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxadsoyad.Name = "textBoxadsoyad";
            this.textBoxadsoyad.Size = new System.Drawing.Size(232, 28);
            this.textBoxadsoyad.TabIndex = 11;
            // 
            // textBoxtc
            // 
            this.textBoxtc.Location = new System.Drawing.Point(166, 60);
            this.textBoxtc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxtc.Name = "textBoxtc";
            this.textBoxtc.Size = new System.Drawing.Size(232, 28);
            this.textBoxtc.TabIndex = 12;
            // 
            // comboBoxmezuniyet
            // 
            this.comboBoxmezuniyet.FormattingEnabled = true;
            this.comboBoxmezuniyet.Location = new System.Drawing.Point(166, 211);
            this.comboBoxmezuniyet.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxmezuniyet.Name = "comboBoxmezuniyet";
            this.comboBoxmezuniyet.Size = new System.Drawing.Size(261, 30);
            this.comboBoxmezuniyet.TabIndex = 13;
            // 
            // radioButtonara
            // 
            this.radioButtonara.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonara.AutoSize = true;
            this.radioButtonara.Location = new System.Drawing.Point(426, 60);
            this.radioButtonara.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonara.Name = "radioButtonara";
            this.radioButtonara.Size = new System.Drawing.Size(62, 34);
            this.radioButtonara.TabIndex = 14;
            this.radioButtonara.TabStop = true;
            this.radioButtonara.Text = "ARA";
            this.radioButtonara.UseVisualStyleBackColor = true;
            // 
            // radioButtonerkek
            // 
            this.radioButtonerkek.AutoSize = true;
            this.radioButtonerkek.Location = new System.Drawing.Point(222, 51);
            this.radioButtonerkek.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonerkek.Name = "radioButtonerkek";
            this.radioButtonerkek.Size = new System.Drawing.Size(99, 28);
            this.radioButtonerkek.TabIndex = 15;
            this.radioButtonerkek.TabStop = true;
            this.radioButtonerkek.Text = "ERKEK";
            this.radioButtonerkek.UseVisualStyleBackColor = true;
            // 
            // radioButtonkadin
            // 
            this.radioButtonkadin.AutoSize = true;
            this.radioButtonkadin.Location = new System.Drawing.Point(8, 51);
            this.radioButtonkadin.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonkadin.Name = "radioButtonkadin";
            this.radioButtonkadin.Size = new System.Drawing.Size(92, 28);
            this.radioButtonkadin.TabIndex = 16;
            this.radioButtonkadin.TabStop = true;
            this.radioButtonkadin.Text = "KADIN";
            this.radioButtonkadin.UseVisualStyleBackColor = true;
            // 
            // radioButtonekle
            // 
            this.radioButtonekle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonekle.AutoSize = true;
            this.radioButtonekle.Location = new System.Drawing.Point(18, 362);
            this.radioButtonekle.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonekle.Name = "radioButtonekle";
            this.radioButtonekle.Size = new System.Drawing.Size(72, 34);
            this.radioButtonekle.TabIndex = 17;
            this.radioButtonekle.TabStop = true;
            this.radioButtonekle.Text = "EKLE";
            this.radioButtonekle.UseVisualStyleBackColor = true;
            this.radioButtonekle.Click += new System.EventHandler(this.radioButtonekle_Click);
            // 
            // radioButtonsilchkbx
            // 
            this.radioButtonsilchkbx.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonsilchkbx.AutoSize = true;
            this.radioButtonsilchkbx.Location = new System.Drawing.Point(224, 362);
            this.radioButtonsilchkbx.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonsilchkbx.Name = "radioButtonsilchkbx";
            this.radioButtonsilchkbx.Size = new System.Drawing.Size(177, 34);
            this.radioButtonsilchkbx.TabIndex = 18;
            this.radioButtonsilchkbx.TabStop = true;
            this.radioButtonsilchkbx.Text = "SİL(CHECKBOX)";
            this.radioButtonsilchkbx.UseVisualStyleBackColor = true;
            // 
            // radioButtonsilnrml
            // 
            this.radioButtonsilnrml.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonsilnrml.AutoSize = true;
            this.radioButtonsilnrml.Location = new System.Drawing.Point(558, 362);
            this.radioButtonsilnrml.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonsilnrml.Name = "radioButtonsilnrml";
            this.radioButtonsilnrml.Size = new System.Drawing.Size(150, 34);
            this.radioButtonsilnrml.TabIndex = 19;
            this.radioButtonsilnrml.TabStop = true;
            this.radioButtonsilnrml.Text = "SİL(NORMAL)";
            this.radioButtonsilnrml.UseVisualStyleBackColor = true;
            // 
            // radioButtontümünüsil
            // 
            this.radioButtontümünüsil.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtontümünüsil.AutoSize = true;
            this.radioButtontümünüsil.Location = new System.Drawing.Point(933, 362);
            this.radioButtontümünüsil.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtontümünüsil.Name = "radioButtontümünüsil";
            this.radioButtontümünüsil.Size = new System.Drawing.Size(150, 34);
            this.radioButtontümünüsil.TabIndex = 20;
            this.radioButtontümünüsil.TabStop = true;
            this.radioButtontümünüsil.Text = "SİL(TÜMÜNÜ)";
            this.radioButtontümünüsil.UseVisualStyleBackColor = true;
            // 
            // radioButtonyenikyt
            // 
            this.radioButtonyenikyt.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonyenikyt.AutoSize = true;
            this.radioButtonyenikyt.Location = new System.Drawing.Point(1291, 362);
            this.radioButtonyenikyt.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonyenikyt.Name = "radioButtonyenikyt";
            this.radioButtonyenikyt.Size = new System.Drawing.Size(131, 34);
            this.radioButtonyenikyt.TabIndex = 21;
            this.radioButtonyenikyt.TabStop = true;
            this.radioButtonyenikyt.Text = "YENİ KAYIT";
            this.radioButtonyenikyt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonkadin);
            this.groupBox1.Controls.Add(this.radioButtonerkek);
            this.groupBox1.Location = new System.Drawing.Point(1062, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(357, 138);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CİNSİYETİ";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 418);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1480, 285);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 739);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButtonyenikyt);
            this.Controls.Add(this.radioButtontümünüsil);
            this.Controls.Add(this.radioButtonsilnrml);
            this.Controls.Add(this.radioButtonsilchkbx);
            this.Controls.Add(this.radioButtonekle);
            this.Controls.Add(this.radioButtonara);
            this.Controls.Add(this.comboBoxmezuniyet);
            this.Controls.Add(this.textBoxtc);
            this.Controls.Add(this.textBoxadsoyad);
            this.Controls.Add(this.textBoxyas);
            this.Controls.Add(this.textBoxdogumyeri);
            this.Controls.Add(this.textBoxtelefonno);
            this.Controls.Add(this.labelkayitsayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ÖĞRENCİ KAYIT SİSTEMİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelkayitsayisi;
        private System.Windows.Forms.TextBox textBoxtelefonno;
        private System.Windows.Forms.TextBox textBoxdogumyeri;
        private System.Windows.Forms.TextBox textBoxyas;
        private System.Windows.Forms.TextBox textBoxadsoyad;
        private System.Windows.Forms.TextBox textBoxtc;
        private System.Windows.Forms.ComboBox comboBoxmezuniyet;
        private System.Windows.Forms.RadioButton radioButtonara;
        private System.Windows.Forms.RadioButton radioButtonerkek;
        private System.Windows.Forms.RadioButton radioButtonkadin;
        private System.Windows.Forms.RadioButton radioButtonekle;
        private System.Windows.Forms.RadioButton radioButtonsilchkbx;
        private System.Windows.Forms.RadioButton radioButtonsilnrml;
        private System.Windows.Forms.RadioButton radioButtontümünüsil;
        private System.Windows.Forms.RadioButton radioButtonyenikyt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
    }
}

