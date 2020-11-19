using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchServerLibrary
{
    class UserList
    {
        public static Dictionary<int, User> list = new Dictionary<int, User>();

        //Usuwanie usera z listy po id lub loginie (nie kasuje z whitelisty na razie)
        public string removeUser(int id)
        {
            list.Remove(id);
            return "User with id: " + id + " removed";
        }

        public string removeUser(string log)
        {
            int key = -1;
            foreach (KeyValuePair<int, User> entry in list)
            {
                if(entry.Value.getLogin() == log)
                {
                    key = entry.Key;
                }
            }
            if(key == -1)
            {
                return "There is no user with login: " + log;
            } 
            else
            {
                list.Remove(key);
                return "User: " + log + " removed";
            }
        }
    }
}
