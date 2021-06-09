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

namespace vacc
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       
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
            if (name.Text == "" || id.Text == "" || Age.Text == "" || pass.Text == "" || gov.Text == ""  || comboGen.Text == "" || checkedListBox1.SelectedIndex == -1)
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
            user.password = pass.Text;


            //check age for the age limit
            if (int.Parse(Age.Text) < 20)
                MessageBox.Show("The vaccination isn't available for such range of age.\n You can not proceed unless you are over 20.");

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
            
            //checking if the applicant should go to the waiting list plus setting their priority 
            if (user.vaccinated == false) {
                user.priorityDegree = user.settingPriority();
            }
            

            MessageBox.Show("You've Succesfully Registered For Vaccination !");
            users.Add(user);
            Admin.receiveDate(user);
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            id.Text = "";
            Age.Text = "";
            pass.Text = "";
            gov.Text = "";
            comboDose.Text = "";
            comboGen.Text = "";
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
    }
}
