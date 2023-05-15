using MongoDB.Driver;
using MongoDB.Bson;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ready_or_not
{
    public class UsersDB
    {
        static string dataBaseName = "UsersBase";
        static string userCollectionName = "Users";
        static MongoClient client;
        static IMongoDatabase database;
        static IMongoCollection<User> userCollection;

        static UsersDB()
        {
            client = new MongoClient();
            database = client.GetDatabase(dataBaseName);
            userCollection = database.GetCollection<User>(userCollectionName);

        }

        public static void AddUserToDataBase(User user)
        {
            userCollection.InsertOne(user);
        }

        public static void ReplaceUser(string login, User user)
        {
            userCollection.ReplaceOne(x => x.Login == login, user);
        }

        public static List<User> FindAllUsers()
        {
            return userCollection.Find(x => true).ToList();
        }

        public static User FindUserByLogin(string login)
        {
            return userCollection.Find(x => x.Login == login).FirstOrDefault();
        }


    }

}
