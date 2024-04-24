using Notifier.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier.Abstractions.Entities;

public class SearchResult
{
    private IDatabase _database = new ToDoListDatabaseManager();
    public string NotificationName { get; set; }
    public Guid NotificationId { get; set; }
    public string ListName { get; set; }
    public static List<SearchResult> searchResults = new List<SearchResult>();
    public void Search(string key)
    {
        searchResults.Clear();
        var receivedSerchResults = _database.GetSearchResults(key);
        searchResults.AddRange(receivedSerchResults); 
    }
}
