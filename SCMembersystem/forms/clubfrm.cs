// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-19-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 08-19-2016
// ***********************************************************************
// <copyright file="clubfrm.cs" company="Ourweb.net  --  508-829-2005">
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
    /// Class clubfrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class clubfrm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="clubfrm"/> class.
        /// </summary>
        public clubfrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the clubfrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clubfrm_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        /// <summary>
        /// Loaddatas this instance.
        /// </summary>
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

        /// <summary>
        /// Savedatas this instance.
        /// </summary>
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

        /// <summary>
        /// Handles the Click event of the savebut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void savebut_Click(object sender, EventArgs e)
        {
            savedata();
            this.Close();
        }
    }
}
