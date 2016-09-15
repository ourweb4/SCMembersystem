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
using SCMembersystem.forms;
using SCMembersystem.Models;
using SCMembersystem.Reports;

namespace SCMembersystem
{
    public partial class mainfrm : Form
    {
        public int currid = 0;
        private Member currMember = new Member();

         
        public mainfrm()
        {
            InitializeComponent();
        }

   
        private void Getmtypes()
        {
            //mtypeBindingSource.DataSource = null;
            using (var context = new DBContext())
            {


                mtypeBindingSource.DataSource = context.Mtypes
                 
                    .OrderBy(e => e.name)
                    
                    .ToList();
            }
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
                        .Where(e => e.lastname.StartsWith(lname))
                        .OrderBy(e => e.lastname)
                        .ThenBy(e => e.firstname)
                        .ToList();

                }
            }
        //    Getmtypes();
        }

        private void loadmember()
        {
            mtypcomboBox.SelectedValue = currMember.mtype;
            activecheckBox.Checked = currMember.active;
            lasttxt.Text = currMember.lastname;
            firsttxt.Text = currMember.firstname;
            addresstxt.Text = currMember.address;
            citytxt.Text = currMember.city;
            statetxt.Text = currMember.state;
            ziptxt.Text = currMember.zip;
            phonetxt.Text = currMember.phone;
            celltxt.Text = currMember.cell;
            emailtxt.Text = currMember.email;
            employedbytxt.Text = currMember.employedby;
            occupationtxt.Text = currMember.occupation;
             dobdateTimePicker.Value = currMember.dob;
            joindateTimePicker.Value = currMember.join;
            nextbilldateTimePicker.Value = currMember.nextbill;
            hoursnumericUpDown.Value = currMember.hours;
            amountnumericUpDown.Value = currMember.amtdue;
            fidcheckBox.Checked = currMember.fid;
            ltccheckBox.Checked = currMember.ltc;
            fishingcheckBox.Checked = currMember.fishing;
            huntingcheckBox.Checked = currMember.hunting;
            goalcheckBox.Checked = currMember.goal;
            nracheckBox.Checked = currMember.nra;
            currid = currMember.Id;

           
        }

        private void savemember()
        {
            if (mtypcomboBox.SelectedValue != null) currMember.mtype = (int) mtypcomboBox.SelectedValue;
            currMember.active = activecheckBox.Checked;
            currMember.lastname = lasttxt.Text;
            currMember.firstname = firsttxt.Text;
            currMember.address = addresstxt.Text;
            currMember.city = citytxt.Text;
            currMember.state = statetxt.Text;
            currMember.zip = ziptxt.Text;
            currMember.phone = phonetxt.Text;
            currMember.cell = celltxt.Text;
            currMember.email = emailtxt.Text;
            currMember.employedby = employedbytxt.Text;
            currMember.occupation = occupationtxt.Text;
            currMember.dob = dobdateTimePicker.Value;
            currMember.join = joindateTimePicker.Value;
            currMember.nextbill = nextbilldateTimePicker.Value;
            currMember.hours = (int) hoursnumericUpDown.Value;
            currMember.amtdue = amountnumericUpDown.Value;
            currMember.fid = fidcheckBox.Checked;
            currMember.ltc = ltccheckBox.Checked;
            currMember.fishing = fishingcheckBox.Checked;
            currMember.hunting = huntingcheckBox.Checked;
            currMember.goal = goalcheckBox.Checked;
            currMember.nra = nracheckBox.Checked;
            currMember.Id = currid;
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            var lname = searchtxt.Text;
            GetMembers(lname);
        }

        private void mainfrm_Load(object sender, EventArgs e)
        {
            Getmtypes();
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

        private void mtypcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void membersdataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            currid = (int)membersdataGridView.Rows[row].Cells[0].Value;
            using (var context = new DBContext())
            {
                currMember = context.Members.SingleOrDefault(r => r.Id == currid);


            }

            if (currMember != null)
            {
                loadmember();
            }




        }

        private void addbut_Click(object sender, EventArgs e)
        {
            currMember= new Member();
            currMember.active = true;
            currMember.dob = DateTime.Now;
            currMember.nextbill=DateTime.Now;
            currMember.join=DateTime.Now;
            currMember.Id = 0;
            currid = 0;
            
            //currMember.mtype = 1;
            loadmember();
            
        }

        private void deletebut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
             //   e.Cancel = true;
                return;

            }

            var memberid = currid;


            var context = new DBContext();
            var member = context.Members.SingleOrDefault(p => p.Id == memberid);

            if (member != null)
            {
                context.Members.Remove(member);
                context.SaveChanges();
                GetMembers("");
                currid = 0;
                currMember=new Member();
                loadmember();
                searchtxt.Text = "";

            }
        }

        private void savebut_Click(object sender, EventArgs e)
        {
            var context=new DBContext();
            if (currid != 0)
            {
                currMember = context.Members.SingleOrDefault(r => r.Id == currid);
                if (currMember != null)
                {
                    savemember();
                    context.SaveChanges();
                    loadmember();
                    GetMembers();
                }
            }
            else
            {
                savemember();
                currid=context.Members.Add(currMember).Id;
                context.SaveChanges();
                loadmember();
                GetMembers();

            }
        }

        private void invoicesbut_Click(object sender, EventArgs e)
        {
            var invfrm = new invoicesfrm(currid);

            invfrm.ShowDialog();
            loadmember();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var helpbox = new AboutBox();

            helpbox.ShowDialog();
        }

        private void membershipTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mtypefrm = new mtypefrm();

            mtypefrm.ShowDialog();
        //    Getmtypes();
        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clubfrm = new clubfrm();
            clubfrm.ShowDialog();
        }

        private void lettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var letterfrm = new lettersfrm();
            letterfrm.ShowDialog();
        }

        private void processInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var processfrm = new processfrm();
            processfrm.ShowDialog();

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Use this since we are a WinForms app
            System.Windows.Forms.Application.Exit();
        }

        private void dobdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void membersdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void paybut_Click(object sender, EventArgs e)
        {
            var context = new DBContext();
            var mtypeid = currMember.mtype;
            var mtype = context.Mtypes.SingleOrDefault(x => x.Id == mtypeid); // get  fee
            if (mtype != null)
            {
                var amt = mtype.cost + mtype.initfee;
                var minhours = mtype.hours;
                var days = mtype.days;
                if (!mtype.once)
                {
                    var crinv = new Invoice();
                    crinv.memberId = currMember.Id;
                    crinv.invdate = DateTime.Now;
                    string description;
                    decimal tot;


                    tot = amt;
                    description = string.Format("Membership Type: {0} ",
                        mtype.name);

                    crinv.amount = tot;
                    crinv.description = description;
                    context.Invoices.Add(crinv);
                    context.SaveChanges();
                    currMember = context.Members.SingleOrDefault(r => r.Id == currid);
                    if (currMember != null)
                    {
                        currMember.amtdue += tot;
                        currMember.nextbill = currMember.nextbill.AddDays(days);
                    }
                    context.SaveChanges();
                }

            }

            var invfrm = new invoicesfrm(currid);

            invfrm.ShowDialog();
            loadmember();

        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }
    }
}
