// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 09-21-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 09-21-2016
// ***********************************************************************
// <copyright file="accountsrptfrm.cs" company="Ourweb.net  --  508-829-2005">
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
    /// Class accountsrptfrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class accountsrptfrm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="accountsrptfrm"/> class.
        /// </summary>
        public accountsrptfrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the accountsrptfrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void accountsrptfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'membersDS.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.membersDS.DataTable1);

            this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
          
    }
    }
}
