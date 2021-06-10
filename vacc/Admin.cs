using System;
using System.Collections;
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
        private static PriorityQueue1<User> pq = new PriorityQueue1<User>();
        

        #endregion

        #region Constructor
        public Admin()
        {
            User user = new User("Ahmed", 12345678945612, "123", "F", 45, "Cairo", false, 1, 4);
            User user1 = new User("Ahmed", 12345678945612, "123", "F", 70, "Cairo", false, 1, 5);
            allUsers.Add(user);
            allUsers.Add(user1);
        }
        #endregion


        #region Functions

        public static PriorityQueue1<User> getWaitinglist()
        {
            
            return pq;
        }

        public static PriorityQueue1<User> addtoWaiting() {
            for (int i = 0; i < allUsers.Count(); i++) {

                if (allUsers[i].vaccinated == false) {
                    
                        pq.enqueue(allUsers[i]);
                                       
                }
            }
            return pq;
           
        }


        
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
        public User SearchUser(long Nationalid)
        {
            for (int i = 0; i < allUsers.Count(); i++)
            {
                if (allUsers[i].NationalID == Nationalid)
                {
                    return allUsers[i];
                }
            }
            return null;
        }
        public bool DeleteUser(long Nationalid)
        {
             User user = SearchUser(Nationalid);
            if(user !=null)
            {
                allUsers.Remove(user);
                return true;
            }
            return false; 
        }
        #endregion

    }
}
