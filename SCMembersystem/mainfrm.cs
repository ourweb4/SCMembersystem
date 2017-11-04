// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill
// Created          : 08-08-2016
//
// Last Modified By : Bill
// Last Modified On : 09-29-2016
// ***********************************************************************
// <copyright file="mainfrm.cs" company="Ourweb.net  --  508-829-2005">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
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
    /// <summary>
    /// Class mainfrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class mainfrm : Form
    {
        /// <summary>
        /// The currid
        /// </summary>
        public int currid = 0;
        /// <summary>
        /// The curr member
        /// </summary>
        private Member currMember = new Member();


        /// <summary>
        /// Initializes a new instance of the <see cref="mainfrm"/> class.
        /// </summary>
        public mainfrm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Getmtypeses this instance.
        /// </summary>
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

        /// <summary>
        /// Gets the members.
        /// </summary>
        /// <param name="lname">The lname.</param>
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

        /// <summary>
        /// Loadmembers this instance.
        /// </summary>
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

        /// <summary>
        /// Savemembers this instance.
        /// </summary>
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

        /// <summary>
        /// Handles the TextChanged event of the searchtxt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            var lname = searchtxt.Text;
            GetMembers(lname);
        }

        /// <summary>
        /// Handles the Load event of the mainfrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainfrm_Load(object sender, EventArgs e)
        {
            Getmtypes();
            GetMembers("");
        }

        /// <summary>
        /// Handles the Click event of the searchbut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void searchbut_Click(object sender, EventArgs e)
        {

            var lname = searchtxt.Text;
            GetMembers(lname);
        }

        /// <summary>
        /// Handles the Click event of the label14 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label14_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the label13 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label13_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the label12 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label12_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the label11 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label11_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the label10 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label10_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the label9 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label9_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the label8 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label8_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the label7 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label7_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the label6 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label6_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the label5 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the CheckedChanged event of the checkBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the mtypcomboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mtypcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the RowEnter event of the membersdataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the addbut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the deletebut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the savebut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the invoicesbut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void invoicesbut_Click(object sender, EventArgs e)
        {
            var invfrm = new invoicesfrm(currid);

            invfrm.ShowDialog();
            loadmember();
        }

        /// <summary>
        /// Handles the Click event of the aboutToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var helpbox = new AboutBox();

            helpbox.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the membershipTypesToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void membershipTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mtypefrm = new mtypefrm();

            mtypefrm.ShowDialog();
            Getmtypes();
        }

        /// <summary>
        /// Handles the Click event of the systemToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clubfrm = new clubfrm();
            clubfrm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the lettersToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var letterfrm = new lettersfrm();
            letterfrm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the processInvoicesToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void processInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var processfrm = new processfrm();
            processfrm.ShowDialog();

        }

        /// <summary>
        /// Handles the Click event of the quitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Use this since we are a WinForms app
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// Handles the ValueChanged event of the dobdateTimePicker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dobdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the CellContentClick event of the membersdataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void membersdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        /// <summary>
        /// Handles the Click event of the paybut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void paybut_Click(object sender, EventArgs e)
        {
            decimal amt;
            var context = new DBContext();
            var invoices = context.Invoices.Where(x => x.memberId == currid);
            var mtypeid = currMember.mtype;
            var mtype = context.Mtypes.SingleOrDefault(x => x.Id == mtypeid); // get  fees
            if (mtype != null)
            {
                 amt = mtype.cost;
                if (invoices.Count() == 0)  //see if new member
                {
                    amt += mtype.initfee; // add on the  new  member  fee
                }
            
            var minhours = mtype.hours;
                var days = mtype.days;
                if (!mtype.once)
                {
                    var crinv = new Invoice();
                    crinv.memberId = currMember.Id;
                    crinv.invdate = DateTime.Now;
                    string description;

                    var tot = amt;

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

        /// <summary>
        /// Handles the Click event of the invoicesToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
             var invrptfrm = new invrptfrm();
            invrptfrm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the membersToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var membersrpt = new membersrptfrm();
            membersrpt.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the accountsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var accountsrpt = new accountsrptfrm();
            accountsrpt.ShowDialog();
        }

        private void newMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newmem = new newmembersrptfrm();
            newmem.ShowDialog();
        }

        private void fullMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fullmem =  new fullmembersrptfrm();

            fullmem.ShowDialog();
        }

        private void detailsbut_Click(object sender, EventArgs e)
        {
            var detailfrm = new detailsfrm(currid);
            detailfrm.ShowDialog();



            using (var context = new DBContext())
            {
                currMember = context.Members.SingleOrDefault(r => r.Id == currid);


            }

            if (currMember != null)
            {
                loadmember();
            }


        }

        private void commentsbut_Click(object sender, EventArgs e)
        {
            var commentfrm = new commentsfrm(currid);
            commentfrm.ShowDialog();



            using (var context = new DBContext())
            {
                currMember = context.Members.SingleOrDefault(r => r.Id == currid);


            }

            if (currMember != null)
            {
                loadmember();
            }


        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void emailSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mailfrm = new Mailfrm();
            mailfrm.ShowDialog();
        }

        private void countMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var crpt = new countfrm();
            crpt.ShowDialog();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var keyfrm = new keyfrm();
            keyfrm.ShowDialog();
        }
    }
}
