// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill Banks - office@ourweb.net
// Created          : 08-20-2016
//
// Last Modified By : Bill Banks - office@ourweb.net
// Last Modified On : 08-24-2016
// ***********************************************************************
// <copyright file="UPrint.cs" company="Ourweb.net  --  508-829-2005">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMembersystem
{
    /// <summary>
    /// Class UPrint.
    /// </summary>
    class UPrint
    {
        /// <summary>
        /// The print dialog
        /// </summary>
        private PrintDialog printDialog = new PrintDialog();
        /// <summary>
        /// The print document
        /// </summary>
        private PrintDocument printDocument = new PrintDocument();
        /// <summary>
        /// The font
        /// </summary>
        private Font _font=  new Font("Courier New",12);
        /// <summary>
        /// The countline
        /// </summary>
        private int countline = 0;

        /// <summary>
        /// The lines
        /// </summary>
        private IList<string> lines = new List<string>();

        /// <summary>
        /// Gets or sets the font.
        /// </summary>
        /// <value>The font.</value>
        public Font Font
        {
            get
            {
                return _font;
            }

            set
            {
                _font = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UPrint"/> class.
        /// </summary>
        public UPrint()
        {
            printDialog.Document = printDocument;

        }

        /// <summary>
        /// Writelines the specified line.
        /// </summary>
        /// <param name="line">The line.</param>
        /// <returns>System.Int32.</returns>
        public int writeline(string line)
        {
            lines.Add(line);
            countline++;
            return countline;
        }

        /// <summary>
        /// Resets this instance.
        /// </summary>
        public void reset()
        {
            for (int i = lines.Count - 1; i >= 0; i--)
            {
                lines.RemoveAt(i);
            }
            countline = 0;

        }
        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void print()
        {
            printDocument.PrintPage += PrintDocument_PrintPage;
            printDocument.Print();
        }

        /// <summary>
        /// Handles the PrintPage event of the PrintDocument control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PrintPageEventArgs"/> instance containing the event data.</param>
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            int startx = 10;
            int starty = 10;
            int offset = 0;

            float fonthight = Font.GetHeight();


            foreach (var line in lines)
            {

                graphics.DrawString(line,Font,new SolidBrush(Color.Black), new Point(startx,starty+offset) );
                offset += (int) fonthight + 5;

            }

        }
    }
}
