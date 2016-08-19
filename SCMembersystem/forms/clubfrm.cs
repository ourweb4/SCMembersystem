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
    public partial class clubfrm : Form
    {
        public clubfrm()
        {
            InitializeComponent();
        }

        private void clubfrm_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            using (var context = new DBContext())
            {
                var club = context.Clubs.SingleOrDefault(r => r.Id == 1);
                if (club != null)
                {
                    trackcheckBox.Checked = club.trackhours;
                    percentnumericUpDown.Value = club.hours_percent;
                    phonetxt.Text = club.phone;
                    nametxt.Text = club.clubname;
                    addresstxt.Text = club.address;
                    citytxt.Text = club.city;
                    statetxt.Text = club.state;
                    ziptxt.Text = club.zip;
                    websitetxt.Text = club.website;
                    emailtxt.Text = club.email;
                }
            }
        }

        private void savedata()
        {
            
            using (var context = new DBContext())
            {
                var club = context.Clubs.SingleOrDefault(r => r.Id == 1);
                if (club == null)
                {
                     club = new Club();
                    context.Clubs.Add(club);

                }



                club.trackhours = trackcheckBox.Checked;
                club.hours_percent = (int)percentnumericUpDown.Value;
                club.phone = phonetxt.Text;
                club.clubname = nametxt.Text;
                club.address = addresstxt.Text;
                club.city = citytxt.Text;
                club.state = statetxt.Text;
                club.zip = ziptxt.Text;
                club.website = websitetxt.Text;
                club.email = emailtxt.Text;
                club.Id = 1;

                context.SaveChanges();
            }


        }

        private void savebut_Click(object sender, EventArgs e)
        {
            savedata();
            this.Close();
        }
    }
}
