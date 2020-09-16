using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_CV
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void Control_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.Show();
        }

        private void btnSearchPersons_Click(object sender, EventArgs e)
        {
            SearchMgr temp = new SearchMgr();
            temp.Show();
        }
    }
}
