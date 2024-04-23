using Notifier.Dashboard;

using Notifier.Database;
using Notifier.Abstractions.Entities;
using System.Speech.Recognition;
using Notifier.UserControls;

namespace Notifier;

public partial class MainForm : Form
{
    public static MainForm instance;
    private IDatabase _database;
    public MainForm()
    {
        InitializeComponent();
        _database = new ToDoListDatabaseManager();
        instance = this;
    }

    private void addListButton_Click(object sender, EventArgs e)
    {
        var newListForm = new NewList();
        newListForm.ShowDialog();
        
    }

    private void notificationButton_Click(object sender, EventArgs e)
    {
        var newNotificationForm = new NewNotification(this, Guid.Empty);
        newNotificationForm.ShowDialog();
        

    }
    private void listsListBox_selectedIndexChanged(object sender, EventArgs e)
    {
        var selectedList = listsListBox.SelectedItem as List;
        if (selectedList is null) return;
        else
        {
            var listInfoForm = new ListInfo(selectedList);
            listInfoForm.ShowDialog();
            
        }
        
    }

    private void OnFormLoaded(object sender, EventArgs e)
    {

        var lists = _database.GetALLLists().ToArray();
        if (lists != null)
        {
            myListsLabel.Show();
            listsListBox.Show();
            listsListBox.Items.AddRange(lists);

        }
        else
        {

            myListsLabel.Hide();
            listsListBox.Hide();
        }
        allTasksAmountLabel.Text = _database?.GetALLNotifications().Count().ToString();
        doneTasksAmountLabel.Text = _database?.GetDoneNotifications().Count().ToString();
        todayTasksAmountLabel.Text = _database?.GetTodayNotifications().Count().ToString();
        scheduledTasksAmountLabel.Text = _database?.GetScheduledNotifications().Count().ToString();
        importantTasksAmountLabel.Text = _database?.GetImportantNotifications().Count().ToString();
        

    }
    public void UpdateListsListBox()
    {
        listsListBox.Items.Clear();
        var lists = _database?.GetALLLists().ToArray();
        if (lists != null)
        {
            myListsLabel.Show();
            listsListBox.Show();
            listsListBox.Items.AddRange(lists);

        }
        else
        {
            myListsLabel.Hide();
            listsListBox.Hide();
        }
    }
    public void UpdateDashboard()
    {
        allTasksAmountLabel.Text = _database?.GetALLNotifications().Count().ToString();
        doneTasksAmountLabel.Text = _database?.GetDoneNotifications().Count().ToString();
        todayTasksAmountLabel.Text = _database?.GetTodayNotifications().Count().ToString();
        scheduledTasksAmountLabel.Text = _database?.GetScheduledNotifications().Count().ToString();
        importantTasksAmountLabel.Text = _database?.GetImportantNotifications().Count().ToString();

    }

    private void microphonePictureBox_Click(object sender, EventArgs e)
    {
        SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
        Grammar word = new DictationGrammar();
        sr.LoadGrammar(word);
        try
        {
            searchTextBox.Clear();
            searchTextBox.Text = "Listening now ...";
            sr.SetInputToDefaultAudioDevice();
            RecognitionResult result = sr.Recognize();
            searchTextBox.Clear();
            searchTextBox.Text = result.Text;
        }
        catch
        {
            searchTextBox.Text = "";
            MessageBox.Show("Mic isn't found!");
        }
        finally
        {
            sr.UnloadAllGrammars();
        }

    }

    private void LoadSearchResults()
    {
        foreach (SearchResult sr in SearchResult.searchResults)
        {
            SearchResultInfo searchResultInfo = new SearchResultInfo();
            searchResultInfo.LoadDetails(sr);
            searchResultFlowLayoutPanel.Controls.Add(searchResultInfo);

        }

    }
    private void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        if (searchTextBox.TextLength >= 1)
        {
            searchResultFlowLayoutPanel.Controls.Clear();
            SearchResultInfo searchResultInfo = new SearchResultInfo();
            searchResultInfo.GetResult(searchTextBox.Text);
            LoadSearchResults();
            searchResultFlowLayoutPanel.Height = searchResultFlowLayoutPanel.Controls.Count * 54;

        }
        else
        {
            searchResultFlowLayoutPanel.Height = 0;
        }

    }
}

