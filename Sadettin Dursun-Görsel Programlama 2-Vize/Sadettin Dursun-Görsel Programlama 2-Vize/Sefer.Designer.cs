namespace Sadettin_Dursun_Görsel_Programlama_2_Vize
{
    partial class Sefer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sefer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKalkışYer = new System.Windows.Forms.ComboBox();
            this.cmbVarışYer = new System.Windows.Forms.ComboBox();
            this.cmbUçak = new System.Windows.Forms.ComboBox();
            this.kalkışZaman = new System.Windows.Forms.DateTimePicker();
            this.varışZaman = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSefer = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeferAd = new System.Windows.Forms.TextBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.txtÜcret = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSefer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaMenüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            this.anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            this.anaMenüToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.anaMenüToolStripMenuItem.Text = "Ana Menü";
            this.anaMenüToolStripMenuItem.Click += new System.EventHandler(this.anaMenüToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kalkış Noktası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Varış Noktası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Uçak:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kalkış Zamanı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Varış Zamanı:";
            // 
            // cmbKalkışYer
            // 
            this.cmbKalkışYer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKalkışYer.FormattingEnabled = true;
            this.cmbKalkışYer.Items.AddRange(new object[] {
            "Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.cmbKalkışYer.Location = new System.Drawing.Point(237, 38);
            this.cmbKalkışYer.Name = "cmbKalkışYer";
            this.cmbKalkışYer.Size = new System.Drawing.Size(366, 44);
            this.cmbKalkışYer.TabIndex = 6;
            // 
            // cmbVarışYer
            // 
            this.cmbVarışYer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVarışYer.FormattingEnabled = true;
            this.cmbVarışYer.Items.AddRange(new object[] {
            "Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.cmbVarışYer.Location = new System.Drawing.Point(237, 88);
            this.cmbVarışYer.Name = "cmbVarışYer";
            this.cmbVarışYer.Size = new System.Drawing.Size(366, 44);
            this.cmbVarışYer.TabIndex = 7;
            // 
            // cmbUçak
            // 
            this.cmbUçak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUçak.FormattingEnabled = true;
            this.cmbUçak.Location = new System.Drawing.Point(237, 238);
            this.cmbUçak.Name = "cmbUçak";
            this.cmbUçak.Size = new System.Drawing.Size(366, 44);
            this.cmbUçak.TabIndex = 10;
            // 
            // kalkışZaman
            // 
            this.kalkışZaman.Location = new System.Drawing.Point(237, 138);
            this.kalkışZaman.Name = "kalkışZaman";
            this.kalkışZaman.Size = new System.Drawing.Size(366, 44);
            this.kalkışZaman.TabIndex = 11;
            // 
            // varışZaman
            // 
            this.varışZaman.Location = new System.Drawing.Point(237, 188);
            this.varışZaman.Name = "varışZaman";
            this.varışZaman.Size = new System.Drawing.Size(366, 44);
            this.varışZaman.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewSefer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 215);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mevcut Seferler";
            // 
            // dataGridViewSefer
            // 
            this.dataGridViewSefer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSefer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSefer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSefer.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewSefer.Name = "dataGridViewSefer";
            this.dataGridViewSefer.Size = new System.Drawing.Size(1071, 187);
            this.dataGridViewSefer.TabIndex = 0;
            this.dataGridViewSefer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSefer_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(675, 88);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(156, 44);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(869, 37);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(152, 44);
            this.btnGüncelle.TabIndex = 15;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(675, 37);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(156, 44);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sefer Adı:";
            // 
            // txtSeferAd
            // 
            this.txtSeferAd.Location = new System.Drawing.Point(237, 288);
            this.txtSeferAd.Name = "txtSeferAd";
            this.txtSeferAd.Size = new System.Drawing.Size(366, 44);
            this.txtSeferAd.TabIndex = 18;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(869, 88);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(152, 44);
            this.btnYenile.TabIndex = 19;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelId.Location = new System.Drawing.Point(462, 443);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(36, 14);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "label7";
            this.labelId.Visible = false;
            // 
            // txtÜcret
            // 
            this.txtÜcret.Location = new System.Drawing.Point(237, 338);
            this.txtÜcret.Name = "txtÜcret";
            this.txtÜcret.Size = new System.Drawing.Size(366, 44);
            this.txtÜcret.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 36);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ücret:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Sefer Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1077, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtÜcret);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.txtSeferAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.varışZaman);
            this.Controls.Add(this.kalkışZaman);
            this.Controls.Add(this.cmbUçak);
            this.Controls.Add(this.cmbVarışYer);
            this.Controls.Add(this.cmbKalkışYer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Sefer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sefer";
            this.Load += new System.EventHandler(this.Sefer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSefer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaMenüToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKalkışYer;
        private System.Windows.Forms.ComboBox cmbVarışYer;
        private System.Windows.Forms.ComboBox cmbUçak;
        private System.Windows.Forms.DateTimePicker kalkışZaman;
        private System.Windows.Forms.DateTimePicker varışZaman;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewSefer;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSeferAd;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtÜcret;
        private System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
    }
}