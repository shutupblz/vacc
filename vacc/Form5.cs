using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vacc
{
    public partial class Form5 : Form
    {
        private static List<User> oneUser = new List<User>();
        User u = new User();

        public Form5()
        {
            InitializeComponent();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
        List<User> users = new List<User>();
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            long ID = long.Parse(IDtxt.Text);
            ViewInfo f = new ViewInfo();
            if (string.IsNullOrWhiteSpace(IDtxt.Text) && string.IsNullOrWhiteSpace(passtxt.Text))
            {
                MessageBox.Show("Missing Information !");

            }
            else
            {
                try
                {
                    users = Admin.getUserlist();
                    for (int i = 0; i < users.Count(); i++)
                    {

                        if (ID == users[i].NationalID && passtxt.Text == users[i].password)
                        {
                            User.Active_user_ID = ID;
                            flag = true;
                            MessageBox.Show("Welcome");
                            f.recieveData(ID);
                            f.Show();
                            break;

                        }

                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Error Occured");
                
                }
              
                if (!flag)
                {
                    MessageBox.Show("Incorrect username and password !");
                }
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }
    }
}
