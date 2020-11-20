namespace parola
{
    partial class datagridliste
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
            this.dgwParolaListe = new System.Windows.Forms.DataGridView();
            this.exceleaktar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwParolaListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwParolaListe
            // 
            this.dgwParolaListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwParolaListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwParolaListe.Location = new System.Drawing.Point(12, 12);
            this.dgwParolaListe.Name = "dgwParolaListe";
            this.dgwParolaListe.RowHeadersWidth = 51;
            this.dgwParolaListe.RowTemplate.Height = 24;
            this.dgwParolaListe.Size = new System.Drawing.Size(754, 368);
            this.dgwParolaListe.TabIndex = 0;
            // 
            // exceleaktar
            // 
            this.exceleaktar.Location = new System.Drawing.Point(12, 411);
            this.exceleaktar.Name = "exceleaktar";
            this.exceleaktar.Size = new System.Drawing.Size(754, 35);
            this.exceleaktar.TabIndex = 1;
            this.exceleaktar.Text = "excele aktar";
            this.exceleaktar.UseVisualStyleBackColor = true;
            this.exceleaktar.Click += new System.EventHandler(this.exceleaktar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Kayt Sayısı";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.Location = new System.Drawing.Point(704, 383);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(40, 17);
            this.lblKayitSayisi.TabIndex = 2;
            this.lblKayitSayisi.Text = "____";
            // 
            // datagridliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 456);
            this.Controls.Add(this.lblKayitSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exceleaktar);
            this.Controls.Add(this.dgwParolaListe);
            this.Name = "datagridliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "datagridliste";
            this.Load += new System.EventHandler(this.datagridliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwParolaListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.DataGridView dgwParolaListe;
        private System.Windows.Forms.Button exceleaktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKayitSayisi;
    }
}