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
    }
}
