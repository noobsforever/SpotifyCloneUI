﻿using System;
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
    public partial class Registration : Form
    {
        public static IMongoClient client { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string MongoConnection = "mongodb+srv://sunderali416:sunderali416@clustersocialmediaproject-z6nzz.mongodb.net/test?retryWrites=true&w=majority";
        public static string MongoDatabase = "SpotifyClone";
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);
            }
            catch (Exception)
            {
                MessageBox.Show("Connectivity Error..Please Check Your Internet Connection..");
                throw;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var dobtext = dobText.Value.ToString();
            
            var collection = database.GetCollection<BsonDocument>("users");
            var user = new BsonDocument
            {
                {"name",nameText.Text },
                {"email",emailText.Text },
                {"username",usernameText.Text },
                {"password",passwordText.Text },
                {"dob", dobtext},
            };
            collection.InsertOne(user);
            MessageBox.Show("Successful");


            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.And(builder.Eq("email", emailText.Text), builder.Eq("password", passwordText.Text));
            var result = collection.Find(filter).ToList();
            string userId;

            var user1 = result[0];
            userId = user1[0].ToString();



            var collection2 = database.GetCollection<BsonDocument>("playlist");

            var playlist1 = new BsonDocument
            {
                { "user_id",userId },
                {"name","Recently Played" }
            };

            collection2.InsertOne(playlist1);
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}