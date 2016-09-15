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
using SKGL;

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
            Application.Run(new mainfrm());

        }

        static public bool validate()
        {
            var RSAPublicKey = "<RSAKeyValue><Modulus>sGbvxwdlDbqFXOMlVUnAF5ew0t0WpPW7rFpI5jHQOFkht/326dvh7t74RYeMpjy357NljouhpTLA3a6idnn4j6c3jmPWBkjZndGsPL4Bqm+fwE48nKpGPjkj4q/yzT4tHXBTyvaBjA8bVoCTnu+LiC4XEaLZRThGzIn5KQXKCigg6tQRy0GXE13XYFVz/x1mjFbT9/7dS8p85n8BuwlY5JvuBIQkKhuCNFfrUxBWyu87CFnXWjIupCD2VO/GbxaCvzrRjLZjAngLCMtZbYBALksqGPgTUN7ZM24XbPWyLtKPaXF2i4XRR9u6eTj5BfnLbKAU5PIVfjIS+vNYYogteQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

            var keyInfo = new KeyInformation().LoadFromFile("license.txt");

            if (keyInfo.HasValidSignature(RSAPublicKey, 30)
                       .IsOnRightMachine()
                       .IsValid())
            {
                // the signature is correct so
                // the program can now launch
                return true;
            }
            else
            {
                var machineCode = SKGL.SKM.getMachineCode(SKGL.SKM.getSHA1);
                keyInfo = SKGL.SKM.KeyActivation("3", "2", "751963", "MJAWL-ITPVZ-LKGAN-DLJDN", machineCode, secure: true, signMid: true, signDate: true);

                if (keyInfo.HasValidSignature(RSAPublicKey)
                           .IsOnRightMachine()
                           .IsValid())
                {
                    // the signature is correct and the key is valid.
                    // save to file.
                    keyInfo.SaveToFile("license.txt");

                    // the program can now launch
                    return true;
                }
                return false;
            }

        }
    }
}
