using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacc
{
    class Admin
    {
        #region Fields
        private const string username = "Admin";
        private const int password = 142536;
        #endregion

        #region Functions
        public bool login(string name, int pass)
        {
            if(name == username && pass == password)
            {
                return true;
            }
            return false;
            
        }

        public string getUsername()
        {
            return username;
        }

        public int getPass()
        {
            return password;
        }
        #endregion


    }
}
