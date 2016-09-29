// ***********************************************************************
// Assembly         : SCMembersystem
// Author           : Bill
// Created          : 09-29-2016
//
// Last Modified By : Bill
// Last Modified On : 09-29-2016
// ***********************************************************************
// <copyright file="commentsfrm.cs" company="Ourweb.net  --  508-829-2005">
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
    /// Class commentsfrm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class commentsfrm : Form
    {
        /// <summary>
        /// The currid
        /// </summary>
        private int _currid;
        /// <summary>
        /// The cid
        /// </summary>
        private int cid;
        /// <summary>
        /// The curr member
        /// </summary>
        private Member currMember;
        /// <summary>
        /// The curr comment
        /// </summary>
        private Comment currComment;
        /// <summary>
        /// The comments
        /// </summary>
        private IList<Comment> comments;

        /// <summary>
        /// Initializes a new instance of the <see cref="commentsfrm"/> class.
        /// </summary>
        /// <param name="currid">The currid.</param>
        public commentsfrm(int currid)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the TextChanged event of the textBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Load event of the commentsfrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void commentsfrm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Getmemberdetailses this instance.
        /// </summary>
        private void getmemberdetails()
        {
            using (var context = new DBContext())
            {
                currMember = context.Members.SingleOrDefault(r => r.Id == _currid);


            }

            if (currMember != null)
            {
                getcomments();
                namelab.Text = string.Format("{0},  {1}", currMember.lastname, currMember.firstname);


            }
        }

        /// <summary>
        /// Getcommentses this instance.
        /// </summary>
        private void getcomments()
        {

            using (var context = new DBContext())
            {

                dataGridView1.DataSource = context.Comments
                    .Where(e => e.memberid == _currid)
                    .OrderBy(e => e.cdate)
                    .ToList();

            }
        }

        /// <summary>
        /// Loadcomments this instance.
        /// </summary>
        private void loadcomment()
        {
            cid = currComment.Id;
            commenttxt.Text = currComment.comment;
            dateTimePicker.Value = currComment.cdate;
        }

        /// <summary>
        /// Savecomments this instance.
        /// </summary>
        private void savecomment()
        {
            currComment.Id = cid;
            currComment.memberid = _currid;
            currComment.cdate = dateTimePicker.Value;
            currComment.comment = commenttxt.Text;
        }
        /// <summary>
        /// Handles the RowEnter event of the dataGridView1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Handles the CellEnter event of the dataGridView1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            cid = (int)dataGridView1.Rows[row].Cells[0].Value;
            using (var context = new DBContext())
            {
                currComment = context.Comments.SingleOrDefault(r => r.Id == cid);


            }

            if (currComment != null)
            {
                loadcomment();
            }
        }

        /// <summary>
        /// Handles the RowsRemoved event of the dataGridView1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewRowsRemovedEventArgs"/> instance containing the event data.</param>
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the savebut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void savebut_Click(object sender, EventArgs e)
        {
            var context = new DBContext();
            if (cid!= 0)
            {
                currComment = context.Comments.SingleOrDefault(x => x.Id == cid);
                savecomment();
                context.SaveChanges();
                getcomments();
                loadcomment();
            }
            else
            {
                savecomment();
                cid = context.Comments.Add(currComment).Id;
                context.SaveChanges();
                getcomments();
                loadcomment();

            }
        }

        /// <summary>
        /// Handles the Click event of the newbut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void newbut_Click(object sender, EventArgs e)
        {
            currComment=new Comment();
            currComment.cdate=DateTime.Now;
            currComment.memberid = _currid;
            cid = 0;
            currComment.Id = 0;
            loadcomment();
           
        }
    }
}
