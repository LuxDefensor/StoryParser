using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoryParser;

namespace Stories
{
    public partial class formStory : Form
    {
        private Story _currentStory;
        private string _currentFileName;
        private bool _unsaved = false;
        private bool _loaded = false;

        public formStory()
        {
            InitializeComponent();
            #region Event handlers
            this.Load += FormStory_Load;
            menuExit.Click += MenuExit_Click;
            menuOpen.Click += MenuOpen_Click;
            menuLoadSource.Click += MenuLoadSource_Click;
            btnSplitOrientation.Click += BtnSplitOrientation_Click;
            #endregion
        }

        private void MenuLoadSource_Click(object sender, EventArgs e)
        {
            // TODO: Add 'Are you sure?' question
            // TODO: Finish this method
            if (_loaded)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Select file with the story";
                dlg.Filter = "Text files|*.txt";
                dlg.InitialDirectory = Application.ExecutablePath;
                dlg.RestoreDirectory = true;
                dlg.Multiselect = false;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {

                }
            }
            else
            {
                NewStory();
            }
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            DialogResult response;
            if (_loaded)
            {
                if (_unsaved)
                {
                    response = MessageBox.Show("The current story has unsaved changes\nDo you want to save it now?",
                        "Before you open another story:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (response == DialogResult.Yes)
                    {
                        SaveStory();

                    }
                }
            }
            //TODO: Finish this method
        }

        private void BtnSplitOrientation_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            DialogResult response;
            if (!_unsaved)
            {
                response = MessageBox.Show("The current story has unsaved changes\nDo you want to save it now?",
                                    "Before you quit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (response)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        SaveStory();
                        break;
                    case DialogResult.No:
                        //proceed without saving
                        break;
                }
            }
            Application.Exit();
        }

        private void SaveStory()
        {
            _currentStory.Save(_currentFileName);
            _unsaved = false;
        }

        private void SaveStoryAs()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Save story as a new file";
            dlg.Filter = "Text files|*.txt";
            dlg.AddExtension = true;
            dlg.InitialDirectory = Application.ExecutablePath;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _currentFileName = dlg.FileName;
                SaveStory();
            }
        }

        private void LoadStory()
        {
            throw new NotImplementedException();
        }

        private void NewStory()
        {
            DialogResult response;
            if (_loaded)
            {
                if (_unsaved)
                {
                    response = MessageBox.Show("The current story has unsaved changes\nDo you want to save it now?",
                        "Before you create another story:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (response)
                    {
                        case DialogResult.Yes:
                            SaveStory();
                            break;
                        case DialogResult.No:
                            // proceed without saving
                            ClearStory();
                            break;
                    }
                }
            }
            _loaded = true;
            _unsaved = true;
            _currentStory = new Story();
            // TODO: New story initialization
        }

        private void ClearStory()
        {
            _currentStory.Erase();
            _currentStory = null;
            _loaded = false;
            _unsaved = false;
        }


        private void FormStory_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
