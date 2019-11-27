namespace movies
{
    partial class usr_movie
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcr_picture = new System.Windows.Forms.PictureBox();
            this.btn_info = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pcr_picture
            // 
            this.pcr_picture.Image = global::movies.Properties.Resources.loading;
            this.pcr_picture.Location = new System.Drawing.Point(0, 0);
            this.pcr_picture.Name = "pcr_picture";
            this.pcr_picture.Size = new System.Drawing.Size(208, 160);
            this.pcr_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcr_picture.TabIndex = 0;
            this.pcr_picture.TabStop = false;
            // 
            // btn_info
            // 
            this.btn_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_info.Location = new System.Drawing.Point(0, 209);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(208, 49);
            this.btn_info.TabIndex = 1;
            this.btn_info.Text = "Film Hakkında";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_movie_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_name.Location = new System.Drawing.Point(0, 160);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(208, 49);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Film Adı";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(8, 8);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(36, 17);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "tarih";
            // 
            // usr_movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.pcr_picture);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "usr_movie";
            this.Size = new System.Drawing.Size(208, 258);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_info;
        public System.Windows.Forms.PictureBox pcr_picture;
        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.Label lbl_date;
    }
}
