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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\97150\Documents\VaccinedB.mdf;Integrated Security=True;Connect Timeout=30");
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

        private void regbtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || id.Text == "" || Age.Text == "" || pass.Text == "" || gov.Text == "" || comboDose.Text == "" || comboGen.Text == "" )
            {
                MessageBox.Show("Missing Information ! ");

            }
            else
            {
                    MessageBox.Show("You've Succesfully Registered For Vaccination !");
            }

            User u = new User();
            int num = int.Parse(id.Text);
            if (num <= 14)
            {
                u.idnum = num;
                u.age = int.Parse(Age.Text);
                u.combogen = (comboGen.SelectedIndex.ToString());
                u.dosagesNum = int.Parse(comboDose.SelectedItem.ToString());
                u.governate = gov.Text;
                u.name = name.Text;
                u.pass = pass.Text;
               
            }
            else
            {
                MessageBox.Show("Enter the 13 Characters Please .");

            }

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
            Form1 f = new Form1();
            f.Show();
            this.Hide();

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
