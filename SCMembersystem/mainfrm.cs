using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCMembersystem.Data;

namespace SCMembersystem
{
    public partial class mainfrm : Form
    {
        public int currid;
        public mainfrm()
        {
            InitializeComponent();
        }

        private void GetMembers(string lname = "")
        {
            if (lname == "")
            {
                using (var context = new DBContext())
                {
                    membersdataGridView.DataSource = context.Members

                        .OrderBy(e => e.lastname)
                        .ThenBy(e => e.firstname)
                        .ToList();

                }
            }
            else
            {
                using (var context = new DBContext())
                {
                    membersdataGridView.DataSource = context.Members
                        .Where(e => e.lastname == lname)
                        .OrderBy(e => e.lastname)
                        .ThenBy(e => e.firstname)
                        .ToList();

                }
            }
        }

        private void membersdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            var lname = searchtxt.Text;
            GetMembers(lname);
        }

        private void mainfrm_Load(object sender, EventArgs e)
        {
            GetMembers("");
        }

        private void searchbut_Click(object sender, EventArgs e)
        {

            var lname = searchtxt.Text;
            GetMembers(lname);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
