namespace parola.Forms
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.lblParolaListe = new System.Windows.Forms.ListBox();
            this.grpbxListe = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamKayitSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.grpbxParolaDetay = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblSeleniumInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnJsonBackup = new System.Windows.Forms.Button();
            this.BtnJsonRestore = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.excel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpbxListe.SuspendLayout();
            this.grpbxParolaDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblParolaListe
            // 
            this.lblParolaListe.BackColor = System.Drawing.Color.SeaShell;
            this.lblParolaListe.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParolaListe.FormattingEnabled = true;
            this.lblParolaListe.ItemHeight = 20;
            this.lblParolaListe.Location = new System.Drawing.Point(4, 17);
            this.lblParolaListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblParolaListe.Name = "lblParolaListe";
            this.lblParolaListe.Size = new System.Drawing.Size(306, 204);
            this.lblParolaListe.TabIndex = 0;
            this.lblParolaListe.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grpbxListe
            // 
            this.grpbxListe.BackColor = System.Drawing.Color.Transparent;
            this.grpbxListe.Controls.Add(this.lblParolaListe);
            this.grpbxListe.Controls.Add(this.label6);
            this.grpbxListe.Controls.Add(this.lblToplamKayitSayisi);
            this.grpbxListe.Location = new System.Drawing.Point(12, 87);
            this.grpbxListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxListe.Name = "grpbxListe";
            this.grpbxListe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxListe.Size = new System.Drawing.Size(316, 278);
            this.grpbxListe.TabIndex = 1;
            this.grpbxListe.TabStop = false;
            this.grpbxListe.Text = "List of Parolas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Record :";
            // 
            // lblToplamKayitSayisi
            // 
            this.lblToplamKayitSayisi.AutoSize = true;
            this.lblToplamKayitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamKayitSayisi.ForeColor = System.Drawing.Color.Black;
            this.lblToplamKayitSayisi.Location = new System.Drawing.Point(132, 237);
            this.lblToplamKayitSayisi.Name = "lblToplamKayitSayisi";
            this.lblToplamKayitSayisi.Size = new System.Drawing.Size(45, 20);
            this.lblToplamKayitSayisi.TabIndex = 0;
            this.lblToplamKayitSayisi.Text = "____";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parola:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Açıklama:";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(148, 26);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(60, 22);
            this.lblIsim.TabIndex = 7;
            this.lblIsim.Text = "İsim:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(148, 42);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(150, 22);
            this.lblKullaniciAdi.TabIndex = 7;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(148, 59);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(70, 22);
            this.lblParola.TabIndex = 7;
            this.lblParola.Text = "Parola";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(7, 109);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(90, 22);
            this.lblAciklama.TabIndex = 7;
            this.lblAciklama.Text = "Açıklama";
            // 
            // grpbxParolaDetay
            // 
            this.grpbxParolaDetay.BackColor = System.Drawing.Color.Transparent;
            this.grpbxParolaDetay.Controls.Add(this.btnCopy);
            this.grpbxParolaDetay.Controls.Add(this.label1);
            this.grpbxParolaDetay.Controls.Add(this.label2);
            this.grpbxParolaDetay.Controls.Add(this.lblAciklama);
            this.grpbxParolaDetay.Controls.Add(this.lblIsim);
            this.grpbxParolaDetay.Controls.Add(this.lblParola);
            this.grpbxParolaDetay.Controls.Add(this.lblSeleniumInfo);
            this.grpbxParolaDetay.Controls.Add(this.label3);
            this.grpbxParolaDetay.Controls.Add(this.label4);
            this.grpbxParolaDetay.Controls.Add(this.lblKullaniciAdi);
            this.grpbxParolaDetay.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxParolaDetay.ForeColor = System.Drawing.Color.Black;
            this.grpbxParolaDetay.Location = new System.Drawing.Point(332, 87);
            this.grpbxParolaDetay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxParolaDetay.Name = "grpbxParolaDetay";
            this.grpbxParolaDetay.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxParolaDetay.Size = new System.Drawing.Size(422, 278);
            this.grpbxParolaDetay.TabIndex = 9;
            this.grpbxParolaDetay.TabStop = false;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopy.Location = new System.Drawing.Point(260, 237);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(157, 34);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "Copy password";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // lblSeleniumInfo
            // 
            this.lblSeleniumInfo.AutoSize = true;
            this.lblSeleniumInfo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeleniumInfo.ForeColor = System.Drawing.Color.Black;
            this.lblSeleniumInfo.Location = new System.Drawing.Point(148, 83);
            this.lblSeleniumInfo.Name = "lblSeleniumInfo";
            this.lblSeleniumInfo.Size = new System.Drawing.Size(36, 20);
            this.lblSeleniumInfo.TabIndex = 7;
            this.lblSeleniumInfo.Text = "---";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(695, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BtnJsonBackup
            // 
            this.BtnJsonBackup.BackColor = System.Drawing.Color.LightGray;
            this.BtnJsonBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnJsonBackup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnJsonBackup.Image = ((System.Drawing.Image)(resources.GetObject("BtnJsonBackup.Image")));
            this.BtnJsonBackup.Location = new System.Drawing.Point(537, 10);
            this.BtnJsonBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnJsonBackup.Name = "BtnJsonBackup";
            this.BtnJsonBackup.Size = new System.Drawing.Size(89, 60);
            this.BtnJsonBackup.TabIndex = 0;
            this.BtnJsonBackup.Text = "Backup";
            this.BtnJsonBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.BtnJsonRestore.Location = new System.Drawing.Point(436, 10);
            this.BtnJsonRestore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnJsonRestore.Name = "BtnJsonRestore";
            this.BtnJsonRestore.Size = new System.Drawing.Size(89, 60);
            this.BtnJsonRestore.TabIndex = 0;
            this.BtnJsonRestore.Text = "Restore";
            this.BtnJsonRestore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.BtnShow.Location = new System.Drawing.Point(336, 10);
            this.BtnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(89, 60);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Chrome";
            this.BtnShow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.excel.Location = new System.Drawing.Point(637, 10);
            this.excel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(89, 60);
            this.excel.TabIndex = 0;
            this.excel.Text = "Excel";
            this.excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.btnUpdate.Location = new System.Drawing.Point(135, 10);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 60);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.btnDelete.Location = new System.Drawing.Point(236, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 60);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(101, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search this text in list.";
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArama.Location = new System.Drawing.Point(18, 32);
            this.txtArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(312, 30);
            this.txtArama.TabIndex = 8;
            this.txtArama.TextChanged += new System.EventHandler(this.Arama);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(35, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 60);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.BtnShow);
            this.panel1.Controls.Add(this.BtnJsonBackup);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.excel);
            this.panel1.Controls.Add(this.BtnJsonRestore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 369);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 128);
            this.panel1.TabIndex = 10;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(761, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpbxParolaDetay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpbxListe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Parola List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxListe.ResumeLayout(false);
            this.grpbxListe.PerformLayout();
            this.grpbxParolaDetay.ResumeLayout(false);
            this.grpbxParolaDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ListBox lblParolaListe;
        private System.Windows.Forms.GroupBox grpbxListe;
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
        private System.Windows.Forms.GroupBox grpbxParolaDetay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnJsonBackup;
        private System.Windows.Forms.Button BtnJsonRestore;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSeleniumInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
    }
}
