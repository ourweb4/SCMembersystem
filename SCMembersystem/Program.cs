// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-08-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="Program.cs" company="Ourweb.net  --  508-829-2005">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// 
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCMembersystem.forms;


namespace SCMembersystem
{
    /// <summary>
    /// Class Program.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()

        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            runprog();
        }

        static void runprog()
        {
            if (validate())
            {
                Application.Run(new mainfrm());
            }
            else
            {
                Application.Run(new keyfrm());
            }
        }

        static public bool validate()
        {
            return true;

        }

    }
}
