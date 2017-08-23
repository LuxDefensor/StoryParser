using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stories
{
    public partial class InputBox : Form
    {
        public InputBox(string title)
        {
            
            InitializeComponent();
            this.Text = title;

        }

        public InputBox():this("Input new value")
        {

        }

        public string Result
        {
            get
            {
                return txtInputBox.Text;
            }
        }
    }
}
