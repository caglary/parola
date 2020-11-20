namespace parola
{
    partial class SelectConnectionstring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectConnectionstring));
            this.btnLenovo = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLenovo
            // 
            this.btnLenovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLenovo.BackgroundImage")));
            this.btnLenovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLenovo.Location = new System.Drawing.Point(12, 185);
            this.btnLenovo.Name = "btnLenovo";
            this.btnLenovo.Size = new System.Drawing.Size(108, 95);
            this.btnLenovo.TabIndex = 0;
            this.btnLenovo.UseVisualStyleBackColor = true;
            this.btnLenovo.Click += new System.EventHandler(this.BtnLenovo_Click);
            // 
            // btnWork
            // 
            this.btnWork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWork.BackgroundImage")));
            this.btnWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWork.Location = new System.Drawing.Point(126, 185);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(108, 95);
            this.btnWork.TabIndex = 0;
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.BtnWork_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(240, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 95);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SelectConnectionstring
            // 
            this.AcceptButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnLenovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectConnectionstring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectConnectionstring";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLenovo;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}