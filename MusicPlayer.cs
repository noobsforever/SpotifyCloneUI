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
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
namespace SpotifyCloneUI
{
    public partial class MusicPlayer : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "SpotifyClone";


        private WaveOutEvent outputDevice;
        private MediaFoundationReader audioFile;

        DoublyLinked songs_list = new DoublyLinked();
        Node current = new Node();
        

        string playlist_id;
        string song_link;
        public string playlist_name;
        public string song_name;
        public string singer_name;
        public MusicPlayer(string p_id, string s_link)
        {
            playlist_id = p_id;
            song_link = s_link;
            InitializeComponent();
            current.data = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
            if (playlist_id == "")
            {
                this.Hide();
                SearchForm searchform = new SearchForm();
                searchform.ShowDialog();
            }
            else
            {
                this.Hide();
                PlaylistView newView = new PlaylistView(playlist_id, playlist_name);
                newView.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            volumeSlider1.Value = 100;
            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);
            }
            catch (Exception)
            {
                MessageBox.Show("Connectivity Error...Please Check Your Internet...");
                throw;
            }
            if (playlist_id != "")
            {



                var collection = database.GetCollection<BsonDocument>("playlist_item");
                var builder = Builders<BsonDocument>.Filter;
                var filter = builder.Eq("playlist_id", playlist_id);
                var result = collection.Find(filter).ToList();
                var i = 0;
                if (result.Count > 0)
                {
                    foreach (var song in result)
                    {
                        if (i == 0)
                        {
                            songs_list.insertEnd(song[4].ToString());
                        }
                        else
                        {
                            songs_list.insertBegin(song[4].ToString());
                        }
                        
                        i++;
                    }
                }


                current = songs_list.start;
                while (true)
                {
                    if (current.data == song_link)
                    {
                        break;
                    }
                    current = current.next;
                }

                var collection2 = database.GetCollection<BsonDocument>("playlist");
                var builder2 = Builders<BsonDocument>.Filter;
                var filter2 = builder2.Eq("_id", ObjectId.Parse(playlist_id));
                var result2 = collection2.Find(filter2).ToList();
                playlist_name = result2[0][2].ToString();
                playlistnameLabel.Text = playlist_name;


                var collection3 = database.GetCollection<BsonDocument>("songs");
                var builder3 = Builders<BsonDocument>.Filter;
                var filter3 = builder3.Eq("link", current.data);
                var result3 = collection3.Find(filter3).ToList();

                song_name = result3[0][1].ToString();
                singer_name = result3[0][3].ToString();
                nameLabel.Text = song_name;
                singerLabel.Text = singer_name;

                outputDevice = new WaveOutEvent();
                audioFile = new MediaFoundationReader(song_link);
                outputDevice.Init(audioFile);
                outputDevice.Volume = volumeSlider1.Value / 100f; ;
                outputDevice.Play();

            }

            else
            {
                nextButton.Visible = false;
                previousButton.Visible = false;
                playlistnameLabel.Visible = false;

                var collection3 = database.GetCollection<BsonDocument>("songs");
                var builder3 = Builders<BsonDocument>.Filter;
                var filter3 = builder3.Eq("link", song_link);
                var result3 = collection3.Find(filter3).ToList();

                song_name = result3[0][1].ToString();
                singer_name = result3[0][3].ToString();
                nameLabel.Text = song_name;
                singerLabel.Text = singer_name;

                outputDevice = new WaveOutEvent();
                audioFile = new MediaFoundationReader(song_link);
                outputDevice.Init(audioFile);
                outputDevice.Volume = volumeSlider1.Value / 100f; ;
                outputDevice.Play();


            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                audioFile = new MediaFoundationReader(song_link);
                outputDevice.Init(audioFile);
            }
            outputDevice.Volume = volumeSlider1.Value / 100f; ;
            outputDevice.Play();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;

            current = current.next;
            song_link = current.data;
            var collection3 = database.GetCollection<BsonDocument>("songs");
            var builder3 = Builders<BsonDocument>.Filter;
            var filter3 = builder3.Eq("link", current.data);
            var result3 = collection3.Find(filter3).ToList();

            song_name = result3[0][1].ToString();
            singer_name = result3[0][3].ToString();
            nameLabel.Text = song_name;
            singerLabel.Text = singer_name;

            outputDevice = new WaveOutEvent();
            audioFile = new MediaFoundationReader(song_link);
            outputDevice.Init(audioFile);
            outputDevice.Volume = volumeSlider1.Value / 100f ;
            outputDevice.Play();
        }

        private void volumeSlider1_Scroll(object sender, ScrollEventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Volume = volumeSlider1.Value / 100f;
            }
            
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;

            current = current.prev;
            song_link = current.data;
            var collection3 = database.GetCollection<BsonDocument>("songs");
            var builder3 = Builders<BsonDocument>.Filter;
            var filter3 = builder3.Eq("link", current.data);
            var result3 = collection3.Find(filter3).ToList();

            song_name = result3[0][1].ToString();
            singer_name = result3[0][3].ToString();
            nameLabel.Text = song_name;
            singerLabel.Text = singer_name;

            outputDevice = new WaveOutEvent();
            audioFile = new MediaFoundationReader(song_link);
            outputDevice.Init(audioFile);
            outputDevice.Volume = volumeSlider1.Value / 100f;
            outputDevice.Play();
        }
        
    }
}
