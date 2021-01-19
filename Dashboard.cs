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
using System.Net;
using System.Net.Mail;
namespace SpotifyCloneUI
{
    public partial class Dashboard : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "SpotifyClone";
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

        

        private void Dashboard_Load(object sender, EventArgs e)
        {
            usernameDisplay.Text = UserData.username;
            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);
            }
            catch (Exception)
            {
                MessageBox.Show("Connectivity Error, Make Sure You Have Proper Internet Connection..");
                throw;
            }

            var i = 0;
            var collection = database.GetCollection<BsonDocument>("playlist");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("user_id", UserData.id);
            var result = collection.Find(filter).SortBy(bson => bson["_id"]).ThenByDescending(bson => bson["_id"]).ToList();
            PlaylistEntry[] playlists = new PlaylistEntry[result.Count];
            foreach (var playlist in result)
            {
                if(playlist[2].ToString()!="Recently Played")
                {
                    playlists[i] = new PlaylistEntry();
                    playlists[i].Playlist_Name = playlist[2].ToString();
                    playlists[i].Playlist_Id = playlist[0].ToString();
                    playlists[i].Margin = new Padding(0, 0, 0, 0);
                    playlistPanel.Controls.Add(playlists[i]);
                    i++;
                }
                
            }

            if (i == 0)
            {
                emptyLabel.Visible = true;
            }
        }

        private void playlistEntry1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchform = new SearchForm();
            searchform.ShowDialog();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void playlistInput_KeyDown(object sender, KeyEventArgs e)
        {
            bool isSame = false;
            if (e.KeyCode == Keys.Enter)
            {
                if (playlistInput.Text == "")
                {
                    MessageBox.Show("Playlist Name Cannot Be Empty");
                }
                else
                {
                    var collection = database.GetCollection<BsonDocument>("playlist");
                    var builder = Builders<BsonDocument>.Filter;
                    var filter = builder.Eq("user_id", UserData.id);
                    var result = collection.Find(filter).ToList();
                    foreach (var playlist in result)
                    {
                        if (playlist[2].ToString() == playlistInput.Text)
                        {
                            isSame = true;
                        }
                    }

                    if (!isSame)
                    {
                        var collection2 = database.GetCollection<BsonDocument>("playlist");
                        var newItem = new BsonDocument
                    {
                        { "user_id",UserData.id },
                        {"name",playlistInput.Text },
                    };
                        collection2.InsertOne(newItem);
                        this.Hide();
                        Dashboard home = new Dashboard();
                        home.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Playlist with this name already exists..");
                        playlistInput.Text = "";
                    }
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<BsonDocument>("playlist");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.And(builder.Eq("name", "Recently Played"), builder.Eq("user_id", UserData.id));
            var result = collection.Find(filter).ToList();
            var resultPlaylist = result[0];
            this.Hide();
            PlaylistView playlistview = new PlaylistView(resultPlaylist[0].ToString(), "Recently Played");
            playlistview.ShowDialog();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PublicPlaylisView newview = new PublicPlaylisView();
            newview.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<BsonDocument>("playlist");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.And(builder.Eq("name", "Recently Played"), builder.Eq("user_id", UserData.id));
            var result = collection.Find(filter).ToList();
            var resultPlaylist = result[0];                     //recently played songs
            this.Hide();
            Recommendation rec = new Recommendation(resultPlaylist[0].ToString());
            rec.ShowDialog();

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Login login = new Login();
            login.ShowDialog();
            
        }

        private void sendEmail(string text)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("sunderlaghari416@gmail.com");
                message.To.Add(new MailAddress("redtire123@gmail.com"));
                message.Subject = "Recovery Code";
                message.Body = text;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("sunderlaghari416@gmail.com", "");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { MessageBox.Show("Error"); }
        }
    }
}
