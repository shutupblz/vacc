using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacc
{
    public class User
    {
       
        public string name;
        public long NationalID;
        public string password;
        public string gender;
        public int age;
        public string governorate;
        public bool vaccinated;
        public int dosagesNum;

        public User()
        {
            name = "";
            NationalID = 0;
            password = "";
            gender = "";
            age = 0;
            governorate = "";
            vaccinated = false;
            dosagesNum = 0;
        }

    }
}
