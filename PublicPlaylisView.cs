using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
namespace SpotifyCloneUI
{
    public partial class PublicPlaylisView : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "SpotifyClone";
        public PublicPlaylisView()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard home = new Dashboard();
            home.ShowDialog();
        }

        private void PublicPlaylisView_Load(object sender, EventArgs e)
        {
            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                throw;
            }
            var i = 0;
            var collection = database.GetCollection<BsonDocument>("public_playlist");
            var builder = Builders<BsonDocument>.Filter.Empty;
            var result = collection.Find(builder).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();
            if (result.Count > 0)
            {
                emptyLabel.Visible = false;
                PlaylistEntry[] playlists = new PlaylistEntry[result.Count];
                foreach (var playlist in result)
                {
                    if (playlist[2].ToString() != "Recently Played")
                    {
                        playlists[i] = new PlaylistEntry();
                        playlists[i].Playlist_Name = playlist[3].ToString();
                        playlists[i].Playlist_Id = playlist[1].ToString();
                        playlists[i].MakeVisible(playlist[2].ToString());
                        playlists[i].Margin = new Padding(0, 0, 0, 0);
                        songsPanel.Controls.Add(playlists[i]);
                        i++;
                    }

                }
            }
            else
            {
                emptyLabel.Visible = true;
            }
        }
    }
}
