// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-10-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 08-10-2016
// ***********************************************************************
// <copyright file="Committefrm.cs" company="Ourweb.net  --  508-829-2005">
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
    /// Class Committefrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Committefrm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Committefrm"/> class.
        /// </summary>
        public Committefrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Committefrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Committefrm_Load(object sender, EventArgs e)
        {
            GetLists();
        }

        /// <summary>
        /// Gets the lists.
        /// </summary>
        private void GetLists()
        {
            using (var context = new DBContext())
            {
                committeBindingSource.DataSource = context.Committes

                    .OrderBy(e => e.name)
                    .ToList();

            }
        }
        /// <summary>
        /// Handles the Click event of the addbut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addbut_Click(object sender, EventArgs e)
        {
            var name = nametxt.Text;


            var sale = new Committe()
            {
                name = name
            };
            using (var context = new DBContext())
            {
                context.Committes.Add(sale);
                context.SaveChanges();
            }
            GetLists();
        }

        /// <summary>
        /// Handles the UserDeletingRow event of the CommittedataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewRowCancelEventArgs"/> instance containing the event data.</param>
        private void CommittedataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }

            var saleid = (int)e.Row.Cells[0].Value;


            var context = new DBContext();
            var sale = context.Committes.SingleOrDefault(p => p.Id == saleid);

            if (sale != null)
            {
                context.Committes.Remove(sale);
                context.SaveChanges();
                GetLists();
            }
        }

        /// <summary>
        /// Handles the CellEndEdit event of the CommittedataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void CommittedataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                var saleid = (int)CommittedataGridView.Rows[e.RowIndex].Cells[0].Value;
                var name = (string)CommittedataGridView.Rows[e.RowIndex].Cells[1].Value;
                
                var context = new DBContext();
                var sale = context.Committes.SingleOrDefault(p => p.Id == saleid);

                if (sale != null)
                {
                    sale.name = name;
                    context.SaveChanges();
                    GetLists();
                }
            }
        }
    }
    
}
