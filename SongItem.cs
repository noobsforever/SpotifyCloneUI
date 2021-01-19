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
    public partial class SongItem : UserControl
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "SpotifyClone";
        public static string initialText;
        #region properties
        private string song_name;
        private string playlist_id;
        private string singer_name;
        private string song_link;
        private string item_id;
        [Category("Custom Props")]
        public string Song_Name
        {
            get { return song_name; }
            set { song_name = value; nameLabel.Text = value; }
        }
        public string Item_Id
        {
            get { return item_id; }
            set { item_id = value; }
        }

        public string Song_Link
        {
            get { return song_link; }
            set { song_link = value; }
        }



        public string Playlist_Id
        {
            get { return playlist_id; }
            set { playlist_id = value; }
        }
        public string Singer_Name
        {
            get { return singer_name; }
            set { singer_name = value; singerLabel.Text = value; }
        }

        public string addButtonName
        {
            get { return addButton.Text; }
            set { addButton.Text = value; }
        }

        public void HideRemove()
        {
            removeButton.Visible = false;
        }

        public void addPlaylistCombo(string playlist_name)
            
        {
            if (addButton.InvokeRequired)
            {
                addButton.Invoke(new MethodInvoker(delegate { addButton.Items.Add(playlist_name); }));
            }
            ;
        }

        public void HideCombo()
        {
            addButton.Visible = false;
        }


        #endregion
        public SongItem()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<BsonDocument>("playlist_item");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("_id", ObjectId.Parse(item_id));
            var result = collection.DeleteOne(filter);

            var collection2 = database.GetCollection<BsonDocument>("playlist");
            var builder2 = Builders<BsonDocument>.Filter;
            var filter2 = builder2.Eq("_id", ObjectId.Parse(playlist_id));
            var result2 = collection2.Find(filter2).ToList();


            ParentForm.Hide();
            PlaylistView newView = new PlaylistView(playlist_id, result2[0][2].ToString());
            newView.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            MusicPlayer player = new MusicPlayer(Playlist_Id, Song_Link);
            player.Show();
        }

        private void SongItem_Load(object sender, EventArgs e)
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
            initialText = addButton.Text;
        }

        private void addButton_SelectedValueChanged(object sender, EventArgs e)
        {

            var collection = database.GetCollection<BsonDocument>("playlist");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("user_id", UserData.id);
            var result = collection.Find(filter).ToList();

            var collection2 = database.GetCollection<BsonDocument>("playlist_item");

            if (addButton.Text != "Add To A Playlist" && addButton.Text != "Add To Other Playlist")
            {
                foreach (var playList in result)
                {
                    if (playList[2].ToString() == addButton.Text)
                    {
                        var newItem = new BsonDocument
                        {
                            {"playlist_id",playList[0].ToString() },
                            {"name",song_name },
                            {"singer",singer_name },
                            {"link",song_link },
                        };
                        collection2.InsertOne(newItem);
                        MessageBox.Show("Song Added To Playlist " + addButton.Text);
                        ParentForm.Hide();

                        var collection3 = database.GetCollection<BsonDocument>("playlist");
                        var builder3 = Builders<BsonDocument>.Filter;

                        if (initialText == "Add To A Playlist")
                        {
                            SearchForm newForm = new SearchForm();
                            newForm.ShowDialog();
                        }
                        else
                        {

                            var filter3 = builder3.Eq("_id", ObjectId.Parse(playlist_id));
                            var result3 = collection3.Find(filter3).ToList();
                            PlaylistView newView = new PlaylistView(playlist_id, result3[0][2].ToString());
                            newView.ShowDialog();
                        }
                    }
                }
            }
        }









    }

}
