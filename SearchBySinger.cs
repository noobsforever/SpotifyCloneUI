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
    public partial class SearchBySinger : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "SpotifyClone";
        IMongoCollection<BsonDocument> collection;
        FilterDefinition<BsonDocument> builder;
        List<BsonDocument> result;

        HashTableSinger hashTable;

        IMongoCollection<BsonDocument> collection2;
        FilterDefinitionBuilder<BsonDocument> builder2;
        FilterDefinition<BsonDocument> filter2;
        List<BsonDocument> result2;

        IMongoCollection<BsonDocument> collection3;
        FilterDefinitionBuilder<BsonDocument> builder3;
        public SearchBySinger()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard home = new Dashboard();
            home.ShowDialog();
        }

        private void SearchBySinger_Load(object sender, EventArgs e)
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
            collection = database.GetCollection<BsonDocument>("songs");
            builder = Builders<BsonDocument>.Filter.Empty;
            result = collection.Find(builder).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();

            collection2 = database.GetCollection<BsonDocument>("playlist");
            builder2 = Builders<BsonDocument>.Filter;
            filter2 = builder2.Eq("user_id", UserData.id);
            result2 = collection2.Find(filter2).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();
            collection3 = database.GetCollection<BsonDocument>("playlist_item");
            builder3 = Builders<BsonDocument>.Filter;
            hashTable = new HashTableSinger(result.Count());

            foreach(var res in result)
            {
                hashTable.AddSong(res[3].ToString(),res[1].ToString(),res[0].ToString(),res[2].ToString(),res[5].ToString(),res[4].ToString());
            }
        }//func end

        

        private void searchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && searchText.Text != "")
            {
                songsPanel.Controls.Clear();
                


                if (searchText.Text != "")
                {



                    if (hashTable.getIndex(searchText.Text) == -1)
                    {
                        MessageBox.Show("No Songs With That Name Found");
                    }
                    else
                    {
                        int index = hashTable.getIndex(searchText.Text);


                        SongItem songs = new SongItem();
                        songs.Song_Name = hashTable.songName[index];
                        songs.Playlist_Id = "";
                        songs.Singer_Name = hashTable.singerName[index];
                        songs.Song_Link = hashTable.songLink[index];
                        songs.Item_Id = hashTable.id[index];
                        songs.addButtonName = "Add To A Playlist";

                        bool alreadyInPlaylist = false;
                        foreach (var playlist in result2)
                        {




                            var filter3 = builder3.Eq("playlist_id", playlist[0].ToString());
                            var result3 = collection3.Find(filter3).ToList();
                            alreadyInPlaylist = false;
                            foreach (var songResult in result3)
                            {
                                if (songResult[2].ToString() == hashTable.songName[index])
                                {
                                    alreadyInPlaylist = true;
                                }
                            }
                            if (!alreadyInPlaylist && playlist[2].ToString() != "Recently Played")
                            {
                                songs.addPlaylistCombo(playlist[2].ToString());
                            }

                            songs.HideRemove();
                            songsPanel.Controls.Add(songs);


                        }
                    }
                }

            }//if end
        }
    }
}
