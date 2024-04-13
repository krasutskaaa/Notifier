namespace Notifier
{
    partial class dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            todayTasksPanel = new Panel();
            todayTasksPictureBox = new PictureBox();
            todayTasksTitleLabel = new Label();
            todayTasksAmountLabel = new Label();
            scheduledTasksPanel = new Panel();
            scheduledTasksPictureBox = new PictureBox();
            scheduledTasksTitleLabel = new Label();
            scheduledTasksAmountLabel = new Label();
            importantTasksPanel = new Panel();
            importantTasksPictureBox = new PictureBox();
            importantTasksTitleLabel = new Label();
            importantTasksAmountLabel = new Label();
            allTasksPanel = new Panel();
            allTasksPictureBox = new PictureBox();
            allTasksTitleLabel = new Label();
            allTasksAmountLabel = new Label();
            doneTasksPanel = new Panel();
            doneTasksPictureBox = new PictureBox();
            doneTasksTitleLabel = new Label();
            doneTasksAmountLabel = new Label();
            searchTextBox = new TextBox();
            searchPanel = new Panel();
            searchPictureBox = new PictureBox();
            addListButton = new Button();
            notificationButton = new Button();
            myListsLabel = new Label();
            listsListBox = new ListBox();
            pictureBox1 = new PictureBox();
            todayTasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)todayTasksPictureBox).BeginInit();
            scheduledTasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scheduledTasksPictureBox).BeginInit();
            importantTasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)importantTasksPictureBox).BeginInit();
            allTasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allTasksPictureBox).BeginInit();
            doneTasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doneTasksPictureBox).BeginInit();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // todayTasksPanel
            // 
            todayTasksPanel.BackColor = SystemColors.MenuBar;
            todayTasksPanel.Controls.Add(todayTasksPictureBox);
            todayTasksPanel.Controls.Add(todayTasksTitleLabel);
            todayTasksPanel.Controls.Add(todayTasksAmountLabel);
            todayTasksPanel.Location = new Point(12, 73);
            todayTasksPanel.Name = "todayTasksPanel";
            todayTasksPanel.Size = new Size(168, 71);
            todayTasksPanel.TabIndex = 0;
            // 
            // todayTasksPictureBox
            // 
            todayTasksPictureBox.Image = Properties.Resources.calender;
            todayTasksPictureBox.InitialImage = null;
            todayTasksPictureBox.Location = new Point(13, 3);
            todayTasksPictureBox.Name = "todayTasksPictureBox";
            todayTasksPictureBox.Size = new Size(44, 35);
            todayTasksPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            todayTasksPictureBox.TabIndex = 2;
            todayTasksPictureBox.TabStop = false;
            // 
            // todayTasksTitleLabel
            // 
            todayTasksTitleLabel.AutoSize = true;
            todayTasksTitleLabel.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            todayTasksTitleLabel.ForeColor = Color.Black;
            todayTasksTitleLabel.Location = new Point(11, 41);
            todayTasksTitleLabel.Name = "todayTasksTitleLabel";
            todayTasksTitleLabel.Size = new Size(69, 25);
            todayTasksTitleLabel.TabIndex = 1;
            todayTasksTitleLabel.Text = "Today";
            // 
            // todayTasksAmountLabel
            // 
            todayTasksAmountLabel.AutoSize = true;
            todayTasksAmountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            todayTasksAmountLabel.Location = new Point(131, 13);
            todayTasksAmountLabel.Name = "todayTasksAmountLabel";
            todayTasksAmountLabel.Size = new Size(24, 25);
            todayTasksAmountLabel.TabIndex = 0;
            todayTasksAmountLabel.Text = "0";
            // 
            // scheduledTasksPanel
            // 
            scheduledTasksPanel.BackColor = SystemColors.MenuBar;
            scheduledTasksPanel.Controls.Add(scheduledTasksPictureBox);
            scheduledTasksPanel.Controls.Add(scheduledTasksTitleLabel);
            scheduledTasksPanel.Controls.Add(scheduledTasksAmountLabel);
            scheduledTasksPanel.Location = new Point(196, 73);
            scheduledTasksPanel.Name = "scheduledTasksPanel";
            scheduledTasksPanel.Size = new Size(178, 71);
            scheduledTasksPanel.TabIndex = 0;
            // 
            // scheduledTasksPictureBox
            // 
            scheduledTasksPictureBox.Image = Properties.Resources.today;
            scheduledTasksPictureBox.InitialImage = null;
            scheduledTasksPictureBox.Location = new Point(13, 3);
            scheduledTasksPictureBox.Name = "scheduledTasksPictureBox";
            scheduledTasksPictureBox.Size = new Size(44, 38);
            scheduledTasksPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            scheduledTasksPictureBox.TabIndex = 2;
            scheduledTasksPictureBox.TabStop = false;
            // 
            // scheduledTasksTitleLabel
            // 
            scheduledTasksTitleLabel.AutoSize = true;
            scheduledTasksTitleLabel.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scheduledTasksTitleLabel.ForeColor = Color.Black;
            scheduledTasksTitleLabel.Location = new Point(12, 46);
            scheduledTasksTitleLabel.Name = "scheduledTasksTitleLabel";
            scheduledTasksTitleLabel.Size = new Size(108, 25);
            scheduledTasksTitleLabel.TabIndex = 1;
            scheduledTasksTitleLabel.Text = "Scheduled";
            // 
            // scheduledTasksAmountLabel
            // 
            scheduledTasksAmountLabel.AutoSize = true;
            scheduledTasksAmountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            scheduledTasksAmountLabel.Location = new Point(139, 13);
            scheduledTasksAmountLabel.Name = "scheduledTasksAmountLabel";
            scheduledTasksAmountLabel.Size = new Size(24, 25);
            scheduledTasksAmountLabel.TabIndex = 0;
            scheduledTasksAmountLabel.Text = "0";
            // 
            // importantTasksPanel
            // 
            importantTasksPanel.BackColor = SystemColors.MenuBar;
            importantTasksPanel.Controls.Add(importantTasksPictureBox);
            importantTasksPanel.Controls.Add(importantTasksTitleLabel);
            importantTasksPanel.Controls.Add(importantTasksAmountLabel);
            importantTasksPanel.Location = new Point(196, 150);
            importantTasksPanel.Name = "importantTasksPanel";
            importantTasksPanel.Size = new Size(178, 76);
            importantTasksPanel.TabIndex = 0;
            // 
            // importantTasksPictureBox
            // 
            importantTasksPictureBox.Image = Properties.Resources.star;
            importantTasksPictureBox.InitialImage = null;
            importantTasksPictureBox.Location = new Point(13, 4);
            importantTasksPictureBox.Name = "importantTasksPictureBox";
            importantTasksPictureBox.Size = new Size(44, 35);
            importantTasksPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            importantTasksPictureBox.TabIndex = 2;
            importantTasksPictureBox.TabStop = false;
            // 
            // importantTasksTitleLabel
            // 
            importantTasksTitleLabel.AutoSize = true;
            importantTasksTitleLabel.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            importantTasksTitleLabel.ForeColor = Color.Black;
            importantTasksTitleLabel.Location = new Point(13, 42);
            importantTasksTitleLabel.Name = "importantTasksTitleLabel";
            importantTasksTitleLabel.Size = new Size(107, 25);
            importantTasksTitleLabel.TabIndex = 1;
            importantTasksTitleLabel.Text = "Important";
            // 
            // importantTasksAmountLabel
            // 
            importantTasksAmountLabel.AutoSize = true;
            importantTasksAmountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            importantTasksAmountLabel.Location = new Point(139, 14);
            importantTasksAmountLabel.Name = "importantTasksAmountLabel";
            importantTasksAmountLabel.Size = new Size(24, 25);
            importantTasksAmountLabel.TabIndex = 0;
            importantTasksAmountLabel.Text = "0";
            // 
            // allTasksPanel
            // 
            allTasksPanel.BackColor = SystemColors.MenuBar;
            allTasksPanel.Controls.Add(allTasksPictureBox);
            allTasksPanel.Controls.Add(allTasksTitleLabel);
            allTasksPanel.Controls.Add(allTasksAmountLabel);
            allTasksPanel.Location = new Point(12, 150);
            allTasksPanel.Name = "allTasksPanel";
            allTasksPanel.Size = new Size(168, 76);
            allTasksPanel.TabIndex = 0;
            // 
            // allTasksPictureBox
            // 
            allTasksPictureBox.Image = Properties.Resources.box;
            allTasksPictureBox.InitialImage = null;
            allTasksPictureBox.Location = new Point(11, 4);
            allTasksPictureBox.Name = "allTasksPictureBox";
            allTasksPictureBox.Size = new Size(44, 44);
            allTasksPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            allTasksPictureBox.TabIndex = 2;
            allTasksPictureBox.TabStop = false;
            // 
            // allTasksTitleLabel
            // 
            allTasksTitleLabel.AutoSize = true;
            allTasksTitleLabel.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            allTasksTitleLabel.ForeColor = Color.Black;
            allTasksTitleLabel.Location = new Point(13, 51);
            allTasksTitleLabel.Name = "allTasksTitleLabel";
            allTasksTitleLabel.Size = new Size(37, 25);
            allTasksTitleLabel.TabIndex = 1;
            allTasksTitleLabel.Text = "All";
            // 
            // allTasksAmountLabel
            // 
            allTasksAmountLabel.AutoSize = true;
            allTasksAmountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            allTasksAmountLabel.Location = new Point(131, 14);
            allTasksAmountLabel.Name = "allTasksAmountLabel";
            allTasksAmountLabel.Size = new Size(24, 25);
            allTasksAmountLabel.TabIndex = 0;
            allTasksAmountLabel.Text = "0";
            // 
            // doneTasksPanel
            // 
            doneTasksPanel.BackColor = SystemColors.MenuBar;
            doneTasksPanel.Controls.Add(doneTasksPictureBox);
            doneTasksPanel.Controls.Add(doneTasksTitleLabel);
            doneTasksPanel.Controls.Add(doneTasksAmountLabel);
            doneTasksPanel.Location = new Point(12, 232);
            doneTasksPanel.Name = "doneTasksPanel";
            doneTasksPanel.Size = new Size(168, 78);
            doneTasksPanel.TabIndex = 0;
            // 
            // doneTasksPictureBox
            // 
            doneTasksPictureBox.Image = Properties.Resources.check_mark;
            doneTasksPictureBox.InitialImage = null;
            doneTasksPictureBox.Location = new Point(13, 13);
            doneTasksPictureBox.Name = "doneTasksPictureBox";
            doneTasksPictureBox.Size = new Size(44, 35);
            doneTasksPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            doneTasksPictureBox.TabIndex = 2;
            doneTasksPictureBox.TabStop = false;
            // 
            // doneTasksTitleLabel
            // 
            doneTasksTitleLabel.AutoSize = true;
            doneTasksTitleLabel.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doneTasksTitleLabel.ForeColor = Color.Black;
            doneTasksTitleLabel.Location = new Point(11, 51);
            doneTasksTitleLabel.Name = "doneTasksTitleLabel";
            doneTasksTitleLabel.Size = new Size(61, 25);
            doneTasksTitleLabel.TabIndex = 1;
            doneTasksTitleLabel.Text = "Done";
            // 
            // doneTasksAmountLabel
            // 
            doneTasksAmountLabel.AutoSize = true;
            doneTasksAmountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            doneTasksAmountLabel.Location = new Point(131, 13);
            doneTasksAmountLabel.Name = "doneTasksAmountLabel";
            doneTasksAmountLabel.Size = new Size(24, 25);
            doneTasksAmountLabel.TabIndex = 0;
            doneTasksAmountLabel.Text = "0";
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = SystemColors.Window;
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.ForeColor = Color.DimGray;
            searchTextBox.Location = new Point(39, 3);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(279, 31);
            searchTextBox.TabIndex = 1;
            searchTextBox.Text = "Search";
            // 
            // searchPanel
            // 
            searchPanel.BackColor = SystemColors.Window;
            searchPanel.Controls.Add(pictureBox1);
            searchPanel.Controls.Add(searchPictureBox);
            searchPanel.Controls.Add(searchTextBox);
            searchPanel.Location = new Point(12, 20);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(362, 34);
            searchPanel.TabIndex = 2;
            // 
            // searchPictureBox
            // 
            searchPictureBox.Image = Properties.Resources.search;
            searchPictureBox.Location = new Point(3, 3);
            searchPictureBox.Name = "searchPictureBox";
            searchPictureBox.Size = new Size(33, 31);
            searchPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            searchPictureBox.TabIndex = 2;
            searchPictureBox.TabStop = false;
            // 
            // addListButton
            // 
            addListButton.BackColor = Color.LightBlue;
            addListButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addListButton.ForeColor = SystemColors.ButtonHighlight;
            addListButton.Location = new Point(196, 513);
            addListButton.Name = "addListButton";
            addListButton.Size = new Size(178, 44);
            addListButton.TabIndex = 3;
            addListButton.Text = "Add a list";
            addListButton.UseVisualStyleBackColor = false;
            // 
            // notificationButton
            // 
            notificationButton.BackColor = Color.LightBlue;
            notificationButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notificationButton.ForeColor = SystemColors.ButtonHighlight;
            notificationButton.Image = Properties.Resources.envelope;
            notificationButton.ImageAlign = ContentAlignment.MiddleRight;
            notificationButton.Location = new Point(12, 513);
            notificationButton.Name = "notificationButton";
            notificationButton.Size = new Size(178, 44);
            notificationButton.TabIndex = 3;
            notificationButton.Text = "Notification";
            notificationButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            notificationButton.UseVisualStyleBackColor = false;
            // 
            // myListsLabel
            // 
            myListsLabel.AutoSize = true;
            myListsLabel.BackColor = Color.Brown;
            myListsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            myListsLabel.ForeColor = Color.White;
            myListsLabel.Location = new Point(12, 331);
            myListsLabel.Name = "myListsLabel";
            myListsLabel.Size = new Size(85, 25);
            myListsLabel.TabIndex = 4;
            myListsLabel.Text = "My lists";
            // 
            // listsListBox
            // 
            listsListBox.BackColor = Color.Gray;
            listsListBox.BorderStyle = BorderStyle.None;
            listsListBox.FormattingEnabled = true;
            listsListBox.Location = new Point(12, 375);
            listsListBox.Name = "listsListBox";
            listsListBox.Size = new Size(362, 120);
            listsListBox.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.microphone;
            pictureBox1.Location = new Point(323, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(386, 565);
            Controls.Add(listsListBox);
            Controls.Add(myListsLabel);
            Controls.Add(notificationButton);
            Controls.Add(addListButton);
            Controls.Add(searchPanel);
            Controls.Add(scheduledTasksPanel);
            Controls.Add(doneTasksPanel);
            Controls.Add(allTasksPanel);
            Controls.Add(importantTasksPanel);
            Controls.Add(todayTasksPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboard";
            Text = "Dashboard";
            todayTasksPanel.ResumeLayout(false);
            todayTasksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)todayTasksPictureBox).EndInit();
            scheduledTasksPanel.ResumeLayout(false);
            scheduledTasksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scheduledTasksPictureBox).EndInit();
            importantTasksPanel.ResumeLayout(false);
            importantTasksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)importantTasksPictureBox).EndInit();
            allTasksPanel.ResumeLayout(false);
            allTasksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allTasksPictureBox).EndInit();
            doneTasksPanel.ResumeLayout(false);
            doneTasksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doneTasksPictureBox).EndInit();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel todayTasksPanel;
        private Label todayTasksAmountLabel;
        private PictureBox todayTasksPictureBox;
        private Label todayTasksTitleLabel;
        private Panel scheduledTasksPanel;
        private PictureBox scheduledTasksPictureBox;
        private Label scheduledTasksTitleLabel;
        private Label scheduledTasksAmountLabel;
        private Panel importantTasksPanel;
        private PictureBox importantTasksPictureBox;
        private Label importantTasksTitleLabel;
        private Label importantTasksAmountLabel;
        private Panel allTasksPanel;
        private PictureBox allTasksPictureBox;
        private Label allTasksTitleLabel;
        private Label allTasksAmountLabel;
        private Panel doneTasksPanel;
        private PictureBox doneTasksPictureBox;
        private Label doneTasksTitleLabel;
        private Label doneTasksAmountLabel;
        private TextBox searchTextBox;
        private Panel searchPanel;
        private PictureBox searchPictureBox;
        private Button addListButton;
        private Button notificationButton;
        private Label myListsLabel;
        private ListBox listsListBox;
        private PictureBox pictureBox1;
    }
}
