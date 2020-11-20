namespace parola
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
            this.lbxParolaListe = new System.Windows.Forms.ListBox();
            this.grpbxListe = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamKayitSayisi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.grpbxParolaDetay = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnJsonBackup = new System.Windows.Forms.Button();
            this.BtnJsonRestore = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.excel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BtnCloseWeb = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.grpbxListe.SuspendLayout();
            this.grpbxParolaDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxParolaListe
            // 
            this.lbxParolaListe.BackColor = System.Drawing.Color.SeaShell;
            this.lbxParolaListe.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxParolaListe.FormattingEnabled = true;
            this.lbxParolaListe.ItemHeight = 20;
            this.lbxParolaListe.Location = new System.Drawing.Point(5, 21);
            this.lbxParolaListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxParolaListe.Name = "lbxParolaListe";
            this.lbxParolaListe.Size = new System.Drawing.Size(297, 264);
            this.lbxParolaListe.TabIndex = 0;
            this.lbxParolaListe.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grpbxListe
            // 
            this.grpbxListe.BackColor = System.Drawing.Color.Transparent;
            this.grpbxListe.Controls.Add(this.lbxParolaListe);
            this.grpbxListe.Controls.Add(this.label6);
            this.grpbxListe.Controls.Add(this.lblToplamKayitSayisi);
            this.grpbxListe.Location = new System.Drawing.Point(9, 143);
            this.grpbxListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxListe.Name = "grpbxListe";
            this.grpbxListe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxListe.Size = new System.Drawing.Size(308, 326);
            this.grpbxListe.TabIndex = 1;
            this.grpbxListe.TabStop = false;
            this.grpbxListe.Text = "Liste";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Toplam Kayıt Sayısı :";
            // 
            // lblToplamKayitSayisi
            // 
            this.lblToplamKayitSayisi.AutoSize = true;
            this.lblToplamKayitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamKayitSayisi.ForeColor = System.Drawing.Color.Black;
            this.lblToplamKayitSayisi.Location = new System.Drawing.Point(233, 296);
            this.lblToplamKayitSayisi.Name = "lblToplamKayitSayisi";
            this.lblToplamKayitSayisi.Size = new System.Drawing.Size(45, 20);
            this.lblToplamKayitSayisi.TabIndex = 0;
            this.lblToplamKayitSayisi.Text = "____";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Aramak istediğiniz metini giriniz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(112, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(112, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(112, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parola";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(112, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Açıklama";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(245, 37);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(45, 20);
            this.lblIsim.TabIndex = 7;
            this.lblIsim.Text = "İsim:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(245, 57);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(106, 20);
            this.lblKullaniciAdi.TabIndex = 7;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(245, 79);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(57, 20);
            this.lblParola.TabIndex = 7;
            this.lblParola.Text = "Parola";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(112, 119);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(77, 20);
            this.lblAciklama.TabIndex = 7;
            this.lblAciklama.Text = "Açıklama";
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArama.Location = new System.Drawing.Point(6, 282);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(361, 30);
            this.txtArama.TabIndex = 8;
            this.txtArama.TextChanged += new System.EventHandler(this.Arama);
            // 
            // grpbxParolaDetay
            // 
            this.grpbxParolaDetay.BackColor = System.Drawing.Color.Transparent;
            this.grpbxParolaDetay.Controls.Add(this.btnCopy);
            this.grpbxParolaDetay.Controls.Add(this.pictureBox1);
            this.grpbxParolaDetay.Controls.Add(this.label1);
            this.grpbxParolaDetay.Controls.Add(this.txtArama);
            this.grpbxParolaDetay.Controls.Add(this.label2);
            this.grpbxParolaDetay.Controls.Add(this.lblAciklama);
            this.grpbxParolaDetay.Controls.Add(this.lblIsim);
            this.grpbxParolaDetay.Controls.Add(this.lblParola);
            this.grpbxParolaDetay.Controls.Add(this.label3);
            this.grpbxParolaDetay.Controls.Add(this.label4);
            this.grpbxParolaDetay.Controls.Add(this.lblKullaniciAdi);
            this.grpbxParolaDetay.Controls.Add(this.label5);
            this.grpbxParolaDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxParolaDetay.ForeColor = System.Drawing.Color.Black;
            this.grpbxParolaDetay.Location = new System.Drawing.Point(323, 143);
            this.grpbxParolaDetay.Name = "grpbxParolaDetay";
            this.grpbxParolaDetay.Size = new System.Drawing.Size(570, 326);
            this.grpbxParolaDetay.TabIndex = 9;
            this.grpbxParolaDetay.TabStop = false;
            this.grpbxParolaDetay.Text = "Parola detay";
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopy.Location = new System.Drawing.Point(437, 76);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(117, 29);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "Copy password";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.BtnJsonBackup);
            this.groupBox2.Controls.Add(this.BtnJsonRestore);
            this.groupBox2.Controls.Add(this.BtnShow);
            this.groupBox2.Controls.Add(this.excel);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.BtnCloseWeb);
            this.groupBox2.Controls.Add(this.BtnExit);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 125);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // BtnJsonBackup
            // 
            this.BtnJsonBackup.BackColor = System.Drawing.Color.LightGray;
            this.BtnJsonBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnJsonBackup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnJsonBackup.Image = ((System.Drawing.Image)(resources.GetObject("BtnJsonBackup.Image")));
            this.BtnJsonBackup.Location = new System.Drawing.Point(550, 34);
            this.BtnJsonBackup.Name = "BtnJsonBackup";
            this.BtnJsonBackup.Size = new System.Drawing.Size(100, 75);
            this.BtnJsonBackup.TabIndex = 0;
            this.BtnJsonBackup.Text = "Backup";
            this.BtnJsonBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnJsonBackup.UseVisualStyleBackColor = false;
            this.BtnJsonBackup.Click += new System.EventHandler(this.BtnJsonBackup_Click);
            // 
            // BtnJsonRestore
            // 
            this.BtnJsonRestore.BackColor = System.Drawing.Color.LightGray;
            this.BtnJsonRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnJsonRestore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnJsonRestore.Image = ((System.Drawing.Image)(resources.GetObject("BtnJsonRestore.Image")));
            this.BtnJsonRestore.Location = new System.Drawing.Point(444, 34);
            this.BtnJsonRestore.Name = "BtnJsonRestore";
            this.BtnJsonRestore.Size = new System.Drawing.Size(100, 75);
            this.BtnJsonRestore.TabIndex = 0;
            this.BtnJsonRestore.Text = "Restore ";
            this.BtnJsonRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnJsonRestore.UseVisualStyleBackColor = false;
            this.BtnJsonRestore.Click += new System.EventHandler(this.BtnJsonRestore_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.LightGray;
            this.BtnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnShow.Image = ((System.Drawing.Image)(resources.GetObject("BtnShow.Image")));
            this.BtnShow.Location = new System.Drawing.Point(338, 34);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(100, 75);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Open";
            this.BtnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // excel
            // 
            this.excel.BackColor = System.Drawing.Color.LightGray;
            this.excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.excel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.excel.Image = ((System.Drawing.Image)(resources.GetObject("excel.Image")));
            this.excel.Location = new System.Drawing.Point(656, 34);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(100, 75);
            this.excel.TabIndex = 0;
            this.excel.Text = "Excel";
            this.excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.excel.UseVisualStyleBackColor = false;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(20, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 75);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Edit/New";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.Update_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(126, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 75);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // BtnCloseWeb
            // 
            this.BtnCloseWeb.BackColor = System.Drawing.Color.LightGray;
            this.BtnCloseWeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCloseWeb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCloseWeb.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseWeb.Image")));
            this.BtnCloseWeb.Location = new System.Drawing.Point(232, 34);
            this.BtnCloseWeb.Name = "BtnCloseWeb";
            this.BtnCloseWeb.Size = new System.Drawing.Size(100, 75);
            this.BtnCloseWeb.TabIndex = 0;
            this.BtnCloseWeb.Text = "Close";
            this.BtnCloseWeb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCloseWeb.UseVisualStyleBackColor = false;
            this.BtnCloseWeb.Click += new System.EventHandler(this.BtnCloseWeb_Click_1);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(762, 34);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(100, 75);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbxParolaDetay);
            this.Controls.Add(this.grpbxListe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAROLAM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxListe.ResumeLayout(false);
            this.grpbxListe.PerformLayout();
            this.grpbxParolaDetay.ResumeLayout(false);
            this.grpbxParolaDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxParolaListe;
        private System.Windows.Forms.GroupBox grpbxListe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToplamKayitSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.GroupBox grpbxParolaDetay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button BtnCloseWeb;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnJsonBackup;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnJsonRestore;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

