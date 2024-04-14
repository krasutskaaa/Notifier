namespace Notifier.Dashboard
{
    partial class NewNotification
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
            cancelButton = new Button();
            doneButton = new Button();
            label1 = new Label();
            notificationNameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            detailsCheckedListBox = new CheckedListBox();
            detailsLabel = new Label();
            myListsLabel = new Label();
            listsListBox = new ListBox();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.LightBlue;
            cancelButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancelButton.ForeColor = SystemColors.ButtonHighlight;
            cancelButton.Location = new Point(12, 12);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(149, 42);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // doneButton
            // 
            doneButton.BackColor = Color.LightBlue;
            doneButton.FlatAppearance.BorderColor = Color.Brown;
            doneButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            doneButton.ForeColor = SystemColors.ButtonHighlight;
            doneButton.Location = new Point(217, 12);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(157, 42);
            doneButton.TabIndex = 4;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(118, 68);
            label1.Name = "label1";
            label1.Size = new Size(137, 22);
            label1.TabIndex = 5;
            label1.Text = "New notification";
            // 
            // notificationNameTextBox
            // 
            notificationNameTextBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            notificationNameTextBox.ForeColor = Color.Gray;
            notificationNameTextBox.Location = new Point(12, 113);
            notificationNameTextBox.Name = "notificationNameTextBox";
            notificationNameTextBox.Size = new Size(362, 28);
            notificationNameTextBox.TabIndex = 6;
            notificationNameTextBox.Text = "A name";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionTextBox.ForeColor = Color.Gray;
            descriptionTextBox.Location = new Point(12, 162);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(362, 85);
            descriptionTextBox.TabIndex = 8;
            descriptionTextBox.Text = "Description";
            // 
            // detailsCheckedListBox
            // 
            detailsCheckedListBox.BackColor = Color.Gray;
            detailsCheckedListBox.BorderStyle = BorderStyle.None;
            detailsCheckedListBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            detailsCheckedListBox.FormattingEnabled = true;
            detailsCheckedListBox.Items.AddRange(new object[] { "Date", "Time", "Important" });
            detailsCheckedListBox.Location = new Point(12, 309);
            detailsCheckedListBox.Name = "detailsCheckedListBox";
            detailsCheckedListBox.Size = new Size(362, 69);
            detailsCheckedListBox.TabIndex = 9;
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.BackColor = Color.Brown;
            detailsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            detailsLabel.ForeColor = Color.White;
            detailsLabel.Location = new Point(12, 271);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(71, 25);
            detailsLabel.TabIndex = 10;
            detailsLabel.Text = "Details";
            // 
            // myListsLabel
            // 
            myListsLabel.AutoSize = true;
            myListsLabel.BackColor = Color.Brown;
            myListsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            myListsLabel.ForeColor = Color.White;
            myListsLabel.Location = new Point(12, 397);
            myListsLabel.Name = "myListsLabel";
            myListsLabel.Size = new Size(85, 25);
            myListsLabel.TabIndex = 11;
            myListsLabel.Text = "My lists";
            // 
            // listsListBox
            // 
            listsListBox.BackColor = Color.Gray;
            listsListBox.BorderStyle = BorderStyle.None;
            listsListBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listsListBox.FormattingEnabled = true;
            listsListBox.ItemHeight = 22;
            listsListBox.Location = new Point(12, 433);
            listsListBox.Name = "listsListBox";
            listsListBox.Size = new Size(362, 88);
            listsListBox.TabIndex = 12;
            // 
            // NewNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(386, 565);
            Controls.Add(listsListBox);
            Controls.Add(myListsLabel);
            Controls.Add(detailsLabel);
            Controls.Add(detailsCheckedListBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(notificationNameTextBox);
            Controls.Add(label1);
            Controls.Add(doneButton);
            Controls.Add(cancelButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewNotification";
            Text = "NewNotification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button doneButton;
        private Label label1;
        private TextBox notificationNameTextBox;
        private TextBox descriptionTextBox;
        private CheckedListBox detailsCheckedListBox;
        private Label detailsLabel;
        private Label myListsLabel;
        private ListBox listsListBox;
    }
}