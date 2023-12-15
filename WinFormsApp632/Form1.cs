using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp632;

public partial class Form1 : Form
{
    private string currentPathListView1 = Environment.SystemDirectory;
    private string currentPathListView3 = Environment.SystemDirectory;
    private ListView activeListView;
    private ListViewColumnSorter lvwColumnSorter;
    public Form1()
    {
        InitializeComponent();
        InitializeListView();
        InitializeComboBoxes();

        this.KeyPreview = true;
        this.KeyDown += Form1_KeyDown;
        lvwColumnSorter = new ListViewColumnSorter();
        listView1.ListViewItemSorter = lvwColumnSorter;
        listView3.ListViewItemSorter = lvwColumnSorter;
    }
    private void InitializeListView()
    {
        listView1.View = View.Details;
        listView1.Columns.Add("Nazwa", 200);
        listView1.Columns.Add("Data utworzenia", 150);
        
        listView3.View = View.Details;
        listView3.Columns.Add("Nazwa", 200);
        listView3.Columns.Add("Data utworzenia", 150);
    }
    private void InitializeComboBoxes()
    {
        DriveInfo[] drives = DriveInfo.GetDrives();
        foreach (DriveInfo drive in drives)
        {
            comboBox1.Items.Add(drive.Name);
            comboBox2.Items.Add(drive.Name);

            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            if (comboBox2.Items.Count > 0) comboBox2.SelectedIndex = 0;
        }
    }

    private void LoadListViewDirectories(string path, ListView listView)
    {
        listView.Items.Clear();
        listView1.Items.Add("<-.........");
        listView3.Items.Add("<-.........");
        try
        {
            DirectoryInfo directory = new DirectoryInfo(path);

            foreach (var item in directory.GetFileSystemInfos())
            {
                ListViewItem listItem = new ListViewItem(item.Name);
                listItem.ImageKey = (item is DirectoryInfo) ? "FolderIcon" : "FileIcon";
                listItem.SubItems.Add(item.CreationTime.ToString());
                listView.Items.Add(listItem);
            }
        }
        catch (UnauthorizedAccessException)
        {
            MessageBox.Show("Brak dostêpu");
        }
    }
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentPathListView1 = comboBox1.SelectedItem.ToString();
        LoadListViewDirectories(currentPathListView1, listView1);
    }
    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentPathListView3 = comboBox2.SelectedItem.ToString();
        LoadListViewDirectories(currentPathListView3, listView3);
    }
    private void ListView1_ItemActivate(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count > 0)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];

            if(selectedItem.Text == "<-.........")
            {
                string parentPath = Directory.GetParent(currentPathListView1)?.FullName;
                if (!string.IsNullOrEmpty(parentPath))
                {
                    currentPathListView1 = parentPath;
                    LoadListViewDirectories(currentPathListView1, listView1);
                }
            }
            else
            {
                string selectedDirectory = selectedItem.Text;
                currentPathListView1 = Path.Combine(currentPathListView1, selectedDirectory);

                LoadListViewDirectories(currentPathListView1, listView1);
            }
        }
    }
    private void listView3_ItemActivate(object sender, EventArgs e)
    {
        if (listView3.SelectedItems.Count > 0)
        {
            ListViewItem selectedItem = listView3.SelectedItems[0];
            if(selectedItem.Text == "<-.........")
            {
                string parentPath = Directory.GetParent(currentPathListView3)?.FullName;
                if (!string.IsNullOrEmpty(parentPath))
                {
                    currentPathListView3 = parentPath;
                    LoadListViewDirectories(currentPathListView3, listView3);
                }
            }
            else
            {
                string selectedDirectory = selectedItem.Text;
                currentPathListView3 = Path.Combine(currentPathListView3, selectedDirectory);
                LoadListViewDirectories(currentPathListView3, listView3);
            }
        }
    }
    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F8)
        {
            string activeListViewPath = GetActiveListViewPath();
            CreateNewFolder(activeListViewPath, activeListView);
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.F7)
        {
            DeleteSelected();
            e.Handled = true;
        }
    }
    private void CreateNewFolder(string path, ListView activeListView)
    {
        string newFolderName = "NowyFolder_" + DateTime.Now.ToString("yyyyMMddHHmmss");
        string newFolderPath = Path.Combine(path, newFolderName);

        Directory.CreateDirectory(newFolderPath);

        LoadListViewDirectories(path, activeListView);
    }
    private void DeleteSelected()
    {
        if (activeListView != null && activeListView.SelectedItems.Count > 0)
        {
            string activeListViewPath = GetActiveListViewPath();
            string trashPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Kosz");

            if (!Directory.Exists(trashPath))
            {
                Directory.CreateDirectory(trashPath);
            }
            foreach (ListViewItem selectedItem in activeListView.SelectedItems)
            {
                string selectedItemPath = Path.Combine(activeListViewPath, selectedItem.Text);
                string destinationPath = Path.Combine(trashPath, selectedItem.Text);
                try
                {
                    if (File.Exists(selectedItemPath))
                    {
                        File.Move(selectedItemPath, destinationPath);
                    }
                    else if (Directory.Exists(selectedItemPath))
                    {
                        Directory.Move(selectedItemPath, destinationPath);
                    }
                    LoadListViewDirectories(activeListViewPath, activeListView);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"B³¹d podczas przenoszenia do kosza: {ex.Message}");
                }
            }
        }
    }
    private void ListView_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (sender is ListView listView && listView.SelectedItems.Count == 1)
        {
            activeListView = listView;
        }
    }

    private string GetActiveListViewPath()
    {
        if (activeListView != null)
        {
            return (activeListView == listView1) ? currentPathListView1 : currentPathListView3;
        }
        return string.Empty;
    }

    private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        ListView listView = (ListView)sender;

        if (e.Column == lvwColumnSorter.SortColumn)
        {
            if (lvwColumnSorter.Order == SortOrder.Ascending)
            {
                lvwColumnSorter.Order = SortOrder.Descending;
            }
            else
            {
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
        }
        else
        {
            lvwColumnSorter.SortColumn = e.Column;
            lvwColumnSorter.Order = SortOrder.Descending;
        }
        listView.Sort();
    }
    private void listView_ItemDrag(object sender, ItemDragEventArgs e)
    {
        ListViewItem draggedItem = e.Item as ListViewItem;
        (sender as ListView).DoDragDrop(e.Item, DragDropEffects.Copy | DragDropEffects.Move);
    }
    private void listView_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(typeof(ListViewItem)))
        {
            e.Effect = DragDropEffects.Copy | DragDropEffects.Move;
        }
        else
        {
            e.Effect = DragDropEffects.None;
        }
    }
    private void listView_DragDrop(object sender, DragEventArgs e)
    {
        ListView destinationListView = (ListView)sender;

        if (e.Data.GetDataPresent(typeof(ListViewItem)))
        {
            ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            MessageBox.Show(draggedItem.Text);
            string sourcePath = GetActiveListViewPath();
            string destinationPath = activeListView == listView3 ? currentPathListView1 : currentPathListView3;

            MessageBox.Show(destinationPath);

            if (sourcePath != destinationPath)
            {
                string sourceFilePath = Path.Combine(sourcePath, draggedItem.Text);
                string destinationFilePath = Path.Combine(destinationPath, draggedItem.Text);

                try
                {
                    if (File.Exists(sourceFilePath))
                    {
                        File.Copy(sourceFilePath, destinationFilePath, true);
                    }
                    else if (Directory.Exists(sourceFilePath))
                    {
                        CopyDirectory(sourceFilePath, destinationFilePath);
                    }
                    LoadListViewDirectories(destinationPath, destinationListView);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"B³¹d podczas kopiowania pliku lub katalogu: {ex.Message}");
                }
            }
        }
    }
    private void CopyDirectory(string sourceDir, string destDir)
    {
        if (!Directory.Exists(destDir))
        {
            Directory.CreateDirectory(destDir);
        }
        foreach (string file in Directory.GetFiles(sourceDir))
        {
            string destFile = Path.Combine(destDir, Path.GetFileName(file));
            MessageBox.Show(destFile);
            File.Copy(file, destFile, true);
        }
        foreach (string subDir in Directory.GetDirectories(sourceDir))
        {
            string destSubDir = Path.Combine(destDir, Path.GetFileName(subDir));
            CopyDirectory(subDir, destSubDir);
        }
    }
}