using Movie_App.Models;
using Movie_App.User_Controls;
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


        private async void button_search_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string search = $"{_url}&s={textBox1.Text}";


            using HttpClient client = new();
            string jsonStr = await client.GetStringAsync(search);

            var moviecollection = JsonSerializer.Deserialize<MovieCollection>(jsonStr);
            if (moviecollection.Search is not null)
            {

                foreach (var item in moviecollection?.Search)
                {
                    search =  $"{_url}&t={item.Title}";
                    using HttpClient client2 = new();
                    string jsonStrM = await client.GetStringAsync(search);

                    var movie = JsonSerializer.Deserialize<Movie>(jsonStrM);
                    MovieBlock movieBlock = new(movie);
                    movieBlock.Margin = new Padding(15);
                    flowLayoutPanel1.Controls.Add(movieBlock);
                }
            }
            else
            {
                try
                {
                    search =  $"{_url}&t={textBox1.Text}";
                    using HttpClient client2 = new();
                    string jsonStrM = await client.GetStringAsync(search);

                    var movie = JsonSerializer.Deserialize<Movie>(jsonStrM);
                    MovieBlock movieBlock = new(movie);
                    movieBlock.Margin = new Padding(15);
                    flowLayoutPanel1.Controls.Add(movieBlock);

                }
                catch (Exception)
                {

                    MessageBox.Show("Movie not found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_search_Click(sender, e);
        }
    }
}
