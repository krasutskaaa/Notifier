using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notifier.Abstractions.Entities;

namespace Notifier.Database
{
    public interface IDatabase
    {
        public void RemoveList(string name);
        public void RemoveNotification(Guid listId, string name);
        public void EditNotification(Notification editedNotification);
        IEnumerable<List> GetAllLists();
        IEnumerable<Notification> GetAllNotifications();
        IEnumerable<Notification> GetDoneNotifications();
        IEnumerable<Notification> GetImportantNotifications();
        IEnumerable<Notification> GetTodayNotifications();
        IEnumerable<Notification> GetScheduledNotifications();
        void AddList(string? name);
        IEnumerable<Notification> GetNotificationsByListId(Guid listId);
        void AddNotification(Guid listId, string name,
        string description, DateTime dateTime, bool isImportant);
        public List GetListById(Guid Id);
        public IEnumerable<SearchResult> GetSearchResults(string key);
        public Notification GetNotificationByNotificationId(Guid notificationId);

    }
}
