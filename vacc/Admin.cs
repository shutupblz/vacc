﻿using System;
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
        private const int password = 12345;
        private static List<User> allUsers = new List<User>();
        //List<User> waitingList = new List<User>();

        

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

        public static void receiveDate(User user)
        {
            allUsers.Add(user);
        }
        //public User searchUser (int nationalNumber, List<User> Users)
        //{
        //    User u = new User();
        //    return u;
        //}
        public static List<User> getUserlist()
        {


            return allUsers;

        }
        public void viewUser()
        {

        }
    }
}
