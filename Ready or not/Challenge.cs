using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Ready_or_not
{
    public class Challenge
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId id;

        private string name;
        private string description;
        private int difficulty;
        private int reward;
        

        public Challenge(string name, string description, int difficulty, int reward)
        {
            this.name = name;
            this.description = description;
            this.difficulty = difficulty;
            this.reward = reward;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Difficulty { get => difficulty; set => difficulty = value; }
        public int Reward { get => reward; set => reward = value; }
    }
}
