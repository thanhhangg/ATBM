using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Auth
    {
        private static Auth _instance = null;

        public string Username;
        public string Role;
        public bool IsAuth = false;

        private Auth() { }

        public static Auth GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Auth();
            }

            return _instance;
        }

        public void LogOut()
        {
            Username = null;
            Role = null;
            IsAuth = false;
        }
    }
}

