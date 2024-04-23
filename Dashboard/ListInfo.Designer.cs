namespace Notifier.Dashboard
{
    partial class ListInfo
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
            backwardsButton = new Button();
            notificationButton = new Button();
            notificationsListBox = new ListBox();
            deleteListButton = new Button();
            listLabel = new Label();
            SuspendLayout();
            // 
            // backwardsButton
            // 
            backwardsButton.BackColor = Color.Gray;
            backwardsButton.FlatAppearance.BorderColor = Color.Gray;
            backwardsButton.FlatStyle = FlatStyle.Flat;
            backwardsButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            backwardsButton.ForeColor = SystemColors.ButtonHighlight;
            backwardsButton.Image = Properties.Resources.arrow_left;
            backwardsButton.ImageAlign = ContentAlignment.MiddleLeft;
            backwardsButton.Location = new Point(16, 19);
            backwardsButton.Name = "backwardsButton";
            backwardsButton.RightToLeft = RightToLeft.No;
            backwardsButton.Size = new Size(104, 30);
            backwardsButton.TabIndex = 1;
            backwardsButton.Text = "Lists";
            backwardsButton.TextAlign = ContentAlignment.MiddleRight;
            backwardsButton.UseVisualStyleBackColor = false;
            backwardsButton.Click += backwardsButton_Click;
            // 
            // notificationButton
            // 
            notificationButton.BackColor = Color.LightBlue;
            notificationButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notificationButton.ForeColor = SystemColors.ButtonHighlight;
            notificationButton.Image = Properties.Resources.envelope;
            notificationButton.ImageAlign = ContentAlignment.MiddleRight;
            notificationButton.Location = new Point(12, 462);
            notificationButton.Name = "notificationButton";
            notificationButton.Size = new Size(169, 44);
            notificationButton.TabIndex = 4;
            notificationButton.Text = "Notification";
            notificationButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            notificationButton.UseVisualStyleBackColor = false;
            notificationButton.Click += notificationButton_Click;
            // 
            // notificationsListBox
            // 
            notificationsListBox.BackColor = Color.Gray;
            notificationsListBox.BorderStyle = BorderStyle.None;
            notificationsListBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            notificationsListBox.FormattingEnabled = true;
            notificationsListBox.ItemHeight = 22;
            notificationsListBox.Location = new Point(16, 106);
            notificationsListBox.Name = "notificationsListBox";
            notificationsListBox.Size = new Size(332, 330);
            notificationsListBox.TabIndex = 5;
            notificationsListBox.SelectedIndexChanged += notificationsListBox_SelectedIndexChanged;
            // 
            // deleteListButton
            // 
            deleteListButton.BackColor = Color.LightBlue;
            deleteListButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteListButton.ForeColor = SystemColors.ButtonHighlight;
            deleteListButton.Location = new Point(187, 462);
            deleteListButton.Name = "deleteListButton";
            deleteListButton.Size = new Size(169, 44);
            deleteListButton.TabIndex = 6;
            deleteListButton.Text = "Delete ";
            deleteListButton.UseVisualStyleBackColor = false;
            deleteListButton.Click += deleteListButton_Click;
            // 
            // listLabel
            // 
            listLabel.AutoSize = true;
            listLabel.BackColor = Color.Brown;
            listLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listLabel.ForeColor = Color.White;
            listLabel.Location = new Point(16, 78);
            listLabel.Name = "listLabel";
            listLabel.Size = new Size(108, 25);
            listLabel.TabIndex = 8;
            listLabel.Text = "A list name";
            // 
            // ListInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(368, 518);
            Controls.Add(listLabel);
            Controls.Add(deleteListButton);
            Controls.Add(notificationsListBox);
            Controls.Add(notificationButton);
            Controls.Add(backwardsButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListInfo";
            Text = "ListInfo";
            Load += OnFormLoaded;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button backwardsButton;
        private Button notificationButton;
        private ListBox notificationsListBox;
        private Button deleteListButton;
        private Label listLabel;
    }
}