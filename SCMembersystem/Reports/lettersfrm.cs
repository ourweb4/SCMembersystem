// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-23-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 08-22-2016
// ***********************************************************************
// <copyright file="lettersfrm.cs" company="Ourweb.net  --  508-829-2005">
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

namespace SCMembersystem.Reports
{
    /// <summary>
    /// Class lettersfrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class lettersfrm : Form
    {
        /// <summary>
        /// The clubinfo
        /// </summary>
        private Club clubinfo= new Club();
        /// <summary>
        /// Initializes a new instance of the <see cref="lettersfrm"/> class.
        /// </summary>
        public lettersfrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the lettersfrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lettersfrm_Load(object sender, EventArgs e)
        {
            clubinfo.read();
        }

        /// <summary>
        /// Printletters the specified member.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <param name="mtype">The mtype.</param>
        private void printletter(Member member, Mtype mtype)
        {
            
             UPrint pr = new UPrint();

             pr.writeline(clubinfo.clubname);
             pr.writeline(clubinfo.address);
             pr.writeline(string.Format("{0}, {1}  {2}", clubinfo.city, clubinfo.state, clubinfo.zip));
             pr.writeline(string.Format(" Website: {0} Email: {1} ", clubinfo.website, clubinfo.email));
            pr.writeline("");
            pr.writeline("");
            pr.writeline("");
            pr.writeline(DateTime.Today.ToShortDateString());
            pr.writeline("");
            pr.writeline("");
            pr.writeline("");
            pr.writeline(string.Format("{0} {1}", member.firstname, member.lastname));
            pr.writeline(member.address);
            pr.writeline(string.Format("{0}, {1}  {2}", member.city, member.state, member.zip));
            pr.writeline("");
            pr.writeline("");

            if (clubinfo.trackhours)
            {
                pr.writeline(string.Format("Your membership fee of {0:C} is up  for renewal. If you dont turn in your hours tracking card with {1} hours on it, there will  be additional fee of {2:C}", mtype.cost, mtype.hours, clubinfo.hours_percent/100*mtype.cost));
            }
            else
            {
                pr.writeline(string.Format("Your membership fee of {0:C} is up  for renewal", mtype.cost));
            }

            pr.print();

        }
        /// <summary>
        /// Handles the Click event of the printbutton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void printbutton_Click(object sender, EventArgs e)
        {
            var from = fromdateTimePicker.Value.AddDays(-1);
            var to = todateTimePicker.Value.AddDays(1);
            using (var context = new DBContext())
            {
                var members = context.Members.Where(r => r.nextbill > from && r.nextbill < to && r.active)
                    .OrderBy(r => r.lastname)
                    .ToList();         //get members to letter



                foreach (var member in members)
                {
                    var mtypeid = member.mtype;
                    var mtype = context.Mtypes.SingleOrDefault(x => x.Id == mtypeid); // get  fee

                    printletter(member, mtype);

                }









            }
                
        }
    }
}