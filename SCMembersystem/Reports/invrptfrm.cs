// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 09-18-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 09-18-2016
// ***********************************************************************
// <copyright file="invrptfrm.cs" company="Ourweb.net  --  508-829-2005">
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
    /// Class invrptfrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class invrptfrm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="invrptfrm"/> class.
        /// </summary>
        public invrptfrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the invrptfrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void invrptfrm_Load(object sender, EventArgs e)
        {
         

            this.reportViewer1.RefreshReport();
        }

        /// <summary>
        /// Handles the Click event of the reportbut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void reportbut_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1,fromdateTimePicker.Value, todateTimePicker.Value);
        }
    }
}
