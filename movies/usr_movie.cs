using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movies
{
    public partial class usr_movie : UserControl
    {
        public string MovieInfo { get; set; }
        public usr_movie()
        {
            InitializeComponent();
        }

        private void btn_movie_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MovieInfo, "Film Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
