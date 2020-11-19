using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchServerLibrary
{
    class User
    {
        public int id;
        public int idCount = 1;
        private string login;
        private string password;
        private int score;

        // Użytkownik ma takie atrybuty jak id (do identyfikacji w słowniku), login, hasłow i wynik w grze
        public User(string login, string password)
        {
            this.id = idCount;
            this.login = login;
            this.password = password;
            this.score = 0;
            idCount += 1;
        }

        public string getLogin()
        {
            return login;
        }

        public string getPassword()
        {
            return password;
        }
    }
}
