using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Notifier.Abstractions.Entities;

namespace Notifier.Database;
[Authorize]
public class ToDoListDatabaseManager : IDatabase
{
    public IEnumerable<List> GetAllLists()
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            var lists = db.Lists.ToArray();
            return lists;
        }
    }
    public IEnumerable<Notification> GetAllNotifications()
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            var notifications = db.Notifications.ToArray();
            return notifications;
        }
    }
    public IEnumerable<Notification> GetDoneNotifications()
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            var notifications = db.Notifications.Where(notifications =>
            notifications.IsDone.Equals(true)).ToArray();
            return notifications;
        }
    }
    public IEnumerable<Notification> GetImportantNotifications()
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            var notifications = db.Notifications.Where(notifications =>
            notifications.IsImportant.Equals(true)).ToArray();
            return notifications;
        }
    }
    public IEnumerable<Notification> GetTodayNotifications()
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            var notifications = db.Notifications.Where(notification =>
            notification.DateTime.Equals(DateTime.Today)).ToArray();
            return notifications;
        }
    }
    public IEnumerable<Notification> GetScheduledNotifications()
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            DateTime dateTimeToCompare = new DateTime(2024, 01, 01);
            var notifications = db.Notifications.Where(notification =>
            !(notification.DateTime.Equals(dateTimeToCompare))).ToArray();
            return notifications;
        }
    }
    public void AddList(string? name)
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            db.Lists.Add(new List
            {
                Name = name
            });
            db.SaveChanges();
        }
    }
    public void RemoveList(string name)
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            if (!db.Lists.Any(list => list.Name.Equals(name)))
                throw new ArgumentException("The list isn't found", nameof(name));
            List? list = db.Lists.FirstOrDefault(list => list.Name.Equals(name));
            if (list != null)
            {
                var notifications = db.Notifications.Where(notification => notification.ListId.Equals(list.Id));
                db.Notifications.RemoveRange(notifications);
                db.Lists.Remove(list);
                db.SaveChanges();
            }
        }
    }
    public void AddNotification(Guid listId, string name,
        string? description, DateTime dateTime, bool isImportant)
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            db.Notifications.Add(new Notification
            {
                ListId = listId,
                Name = name,
                Description = description,
                DateTime = dateTime,
                IsImportant = isImportant,
                IsDone = false
            });
            db.SaveChanges();
        }
    }
    public void RemoveNotification(Guid listId, string name)
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            if (!db.Notifications.Any(notification => notification.Name.Equals(name)&&
            notification.ListId.Equals(listId)))
                throw new ArgumentException("The notification isn't found", nameof(name));
            Notification? notification = db.Notifications.FirstOrDefault(notification => 
            notification.Name.Equals(name)&&notification.ListId.Equals(listId));
            if (notification != null)
            {
                db.Notifications.Remove(notification);
                db.SaveChanges();
            }
        }
    }
    public void EditNotification(Notification editedNotification)
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            if (!db.Notifications.Any(notification => notification.Name.Equals(editedNotification.Name) &&
            notification.ListId.Equals(editedNotification.ListId)))
                throw new ArgumentException("The notification isn't found", nameof(editedNotification.Name));
            Notification? notification = db.Notifications.FirstOrDefault(notification =>
            notification.Name.Equals(editedNotification.Name) && notification.ListId.Equals(editedNotification.ListId));
            if (notification != null)
            {
                notification.Description = editedNotification.Description;
                notification.IsImportant = editedNotification.IsImportant;
                notification.IsDone = editedNotification.IsDone;
                notification.DateTime = editedNotification.DateTime;
                db.SaveChanges();
            }
        }
    }
    public IEnumerable<Notification> GetNotificationsByListId(Guid listId)
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            if (!db.Notifications.Any(notification => notification.ListId.Equals(listId)))
                MessageBox.Show("There aren't  any notifications belong to the list");
            var notifications = db.Notifications.Where(notification => notification.ListId.Equals(listId)).ToArray();
            return notifications;
        }
    }
    public Notification GetNotificationByNotificationId(Guid notificationId)
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            if (!db.Notifications.Any(notification => notification.Id.Equals(notificationId)))
                MessageBox.Show("There isn't any notification with such id");
            var notification = db.Notifications.FirstOrDefault(notification => notification.Id.Equals(notificationId));
            return notification;
        }
    }

    public List GetListById(Guid Id)
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            if (!db.Lists.Any(list => list.Id.Equals(Id)))
                MessageBox.Show("There aren't  any lists!");
            var list = db.Lists.FirstOrDefault(list => list.Id.Equals(Id));
            return list;
        }
    }
    public IEnumerable<SearchResult> GetSearchResults(string key)
    {
        using (ToDoListDatabase db = new ToDoListDatabase())
        {
            var notifications = db.Notifications.Where(notification => notification.Name.StartsWith(key)).ToArray();
            if (notifications is not null)
            {
                var lists = db.Lists.Where(list => notifications.Select(notification => notification.ListId).Contains(list.Id)).ToArray();
                foreach (var notification in notifications)
                {
                    var list = lists.FirstOrDefault(list => list.Id.Equals(notification.ListId));
                    if (list is not null)
                    {
                        SearchResult currentSearchResult = new SearchResult
                        {
                            NotificationName = notification.Name,
                            NotificationId = notification.Id,
                            ListName = list.Name
                        };
                        yield return currentSearchResult;
                    }
                    else
                    {
                        SearchResult sr = new SearchResult 
                        { 
                            NotificationName = "No such result", 
                            ListName = "" ,
                            NotificationId = Guid.Empty 
                        };
                        yield return sr;
                    }
                }
            }
            else
            {
                SearchResult sr = new SearchResult 
                {
                    NotificationName = "No such result",
                    ListName = "",
                    NotificationId = Guid.Empty};
                yield return sr;
            }


        }
    }





}
