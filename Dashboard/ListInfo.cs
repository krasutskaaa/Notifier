using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Notifier.Abstractions.Entities;
using Notifier.Database;

namespace Notifier.Dashboard
{
    public partial class ListInfo : Form
    {
        public static ListInfo instance;
        private List _list;
        private IDatabase _database;
        public ListInfo(List list)
        {
            _database = new ToDoListDatabaseManager();
            this._list = list;
            InitializeComponent();
        }

        public void OnFormLoaded(object sender, EventArgs e)
        {
            listLabel.Text = _list.Name;
            var notifications = _database.GetNotificationsByListId(_list.Id).ToArray();
            notificationsListBox.Items.AddRange(notifications);
        }

        private void backwardsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            var newNotificationForm = new NewNotification(this, _list.Id);
            newNotificationForm.ShowDialog();
        }

        private void deleteListButton_Click(object sender, EventArgs e)
        {
            _database.RemoveList(listLabel.Text);
            MessageBox.Show($"The {listLabel.Text} list was successfully deleted");
            MainForm.instance.UpdateListsListBox();
            MainForm.instance.UpdateDashboard();
            this.Close();
        }
        public void UpdateNotificationsListBox(Guid listId)
        {
            notificationsListBox.Items.Clear();
            var notifications = _database.GetAllNotifications().ToArray();
            notificationsListBox.Items.AddRange(notifications);
        }

        private void notificationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedNotification = notificationsListBox.SelectedItem as Notification;
            if (selectedNotification is null) return;
            var notificationInfoForm = new NotificationInfo(this,selectedNotification, _list.Name);
            notificationInfoForm.ShowDialog();
        }
    }
}
