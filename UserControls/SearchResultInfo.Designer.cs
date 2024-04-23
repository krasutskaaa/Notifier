namespace Notifier.UserControls
{
    partial class SearchResultInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchResultNotificationNameLabel = new Label();
            searchResulListNamelabel = new Label();
            notificationLocationlabel = new Label();
            SuspendLayout();
            // 
            // searchResultNotificationNameLabel
            // 
            searchResultNotificationNameLabel.AutoSize = true;
            searchResultNotificationNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchResultNotificationNameLabel.Location = new Point(12, 0);
            searchResultNotificationNameLabel.Name = "searchResultNotificationNameLabel";
            searchResultNotificationNameLabel.Size = new Size(196, 25);
            searchResultNotificationNameLabel.TabIndex = 0;
            searchResultNotificationNameLabel.Text = "A notification name";
            // 
            // searchResulListNamelabel
            // 
            searchResulListNamelabel.AutoSize = true;
            searchResulListNamelabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchResulListNamelabel.Location = new Point(96, 25);
            searchResulListNamelabel.Name = "searchResulListNamelabel";
            searchResulListNamelabel.Size = new Size(93, 20);
            searchResulListNamelabel.TabIndex = 1;
            searchResulListNamelabel.Text = "A list name";
            // 
            // notificationLocationlabel
            // 
            notificationLocationlabel.AutoSize = true;
            notificationLocationlabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            notificationLocationlabel.Location = new Point(12, 25);
            notificationLocationlabel.Name = "notificationLocationlabel";
            notificationLocationlabel.Size = new Size(78, 20);
            notificationLocationlabel.TabIndex = 2;
            notificationLocationlabel.Text = "Location:";
            // 
            // SearchResultInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(notificationLocationlabel);
            Controls.Add(searchResulListNamelabel);
            Controls.Add(searchResultNotificationNameLabel);
            Name = "SearchResultInfo";
            Size = new Size(283, 54);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label searchResultNotificationNameLabel;
        private Label searchResulListNamelabel;
        private Label notificationLocationlabel;
    }
}
