// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 09-19-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 09-19-2016
// ***********************************************************************
// <copyright file="membersrptfrm.cs" company="Ourweb.net  --  508-829-2005">
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

namespace SCMembersystem.Reports
{
    /// <summary>
    /// Class membersrptfrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class membersrptfrm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="membersrptfrm"/> class.
        /// </summary>
        public membersrptfrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the membersrptfrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void membersrptfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'membersDS.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.membersDS.DataTable1);
            // TODO: This line of code loads data into the 'membersDS.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.membersDS.DataTable1);


            this.reportViewer1.RefreshReport();
        }

        /// <summary>
        /// Handles the Load event of the reportViewer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void reportViewer1_Load(object sender, EventArgs e)
        {
     //       this.membersTableAdapter1.Fill(this.membersDS1.Members);
        }

        private void membersDSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
