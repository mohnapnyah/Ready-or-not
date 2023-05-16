using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ready_or_not
{
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId id;

        private string number;
        private string email;
        private string login;
        private string password;
        private List<Challenge> challenges;
        private string name;
        private string surname;
        private string patronymic;
        private List<Challenge> completedChallenges;
        private int points;


        public User(string login, string password, string number, string email, string name, string surname)
        {
            this.login = login;
            this.password = password;
            this.challenges = new List<Challenge>();
            this.number = number;
            this.email = email;
            this.name = name;
            this.surname = surname;
            this.completedChallenges = new List<Challenge>();
        }

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public List<Challenge> Challenges { get => challenges; set => challenges = value; }
        public string Number { get => number; set => number = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public List<Challenge> CompletedChallenges { get => completedChallenges; set => completedChallenges = value; }
        public int Points { get => points; set => points = value; }
    }
}
