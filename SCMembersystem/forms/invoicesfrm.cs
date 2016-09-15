// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-17-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 09-14-2016
// ***********************************************************************
// <copyright file="invoicesfrm.cs" company="Ourweb.net  --  508-829-2005">
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
using SCMembersystem.Models;

namespace SCMembersystem.forms
{
    /// <summary>
    /// Class invoicesfrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class invoicesfrm : Form
    {
        /// <summary>
        /// The currid
        /// </summary>
        private int currid;
        /// <summary>
        /// The currinvno
        /// </summary>
        private int currinvno;

        /// <summary>
        /// The curr member
        /// </summary>
        private Member currMember;
        /// <summary>
        /// The curr invoice
        /// </summary>
        private Invoice currInvoice = new Invoice();
        /// <summary>
        /// The m invoices
        /// </summary>
        private List<Invoice> mInvoices;
        /// <summary>
        /// The totamt
        /// </summary>
        private decimal totamt;

        /// <summary>
        /// Initializes a new instance of the <see cref="invoicesfrm"/> class.
        /// </summary>
        /// <param name="memberid">The memberid.</param>
        public invoicesfrm(int memberid)
        {
            InitializeComponent();
            currid = memberid;
        }

        /// <summary>
        /// Handles the Load event of the invoicesfrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void invoicesfrm_Load(object sender, EventArgs e)
        {
            getmemberdetails();

        }

        /// <summary>
        /// Loadmembers this instance.
        /// </summary>
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
        /// <summary>
        /// Getmemberdetailses this instance.
        /// </summary>
        private void getmemberdetails()
        {
            using (var context = new DBContext())
            {
                currMember = context.Members.SingleOrDefault(r => r.Id == currid);


            }

            if (currMember != null)
            {
                getinvoices();

                loadmember();
            }
        }

        /// <summary>
        /// Loadinvoices this instance.
        /// </summary>
        private void loadinvoice()
        {
            currinvno = currInvoice.Id;
            amountnumericUpDown.Value = currInvoice.amount;
            paidnumericUpDown.Value = currInvoice.paidamount;
            invdatedateTimePicker.Value = (DateTime) currInvoice.invdate;
            descriptiontxt.Text = currInvoice.description;
        }

        /// <summary>
        /// Saveinvoices this instance.
        /// </summary>
        private void saveinvoice()
        {
            currInvoice.Id = currinvno;
            currInvoice.memberId = currid; //member id
            currInvoice.amount = amountnumericUpDown.Value;
            currInvoice.paidamount = paidnumericUpDown.Value;
            currInvoice.invdate = invdatedateTimePicker.Value;
            currInvoice.description = descriptiontxt.Text;
        }
        /// <summary>
        /// Getinvoiceses this instance.
        /// </summary>
        private void getinvoices()
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

                 double totamt = 0.0;

                foreach (var invoice in mInvoices)
                {
                    totamt += (double) (invoice.amount - invoice.paidamount);

                }
                
                    currMember = context.Members.SingleOrDefault(r => r.Id == currid);


                if (currMember != null) currMember.amtdue = (decimal) totamt;

                context.SaveChanges();
                
            }               
            }


        /// <summary>
        /// Handles the CellContentClick event of the dataGridView1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            currinvno = (int)dataGridView1.Rows[row].Cells[0].Value;
            using (var context = new DBContext())
            {
                currInvoice = context.Invoices.SingleOrDefault(r => r.Id == currinvno);


            }

            if (currInvoice != null)
            {
                loadinvoice();
            }
        }

        /// <summary>
        /// Handles the Click event of the savebut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void savebut_Click(object sender, EventArgs e)
        {

            var context = new DBContext();
            if (currinvno != 0)
            {
                currInvoice = context.Invoices.SingleOrDefault(r => r.Id == currinvno);
                if (currInvoice != null)
                {
                    saveinvoice();
                    context.SaveChanges();
                    loadinvoice();
                    getinvoices();
                    loadmember();
                }
            }
            else
            {
                saveinvoice();
                currinvno = context.Invoices.Add(currInvoice).Id;
                context.SaveChanges();
                loadinvoice();
                getinvoices();
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
            currInvoice = new Invoice();
            currInvoice.Id = 0;
            currinvno = 0;
            currInvoice.memberId = currid;
            currInvoice.invdate=DateTime.Now;
            loadinvoice();

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

            var invid = currinvno;


            var context = new DBContext();
            var invoice = context.Invoices.SingleOrDefault(p => p.Id == invid);

            if (invoice != null)
            {
                context.Invoices.Remove(invoice);
                context.SaveChanges();
                getinvoices();
                currinvno = 0;
                currInvoice = new Invoice();
                loadmember();
                loadinvoice();

            }
        }
    }
}
