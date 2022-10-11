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
    public partial class MoviePoster : UserControl
    {
        public MoviePoster()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(200, 255);
        }

        private void guna2PictureBox1_MouseHover(object sender, EventArgs e)
        {
            Size=new System.Drawing.Size(210, 285);
        }
    }
}
