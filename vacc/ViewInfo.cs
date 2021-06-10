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
    public partial class ViewInfo : Form
    {
        User user = new User();
        public ViewInfo()
        {
            InitializeComponent();
        }
        long NationalID;
        public void ValueFromForm1(string value)
        {
            nametxt.Text = value;
        }
        private void name_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ViewInfo_Load(object sender, EventArgs e)
        {
            User user = Admin.SearchUser(NationalID);
            
            
            nametxt.Text = user.name;
            id.Text = user.NationalID.ToString();
            email.Text = user.email;
            gender.Text = user.gender;
            age.Text = user.age.ToString();
            gov.Text = user.governorate;
            vac.Text = user.vaccinated.ToString();
            category.Text = user.category;
            dosagenum.Text = user.dosagesNum.ToString();




            //nametxt.Text = user.name;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void recieveData(long NID)
        {
           
            NationalID = NID;
        
        }

        private void email_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = Admin.SearchUser(NationalID);
            user.name = nametxt.Text;
            user.governorate = gov.Text;
            user.email = email.Text;
            user.gender = gender.Text;
            gov.Text = user.governorate;
            Admin.update(user);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }
    }
}
