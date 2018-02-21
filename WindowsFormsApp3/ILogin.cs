using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    interface ILogin
    {
        string Username { get; set; }
        string UserPassword { get; set; }
        void AddUser(string username,string password);
        bool UserLogIn(string username,string password);
    }
}
