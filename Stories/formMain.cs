using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StoryParser;

namespace Stories
{
    public partial class formMain : Form
    {
        private Story story;

        public formMain()
        {
            InitializeComponent();

            #region Event handlers

            this.Load += FormMain_Load;
            mnuExit.Click += MnuExit_Click;
            btnStoryTitleConfirm.Click += BtnStoryTitleConfirm_Click;
            btnStoryTitleCancel.Click += BtnStoryTitleCancel_Click;
            #endregion
        }

        private void BtnStoryTitleCancel_Click(object sender, EventArgs e)
        {
            txtStoryTitle.Text = story.Title;
            txtAuthor.Text = story.Author;
            cboStoryType.Text = story.StoryType;
            txtStoryTitle.Focus();
        }

        private void BtnStoryTitleConfirm_Click(object sender, EventArgs e)
        {
            story.Title = txtStoryTitle.Text;
            story.Author = txtAuthor.Text;
            story.StoryType = cboStoryType.Text;
            txtStoryTitle.Focus();
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            story = new Story();
            
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            InputBox dlg = new InputBox("Add new person's name");
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Subject newPerson = new Subject();
                newPerson.Name = dlg.Result;
                story.Subjects.Add(newPerson);
                lstPersons.DataSource = story.RatedSubjects.OrderByDescending(s => s.Item2);
            }
        }
    }
}
