using Movie_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
//179 127 0
namespace Movie_App.Forms
{
    public partial class MainForm : Form
    {
        const string _apiKey = "5aa4e11a";
        const string _url = $"http://www.omdbapi.com/?apikey={_apiKey}";

        public MainForm()
        {
            InitializeComponent();
        }
        
        private async void button1_Click(object sender, EventArgs e)
        {
            string search = $"{_url}&t={textBox1.Text}";


            using HttpClient client = new();
            string jsonStr = await client.GetStringAsync(search);


            var movie = JsonSerializer.Deserialize<Movie>(jsonStr);
            moviePoster1.guna2PictureBox1.LoadAsync(movie?.Poster);
        }
    }
}
