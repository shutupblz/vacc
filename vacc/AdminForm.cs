using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace vacc
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }


        List<User> users = new List<User>();
        PriorityQueue1<User> usersWaiting = new PriorityQueue1<User>();
        private void AdminForm_Load(object sender, EventArgs e)
        {

            
            users = Admin.getUserlist();
            usersWaiting = Admin.addtoWaiting();
            
            for (int i = 0; i < users.Count(); i++)
            {
                dataGridView1.Rows.Add(users[i].name, users[i].NationalID, users[i].gender, users[i].age, users[i].governorate, users[i].vaccinated, users[i].dosagesNum);
            }
            for(int i=0; i<usersWaiting.count(); i++)
            {
                waitingGridView.Rows.Add(usersWaiting.Peek().name, usersWaiting.Peek().NationalID, usersWaiting.Peek().gender, usersWaiting.Peek().age, usersWaiting.Peek().governorate, usersWaiting.Peek().vaccinated, usersWaiting.Peek().dosagesNum, usersWaiting.Peek().priorityDegree);
                usersWaiting.deque();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
          
            User user = admin.SearchUser(long.Parse(textBox1.Text));
            if (user != null)
            {
                textBox2.Text = user.name;
                textBox3.Text = user.gender;
                textBox4.Text = user.age.ToString();
                comboBox1.Text = user.vaccinated.ToString();
                comboBox2.Text = user.dosagesNum.ToString();

            }
            else
            {
                MessageBox.Show("User doesn't exist");
            }
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            bool deleteuser =  admin.DeleteUser(long.Parse(textBox1.Text));
            if(deleteuser)
            {
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("This User Doesn't Exist");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            users = Admin.getUserlist();
            dataGridView1.RowCount = 1;
            for (int i = 0; i < users.Count(); i++)
            {
                dataGridView1.Rows.Add(users[i].name, users[i].NationalID, users[i].gender, users[i].age, users[i].governorate, users[i].vaccinated, users[i].dosagesNum);

            }
        }

        private void waitingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static void Email(string htmlString)
        {
           
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient stmp = new SmtpClient();
                message.From = new MailAddress("purplew37@gmail.com");
                message.To.Add(new MailAddress("purplew37@gmail.com"));
                message.Subject = "Covid-19 Vaccination First Dose Notice";
                message.IsBodyHtml = true;
                message.Body = htmlString;
                stmp.Port = 587;
                stmp.Host = "smtp.gmail.com";
                stmp.EnableSsl = true;
                stmp.UseDefaultCredentials = false;
                stmp.Credentials = new NetworkCredential("purplew37@gmail.com", "S@lma3010");
                stmp.DeliveryMethod = SmtpDeliveryMethod.Network;
                stmp.Send(message);
            }
            catch (Exception) { }
        }
        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            string htmlString1 = "Hello,\nHope this email finds you well and healthy.\n First Vaccination Notice:\n Your first dose will be on: " + DateTime.Now + "\nand the second Vaccination will be 14 days apart: " + DateTime.Now.AddDays(14) + "\nYou may have 3 days after each vaccination date to attend to your destinated area, after the 3 days your vaccination application will be removed and you will have to register again for vaccination.";

            Email(htmlString1);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The E-mails will be sent to the first 50 people until the admin decide the capacity of the day.");
        }
    }
}
