using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movies
{
    public partial class frm_movies : Form
    {
        public frm_movies()
        {
            InitializeComponent();

            foreach (var item in Movies.getMovies())
            {
                usr_movie movie = new usr_movie();
                movie.lbl_date.Text = item.tarih;
                movie.pcr_picture.ImageLocation = item.resim;
                movie.pcr_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                movie.lbl_name.Text = item.adi;
                movie.MovieInfo = item.detay;
                flp_movies.Controls.Add(movie);
            }
        }
    }
}
