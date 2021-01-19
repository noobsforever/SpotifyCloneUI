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
using System.Threading;
using System.Net;
using System.Drawing.Imaging;
using System.IO;
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

        private WaveOutEvent outputDeviceNext;
        private MediaFoundationReader audioFileNext;

        private WaveOutEvent outputDevicePrev;
        private MediaFoundationReader audioFilePrev;

        DoublyLinked songs_list = new DoublyLinked();
        Node current = new Node();
        

        string playlist_id;
        string song_link;
        public string playlist_name;
        public string song_name;
        public string singer_name;
        public string image_link;
        public string imageLocNext;
        public string imageLocPrev;
        string song_link_next;
        public string playlist_name_next;
        public string song_name_next;
        public string singer_name_next;
        public string image_link_next;

        string song_link_prev;
        public string playlist_prev;
        public string song_name_prev;
        public string singer_name_prev;
        public string image_link_prev;
        Thread thread1;
        Thread thread2;
        public int uid = 0;
        public string currentDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        public MusicPlayer(string p_id, string s_link)
        {
            playlist_id = p_id;
            song_link = s_link;
            InitializeComponent();
            current.data = "";
            thread1 = new Thread(loadNext);
            thread2 = new Thread(loadPrevious);
           
            if (Directory.Exists(currentDirectory + "\\images"))
               {
                 DeleteDirectory(currentDirectory + "\\images");
               }
                
            
            Directory.CreateDirectory(currentDirectory + "\\images");
            currentDirectory += "\\images";
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
                addToRecents(song_link, song_name, singer_name);
                image_link = result3[0][4].ToString();   
                song_picture.Load(image_link);
                outputDevice = new WaveOutEvent();
                audioFile = new MediaFoundationReader(song_link);
                outputDevice.Init(audioFile);
                outputDevice.Volume = volumeSlider1.Value / 100f; ;
                outputDevice.Play();
                thread1.Start();
                thread2.Start();
                
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
                image_link = result3[0][4].ToString();
                song_picture.Load(image_link);
                addToRecents(song_link, song_name, singer_name);
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
            
            if (outputDevice != null)
            {
                outputDevice?.Stop();
                outputDevice.Dispose();
                outputDevice = null;
                audioFile.Dispose();
                audioFile = null;
            }
            
        }

        private void loadNext()
        {
            
            int tempId=uid+1;
            uid++;
            Node tempCurrent = new Node();
            tempCurrent = current.next;
            song_link_next = tempCurrent.data;
            var collection3 = database.GetCollection<BsonDocument>("songs");
            var builder3 = Builders<BsonDocument>.Filter;
            var filter3 = builder3.Eq("link", tempCurrent.data);
            var result3 = collection3.Find(filter3).ToList();

            song_name_next = result3[0][1].ToString();
            singer_name_next = result3[0][3].ToString();
            image_link_next = result3[0][4].ToString();

            WebClient client = new WebClient();
            Stream stream = client.OpenRead(image_link_next);
            Bitmap bitmap; 
            bitmap = new Bitmap(stream);
            string loc = currentDirectory + "\\image"+tempId.ToString()+".jpeg";
            if (bitmap != null)
            {
                bitmap.Save(loc,ImageFormat.Jpeg);
            }

            image_link_next = loc;

            stream.Flush();
            stream.Close();
            client.Dispose();

            outputDeviceNext = new WaveOutEvent();
            audioFileNext = new MediaFoundationReader(song_link_next);
            outputDeviceNext.Init(audioFileNext);
            outputDeviceNext.Volume = volumeSlider1.Value / 100f;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
           
            if (outputDevice != null)
            {
                outputDevice?.Stop();
                outputDevice.Dispose();
                outputDevice = null;
                audioFile.Dispose();
                audioFile = null;
            }

            current = current.next;
            outputDevice = outputDeviceNext;
            audioFile = audioFileNext;

            song_link = song_link_next;
            song_name = song_name_next;
            singer_name = singer_name_next;
            image_link = image_link_next;

            nameLabel.Text =song_name;
            singerLabel.Text = singer_name;
            song_picture.Load(image_link);
            addToRecents(song_link, song_name, singer_name);
            
            outputDevice.Play();
            
            thread1 = new Thread(loadNext);
            thread2 = new Thread(loadPrevious);
            thread1.Start();
            thread2.Start();
            

        }

        private void volumeSlider1_Scroll(object sender, ScrollEventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Volume = volumeSlider1.Value / 100f;
            }
            
        }


        private void loadPrevious()
        {
            int tempId = uid + 1;
            uid++;
            Node tempCurrent = new Node();
            tempCurrent = current.prev;
            song_link_prev = tempCurrent.data;
            var collection3 = database.GetCollection<BsonDocument>("songs");
            var builder3 = Builders<BsonDocument>.Filter;
            var filter3 = builder3.Eq("link", tempCurrent.data);
            var result3 = collection3.Find(filter3).ToList();

            song_name_prev = result3[0][1].ToString();
            singer_name_prev = result3[0][3].ToString();
            image_link_prev = result3[0][4].ToString();


            WebClient client = new WebClient();
            Stream stream = client.OpenRead(image_link_prev);
            Bitmap bitmap;
            bitmap = new Bitmap(stream);
            string loc = currentDirectory + "\\image" + tempId.ToString() + ".jpeg";
            if (bitmap != null)
            {
                bitmap.Save(loc, ImageFormat.Jpeg);
            }

            image_link_prev = loc;


            stream.Flush();
            stream.Close();
            client.Dispose();

            outputDevicePrev = new WaveOutEvent();
            audioFilePrev = new MediaFoundationReader(song_link_prev);
            outputDevicePrev.Init(audioFilePrev);
            outputDevicePrev.Volume = volumeSlider1.Value / 100f;
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice?.Stop();
                outputDevice.Dispose();
                outputDevice = null;
                audioFile.Dispose();
                audioFile = null;
            }
            current = current.prev;
            outputDevice = outputDevicePrev;
            audioFile = audioFilePrev;

            song_link = song_link_prev;
            song_name = song_name_prev;
            singer_name = singer_name_prev;
            image_link = image_link_prev;

            nameLabel.Text = song_name;
            singerLabel.Text = singer_name;
            song_picture.Load(image_link);
            addToRecents(song_link, song_name, singer_name);

            outputDevice.Play();
           
            thread1 = new Thread(loadNext);
            thread2 = new Thread(loadPrevious);
            thread1.Start();
            thread2.Start();
        }

        private void addToRecents(string s_link, string s_name,string singer_n)
        {
            if (QueueStatic.recents.Contains(s_link))
            {

            }
            else
            {
                string song_l;
                if (QueueStatic.recents.Count == 10)
                {
                    song_l = QueueStatic.recents.Peek();
                    var collection = database.GetCollection<BsonDocument>("playlist_item");
                    var builder = Builders<BsonDocument>.Filter;
                    var filter = builder.And(builder.Eq("playlist_id", UserData.recentId), builder.Eq("link", song_l));
                    var result = collection.FindOneAndDelete(filter);
                    QueueStatic.recents.Dequeue();
                    QueueStatic.recents.Enqueue(s_link);

                    var song1 = new BsonDocument
                 {
                    { "playlist_id", UserData.recentId },
                    { "name",s_name },
                    { "singer",singer_n},
                    { "link",s_link }
                };
                    collection.InsertOne(song1);

                }
                else
                {
                    var collection = database.GetCollection<BsonDocument>("playlist_item");
                    QueueStatic.recents.Enqueue(s_link);
                    var song1 = new BsonDocument
                 {
                    { "playlist_id", UserData.recentId },
                    { "name",s_name },
                    { "singer",singer_n},
                    { "link",s_link }
                };
                    collection.InsertOne(song1);
                }
            }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
            this.Dispose();
        }

        private void MusicPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            outputDevice?.Stop();
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
            song_picture.Image = null;
            
            
        }

        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }

        private void playlistnameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
