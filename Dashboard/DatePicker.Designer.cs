namespace Notifier.Dashboard
{
    partial class DatePicker
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
            monthCalendar = new MonthCalendar();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(23, 20);
            monthCalendar.Margin = new Padding(14, 11, 14, 11);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // DatePicker
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(239, 249);
            Controls.Add(monthCalendar);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "DatePicker";
            Text = "Date Picker";
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar;
        private OpenFileDialog openFileDialog1;
    }
}