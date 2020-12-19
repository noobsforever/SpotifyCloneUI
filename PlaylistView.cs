using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyCloneUI
{
    public partial class PlaylistView : Form
    {
        public PlaylistView()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void songItem1_Load(object sender, EventArgs e)
        {

        }
    }
}
