using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            {
                
                var dobtext = dobText.Value.ToString();
                if (nameText.Text == "" || emailText.Text == "" || usernameText.Text == "" || passwordText.Text == "")
                {
                    MessageBox.Show("Please Recheck And Fill All The Fields");
                }
                else
                {
                    if (!Regex.IsMatch(nameText.Text, @"^[a-zA-Z][a-z]*(\s[a-zA-Z][a-z]*)+$"))
                    {
                        MessageBox.Show("Please Re-Enter Your Name Without Any Numbers Or Special Characters");
                    }
                    else
                    {
                        if (!Regex.IsMatch(emailText.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                        {
                            MessageBox.Show("Please Enter A Valid Email Address");
                        }
                        else
                        {
                            if (!Regex.Match(usernameText.Text, @"^[a-zA-Z][\w]*$").Success)
                            {
                                MessageBox.Show("Username Must Start With A Letter And Must Not Contain Any Special Characters");
                            }
                            else
                            {
                                if (passwordText.Text.Length < 8 || passwordText.Text.Length > 15)
                                {
                                    MessageBox.Show("Password Must Contain Between 8 And 15 Characters.");
                                }
                                else
                                {
                                    DateTime bday = DateTime.Parse(dobtext);//pls check what should come here
                                    DateTime today = DateTime.Today;
                                    int age = today.Year - bday.Year;
                                    if (age < 16)
                                    {
                                        MessageBox.Show("You Must Be 16 Years Or Older To Create An Account");
                                    }
                                   


                                    else
                                    {
                                        bool usernameExists = false;
                                        bool emailExists = false;
                                        var collection3 = database.GetCollection<BsonDocument>("users");
                                        var builder3 = Builders<BsonDocument>.Filter;
                                        var filter3 = builder3.Eq("email", emailText.Text);
                                        var result3 = collection3.Find(filter3).ToList();
                                        if (result3.Count() > 0)
                                        {
                                            emailExists = true;
                                        }

                                        var collection4 = database.GetCollection<BsonDocument>("users");
                                        var builder4 = Builders<BsonDocument>.Filter;
                                        var filter4 = builder4.Eq("username", usernameText.Text);
                                        var result4 = collection4.Find(filter4).ToList();

                                        if (result4.Count() > 0)
                                        {
                                            usernameExists = true;
                                        }
                                        if (usernameExists)
                                        {
                                            MessageBox.Show("Username Already Exists...");
                                        }
                                        else if (emailExists)
                                        {
                                            MessageBox.Show("Email Already exists");
                                        }
                                        else
                                        {



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
                            }
                        }
                    }

                }
            }
            }

        private void nameText_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name(Two Word Should Not Include Numbers)\nUsername(No Spaces May Contain Number After Letters)\nPassword(Length Greater Than 8 and Less than 15)\nAge(Should Be Greater Than 15)");
        }
    }
}