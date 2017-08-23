namespace Stories
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtStoryTitle = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStoryTitleConfirm = new System.Windows.Forms.Button();
            this.btnStoryTitleCancel = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStoryType = new System.Windows.Forms.ComboBox();
            this.tabLists = new System.Windows.Forms.TabControl();
            this.tabPersons = new System.Windows.Forms.TabPage();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnDeletePlace = new System.Windows.Forms.Button();
            this.btnAddPlace = new System.Windows.Forms.Button();
            this.lstPersons = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabLists.SuspendLayout();
            this.tabPersons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabLists, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1128, 531);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtStoryTitle
            // 
            this.txtStoryTitle.Location = new System.Drawing.Point(62, 7);
            this.txtStoryTitle.Name = "txtStoryTitle";
            this.txtStoryTitle.Size = new System.Drawing.Size(282, 20);
            this.txtStoryTitle.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1128, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(92, 22);
            this.mnuExit.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 586);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1128, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboStoryType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.btnStoryTitleCancel);
            this.panel1.Controls.Add(this.btnStoryTitleConfirm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStoryTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 114);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Story title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author:";
            // 
            // btnStoryTitleConfirm
            // 
            this.btnStoryTitleConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStoryTitleConfirm.ForeColor = System.Drawing.Color.Blue;
            this.btnStoryTitleConfirm.Location = new System.Drawing.Point(354, 59);
            this.btnStoryTitleConfirm.Name = "btnStoryTitleConfirm";
            this.btnStoryTitleConfirm.Size = new System.Drawing.Size(19, 21);
            this.btnStoryTitleConfirm.TabIndex = 3;
            this.btnStoryTitleConfirm.Text = "V";
            this.btnStoryTitleConfirm.UseVisualStyleBackColor = true;
            // 
            // btnStoryTitleCancel
            // 
            this.btnStoryTitleCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStoryTitleCancel.ForeColor = System.Drawing.Color.Red;
            this.btnStoryTitleCancel.Location = new System.Drawing.Point(376, 59);
            this.btnStoryTitleCancel.Name = "btnStoryTitleCancel";
            this.btnStoryTitleCancel.Size = new System.Drawing.Size(19, 21);
            this.btnStoryTitleCancel.TabIndex = 4;
            this.btnStoryTitleCancel.Text = "X";
            this.btnStoryTitleCancel.UseVisualStyleBackColor = true;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(62, 33);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(282, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type:";
            // 
            // cboStoryType
            // 
            this.cboStoryType.FormattingEnabled = true;
            this.cboStoryType.Items.AddRange(new object[] {
            "Novel",
            "Short story",
            "Non-fiction",
            "Movie",
            "Animation",
            "Cartoon",
            "Comic book",
            "Play",
            "TV series",
            "Podcast",
            "Audio show",
            "Poem",
            "Fable",
            "Tale",
            "Epos",
            "Mythology"});
            this.cboStoryType.Location = new System.Drawing.Point(62, 59);
            this.cboStoryType.Name = "cboStoryType";
            this.cboStoryType.Size = new System.Drawing.Size(282, 21);
            this.cboStoryType.TabIndex = 9;
            // 
            // tabLists
            // 
            this.tabLists.Controls.Add(this.tabDetails);
            this.tabLists.Controls.Add(this.tabPersons);
            this.tabLists.Controls.Add(this.tabEvents);
            this.tabLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLists.Location = new System.Drawing.Point(567, 3);
            this.tabLists.Name = "tabLists";
            this.tableLayoutPanel1.SetRowSpan(this.tabLists, 3);
            this.tabLists.SelectedIndex = 0;
            this.tabLists.Size = new System.Drawing.Size(558, 525);
            this.tabLists.TabIndex = 2;
            // 
            // tabPersons
            // 
            this.tabPersons.Controls.Add(this.lstPersons);
            this.tabPersons.Location = new System.Drawing.Point(4, 22);
            this.tabPersons.Name = "tabPersons";
            this.tabPersons.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersons.Size = new System.Drawing.Size(550, 499);
            this.tabPersons.TabIndex = 0;
            this.tabPersons.Text = "Persons";
            this.tabPersons.UseVisualStyleBackColor = true;
            // 
            // tabEvents
            // 
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(400, 396);
            this.tabEvents.TabIndex = 1;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 203);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(558, 325);
            this.listBox1.TabIndex = 3;
            // 
            // tabDetails
            // 
            this.tabDetails.Location = new System.Drawing.Point(4, 22);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(487, 405);
            this.tabDetails.TabIndex = 2;
            this.tabDetails.Text = "Details";
            this.tabDetails.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeletePlace);
            this.panel2.Controls.Add(this.btnAddPlace);
            this.panel2.Controls.Add(this.btnDeletePerson);
            this.panel2.Controls.Add(this.btnAddPerson);
            this.panel2.Controls.Add(this.btnDeleteEvent);
            this.panel2.Controls.Add(this.btnAddEvent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 74);
            this.panel2.TabIndex = 4;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(9, 9);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(83, 23);
            this.btnAddEvent.TabIndex = 0;
            this.btnAddEvent.Text = "Add event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(9, 38);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(83, 23);
            this.btnDeleteEvent.TabIndex = 1;
            this.btnDeleteEvent.Text = "Delete event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Location = new System.Drawing.Point(98, 38);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(95, 23);
            this.btnDeletePerson.TabIndex = 3;
            this.btnDeletePerson.Text = "Delete person";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(98, 9);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(95, 23);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.Text = "Add person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnDeletePlace
            // 
            this.btnDeletePlace.Location = new System.Drawing.Point(199, 38);
            this.btnDeletePlace.Name = "btnDeletePlace";
            this.btnDeletePlace.Size = new System.Drawing.Size(80, 23);
            this.btnDeletePlace.TabIndex = 5;
            this.btnDeletePlace.Text = "Delete place";
            this.btnDeletePlace.UseVisualStyleBackColor = true;
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.Location = new System.Drawing.Point(199, 9);
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Size = new System.Drawing.Size(80, 23);
            this.btnAddPlace.TabIndex = 4;
            this.btnAddPlace.Text = "Add place";
            this.btnAddPlace.UseVisualStyleBackColor = true;
            // 
            // lstPersons
            // 
            this.lstPersons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPersons.FormattingEnabled = true;
            this.lstPersons.Location = new System.Drawing.Point(6, 11);
            this.lstPersons.Name = "lstPersons";
            this.lstPersons.Size = new System.Drawing.Size(538, 199);
            this.lstPersons.TabIndex = 0;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 608);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "Stories";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabLists.ResumeLayout(false);
            this.tabPersons.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtStoryTitle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStoryTitleCancel;
        private System.Windows.Forms.Button btnStoryTitleConfirm;
        private System.Windows.Forms.ComboBox cboStoryType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TabControl tabLists;
        private System.Windows.Forms.TabPage tabPersons;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeletePlace;
        private System.Windows.Forms.Button btnAddPlace;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.ListBox lstPersons;
    }
}

