namespace movies
{
    partial class frm_movies
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
            this.flp_movies = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_movies
            // 
            this.flp_movies.AutoScroll = true;
            this.flp_movies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_movies.Location = new System.Drawing.Point(0, 0);
            this.flp_movies.Name = "flp_movies";
            this.flp_movies.Padding = new System.Windows.Forms.Padding(5);
            this.flp_movies.Size = new System.Drawing.Size(746, 495);
            this.flp_movies.TabIndex = 0;
            // 
            // frm_movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 495);
            this.Controls.Add(this.flp_movies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_movies";
            this.Text = "Vizyondaki Filmler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_movies;
    }
}

