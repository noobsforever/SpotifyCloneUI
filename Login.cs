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
