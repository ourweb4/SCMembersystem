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
    public partial class Committefrm : Form
    {
        public Committefrm()
        {
            InitializeComponent();
        }

        private void Committefrm_Load(object sender, EventArgs e)
        {
            GetLists();
        }

        private void GetLists()
        {
            using (var context = new DBContext())
            {
                committeBindingSource.DataSource = context.Committes

                    .OrderBy(e => e.name)
                    .ToList();

            }
        }
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
