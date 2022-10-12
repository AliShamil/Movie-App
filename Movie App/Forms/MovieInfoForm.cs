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

namespace Movie_App.Forms
{
    public partial class MovieInfoForm : Form
    {
        public MovieInfoForm(Movie movie)
        {
            InitializeComponent();

            moviePoster1.guna2PictureBox1.LoadAsync(movie.Poster);
            lbl_name.Text = movie.Title;
            lbl_year_country.Text = $@"{movie.Year} - {movie.Country} - {movie.Genre}";
            lbl_time.Text += movie.Runtime;
            lbl_type.Text += movie.Type;
            lbl_box_office.Text += movie.BoxOffice;
            lbl_director.Text += movie.Director;
            lbl_actors.Text+=movie.Actors;
            lbl_language.Text+=movie.Language;
            txt_description.Text = movie.Plot;
            lbl_IMDB.Text+=movie.imdbRating;
        }
    }
}
