﻿using System;
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
    public partial class mtypefrm : Form
    {
        public mtypefrm()
        {
            InitializeComponent();
        }

        private void mtypefrm_Load(object sender, EventArgs e)
        {
            GetLists();
        }


        private void GetLists()
        {
            using (var context = new DBContext())
            {
                mtypeBindingSource.DataSource = context.Mtypes 
                    
                    .OrderBy(e => e.name)
                    .ToList();
                
            }
        }

        private void addbut_Click(object sender, EventArgs e)
        {
            var hour = hoursUpDown.Value;
            var cost = costUpDown.Value;
            var name = nametxt.Text;

   var sale = new Mtype()
            {
              
           hours=(int) hour,
                cost = cost,
                name=name
            };
            using (var context = new DBContext())
            {
                context.Mtypes.Add(sale);
                context.SaveChanges();
            }
            GetLists();
        }

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

        private void MtypesdataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                var saleid = (int) MtypesdataGridView.Rows[e.RowIndex].Cells[0].Value;
                var name = (string) MtypesdataGridView.Rows[e.RowIndex].Cells[1].Value;
                var cost = (decimal) MtypesdataGridView.Rows[e.RowIndex].Cells[2].Value;
                var hours = (int) MtypesdataGridView.Rows[e.RowIndex].Cells[3].Value;

                var context = new DBContext();
                var sale = context.Mtypes.SingleOrDefault(p => p.Id == saleid);

                if (sale != null)
                {
                    sale.name=name;
                    sale.cost = cost;
                    sale.hours = hours;
                    context.SaveChanges();
                    GetLists();
                }
            }
        }
    }
}
