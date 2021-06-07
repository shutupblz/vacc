using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacc
{
    public class User: IComparable<User>
    {
       
        public string name;
        public long NationalID;
        public string password;
        public string gender;
        public int age;
        public string governorate;
        public bool vaccinated;
        public int dosagesNum;
        public int priorityDegree;

        public User(string name, long nationalID, string password, string gender, int age, string governorate, bool vaccinated, int dosagesNum, int priorityDegree)
        {
            this.name = name;
            NationalID = nationalID;
            this.password = password;
            this.gender = gender;
            this.age = age;
            this.governorate = governorate;
            this.vaccinated = vaccinated;
            this.dosagesNum = dosagesNum;
            this.priorityDegree = priorityDegree;
        }


        //public Queue<User> waitingQueue = new Queue<User>();


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
        public int CompareTo(User other)
        {
            if (this.priorityDegree > other.priorityDegree) return 1;
            if (this.priorityDegree < other.priorityDegree) return -1;
            return 0;
        }
        //setting the priority as the user enters data
        public int settingPriority() {

            if (age >= 60 && age <= 80)
                priorityDegree = 5;
            else if (age >= 40 && age < 60)
                priorityDegree = 4;
            else if (age >= 30 && age < 40)
                priorityDegree = 3;
            else
                priorityDegree = 0;



            return 0;
        }
    }
}
