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
        //void LoadNotifications();
        IEnumerable<List> GetALLLists();
        IEnumerable<Notification> GetALLNotifications();
        IEnumerable<Notification> GetDoneNotifications();
        IEnumerable<Notification> GetImportantNotifications();
        IEnumerable<Notification> GetTodayNotifications();
        IEnumerable<Notification> GetScheduledNotifications();
        //IEnumerable<string> GetALLNotificationsNames();
        void AddList(string? name);
        IEnumerable<Notification> GetNotificationsByListId(Guid listId);
        void AddNotification(Guid listId, string name,
        string description, DateTime dateTime, bool isImportant);
        public SearchResult GetSearchResult(string key);
        public List GetListByListId(Guid listId);
        //public IEnumerable<SearchResult> GetSearchResult(string key);

    }
}
