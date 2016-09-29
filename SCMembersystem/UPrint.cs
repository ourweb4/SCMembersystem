// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill
// Created          : 08-20-2016
//
// Last Modified By : Bill
// Last Modified On : 09-25-2016
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
        private int _leftmargin = 10;

        /// <summary>
        /// The topmargin
        /// </summary>
        private int _topmargin = 10;
        /// <summary>
        /// The linespacing
        /// </summary>
        private int _linespacing = 5;

        /// <summary>
        /// Gets or sets the leftmargin.
        /// </summary>
        /// <value>The leftmargin.</value>
        public int leftmargin
        {
            get
            {
                return _leftmargin;
                
            }
            set
            {
                _leftmargin = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the topmargin.
        /// </summary>
        /// <value>The topmargin.</value>
        public int topmargin
        {
            get
            {
                return _topmargin;
                
            }
            set
            {
                _topmargin = value; 
                
            }
        }
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
        /// Gets or sets the linespacing.
        /// </summary>
        /// <value>The linespacing.</value>
        public int Linespacing
        {
            get
            {
                return _linespacing;
            }

            set
            {
                _linespacing = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UPrint" /> class.
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
        /// <param name="e">The <see cref="PrintPageEventArgs" /> instance containing the event data.</param>
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            int startx = _leftmargin;
            int starty = _topmargin;
            int offset = 0;

            float fonthight = Font.GetHeight();


            foreach (var line in lines)
            {

                graphics.DrawString(line,Font,new SolidBrush(Color.Black), new Point(startx,starty+offset) );
                offset += (int) fonthight + _linespacing;

            }

        }
    }
}
