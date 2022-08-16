
namespace EntityFrameworkGrupOdevi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Anasayfa = new System.Windows.Forms.TabPage();
            this.txtEser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstEserler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbYazarResim = new System.Windows.Forms.PictureBox();
            this.cmbYazarlar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Yazarlar = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            this.grpYazarEkle = new System.Windows.Forms.GroupBox();
            this.btnEkleYazarlar = new System.Windows.Forms.Button();
            this.btnIptalYazarlar = new System.Windows.Forms.Button();
            this.txtTamAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Eserler = new System.Windows.Forms.TabPage();
            this.lstEserPanelEserler = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grbEser = new System.Windows.Forms.GroupBox();
            this.btnEkleEserler = new System.Windows.Forms.Button();
            this.btnIptalEserler = new System.Windows.Forms.Button();
            this.txtEserIcerik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.txtEserBaslik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Anasayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbYazarResim)).BeginInit();
            this.Yazarlar.SuspendLayout();
            this.grpYazarEkle.SuspendLayout();
            this.Eserler.SuspendLayout();
            this.grbEser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Anasayfa);
            this.tabControl1.Controls.Add(this.Yazarlar);
            this.tabControl1.Controls.Add(this.Eserler);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1077, 676);
            this.tabControl1.TabIndex = 0;
            // 
            // Anasayfa
            // 
            this.Anasayfa.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Anasayfa.Controls.Add(this.txtEser);
            this.Anasayfa.Controls.Add(this.label3);
            this.Anasayfa.Controls.Add(this.lstEserler);
            this.Anasayfa.Controls.Add(this.label2);
            this.Anasayfa.Controls.Add(this.pbYazarResim);
            this.Anasayfa.Controls.Add(this.cmbYazarlar);
            this.Anasayfa.Controls.Add(this.label1);
            this.Anasayfa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anasayfa.Location = new System.Drawing.Point(4, 28);
            this.Anasayfa.Name = "Anasayfa";
            this.Anasayfa.Padding = new System.Windows.Forms.Padding(3);
            this.Anasayfa.Size = new System.Drawing.Size(1069, 644);
            this.Anasayfa.TabIndex = 0;
            this.Anasayfa.Text = "AnaSayfa";
            // 
            // txtEser
            // 
            this.txtEser.BackColor = System.Drawing.SystemColors.Info;
            this.txtEser.Location = new System.Drawing.Point(406, 325);
            this.txtEser.Multiline = true;
            this.txtEser.Name = "txtEser";
            this.txtEser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEser.Size = new System.Drawing.Size(656, 309);
            this.txtEser.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eser:";
            // 
            // lstEserler
            // 
            this.lstEserler.BackColor = System.Drawing.SystemColors.Info;
            this.lstEserler.FormattingEnabled = true;
            this.lstEserler.ItemHeight = 19;
            this.lstEserler.Location = new System.Drawing.Point(405, 68);
            this.lstEserler.Name = "lstEserler";
            this.lstEserler.Size = new System.Drawing.Size(657, 194);
            this.lstEserler.TabIndex = 4;
            this.lstEserler.SelectedIndexChanged += new System.EventHandler(this.lstEserler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eserler:";
            // 
            // pbYazarResim
            // 
            this.pbYazarResim.Image = ((System.Drawing.Image)(resources.GetObject("pbYazarResim.Image")));
            this.pbYazarResim.Location = new System.Drawing.Point(45, 138);
            this.pbYazarResim.Name = "pbYazarResim";
            this.pbYazarResim.Size = new System.Drawing.Size(314, 466);
            this.pbYazarResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbYazarResim.TabIndex = 2;
            this.pbYazarResim.TabStop = false;
            // 
            // cmbYazarlar
            // 
            this.cmbYazarlar.BackColor = System.Drawing.SystemColors.Info;
            this.cmbYazarlar.FormattingEnabled = true;
            this.cmbYazarlar.Location = new System.Drawing.Point(75, 68);
            this.cmbYazarlar.Name = "cmbYazarlar";
            this.cmbYazarlar.Size = new System.Drawing.Size(314, 27);
            this.cmbYazarlar.TabIndex = 1;
            this.cmbYazarlar.SelectedIndexChanged += new System.EventHandler(this.cmbYazarlar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazarlar:";
            // 
            // Yazarlar
            // 
            this.Yazarlar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Yazarlar.Controls.Add(this.label5);
            this.Yazarlar.Controls.Add(this.lstYazarlar);
            this.Yazarlar.Controls.Add(this.grpYazarEkle);
            this.Yazarlar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yazarlar.Location = new System.Drawing.Point(4, 28);
            this.Yazarlar.Name = "Yazarlar";
            this.Yazarlar.Padding = new System.Windows.Forms.Padding(3);
            this.Yazarlar.Size = new System.Drawing.Size(1069, 644);
            this.Yazarlar.TabIndex = 1;
            this.Yazarlar.Text = "Yazarlar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yazarlar:";
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.BackColor = System.Drawing.SystemColors.Info;
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.ItemHeight = 19;
            this.lstYazarlar.Location = new System.Drawing.Point(13, 232);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(1049, 403);
            this.lstYazarlar.TabIndex = 1;
            // 
            // grpYazarEkle
            // 
            this.grpYazarEkle.Controls.Add(this.btnEkleYazarlar);
            this.grpYazarEkle.Controls.Add(this.btnIptalYazarlar);
            this.grpYazarEkle.Controls.Add(this.txtTamAd);
            this.grpYazarEkle.Controls.Add(this.label4);
            this.grpYazarEkle.Location = new System.Drawing.Point(273, 45);
            this.grpYazarEkle.Name = "grpYazarEkle";
            this.grpYazarEkle.Size = new System.Drawing.Size(438, 165);
            this.grpYazarEkle.TabIndex = 0;
            this.grpYazarEkle.TabStop = false;
            this.grpYazarEkle.Text = "Yazar Ekle";
            // 
            // btnEkleYazarlar
            // 
            this.btnEkleYazarlar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnEkleYazarlar.Location = new System.Drawing.Point(277, 101);
            this.btnEkleYazarlar.Name = "btnEkleYazarlar";
            this.btnEkleYazarlar.Size = new System.Drawing.Size(110, 34);
            this.btnEkleYazarlar.TabIndex = 3;
            this.btnEkleYazarlar.Text = "EKLE";
            this.btnEkleYazarlar.UseVisualStyleBackColor = false;
            this.btnEkleYazarlar.Click += new System.EventHandler(this.btnEkleYazarlar_Click);
            // 
            // btnIptalYazarlar
            // 
            this.btnIptalYazarlar.BackColor = System.Drawing.Color.Red;
            this.btnIptalYazarlar.Location = new System.Drawing.Point(95, 101);
            this.btnIptalYazarlar.Name = "btnIptalYazarlar";
            this.btnIptalYazarlar.Size = new System.Drawing.Size(110, 34);
            this.btnIptalYazarlar.TabIndex = 2;
            this.btnIptalYazarlar.Text = "IPTAL";
            this.btnIptalYazarlar.UseVisualStyleBackColor = false;
            this.btnIptalYazarlar.Click += new System.EventHandler(this.btnIptalYazarlar_Click);
            // 
            // txtTamAd
            // 
            this.txtTamAd.BackColor = System.Drawing.SystemColors.Info;
            this.txtTamAd.Location = new System.Drawing.Point(95, 38);
            this.txtTamAd.Name = "txtTamAd";
            this.txtTamAd.Size = new System.Drawing.Size(292, 26);
            this.txtTamAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tam Ad:";
            // 
            // Eserler
            // 
            this.Eserler.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Eserler.Controls.Add(this.lstEserPanelEserler);
            this.Eserler.Controls.Add(this.label9);
            this.Eserler.Controls.Add(this.grbEser);
            this.Eserler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eserler.Location = new System.Drawing.Point(4, 28);
            this.Eserler.Name = "Eserler";
            this.Eserler.Padding = new System.Windows.Forms.Padding(3);
            this.Eserler.Size = new System.Drawing.Size(1069, 644);
            this.Eserler.TabIndex = 2;
            this.Eserler.Text = "Eserler";
            // 
            // lstEserPanelEserler
            // 
            this.lstEserPanelEserler.BackColor = System.Drawing.SystemColors.Info;
            this.lstEserPanelEserler.FormattingEnabled = true;
            this.lstEserPanelEserler.ItemHeight = 19;
            this.lstEserPanelEserler.Location = new System.Drawing.Point(476, 31);
            this.lstEserPanelEserler.Name = "lstEserPanelEserler";
            this.lstEserPanelEserler.Size = new System.Drawing.Size(590, 593);
            this.lstEserPanelEserler.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Eserler:";
            // 
            // grbEser
            // 
            this.grbEser.Controls.Add(this.btnEkleEserler);
            this.grbEser.Controls.Add(this.btnIptalEserler);
            this.grbEser.Controls.Add(this.txtEserIcerik);
            this.grbEser.Controls.Add(this.label8);
            this.grbEser.Controls.Add(this.cmbYazar);
            this.grbEser.Controls.Add(this.txtEserBaslik);
            this.grbEser.Controls.Add(this.label7);
            this.grbEser.Controls.Add(this.label6);
            this.grbEser.Location = new System.Drawing.Point(16, 22);
            this.grbEser.Name = "grbEser";
            this.grbEser.Size = new System.Drawing.Size(428, 509);
            this.grbEser.TabIndex = 0;
            this.grbEser.TabStop = false;
            this.grbEser.Text = "Eser";
            // 
            // btnEkleEserler
            // 
            this.btnEkleEserler.BackColor = System.Drawing.Color.GreenYellow;
            this.btnEkleEserler.Location = new System.Drawing.Point(303, 448);
            this.btnEkleEserler.Name = "btnEkleEserler";
            this.btnEkleEserler.Size = new System.Drawing.Size(111, 43);
            this.btnEkleEserler.TabIndex = 7;
            this.btnEkleEserler.Text = "EKLE";
            this.btnEkleEserler.UseVisualStyleBackColor = false;
            this.btnEkleEserler.Click += new System.EventHandler(this.btnEkleEserler_Click);
            // 
            // btnIptalEserler
            // 
            this.btnIptalEserler.BackColor = System.Drawing.Color.Red;
            this.btnIptalEserler.Location = new System.Drawing.Point(12, 448);
            this.btnIptalEserler.Name = "btnIptalEserler";
            this.btnIptalEserler.Size = new System.Drawing.Size(111, 43);
            this.btnIptalEserler.TabIndex = 6;
            this.btnIptalEserler.Text = "IPTAL";
            this.btnIptalEserler.UseVisualStyleBackColor = false;
            this.btnIptalEserler.Click += new System.EventHandler(this.btnIptalEserler_Click);
            // 
            // txtEserIcerik
            // 
            this.txtEserIcerik.BackColor = System.Drawing.SystemColors.Info;
            this.txtEserIcerik.Location = new System.Drawing.Point(11, 172);
            this.txtEserIcerik.Multiline = true;
            this.txtEserIcerik.Name = "txtEserIcerik";
            this.txtEserIcerik.Size = new System.Drawing.Size(403, 253);
            this.txtEserIcerik.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Eser Icerik:";
            // 
            // cmbYazar
            // 
            this.cmbYazar.BackColor = System.Drawing.SystemColors.Info;
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(122, 73);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(237, 27);
            this.cmbYazar.TabIndex = 3;
            this.cmbYazar.TabStop = false;
            this.cmbYazar.SelectedIndexChanged += new System.EventHandler(this.cmbYazar_SelectedIndexChanged);
            // 
            // txtEserBaslik
            // 
            this.txtEserBaslik.BackColor = System.Drawing.SystemColors.Info;
            this.txtEserBaslik.Location = new System.Drawing.Point(122, 44);
            this.txtEserBaslik.Name = "txtEserBaslik";
            this.txtEserBaslik.Size = new System.Drawing.Size(237, 26);
            this.txtEserBaslik.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Yazar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Eser Baslik:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 676);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Anasayfa.ResumeLayout(false);
            this.Anasayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbYazarResim)).EndInit();
            this.Yazarlar.ResumeLayout(false);
            this.Yazarlar.PerformLayout();
            this.grpYazarEkle.ResumeLayout(false);
            this.grpYazarEkle.PerformLayout();
            this.Eserler.ResumeLayout(false);
            this.Eserler.PerformLayout();
            this.grbEser.ResumeLayout(false);
            this.grbEser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Anasayfa;
        private System.Windows.Forms.TextBox txtEser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstEserler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbYazarResim;
        private System.Windows.Forms.ComboBox cmbYazarlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Yazarlar;
        private System.Windows.Forms.TabPage Eserler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstYazarlar;
        private System.Windows.Forms.GroupBox grpYazarEkle;
        private System.Windows.Forms.Button btnEkleYazarlar;
        private System.Windows.Forms.Button btnIptalYazarlar;
        private System.Windows.Forms.TextBox txtTamAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbEser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstEserPanelEserler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEserIcerik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.TextBox txtEserBaslik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEkleEserler;
        private System.Windows.Forms.Button btnIptalEserler;
    }
}

