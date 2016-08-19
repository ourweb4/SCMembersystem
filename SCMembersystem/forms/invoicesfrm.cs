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
using SCMembersystem.Models;

namespace SCMembersystem.forms
{
    public partial class invoicesfrm : Form
    {
        private int currid;

        private Member currMember;

        private List<Invoice> mInvoices;
        private decimal totamt;

        public invoicesfrm(int memberid)
        {
            InitializeComponent();
            currid = memberid;
        }

        private void invoicesfrm_Load(object sender, EventArgs e)
        {
            getmemberdetails();

        }

        private void loadmember()
        {
            firstnamelab.Text = currMember.firstname;
            lastnamelab.Text = currMember.lastname;
            addresslab.Text = currMember.address;
            citylab.Text = currMember.city;
            statelab.Text = currMember.state;
            ziplab.Text = currMember.zip;
            amtduelab.Text = currMember.amtdue.ToString();
        }
        private void getmemberdetails()
        {
            using (var context = new DBContext())
            {
                currMember = context.Members.SingleOrDefault(r => r.Id == currid);


            }

            if (currMember != null)
            {
                loadmember();
            }
        }

        private void loadinvoices()
        {


            using (var context = new DBContext())
            {

                dataGridView1.DataSource = context.Invoices
                    .Where(e => e.memberId == currid)
                    .OrderBy(e => e.invdate)
                    .ToList();

                mInvoices = context.Invoices
                    .Where(e => e.memberId == currid)
                    .ToList();

                 var totamt = 0.0;

                foreach (var invoice in mInvoices)
                {
                    totamt += (double) (invoice.amount - invoice.paidamount);

                }
                currMember.amtdue = (decimal) totamt;

                context.SaveChanges();

            }               
            }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
