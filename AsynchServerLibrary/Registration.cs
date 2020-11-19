using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AsynchServerLibrary
{
    class Registration
    {
        private string path = @"C:\Users\Dominik\Desktop\Studia\IO\users.txt";
        
        // Sprawdza czy dany user jest na liście, jeśli tak to go dodaje (Whitelista)
        public int addUser(string log, string pass)
        {
            User user = new User(log, pass);
            string[] toSave = { log, pass };
            string readText = File.ReadAllText(path);
            if (!readText.Contains(log))
            {
                return -1;
            }
            else
            {
                System.IO.File.WriteAllLines(path, toSave);
                UserList.list.Add(user.id, user);
                return user.id;
            }
        }
    }
}
