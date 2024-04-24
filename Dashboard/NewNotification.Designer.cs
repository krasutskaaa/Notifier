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
            newNotificationNameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            detailsLabel = new Label();
            myListsLabel = new Label();
            listsListBox = new ListBox();
            newNotificationDateTimePicker = new DateTimePicker();
            isImportantCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.LightBlue;
            cancelButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cancelButton.ForeColor = SystemColors.ButtonHighlight;
            cancelButton.Location = new Point(12, 12);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(188, 42);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // doneButton
            // 
            doneButton.BackColor = Color.LightBlue;
            doneButton.FlatAppearance.BorderColor = Color.Brown;
            doneButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            doneButton.ForeColor = SystemColors.ButtonHighlight;
            doneButton.Location = new Point(206, 12);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(186, 42);
            doneButton.TabIndex = 4;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = false;
            doneButton.Click += doneButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(117, 71);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 5;
            label1.Text = "New notification";
            // 
            // newNotificationNameTextBox
            // 
            newNotificationNameTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newNotificationNameTextBox.ForeColor = Color.Gray;
            newNotificationNameTextBox.Location = new Point(12, 113);
            newNotificationNameTextBox.Name = "newNotificationNameTextBox";
            newNotificationNameTextBox.Size = new Size(380, 30);
            newNotificationNameTextBox.TabIndex = 6;
            newNotificationNameTextBox.Text = "A name";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionTextBox.ForeColor = Color.Gray;
            descriptionTextBox.Location = new Point(12, 162);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(380, 85);
            descriptionTextBox.TabIndex = 8;
            descriptionTextBox.Text = "Description";
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
            myListsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            myListsLabel.ForeColor = Color.White;
            myListsLabel.Location = new Point(12, 415);
            myListsLabel.Name = "myListsLabel";
            myListsLabel.Size = new Size(77, 25);
            myListsLabel.TabIndex = 11;
            myListsLabel.Text = "My lists";
            // 
            // listsListBox
            // 
            listsListBox.BackColor = Color.Gray;
            listsListBox.BorderStyle = BorderStyle.None;
            listsListBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listsListBox.FormattingEnabled = true;
            listsListBox.ItemHeight = 25;
            listsListBox.Location = new Point(12, 454);
            listsListBox.Name = "listsListBox";
            listsListBox.Size = new Size(380, 125);
            listsListBox.TabIndex = 12;
            // 
            // newNotificationDateTimePicker
            // 
            newNotificationDateTimePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newNotificationDateTimePicker.Location = new Point(12, 312);
            newNotificationDateTimePicker.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            newNotificationDateTimePicker.Name = "newNotificationDateTimePicker";
            newNotificationDateTimePicker.Size = new Size(380, 30);
            newNotificationDateTimePicker.TabIndex = 13;
            newNotificationDateTimePicker.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // isImportantCheckBox
            // 
            isImportantCheckBox.AutoSize = true;
            isImportantCheckBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            isImportantCheckBox.Location = new Point(12, 359);
            isImportantCheckBox.Name = "isImportantCheckBox";
            isImportantCheckBox.Size = new Size(115, 29);
            isImportantCheckBox.TabIndex = 14;
            isImportantCheckBox.Text = "Important";
            isImportantCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(404, 612);
            Controls.Add(isImportantCheckBox);
            Controls.Add(newNotificationDateTimePicker);
            Controls.Add(listsListBox);
            Controls.Add(myListsLabel);
            Controls.Add(detailsLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(newNotificationNameTextBox);
            Controls.Add(label1);
            Controls.Add(doneButton);
            Controls.Add(cancelButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewNotification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewNotification";
            Load += OnFormLoaded;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button doneButton;
        private Label label1;
        private TextBox newNotificationNameTextBox;
        private TextBox descriptionTextBox;
        private Label detailsLabel;
        private Label myListsLabel;
        private ListBox listsListBox;
        private DateTimePicker newNotificationDateTimePicker;
        private CheckBox isImportantCheckBox;
    }
}