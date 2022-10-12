namespace Movie_App.Forms
{
    partial class MovieInfoForm
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
            this.moviePoster1 = new Movie_App.User_Controls.MoviePoster();
            this.lbl_IMDB = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_box_office = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_language = new System.Windows.Forms.Label();
            this.lbl_actors = new System.Windows.Forms.Label();
            this.lbl_director = new System.Windows.Forms.Label();
            this.lbl_year_country = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moviePoster1
            // 
            this.moviePoster1.Dock = System.Windows.Forms.DockStyle.Top;
            this.moviePoster1.Location = new System.Drawing.Point(0, 0);
            this.moviePoster1.Name = "moviePoster1";
            this.moviePoster1.Size = new System.Drawing.Size(211, 255);
            this.moviePoster1.TabIndex = 0;
            // 
            // lbl_IMDB
            // 
            this.lbl_IMDB.AutoSize = true;
            this.lbl_IMDB.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_IMDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.lbl_IMDB.Location = new System.Drawing.Point(9, 290);
            this.lbl_IMDB.Name = "lbl_IMDB";
            this.lbl_IMDB.Size = new System.Drawing.Size(71, 21);
            this.lbl_IMDB.TabIndex = 2;
            this.lbl_IMDB.Text = "IMDB: ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(217, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(619, 73);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(88, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 73);
            this.panel2.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl_name.Location = new System.Drawing.Point(153, 8);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(129, 57);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lbl_box_office);
            this.panel3.Controls.Add(this.lbl_type);
            this.panel3.Controls.Add(this.txt_description);
            this.panel3.Controls.Add(this.lbl_description);
            this.panel3.Controls.Add(this.lbl_language);
            this.panel3.Controls.Add(this.lbl_actors);
            this.panel3.Controls.Add(this.lbl_director);
            this.panel3.Controls.Add(this.lbl_year_country);
            this.panel3.Location = new System.Drawing.Point(217, 73);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 363);
            this.panel3.TabIndex = 4;
            // 
            // lbl_box_office
            // 
            this.lbl_box_office.AutoSize = true;
            this.lbl_box_office.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_box_office.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.lbl_box_office.Location = new System.Drawing.Point(9, 186);
            this.lbl_box_office.Name = "lbl_box_office";
            this.lbl_box_office.Size = new System.Drawing.Size(112, 21);
            this.lbl_box_office.TabIndex = 4;
            this.lbl_box_office.Text = "Box Office: ";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.lbl_type.Location = new System.Drawing.Point(6, 54);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(65, 21);
            this.lbl_type.TabIndex = 3;
            this.lbl_type.Text = "Type: ";
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_description.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.txt_description.Location = new System.Drawing.Point(0, 248);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.ReadOnly = true;
            this.txt_description.Size = new System.Drawing.Size(634, 126);
            this.txt_description.TabIndex = 2;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.lbl_description.Location = new System.Drawing.Point(6, 227);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(119, 21);
            this.lbl_description.TabIndex = 1;
            this.lbl_description.Text = "Description: ";
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_language.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.lbl_language.Location = new System.Drawing.Point(9, 153);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(102, 21);
            this.lbl_language.TabIndex = 1;
            this.lbl_language.Text = "Language: ";
            // 
            // lbl_actors
            // 
            this.lbl_actors.AutoSize = true;
            this.lbl_actors.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_actors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.lbl_actors.Location = new System.Drawing.Point(9, 120);
            this.lbl_actors.Name = "lbl_actors";
            this.lbl_actors.Size = new System.Drawing.Size(80, 21);
            this.lbl_actors.TabIndex = 1;
            this.lbl_actors.Text = "Actors: ";
            // 
            // lbl_director
            // 
            this.lbl_director.AutoSize = true;
            this.lbl_director.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_director.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.lbl_director.Location = new System.Drawing.Point(9, 87);
            this.lbl_director.Name = "lbl_director";
            this.lbl_director.Size = new System.Drawing.Size(94, 21);
            this.lbl_director.TabIndex = 1;
            this.lbl_director.Text = "Director: ";
            // 
            // lbl_year_country
            // 
            this.lbl_year_country.AutoSize = true;
            this.lbl_year_country.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_year_country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.lbl_year_country.Location = new System.Drawing.Point(200, 28);
            this.lbl_year_country.Name = "lbl_year_country";
            this.lbl_year_country.Size = new System.Drawing.Size(205, 21);
            this.lbl_year_country.TabIndex = 0;
            this.lbl_year_country.Text = "year - country - genre\r\n";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 436);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.lbl_IMDB);
            this.panel1.Controls.Add(this.moviePoster1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 430);
            this.panel1.TabIndex = 0;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(16)))));
            this.lbl_time.Location = new System.Drawing.Point(9, 333);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(66, 21);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "Time: ";
            // 
            // MovieInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(836, 436);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MovieInfoForm";
            this.Text = "MovieInfoForm";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private User_Controls.MoviePoster moviePoster1;
        private Label lbl_IMDB;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel2;
        private Label lbl_name;
        private Panel panel3;
        private TextBox txt_description;
        private Label lbl_description;
        private Label lbl_language;
        private Label lbl_actors;
        private Label lbl_director;
        private Label lbl_year_country;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lbl_time;
        private Label lbl_type;
        private Label lbl_box_office;
    }
}