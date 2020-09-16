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

namespace Lab5_CV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonV2 contact = new PersonV2();

            contact.FirstName = txtFirstName.Text;           
            contact.MiddleName = txtMiddleName.Text;           
            contact.LastName = txtLastName.Text;
            contact.Street1 = txtStreet1.Text;           
            contact.Street2 = txtStreet2.Text;          
            contact.City = txtCity.Text;          
            contact.State = txtState.Text;          
            contact.Zip = txtZip.Text;          
            contact.Phone = txtPhone.Text;        
            contact.Email = txtEmail.Text;
            contact.CellPhone = txtCellPhone.Text;
            contact.InstagramURL = txtInstagramURL.Text;

            if (contact.Feedback.Contains("Error:"))
            {
                lblFeedback.Text = contact.Feedback;
            }
            else
            {
                lblFeedback.Text = contact.AddARecord();
            }
        }

        public Form1(int intPersonsID)
        {
            InitializeComponent();  

            PersonV2 temp = new PersonV2();
            SqlDataReader dr = temp.FindOnePerson(intPersonsID);

            while (dr.Read())
            {
                //Take the Name(s) from the datareader and copy them
                // into the appropriate text fields
                txtFirstName.Text = dr["FirstName"].ToString();
                txtMiddleName.Text = dr["MiddleName"].ToString();
                txtLastName.Text = dr["LastName"].ToString();
                txtStreet1.Text = dr["Street1"].ToString();
                txtStreet2.Text = dr["Street2"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtState.Text = dr["State"].ToString();
                txtZip.Text = dr["Zip"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtCellPhone.Text = dr["CellPhone"].ToString();
                txtInstagramURL.Text = dr["InstagramURL"].ToString();
                lblPersonsID.Text = dr["PersonID"].ToString();
            }


        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
