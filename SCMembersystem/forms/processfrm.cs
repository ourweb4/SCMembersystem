// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 09-06-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 09-07-2016
// ***********************************************************************
// <copyright file="processfrm.cs" company="Ourweb.net  --  508-829-2005">
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
    /// Class processfrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class processfrm : Form
    {
        /// <summary>
        /// The clubinfo
        /// </summary>
        private Club clubinfo = new Club();
        /// <summary>
        /// Initializes a new instance of the <see cref="processfrm"/> class.
        /// </summary>
        public processfrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the processfrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void processfrm_Load(object sender, EventArgs e)
        {
            clubinfo.read();
        }

        /// <summary>
        /// Handles the Click event of the processbut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void processbut_Click(object sender, EventArgs e)
        {
            var from = fromdateTimePicker.Value.AddDays(-1);
            var to = todateTimePicker.Value.AddDays(1);
            using (var context = new DBContext())
            {
                var members = context.Members.Where(r => r.nextbill > from && r.nextbill < to && r.active)
                    .OrderBy(r => r.lastname)
                    .ToList();         //get members to letter

                var count = 0;

                foreach (var member in members)
                {
                    runninglab.Text=String.Format("Making {0} invoices",++count);
                    var mtypeid = member.mtype;
                    var mtype = context.Mtypes.SingleOrDefault(x => x.Id == mtypeid); // get  fee
                    if (mtype != null)
                    {
                        var amt = mtype.cost;
                        var minhours = mtype.hours;
                        var days = mtype.days;
                        if (!mtype.once)
                        {
                            var crinv = new Invoice();
                            crinv.memberId = member.Id;
                            crinv.invdate=DateTime.Now;
                            string description;
                            decimal tot;

                            if (hourcheckBox.Checked && clubinfo.trackhours && member.hours > minhours - 1)
                            {
                                 tot = amt + (amt*clubinfo.hours_percent);
                                 description = string.Format("Membership Type: {0} Plus an inactive fee",
                                    mtype.name);
                            }
                            else
                            {
                                 tot = amt;
                                 description = string.Format("Membership Type: {0} ",
                                    mtype.name);
                            }
                            crinv.amount = tot;
                            crinv.description = description;
                            context.Invoices.Add(crinv);
                            member.amtdue += tot;
                            member.nextbill = member.nextbill.AddDays(days);
                            context.SaveChanges();
                        }

                    }
                }
               
            }
        }
    }
}
