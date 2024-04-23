using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notifier.Abstractions.Entities;
using Notifier.Database;

namespace Notifier.Dashboard;

public partial class NewNotification : Form
{
    private  IDatabase _database;
    private object _sender;
    private  Guid _listId;
    public NewNotification(object sender, Guid listId)
    {
        _listId = listId;
        _sender = sender;
        _database = new ToDoListDatabaseManager();
        InitializeComponent();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {

        this.Close();
        
    }
    private void OnFormLoaded(object sender, EventArgs e)
    {
        if(_sender is MainForm)
        {
            var lists = _database?.GetALLLists().ToArray();
            listsListBox.Items.AddRange(lists);
        }
        else
        {
            List list = _database.GetListByListId(_listId);
            listsListBox.Items.Add(list);
        }


    }

    private void doneButton_Click(object sender, EventArgs e)
    {
        
        string? name = newNotificationNameTextBox.Text;
        string? description = descriptionTextBox.Text;
        DateTime dateTime = newNotificationDateTimePicker.Value;
        if (newNotificationDateTimePicker.Value.Equals("01.01.2023"))
        {
            dateTime = default(DateTime);
        }
        bool isImportant = isImportantCheckBox.Checked;
        var selectedList = listsListBox.SelectedItem as List;
        if (selectedList is null || name == "")
        {
            MessageBox.Show("Please fill required fields!");
            return;
        }
        else
        {
            Guid listId = selectedList.Id;
            _database.AddNotification(listId, name, description, dateTime, isImportant);
            MessageBox.Show($"A new {name} notification was successfully created");
            if(_sender is MainForm)
            {
                MainForm.instance.UpdateDashboard();
            }
            else
            {
                ListInfo.instance?.UpdateListNotificationsBox();
            }
            
            this.Close();
        }
        
    }
}
