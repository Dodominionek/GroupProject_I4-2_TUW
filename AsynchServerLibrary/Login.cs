using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchServerLibrary
{
    public class Login
    {

        //Logowanie usera (sprawdza czy login i hasło się zgadzają po czym loguje)
        public bool login(string log, string pass)
        {
            foreach (KeyValuePair<int, User> entry in UserList.list)
            {
                if (entry.Value.getLogin() == log)
                {
                    if(entry.Value.getPassword() == pass)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
