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
    public partial class PlaylistView : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "SpotifyClone";
        private string playlist_id;
        private string playlist_name;
        
        public PlaylistView(string p_id, string p_name)
        {
            playlist_name = p_name;

            playlist_id = p_id;
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

        private void PlaylistView_Load(object sender, EventArgs e)
        {
            bool UserOwned = true;
            
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

            nameLabel.Text = playlist_name;
            
            var i = 0;
            var collection = database.GetCollection<BsonDocument>("playlist_item");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("playlist_id", playlist_id);
            var result = collection.Find(filter).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();

            var collection5 = database.GetCollection<BsonDocument>("playlist");
            var builder5 = Builders<BsonDocument>.Filter;
            var filter5 = builder5.Eq("_id", ObjectId.Parse(playlist_id));
            var result5 = collection5.Find(filter5).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();
            if (result5[0][1].ToString() == UserData.id)
            {
                publicButton.Visible = true;
                deleteButton.Visible = true;
                UserOwned = true;
            }
            else
            {
                publicButton.Visible = false;
                deleteButton.Visible = false;
                UserOwned = false;
            }
            if (playlist_name == "Liked" || playlist_name == "Recently Played")
            {
                deleteButton.Visible = false;
                publicButton.Visible = false;
            }

            var collection4 = database.GetCollection<BsonDocument>("public_playlist");
            var builder4 = Builders<BsonDocument>.Filter;
            var filter4 = builder4.Eq("playlist_id", playlist_id);
            var result4 = collection4.Find(filter4).ToList();
            if (result4.Count > 0)
            {
                publicButton.Text = "Make Private";
            }
            else
            {
                publicButton.Text = "Make Public";
            }


            var collection2 = database.GetCollection<BsonDocument>("playlist");
            var builder2 = Builders<BsonDocument>.Filter;
            var filter2 = builder2.Eq("user_id", UserData.id);
            var result2 = collection2.Find(filter2).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();

            var collection3 = database.GetCollection<BsonDocument>("playlist_item");
            var builder3 = Builders<BsonDocument>.Filter;

            bool alreadyInPlaylist = false;
            SongItem[] songitems = new SongItem[result.Count];
            foreach (var song in result)
            {
                songitems[i] = new SongItem();
                songitems[i].Song_Name = song[2].ToString();
                songitems[i].Playlist_Id = song[1].ToString();
                songitems[i].Singer_Name = song[3].ToString();
                songitems[i].Song_Link = song[4].ToString();
                songitems[i].Item_Id = song[0].ToString();
                if (!UserOwned)
                {
                    songitems[i].HideRemove();
                }
                foreach (var playlist in result2)
                {
                    var filter3 = builder3.Eq("playlist_id", playlist[0].ToString());
                    var result3 = collection3.Find(filter3).ToList();
                    alreadyInPlaylist = false;
                    foreach (var songResult in result3)
                    {
                        if (songResult[2].ToString() == song[2].ToString())
                        {
                            alreadyInPlaylist = true;
                        }
                    }
                    if (!alreadyInPlaylist && playlist[2].ToString()!="Recently Played")
                    {
                        songitems[i].addPlaylistCombo(playlist[2].ToString());
                    }



                }
                songsPanel.Controls.Add(songitems[i]);
                i++;
            }
            if (i == 0)
            {
                emptyLabel.Visible = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<BsonDocument>("playlist_item");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("playlist_id", playlist_id);
            var result = collection.Find(filter).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();
            var i = 0;
            foreach(var res in result)
            {
                collection.DeleteOne(res);
                i++;
            }

            var collection2 = database.GetCollection<BsonDocument>("playlist");
            var builder2 = Builders<BsonDocument>.Filter;
            var filter2 = builder2.Eq("_id", ObjectId.Parse(playlist_id));
            var result2 = collection2.Find(filter2).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();

            foreach(var res in result2)
            {
                collection2.DeleteOne(res);
            }

            this.Hide();
            Dashboard home = new Dashboard();
            home.ShowDialog();

        }

        private void publicButton_Click(object sender, EventArgs e)
        {
            if(publicButton.Text=="Make Private")
            {
                var collection4 = database.GetCollection<BsonDocument>("public_playlist");
                var builder4 = Builders<BsonDocument>.Filter;
                var filter4 = builder4.Eq("playlist_id", playlist_id);
                var result4 = collection4.Find(filter4).ToList();
                foreach(var res in result4)
                {
                    collection4.DeleteOne(res);
                }
                this.Hide();
                PlaylistView newview = new PlaylistView(playlist_id,playlist_name);
                newview.Show();
            }
            else
            {

               
                var collection = database.GetCollection<BsonDocument>("public_playlist");
                var publicPl = new BsonDocument
                {
                    {"playlist_id",playlist_id },
                    {"username", UserData.username },
                    { "playlist_name",playlist_name },

                };
                collection.InsertOne(publicPl);
                this.Hide();
                PlaylistView newview = new PlaylistView(playlist_id, playlist_name);
                newview.Show();
            }
        }
    }
}
