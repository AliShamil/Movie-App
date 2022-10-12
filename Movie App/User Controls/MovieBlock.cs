using Movie_App.Forms;
using Movie_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_App.User_Controls
{
    public partial class MovieBlock : UserControl
    {
        public Movie Movie { get; set; }
        public MovieBlock(Movie movie)
        {
            InitializeComponent();

            Movie = movie;
            moviePoster1.guna2PictureBox1.LoadAsync(movie.Poster);
            lbl_imdb.Text =movie.imdbRating;
            lbl_year.Text = movie.Year;
            lbl_name.Text = movie.Title;
            lbl_genre.Text = movie.Genre;

        }

        private void MovieBlock_Click(object sender, EventArgs e)
        {
            var movieInfo = new MovieInfoForm(Movie);
            movieInfo.Show();
        }

        private void lbl_name_MouseHover(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(212, 329);
            
        }

        private void MovieBlock_MouseLeave(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(202, 299);
            
        }
    }
}
