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
            todayTasksTitleLabel = new Label();
            todayTasksAmountLabel = new Label();
            todayTasksPictureBox = new PictureBox();
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
            SuspendLayout();
            // 
            // todayTasksPanel
            // 
            todayTasksPanel.BackColor = SystemColors.MenuBar;
            todayTasksPanel.Controls.Add(todayTasksPictureBox);
            todayTasksPanel.Controls.Add(todayTasksTitleLabel);
            todayTasksPanel.Controls.Add(todayTasksAmountLabel);
            todayTasksPanel.Location = new Point(25, 73);
            todayTasksPanel.Name = "todayTasksPanel";
            todayTasksPanel.Size = new Size(155, 90);
            todayTasksPanel.TabIndex = 0;
            // 
            // todayTasksTitleLabel
            // 
            todayTasksTitleLabel.AutoSize = true;
            todayTasksTitleLabel.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            todayTasksTitleLabel.ForeColor = Color.Black;
            todayTasksTitleLabel.Location = new Point(3, 57);
            todayTasksTitleLabel.Name = "todayTasksTitleLabel";
            todayTasksTitleLabel.Size = new Size(69, 25);
            todayTasksTitleLabel.TabIndex = 1;
            todayTasksTitleLabel.Text = "Today";
            // 
            // todayTasksAmountLabel
            // 
            todayTasksAmountLabel.AutoSize = true;
            todayTasksAmountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            todayTasksAmountLabel.Location = new Point(118, 13);
            todayTasksAmountLabel.Name = "todayTasksAmountLabel";
            todayTasksAmountLabel.Size = new Size(24, 25);
            todayTasksAmountLabel.TabIndex = 0;
            todayTasksAmountLabel.Text = "0";
            // 
            // todayTasksPictureBox
            // 
            todayTasksPictureBox.Image = Properties.Resources.calendar__2_;
            todayTasksPictureBox.InitialImage = null;
            todayTasksPictureBox.Location = new Point(13, 13);
            todayTasksPictureBox.Name = "todayTasksPictureBox";
            todayTasksPictureBox.Size = new Size(44, 35);
            todayTasksPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            todayTasksPictureBox.TabIndex = 2;
            todayTasksPictureBox.TabStop = false;
            // 
            // scheduledTasksPanel
            // 
            scheduledTasksPanel.BackColor = SystemColors.MenuBar;
            scheduledTasksPanel.Controls.Add(scheduledTasksPictureBox);
            scheduledTasksPanel.Controls.Add(scheduledTasksTitleLabel);
            scheduledTasksPanel.Controls.Add(scheduledTasksAmountLabel);
            scheduledTasksPanel.Location = new Point(207, 73);
            scheduledTasksPanel.Name = "scheduledTasksPanel";
            scheduledTasksPanel.Size = new Size(155, 90);
            scheduledTasksPanel.TabIndex = 0;
            // 
            // scheduledTasksPictureBox
            // 
            scheduledTasksPictureBox.Image = Properties.Resources.today__1_;
            scheduledTasksPictureBox.InitialImage = null;
            scheduledTasksPictureBox.Location = new Point(13, 13);
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
            scheduledTasksTitleLabel.Location = new Point(3, 57);
            scheduledTasksTitleLabel.Name = "scheduledTasksTitleLabel";
            scheduledTasksTitleLabel.Size = new Size(108, 25);
            scheduledTasksTitleLabel.TabIndex = 1;
            scheduledTasksTitleLabel.Text = "Scheduled";
            // 
            // scheduledTasksAmountLabel
            // 
            scheduledTasksAmountLabel.AutoSize = true;
            scheduledTasksAmountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            scheduledTasksAmountLabel.Location = new Point(118, 13);
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
            importantTasksPanel.Location = new Point(207, 172);
            importantTasksPanel.Name = "importantTasksPanel";
            importantTasksPanel.Size = new Size(155, 90);
            importantTasksPanel.TabIndex = 0;
            // 
            // importantTasksPictureBox
            // 
            importantTasksPictureBox.Image = Properties.Resources.star;
            importantTasksPictureBox.InitialImage = null;
            importantTasksPictureBox.Location = new Point(13, 13);
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
            importantTasksTitleLabel.Location = new Point(3, 51);
            importantTasksTitleLabel.Name = "importantTasksTitleLabel";
            importantTasksTitleLabel.Size = new Size(107, 25);
            importantTasksTitleLabel.TabIndex = 1;
            importantTasksTitleLabel.Text = "Important";
            // 
            // importantTasksAmountLabel
            // 
            importantTasksAmountLabel.AutoSize = true;
            importantTasksAmountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            importantTasksAmountLabel.Location = new Point(118, 13);
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
            allTasksPanel.Location = new Point(25, 172);
            allTasksPanel.Name = "allTasksPanel";
            allTasksPanel.Size = new Size(155, 90);
            allTasksPanel.TabIndex = 0;
            // 
            // allTasksPictureBox
            // 
            allTasksPictureBox.Image = Properties.Resources.box;
            allTasksPictureBox.InitialImage = null;
            allTasksPictureBox.Location = new Point(11, 13);
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
            allTasksTitleLabel.Location = new Point(11, 60);
            allTasksTitleLabel.Name = "allTasksTitleLabel";
            allTasksTitleLabel.Size = new Size(37, 25);
            allTasksTitleLabel.TabIndex = 1;
            allTasksTitleLabel.Text = "All";
            // 
            // allTasksAmountLabel
            // 
            allTasksAmountLabel.AutoSize = true;
            allTasksAmountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            allTasksAmountLabel.Location = new Point(118, 13);
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
            doneTasksPanel.Location = new Point(25, 277);
            doneTasksPanel.Name = "doneTasksPanel";
            doneTasksPanel.Size = new Size(155, 90);
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
            doneTasksAmountLabel.Location = new Point(118, 13);
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
            searchTextBox.Size = new Size(225, 31);
            searchTextBox.TabIndex = 1;
            searchTextBox.Text = "Search";
            // 
            // searchPanel
            // 
            searchPanel.BackColor = SystemColors.Window;
            searchPanel.Controls.Add(searchPictureBox);
            searchPanel.Controls.Add(searchTextBox);
            searchPanel.Location = new Point(25, 20);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(337, 34);
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
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(386, 565);
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
            ResumeLayout(false);
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
    }
}
