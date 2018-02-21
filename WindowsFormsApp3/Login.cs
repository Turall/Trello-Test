using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Login : ILogin
    {
        Dictionary<ILogin, IBorders> LoginMap;
        Dictionary<string,string> LoginList;
        public string Username { get; set; }
        public string UserPassword { get; set; }

        public Login()
        {
            LoginList = new Dictionary<string, string>();
            LoginMap = new Dictionary<ILogin, IBorders>();
        }
        public void AddUser(string username,string password)
        {
            Username = username;
            UserPassword = password;
            LoginList.Add(Username, UserPassword);
        }

        public bool UserLogIn(string username,string password)
        {
            if(LoginList == null)
            {
                return false;
            }
            else
            {
                foreach (var item in LoginList)
                {
                    if(item.Key == username && item.Value == password)
                    {
                        return true;
                    }
                    
                }
                return false;
            }
        }
    }
}
