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
    public partial class SearchForm : Form
    {

        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "SpotifyClone";
        public SearchForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            songsPanel.Controls.Clear();
            string searchQuery;
            string nameResult;
            string singerResult;


            if (searchText.Text != "")
            {
                var collection = database.GetCollection<BsonDocument>("songs");
                var builder = Builders<BsonDocument>.Filter.Empty;
                var result = collection.Find(builder).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();



                var collection2 = database.GetCollection<BsonDocument>("playlist");
                var builder2 = Builders<BsonDocument>.Filter;
                var filter2 = builder2.Eq("user_id", UserData.id);
                var result2 = collection2.Find(filter2).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();

                var collection3 = database.GetCollection<BsonDocument>("playlist_item");
                var builder3 = Builders<BsonDocument>.Filter;
                bool alreadyInPlaylist = false;

                var i = 0;
                SongItem[] songs = new SongItem[result.Count];

                foreach (var song in result)
                {
                    searchQuery = searchText.Text;
                    nameResult = song[1].ToString();
                    singerResult = song[3].ToString();
                    searchQuery = searchQuery.ToLower();
                    nameResult = nameResult.ToLower();
                    singerResult = singerResult.ToLower();
                    if (nameResult.Contains(searchQuery) || singerResult.Contains(searchQuery))
                    {
                        songs[i] = new SongItem();
                        songs[i].Song_Name = song[1].ToString();
                        songs[i].Playlist_Id = "";
                        songs[i].Singer_Name = song[3].ToString();
                        songs[i].Song_Link = song[2].ToString();
                        songs[i].Item_Id = song[0].ToString();
                        songs[i].addButtonName = "Add To A Playlist";
                        foreach (var playlist in result2)
                        {


                            var filter3 = builder3.Eq("playlist_id", playlist[0].ToString());
                            var result3 = collection3.Find(filter3).ToList();
                            alreadyInPlaylist = false;
                            foreach (var songResult in result3)
                            {
                                if (songResult[2].ToString() == song[1].ToString())
                                {
                                    alreadyInPlaylist = true;
                                }
                            }
                            if (!alreadyInPlaylist && playlist[2].ToString()!="Recently Played")
                            {
                                songs[i].addPlaylistCombo(playlist[2].ToString());
                            }


                        }
                        songs[i].HideRemove();
                        songsPanel.Controls.Add(songs[i]);
                        i++;
                    }
                }
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
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
        }
    }
}
