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
    public partial class Login : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "SpotifyClone";
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<BsonDocument>("users");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.And(builder.Eq("email", emailText.Text), builder.Eq("password", passwordText.Text));
            var result = collection.Find(filter).ToList();
            if (result.Count > 0)
            {
                var user1 = result[0];
                UserData.name = user1[1].ToString();
                UserData.email = user1[2].ToString();
                UserData.id = user1[0].ToString();
                UserData.password = user1[4].ToString();
                UserData.username = user1[3].ToString();

                var collection2 = database.GetCollection<BsonDocument>("playlist");
                var builder2 = Builders<BsonDocument>.Filter;
                var filter2 = builder.Eq("user_id", UserData.id);
                var result2 = collection2.Find(filter2).ToList();

                foreach(var playL in result2)
                {
                    if(playL[2].ToString()=="Recently Played")
                    {
                        UserData.recentId = playL[0].ToString();
                    }
                }

                var collection3 = database.GetCollection<BsonDocument>("playlist_item");
                var builder3 = Builders<BsonDocument>.Filter;
                var filter3 = builder3.Eq("playlist_id", UserData.recentId);
                var result3 = collection3.Find(filter3).ToList();

                foreach(var res in result3)
                {
                    QueueStatic.recents.Enqueue(res[4].ToString());
                }

                this.Hide();
                Dashboard home = new Dashboard();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Email And Password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
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
        }
    }
}
