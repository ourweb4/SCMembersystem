// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-09-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 09-06-2016
// ***********************************************************************
// <copyright file="MtypeFrm.cs" company="Ourweb.net  --  508-829-2005">
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
    /// Class mtypefrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class mtypefrm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="mtypefrm"/> class.
        /// </summary>
        public mtypefrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the mtypefrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mtypefrm_Load(object sender, EventArgs e)
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
                mtypeBindingSource.DataSource = context.Mtypes 
                    
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
            var hour = hoursUpDown.Value;
            var cost = costUpDown.Value;
            var name = nametxt.Text;
            var ifee = ifeenumericUpDown.Value;
            var days = daysnumericUpDown.Value;
            var once = oncecheckBox.Checked;

   var sale = new Mtype()
            {
              
           hours=(int) hour,
           once=once,
           days=(int) days,
                cost = cost,
                initfee=ifee,
                name=name
            };
            using (var context = new DBContext())
            {
                context.Mtypes.Add(sale);
                context.SaveChanges();
            }
            GetLists();
            oncecheckBox.Checked = false;
            hoursUpDown.Value = 0;
            costUpDown.Value = 0;
            nametxt.Text = "";
            ifeenumericUpDown.Value = 0;
            daysnumericUpDown.Value = 0;
        }

        /// <summary>
        /// Handles the UserDeletingRow event of the MtypesdataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewRowCancelEventArgs"/> instance containing the event data.</param>
        private void MtypesdataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }

            var saleid = (int)e.Row.Cells[0].Value;


            var context = new DBContext();
            var sale = context.Mtypes.SingleOrDefault(p => p.Id == saleid);

            if (sale != null)
            {
                context.Mtypes.Remove(sale);
                context.SaveChanges();
                GetLists();
            }

        }

        /// <summary>
        /// Handles the CellEndEdit event of the MtypesdataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void MtypesdataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                var saleid = (int) MtypesdataGridView.Rows[e.RowIndex].Cells[0].Value;
                var name = (string) MtypesdataGridView.Rows[e.RowIndex].Cells[1].Value;
                var cost = (decimal) MtypesdataGridView.Rows[e.RowIndex].Cells[2].Value;
                var ifee = (decimal)MtypesdataGridView.Rows[e.RowIndex].Cells[3].Value;
                var hours = (int) MtypesdataGridView.Rows[e.RowIndex].Cells[4].Value;
                var days = (int)MtypesdataGridView.Rows[e.RowIndex].Cells[5].Value;
                var once = (bool)MtypesdataGridView.Rows[e.RowIndex].Cells[6].Value;



                var context = new DBContext();
                var sale = context.Mtypes.SingleOrDefault(p => p.Id == saleid);

                if (sale != null)
                {
                    sale.name=name;
                    sale.days = days;
                    sale.once = once;
                    sale.cost = cost;
                    sale.initfee = ifee;
                    sale.hours = hours;
                    context.SaveChanges();
                    GetLists();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MtypesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
