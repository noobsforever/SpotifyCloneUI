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
    public partial class PlaylistEntry : UserControl
    {

        #region properties
        private string playlist_name;
        private string playlist_id;

        [Category("Custom Props")]
        public string Playlist_Name
        {
            get { return playlist_name; }
            set { playlist_name = value; playlistButton.Text = value; }
        }

        public string Playlist_Id
        {
            get { return playlist_id; }
            set { playlist_id = value; }
        }

        public void MakeVisible(string username)
        {
            byLabel.Visible = true;
            byNameLabel.Visible = true;
            byNameLabel.Text = username;
        }




        #endregion
        public PlaylistEntry()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ParentForm.Hide();
            PlaylistView view = new PlaylistView(Playlist_Id, playlist_name);
            view.ShowDialog();
        }
    }
}
