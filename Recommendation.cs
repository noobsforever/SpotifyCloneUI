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
    public partial class Recommendation : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "SpotifyClone";
        public static string playlistId;
        public Recommendation(string p_id)
        {
            playlistId = p_id;
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard home = new Dashboard();
            home.ShowDialog();
        }

        private void Recommendation_Load(object sender, EventArgs e)
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
            var collection = database.GetCollection<BsonDocument>("playlist_item");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("playlist_id", playlistId);
            var result = collection.Find(filter).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();
            var collection2 = database.GetCollection<BsonDocument>("genres");
            var builder2 = Builders<BsonDocument>.Filter;
            var collection3 = database.GetCollection<BsonDocument>("songs");
            var builder3 = Builders<BsonDocument>.Filter;


            foreach (var song in result)
            {
               
                var filter2 = builder2.Eq("song_name", song[2].ToString());
                var result2 = collection2.Find(filter2).ToList();
                string genre = result2[0][3].ToString();       //getting genre of song in recently played list

                var filter3 = builder.Eq("genre", genre);
                var result3 = collection2.Find(filter3).ToList();

                var start = 0;
                var end = result3.Count() - 1;
                Random rnd = new Random();
                int index = rnd.Next(start, end);
                var songItem = result3[index];
                var filter4 = builder3.Eq("_id", ObjectId.Parse(songItem[1].ToString()));
                var result4 = collection3.Find(filter4).ToList();  //the song item
                var songI = new SongItem();
               
                songI.Song_Name = result4[0][1].ToString();
                songI.Playlist_Id = "";
                songI.Singer_Name = result4[0][3].ToString();
                songI.Song_Link = result4[0][2].ToString();
                songI.Item_Id = result4[0][0].ToString();
                songI.addButtonName = "Add To A Playlist";








                songI.HideCombo();
                songI.HideRemove();
                songsPanel.Controls.Add(songI);
                i++;
            }


        }
    }
}
