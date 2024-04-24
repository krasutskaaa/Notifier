using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notifier.Database;

namespace Notifier.Dashboard
{
    
    public partial class NewList : Form
    {
        private IDatabase _database;
        public NewList()
        {
            _database = new ToDoListDatabaseManager();
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            string? name = newListTextBox.Text.ToString();
            _database?.AddList(name);
            MessageBox.Show($"A new {name} list was successfully created");
            MainForm.instance?.UpdateListsListBox();
            this.Close();
        }
    }
}
