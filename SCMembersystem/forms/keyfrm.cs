// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill
// Created          : 10-11-2016
//
// Last Modified By : Bill
// Last Modified On : 10-26-2016
// ***********************************************************************
// <copyright file="keyfrm.cs" company="Ourweb.net  --  508-829-2005">
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
using SKM.V3;
using SKM.V3.Methods;
using SKM.V3.Models;

namespace SCMembersystem.forms
{
    /// <summary>
    /// Class keyfrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class keyfrm : Form
    {
        //WyIyNzciLCJ2K2hRY2lhMk81QTZJaW5vakZvUE0rQTZpZC9nS0pPQjlTTGFSOXc0Il0=

        //WyIyODEiLCIwQ1pGMVVWTzdCc3NYV1RYeUl6Z0tOUHJETklST1lNWUNpeEdFWnhLIl0=
        /// <summary>
        /// The authentication
        /// </summary>
        private string Auth = "WyIyODEiLCIwQ1pGMVVWTzdCc3NYV1RYeUl6Z0tOUHJETklST1lNWUNpeEdFWnhLIl0=";


        /// <summary>
        /// Registarxes this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool registarx()
        {
          
var result = Key.Activate(token: Auth, parameters: new ActivateModel()
{
    Key = Properties.Settings.Default.lickey,
    ProductId = 3526,
    Sign = true,
    MachineCode = SKGL.SKM.getMachineCode(SKGL.SKM.getSHA1)
        });

            if (result == null || result.Result == ResultType.Error)
            {
                // an error occured or the key is invalid or it cannot be activated
                // (eg. the limit of activated devices was achieved)
                return false;
            }
            var lic = result.LicenseKey;
            lic.SaveToFile("lic.key");
            displayexpire(lic.DaysLeft(), lic.Expires);
            return true;
// everything went fine if we are here!
        }

        /// <summary>
        /// Displayexpires the specified days.
        /// </summary>
        /// <param name="days">The days.</param>
        /// <param name="datex">The datex.</param>
        private void displayexpire(int days, DateTime datex)
        {
            dayslab.Text=String.Format("Your  key has {0} days and set to end on {1}",days, datex);
            
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="keyfrm"/> class.
        /// </summary>
        public keyfrm()
        {
            InitializeComponent();

                        keytxt.Text = Properties.Settings.Default.lickey;
        }

        /// <summary>
        /// Handles the Load event of the keyfrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void keyfrm_Load(object sender, EventArgs e)
        {
            var lic = new LicenseKey().LoadFromFile("lic.key");
            displayexpire(lic.DaysLeft(), lic.Expires);
        }

        /// <summary>
        /// Handles the Click event of the savebut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void savebut_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.lickey = keytxt.Text;
            Properties.Settings.Default.Save();
            if (registarx())
            {
                messkey.Text = "Your key is valid. Please close the app and restart";
            }
            else
             {
                messkey.Text = "Your key is invalid.";

            }
        }
    }
}
