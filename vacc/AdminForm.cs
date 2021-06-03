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
            
            for(int i=0; i< users.Count(); i++)
            {
               dataGridView1.Rows.Add(users[i].name, users[i].NationalID, users[i].gender, users[i].age, users[i].governorate, users[i].vaccinated, users[i].dosagesNum);
              
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
