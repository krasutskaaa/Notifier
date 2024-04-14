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
            listLabel = new Label();
            backwardsButton = new Button();
            notificationButton = new Button();
            notificationsListBox = new ListBox();
            SuspendLayout();
            // 
            // listLabel
            // 
            listLabel.AutoSize = true;
            listLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listLabel.Location = new Point(16, 68);
            listLabel.Name = "listLabel";
            listLabel.Size = new Size(98, 22);
            listLabel.TabIndex = 0;
            listLabel.Text = "A list name";
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
            notificationButton.Size = new Size(178, 44);
            notificationButton.TabIndex = 4;
            notificationButton.Text = "Notification";
            notificationButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            notificationButton.UseVisualStyleBackColor = false;
            // 
            // notificationsListBox
            // 
            notificationsListBox.BackColor = Color.Gray;
            notificationsListBox.BorderStyle = BorderStyle.None;
            notificationsListBox.FormattingEnabled = true;
            notificationsListBox.Location = new Point(16, 106);
            notificationsListBox.Name = "notificationsListBox";
            notificationsListBox.Size = new Size(332, 340);
            notificationsListBox.TabIndex = 5;
            // 
            // ListInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(368, 518);
            Controls.Add(notificationsListBox);
            Controls.Add(notificationButton);
            Controls.Add(backwardsButton);
            Controls.Add(listLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListInfo";
            Text = "ListInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label listLabel;
        private Button backwardsButton;
        private Button notificationButton;
        private ListBox notificationsListBox;
    }
}