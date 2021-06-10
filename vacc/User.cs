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
<<<<<<< Updated upstream
       
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
        //if the priority degree is 6, then that is a emergency 
        //the other numbers are set according how severe the case is
        public int settingPriority() {
            if (age > 100)
                return priorityDegree = 6;
            else if (age >= 60 && age <= 100)
               return priorityDegree = 5;
            else if (age >= 40 && age < 60)
                return priorityDegree = 4;
            else if (age >= 20 && age < 40)
                return priorityDegree = 3;
            
            //waiting for the chronic disease, medical sector thing and the emails also 


            return 0;
        }
=======
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
>>>>>>> Stashed changes
    }
}
