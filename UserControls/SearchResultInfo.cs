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

namespace Notifier.UserControls
{
    public partial class SearchResultInfo : UserControl
    {
        public SearchResultInfo()
        {
            InitializeComponent();
        }

        public void LoadDetails(SearchResult searchResult)
        {
            searchResultNotificationNameLabel.Text = searchResult.NotificationName;
            searchResulListNamelabel.Text = searchResult.ListName;
        }
        public void GetResult(string key)
        {
            SearchResult searchResult = new SearchResult();
            searchResult.Search(key);
            searchResultNotificationNameLabel.Text = searchResult.NotificationName;
            searchResulListNamelabel.Text = searchResult.ListName;

        }
    }
}
