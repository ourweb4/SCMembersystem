// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill
// Created          : 09-28-2016
//
// Last Modified By : Bill
// Last Modified On : 09-29-2016
// ***********************************************************************
// <copyright file="detailsfrm.cs" company="Ourweb.net  --  508-829-2005">
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
using SCMembersystem.Migrations;
using SCMembersystem.Models;

namespace SCMembersystem.forms
{
    /// <summary>
    /// Class detailsfrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class detailsfrm : Form
    {
        /// <summary>
        /// The currid
        /// </summary>
        private int _currid;
        /// <summary>
        /// The curr member
        /// </summary>
        private Member currMember;
        /// <summary>
        /// Initializes a new instance of the <see cref="detailsfrm"/> class.
        /// </summary>
        /// <param name="currid">The currid.</param>
        public detailsfrm(int currid)
        {
            InitializeComponent();
            _currid = currid;

            using (var context = new DBContext())
            {
                currMember = context.Members.SingleOrDefault(r => r.Id == currid);


            }

            if (currMember != null)
            {
                loadmember();
                namelab.Text = string.Format("{0},  {1}", currMember.lastname, currMember.firstname);
            }
        }

        /// <summary>
        /// Loadmembers this instance.
        /// </summary>
        private void loadmember()
        {
            keycardtxt.Text = currMember.keycard;
            keymaintxt.Text = currMember.keymain;
            keyrangetxt.Text = currMember.keyrange;
            keymaincheckBox.Checked = currMember.mainactive;
            keyrangecheckBox.Checked = currMember.rangeactive;
            fobtxt.Text = currMember.fob;
            fobmaintxt.Text = currMember.fobmain;
            fobrangetxt.Text = currMember.fobrange;
            fobmaincheckBox.Checked = currMember.fobmainactive;
            fobrangecheckBox.Checked = currMember.fobrangractive;
        }

        /// <summary>
        /// Savemembers this instance.
        /// </summary>
        private void savemember()
        {
            currMember.keycard = keycardtxt.Text;
            currMember.keyrange = keyrangetxt.Text;
            currMember.keymain = keymaintxt.Text;
            currMember.mainactive = keymaincheckBox.Checked;
            currMember.fob = fobtxt.Text;
            currMember.fobmain = fobmaintxt.Text;
            currMember.fobrange = fobrangecheckBox.Text;
            currMember.fobmainactive = fobmaincheckBox.Checked;
            currMember.fobrangractive = fobrangecheckBox.Checked;
        }
        /// <summary>
        /// Handles the Click event of the savebut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void savebut_Click(object sender, EventArgs e)
        {
            var context = new DBContext();
            if (_currid != 0)
            {
                currMember = context.Members.SingleOrDefault(r => r.Id == _currid);
                if (currMember != null)
                {
                    savemember();
                    context.SaveChanges();
                    loadmember();
                    
                }
            }
            this.Close();

        }

        /// <summary>
        /// Handles the Load event of the detailsfrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void detailsfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
