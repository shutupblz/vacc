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
       
        private void AdminForm_Load(object sender, EventArgs e)
        {


            users = Admin.getUserlist();

            for (int i = 0; i < users.Count(); i++)
            {
                dataGridView1.Rows.Add(users[i].name, users[i].NationalID, users[i].gender, users[i].age, users[i].governorate, users[i].vaccinated, users[i].dosagesNum);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
          
            User user = Admin.SearchUser(long.Parse(textBox1.Text));
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
