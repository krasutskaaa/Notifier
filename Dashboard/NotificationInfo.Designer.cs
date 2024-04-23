namespace Notifier.Dashboard
{
    partial class NotificationInfo
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
            deleteNotificationButton = new Button();
            descriptionTextBox = new TextBox();
            detailsLabel = new Label();
            notificationDateTimePicker = new DateTimePicker();
            isImportantCheckBox = new CheckBox();
            isDoneCheckBox = new CheckBox();
            editButton = new Button();
            notificationLabel = new Label();
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
            backwardsButton.Location = new Point(12, 25);
            backwardsButton.Name = "backwardsButton";
            backwardsButton.RightToLeft = RightToLeft.No;
            backwardsButton.Size = new Size(161, 30);
            backwardsButton.TabIndex = 2;
            backwardsButton.Text = "A List name";
            backwardsButton.TextAlign = ContentAlignment.MiddleRight;
            backwardsButton.UseVisualStyleBackColor = false;
            backwardsButton.Click += backwardsButton_Click;
            // 
            // deleteNotificationButton
            // 
            deleteNotificationButton.BackColor = Color.LightBlue;
            deleteNotificationButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteNotificationButton.ForeColor = SystemColors.ButtonHighlight;
            deleteNotificationButton.Location = new Point(194, 509);
            deleteNotificationButton.Name = "deleteNotificationButton";
            deleteNotificationButton.Size = new Size(180, 44);
            deleteNotificationButton.TabIndex = 7;
            deleteNotificationButton.Text = "Delete ";
            deleteNotificationButton.UseVisualStyleBackColor = false;
            deleteNotificationButton.Click += deleteNotificationButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = Color.White;
            descriptionTextBox.BorderStyle = BorderStyle.None;
            descriptionTextBox.Enabled = false;
            descriptionTextBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionTextBox.ForeColor = Color.Black;
            descriptionTextBox.Location = new Point(12, 117);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(362, 110);
            descriptionTextBox.TabIndex = 9;
            descriptionTextBox.Text = " ";
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.BackColor = Color.Brown;
            detailsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            detailsLabel.ForeColor = Color.White;
            detailsLabel.Location = new Point(12, 242);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(71, 25);
            detailsLabel.TabIndex = 11;
            detailsLabel.Text = "Details";
            // 
            // notificationDateTimePicker
            // 
            notificationDateTimePicker.Location = new Point(12, 287);
            notificationDateTimePicker.Name = "notificationDateTimePicker";
            notificationDateTimePicker.Size = new Size(362, 27);
            notificationDateTimePicker.TabIndex = 14;
            notificationDateTimePicker.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // isImportantCheckBox
            // 
            isImportantCheckBox.AutoSize = true;
            isImportantCheckBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            isImportantCheckBox.Location = new Point(12, 334);
            isImportantCheckBox.Name = "isImportantCheckBox";
            isImportantCheckBox.Size = new Size(106, 26);
            isImportantCheckBox.TabIndex = 15;
            isImportantCheckBox.Text = "Important";
            isImportantCheckBox.UseVisualStyleBackColor = true;
            // 
            // isDoneCheckBox
            // 
            isDoneCheckBox.AutoSize = true;
            isDoneCheckBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            isDoneCheckBox.Location = new Point(12, 366);
            isDoneCheckBox.Name = "isDoneCheckBox";
            isDoneCheckBox.Size = new Size(75, 26);
            isDoneCheckBox.TabIndex = 16;
            isDoneCheckBox.Text = "Done";
            isDoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.BackColor = Color.LightBlue;
            editButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editButton.ForeColor = SystemColors.ButtonHighlight;
            editButton.Location = new Point(12, 509);
            editButton.Name = "editButton";
            editButton.Size = new Size(176, 44);
            editButton.TabIndex = 18;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // notificationLabel
            // 
            notificationLabel.AutoSize = true;
            notificationLabel.BackColor = Color.Brown;
            notificationLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            notificationLabel.ForeColor = Color.White;
            notificationLabel.Location = new Point(12, 73);
            notificationLabel.Name = "notificationLabel";
            notificationLabel.Size = new Size(177, 25);
            notificationLabel.TabIndex = 19;
            notificationLabel.Text = "A notification name";
            // 
            // NotificationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(386, 565);
            Controls.Add(notificationLabel);
            Controls.Add(editButton);
            Controls.Add(isDoneCheckBox);
            Controls.Add(isImportantCheckBox);
            Controls.Add(notificationDateTimePicker);
            Controls.Add(detailsLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(deleteNotificationButton);
            Controls.Add(backwardsButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotificationInfo";
            Text = "NotificationInfo";
            Load += OnFormLoaded;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backwardsButton;
        private Button deleteNotificationButton;
        private TextBox descriptionTextBox;
        private Label detailsLabel;
        private DateTimePicker notificationDateTimePicker;
        private CheckBox isImportantCheckBox;
        private CheckBox isDoneCheckBox;
        private Button editButton;
        private Label notificationLabel;
    }
}