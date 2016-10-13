using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SCMembersystem.forms
{
    public partial class keyfrm : Form
    {
        //WyIyNzciLCJ2K2hRY2lhMk81QTZJaW5vakZvUE0rQTZpZC9nS0pPQjlTTGFSOXc0Il0=
        private string Auth = "WyIyNzciLCJ2K2hRY2lhMk81QTZJaW5vakZvUE0rQTZpZC9nS0pPQjlTTGFSOXc0Il0=";


        private bool registarx()
        {
            return true;
        }

        public keyfrm()
        {
            InitializeComponent();

                        keytxt.Text = Properties.Settings.Default.lickey;
        }

        private void keyfrm_Load(object sender, EventArgs e)
        {
            
        }

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
