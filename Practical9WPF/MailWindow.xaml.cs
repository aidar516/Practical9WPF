using System.Windows;
using System.Windows.Controls;
using ImapX.Collections;

namespace Practical9WPF;

public partial class MailWindow : Window
{
    private CommonFolderCollection folders = ImapHelper.GetFolders();

    public MailWindow()
    {
        InitializeComponent();
        folders = ImapHelper.GetFolders();

        foreach (var folder in folders)
        {
            Button folderButton = new Button();
            folderButton.Style = FindResource("FolderButtonStyle") as Style;
            folderButton.Content = folder.Name;
            folderButton.Click += FolderButton_Click; 
            foldersTreeView.Items.Add(folderButton);
        }
    }

    private void FoldersTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
    {
        if (foldersTreeView.SelectedItem is TreeViewItem selectedNode)
        {
            string selectedFolderName = selectedNode.Header.ToString();
            MessagesPage messagesPage = new MessagesPage(selectedFolderName);
            contentFrame.NavigationService.Navigate(messagesPage);
        }
    }
    
    private void FolderButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button button)
        {
            string selectedFolderName = button.Content.ToString();
            MessagesPage messagesPage = new MessagesPage(selectedFolderName);
            contentFrame.Content = messagesPage;
        }
    }

    private void SendBtn_Click(object sender, RoutedEventArgs e)
    {
        ReplyAndWritePage replyAndWritePage = new ReplyAndWritePage();
        contentFrame.NavigationService.Navigate(replyAndWritePage);
    }
}