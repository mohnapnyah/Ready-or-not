using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ready_or_not
{
    public class ChallengeDB
    {
        static string dataBaseName = "ChallengeBase";
        static string ChallengeCollectionName = "Challenges";
        static MongoClient client;
        static IMongoDatabase database;
        static IMongoCollection<Challenge> ChallengeCollection;

        static ChallengeDB ()
        {
            client = new MongoClient();
            database = client.GetDatabase(dataBaseName);
            ChallengeCollection = database.GetCollection<Challenge>(ChallengeCollectionName);

        }

        public static void AddChallengeToDataBase(Challenge challenge)
        {
            ChallengeCollection.InsertOne(challenge);
        }

        public static List<Challenge> FindAllChallenges()
        {
            return ChallengeCollection.Find(x => true).ToList();
        }

        public static Challenge FindChallengeByName(string name)
        {
            return ChallengeCollection.Find(x => x.Name == name).FirstOrDefault();
        }
    }
}
