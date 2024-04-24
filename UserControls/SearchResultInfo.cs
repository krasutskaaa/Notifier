using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notifier.Abstractions.Entities;
using Notifier.Dashboard;
using Notifier.Database;

namespace Notifier.UserControls
{
    public partial class SearchResultInfo : UserControl
    {
        private IDatabase _database = new ToDoListDatabaseManager();
        private Guid _tempId;
        private string _listName;
        public SearchResultInfo()
        {
            InitializeComponent();
        }

        public void LoadDetails(SearchResult searchResult)
        {
            searchResultNotificationNameLabel.Text = searchResult.NotificationName;
            searchResulListNamelabel.Text = searchResult.ListName;
            _tempId = searchResult.NotificationId;
            _listName = searchResult.ListName;
        }
        public void GetResult(string key)
        {
            SearchResult searchResult = new SearchResult();
            searchResult.Search(key);
            searchResultNotificationNameLabel.Text = searchResult.NotificationName;
            searchResulListNamelabel.Text = searchResult.ListName;

        }

        private void SearchResultInfo_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ButtonFace;
        }

        private void SearchResultInfo_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ButtonHighlight;
        }

        private void SearchResultInfo_Click(object sender, EventArgs e)
        {
            Notification currentNotification = _database.GetNotificationByNotificationId(_tempId);
            var notificationInfoForm = new NotificationInfo(this,currentNotification, _listName);
            notificationInfoForm.ShowDialog();

        }
    }
}
