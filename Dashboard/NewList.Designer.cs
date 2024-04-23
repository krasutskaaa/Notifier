namespace Notifier.Dashboard
{
    partial class NewList
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
            newListPictureBox = new PictureBox();
            newListTextBox = new TextBox();
            doneButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)newListPictureBox).BeginInit();
            SuspendLayout();
            // 
            // newListPictureBox
            // 
            newListPictureBox.Image = Properties.Resources.todo_list;
            newListPictureBox.Location = new Point(128, 23);
            newListPictureBox.Name = "newListPictureBox";
            newListPictureBox.Size = new Size(90, 69);
            newListPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            newListPictureBox.TabIndex = 0;
            newListPictureBox.TabStop = false;
            // 
            // newListTextBox
            // 
            newListTextBox.BackColor = SystemColors.Window;
            newListTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newListTextBox.ForeColor = Color.Gray;
            newListTextBox.Location = new Point(59, 108);
            newListTextBox.Name = "newListTextBox";
            newListTextBox.Size = new Size(238, 30);
            newListTextBox.TabIndex = 1;
            newListTextBox.Text = "A list name";
            // 
            // doneButton
            // 
            doneButton.BackColor = Color.LightBlue;
            doneButton.FlatAppearance.BorderColor = Color.Brown;
            doneButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            doneButton.ForeColor = SystemColors.ButtonHighlight;
            doneButton.Location = new Point(177, 158);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(157, 32);
            doneButton.TabIndex = 2;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = false;
            doneButton.Click += doneButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.LightBlue;
            cancelButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancelButton.ForeColor = SystemColors.ButtonHighlight;
            cancelButton.Location = new Point(12, 158);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(149, 32);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // NewList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(346, 216);
            Controls.Add(cancelButton);
            Controls.Add(doneButton);
            Controls.Add(newListTextBox);
            Controls.Add(newListPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewList";
            Text = "AddList";
            ((System.ComponentModel.ISupportInitialize)newListPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox newListPictureBox;
        private TextBox newListTextBox;
        private Button doneButton;
        private Button cancelButton;
    }
}