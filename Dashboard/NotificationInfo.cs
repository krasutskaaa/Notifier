using Notifier.Abstractions.Entities;
using Notifier.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notifier.Dashboard
{
    public partial class NotificationInfo : Form
    {
        private IDatabase _database;
        private Notification _notification;
        private string _listName;
        public NotificationInfo(Notification notification, string listName)
        {
            _database = new ToDoListDatabaseManager();
            this._notification = notification;
            this._listName = listName;
            InitializeComponent();


        }
        public void OnFormLoaded(object sender, EventArgs e)
        {
            notificationLabel.Text = _notification.Name;
            descriptionTextBox.Text = _notification.Description;
            notificationDateTimePicker.Value = _notification.DateTime;
            isImportantCheckBox.Checked = _notification.IsImportant;
            isDoneCheckBox.Checked = _notification.IsDone;
            backwardsButton.Text = _listName;

        }

        private void backwardsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void deleteNotificationButton_Click(object sender, EventArgs e)
        {
            _database.RemoveNotification(_notification.ListId, _notification.Name);
            MessageBox.Show($"The {notificationLabel.Text} was successfully deleted");
            ListInfo.instance.UpdateListNotificationsBox();
            MainForm.instance.UpdateDashboard();
            List locationList = _database.GetListByListId(_notification.ListId);

            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            _notification.Description = descriptionTextBox.Text;
            _notification.DateTime = notificationDateTimePicker.Value;
            _notification.IsImportant = isImportantCheckBox.Checked;
            _notification.IsDone = isDoneCheckBox.Checked;
            _database.EditNotification(_notification);
            MessageBox.Show($"The {notificationLabel.Text} was successfully edited");
            MainForm.instance.UpdateDashboard();
        }
    }
}
