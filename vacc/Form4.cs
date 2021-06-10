using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using System.Collections;
namespace vacc
{
    public partial class Form4 : Form
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        public User user { get; set; }


=======
        static List<User> userList = new List<User>();
        static User user = new User();
>>>>>>> Stashed changes
=======
        static List<User> userList = new List<User>();
        static User user = new User();
>>>>>>> Stashed changes


        public Form4()
        {
            
            InitializeComponent();
            //user = new User();
        }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
       
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        private void Form4_Load(object sender, EventArgs e)
        {
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }
        List<User> users = new List<User> ();
        SortedSet<long> ids = new SortedSet<long>();
        private void regbtn_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            //for the sign in 
            long ID = long.Parse(id.Text);
            User user_signin = new User(ID , passtxt.Text);
            User.SignInUserList(user_signin);
            //for the admin to dispalay user data

            if (name.Text == "" || id.Text == "" || Age.Text == "" || passtxt.Text == "" || gov.Text == ""  || comboGen.Text == "" || checkedListBox1.SelectedIndex == -1)
=======
=======
>>>>>>> Stashed changes
            
            User user = new User();
            user.Idnum = userList.Count + 1;
            user.Idnum = int.Parse(id.Text);
            userList.Add(user);
            
            
            if (name.Text == "" || id.Text == "" || Age.Text == "" || pass.Text == "" || gov.Text == "" || comboDose.Text == "" || comboGen.Text == "" )
>>>>>>> Stashed changes
            {
                MessageBox.Show("Missing Information ! ");
                return;
              
            }

            if (checkedListBox1.SelectedItem.ToString() == "Yes" && comboDose.SelectedIndex == -1)
            {

                MessageBox.Show("Missing Information ! ");
                return;
            }

            long nationalID = long.Parse(id.Text);
            User user = new User();
            if (nationalID.ToString().Length == 14)
            {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
                if (ids.Contains(nationalID))
                {
                    MessageBox.Show("This ID has Already registered");
                    return;
                }
                else
                {
                    user.NationalID = nationalID;
                    ids.Add(nationalID);
                }

=======
=======
>>>>>>> Stashed changes
                u.Idnum = num;
                u.Age = int.Parse(Age.Text);
                u.Combogen = (comboGen.SelectedIndex.ToString());
                u.DosagesNum = int.Parse(comboDose.SelectedItem.ToString());
                u.Governate = gov.Text;
                u.Name = name.Text;
                u.Pass = pass.Text;
               
>>>>>>> Stashed changes
            }
            else
            {
                MessageBox.Show("Enter the 14 Characters for the National ID Please.");
                return;

            }
           
            user.age = int.Parse(Age.Text);
            user.gender = comboGen.SelectedItem.ToString();
            user.governorate = gov.SelectedItem.ToString();
            user.name = name.Text;
            user.password = passtxt.Text;
            user.email = emailtxt.Text;
            user.category = categcmd.Text;
            if (checkedListBox1.SelectedItem.ToString()== "No") 
            {
                user.vaccinated = false;
                user.dosagesNum = 0;
            }
            else if(checkedListBox1.SelectedItem.ToString() == "Yes")
            {
                user.vaccinated = true;
                user.dosagesNum = int.Parse(comboDose.SelectedItem.ToString());
            }
           

            MessageBox.Show("You've Succesfully Registered For Vaccination !");
            users.Add(user);
            Admin.receiveDate(user);
            
            //for the viewInfo form
          /*  ViewInfo info = new ViewInfo();
            info.View(user.name);
            info.Show()*/;
            
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            id.Text = "";
            Age.Text = "";
            passtxt.Text = "";
            gov.Text = "";
            comboDose.Text = "";
            comboGen.Text = "";
            emailtxt.Text = "";
            categcmd.Text = "";
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.Show();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void id_OnValueChanged(object sender, EventArgs e)
        {
        
           
    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelVacc_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void id_Validating(object sender, CancelEventArgs e)
        {

        }

        private void id_KeyPress(object sender, KeyPressEventArgs e) 
        {
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

     

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            for (int i = 0; i < 2; i++)
            {
                if (index != i)
                {
                    checkedListBox1.SetItemChecked(i, false);
                
                }
               

            
            }
            if (checkedListBox1.SelectedIndex == 1)
            {
                comboDose.Enabled = true ;
            }
            else
            {
                comboDose.Enabled = false;

            }
            /* if (checkBox2.Checked == true)
           {
               comboDose.Enabled = false;

           }
           else
           { 
               comboDose.Enabled = true;
           }
          */


    }

        private void name_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            
        }

        private void passtxt_Validating(object sender, CancelEventArgs e)
        {
           
            //eg "aaZZa44@"
            var passid = passtxt.Text;

            string pattern = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=])(?=\\S+$).{8,}";

            //check first string
            if (Regex.IsMatch(passid, pattern))
            {
                //if email is valid
               // MessageBox.Show(" valid password");
            }
            else
            {
                MessageBox.Show(" Invalid password");
                return;
            }
        }

        private void emailtxt_Validating(object sender, CancelEventArgs e)
        {
           //example test@gmail.com
            var EmailId = emailtxt.Text;

            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            //check first string
            if (Regex.IsMatch(EmailId, pattern))
            {
                //if email is valid
               // MessageBox.Show(" valid Email address");
            }
            else
            {
                MessageBox.Show(" Invalid Email address");
                return;

            }

=======
=======
>>>>>>> Stashed changes

        }

        private void label11_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            
        }
    }
}
