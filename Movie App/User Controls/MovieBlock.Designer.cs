namespace Movie_App.User_Controls
{
    partial class MovieBlock
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
            this.components = new System.ComponentModel.Container();
            this.lbl_imdb = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.moviePoster1 = new Movie_App.User_Controls.MoviePoster();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_year = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_imdb
            // 
            this.lbl_imdb.AutoSize = true;
            this.lbl_imdb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.lbl_imdb.Location = new System.Drawing.Point(163, 0);
            this.lbl_imdb.Name = "lbl_imdb";
            this.lbl_imdb.Size = new System.Drawing.Size(36, 15);
            this.lbl_imdb.TabIndex = 1;
            this.lbl_imdb.Text = "IMDB";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.moviePoster1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 299);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // moviePoster1
            // 
            this.moviePoster1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviePoster1.Location = new System.Drawing.Point(3, 17);
            this.moviePoster1.Name = "moviePoster1";
            this.moviePoster1.Size = new System.Drawing.Size(196, 220);
            this.moviePoster1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_year);
            this.panel1.Controls.Add(this.lbl_imdb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 14);
            this.panel1.TabIndex = 1;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.lbl_year.Location = new System.Drawing.Point(3, 0);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(29, 15);
            this.lbl_year.TabIndex = 2;
            this.lbl_year.Text = "Year";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Location = new System.Drawing.Point(0, 240);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 32);
            this.panel2.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.Color.Snow;
            this.lbl_name.Location = new System.Drawing.Point(3, 5);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(54, 22);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name";
            this.lbl_name.Click += new System.EventHandler(this.MovieBlock_Click);
            this.lbl_name.MouseLeave += new System.EventHandler(this.MovieBlock_MouseLeave);
            this.lbl_name.MouseHover += new System.EventHandler(this.lbl_name_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_genre);
            this.panel3.Location = new System.Drawing.Point(0, 272);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 26);
            this.panel3.TabIndex = 3;
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.lbl_genre.Location = new System.Drawing.Point(3, 6);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(38, 15);
            this.lbl_genre.TabIndex = 4;
            this.lbl_genre.Text = "Genre";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.lbl_year;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.lbl_imdb;
            // 
            // MovieBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MovieBlock";
            this.Size = new System.Drawing.Size(202, 299);
            this.Click += new System.EventHandler(this.MovieBlock_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_imdb;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lbl_year;
        private Panel panel2;
        private Label lbl_name;
        private Panel panel3;
        private Label lbl_genre;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public MoviePoster moviePoster1;
    }
}
