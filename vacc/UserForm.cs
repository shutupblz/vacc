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
    public partial class UserForm : Form
    {
        User u;
        public UserForm()
        {
            InitializeComponent();
        }
        DataTable userTable = new DataTable();
        List<User> users = new List<User>();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            users = User.getUserlist();

            for (int i = 0; i < users.Count(); i++)
            {
                dataGridView1.Rows.Add(users[i].name, users[i].NationalID, users[i].gender, users[i].age, users[i].governorate, users[i].vaccinated, users[i].dosagesNum);

            }
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*User u = new User();
            userTable.Columns.Add("First Name", typeof(string));
            userTable.Columns.Add("National ID", typeof(int));
            userTable.Columns.Add("Password", typeof(string));
            userTable.Columns.Add("Email", typeof(string));
            userTable.Columns.Add("Gender", typeof(string));
            userTable.Columns.Add("Age", typeof(int));
            userTable.Columns.Add("Governate", typeof(string));
            userTable.Columns.Add("Vaccinated", typeof(bool));
            userTable.Columns.Add("Dosages Number", typeof(int));
            userTable.Columns.Add("Category", typeof(string));
            dataGridView1.DataSource = userTable;

            userTable.Rows.Add(u.geetName.ToString(),)
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            users = User.getUserlist();
            dataGridView1.RowCount = 1;
            for (int i = 0; i < users.Count(); i++)
            {
                dataGridView1.Rows.Add(users[i].name, users[i].NationalID,users[i].gender, users[i].gender, users[i].age, users[i].governorate, users[i].vaccinated, users[i].dosagesNum,users[i]);

            }
        }
    }
}
