using System;
using System.IO;
using System.Windows.Forms;

namespace sheet2_q7
{
    public partial class Form1 : Form
    {
        private string currentDirectory;

        public Form1()
        {
            InitializeComponent();
            InitializeExplorer();
        }

        private void InitializeExplorer()
        {
            currentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            UpdateListView();
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();

            try
            {
                DirectoryInfo directory = new DirectoryInfo(currentDirectory);

                foreach (var subdirectory in directory.GetDirectories())
                {
                    ListViewItem item = new ListViewItem(subdirectory.Name);
                    item.SubItems.Add("Folder");
                    item.SubItems.Add(subdirectory.LastWriteTime.ToString());
                    listView1.Items.Add(item);
                }

                foreach (var file in directory.GetFiles())
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.Length.ToString() + " bytes");
                    item.SubItems.Add(file.LastWriteTime.ToString());
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Up_Click(object sender, EventArgs e)
        {
            DirectoryInfo parentDirectory = Directory.GetParent(currentDirectory);

            if (parentDirectory != null)
            {
                currentDirectory = parentDirectory.FullName;
                UpdateListView();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedItemName = listView1.SelectedItems[0].Text;
                string selectedItemSize = listView1.SelectedItems[0].SubItems[1].Text;

                if (listView1.SelectedItems[0].SubItems[1].Text == "Folder")
                {
                    // Open the selected folder
                    string selectedFolderPath = Path.Combine(currentDirectory, selectedItemName);
                    currentDirectory = selectedFolderPath;
                    UpdateListView();
                }
                else
                {
                    // Display the selected item's name and size
                    MessageBox.Show($"Selected Item: {selectedItemName}\nSize: {selectedItemSize}", "Item Details");
                }
            }
        }
    }
}
