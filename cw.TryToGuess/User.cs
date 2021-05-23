using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw.TryToGuess
{
    [Serializable]
    public class User
    {
        public string Username { get; set; }
        public int BestScore { get; set; }
        public int Level { get; set; }
        public DateTime dateTime { get; set; }

        public User(string username, int bestscore, int level)
        {
            Username = username;
            BestScore = bestscore;
            Level = level;
            dateTime = DateTime.Now;
        }
        public User() { }
    }
}
