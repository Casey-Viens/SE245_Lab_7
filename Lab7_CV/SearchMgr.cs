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
    public partial class SearchMgr : Form
    {
        public SearchMgr()
        {
            InitializeComponent();
        }

        private void SearchMgr_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PersonV2 temp = new PersonV2();
            DataSet ds = temp.SearchPersons(txtFirstName.Text, txtLastName.Text);

            dgvTable.DataSource = ds;
            dgvTable.DataMember = ds.Tables["Persons_Temp"].ToString();
        }
        private void dgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strPersonsID = dgvTable.Rows[e.RowIndex].Cells[0].Value.ToString();

            MessageBox.Show(strPersonsID);

            int intPersonsID = Convert.ToInt32(strPersonsID);
            Form1 Editor = new Form1(intPersonsID);
            Editor.ShowDialog();
        }
    }
}
