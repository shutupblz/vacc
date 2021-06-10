using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace vacc
{
    public class User
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        private static List<User> UserList = new List<User>();


        public string name { get; set; }

        public long NationalID { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string governorate { get; set; }
        public bool vaccinated { get; set; }
        public int dosagesNum { get; set; }
        public string email { get; set; }
        public string category { get; set; }
        public static long Active_user_ID;

        public User()
        {
            name = "";
            NationalID = 0;
            email = "";
            password = "";
            gender = "";
            age = 0;
            governorate = "";
            vaccinated = false;
            dosagesNum = 0;
            category = "";
        }
        public User(long NationalID, string password)
        {
            this.NationalID = NationalID;
            this.password = password;

        }
        public static void SignInUserList(User user)
        {
            UserList.Add(user);
        }

        public static List<User> getUserlist()
        {


            return UserList;



        }
        public static User SearchUser(long Nationalid)
        {
            for (int i = 0; i < UserList.Count(); i++)
            {
                if (UserList[i].NationalID == Nationalid)
                {
                    return UserList[i];
                }
            }
            return null;
        }
=======
=======
>>>>>>> Stashed changes
        private string name;
        private int idnum;
        private string email;
        private string pass;
        private string combogen;

        public string Combogen { get => combogen; set => combogen = value; }
        private int age;
        private string governate;
        private bool vaccinated;
        private int dosagesNum;
        private string category;
        public string Name { get => name; set => name = value; }
        public int Idnum { get => idnum; set => idnum = value; }
        public string Email { get => email; set => email = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Age { get => age; set => age = value; }
        public string Governate { get => governate; set => governate = value; }
        public bool Vaccinated { get => vaccinated; set => vaccinated = value; }
        public int DosagesNum { get => dosagesNum; set => dosagesNum = value; }
        public string Category { get => category; set => category = value; }
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
