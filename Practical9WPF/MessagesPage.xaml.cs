using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ImapX;

namespace Practical9WPF;

public partial class MessagesPage : Page
{
    private ObservableCollection<Message> messagesCollection = new ObservableCollection<Message>();
    public MessagesPage(string folderName)
    {
        InitializeComponent();
        LoadMessagesAsync(folderName);
    }
    
    private async void LoadMessagesAsync(string folderName)
    {
        try
        {
            loadingProgressRing.Visibility = Visibility.Visible;
            loadingProgressRing.IsActive = true;

            messagesCollection.Clear();

            var messages = await Task.Run(() => ImapHelper.GetMessagesForFolder(folderName));

            foreach (var message in messages)
            {
                messagesCollection.Add(message);
            }

            messagesLV.ItemsSource = messagesCollection;

            loadingProgressRing.IsActive = false;
            loadingProgressRing.Visibility = Visibility.Collapsed;
        }
        catch (Exception ex)
        {
            
        }
    }

    private void MessagesLV_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        if (messagesLV.SelectedItem is Message selectedMessage)
        {
            MessagesViewPage messageViewPage = new MessagesViewPage(selectedMessage);
            NavigationService.Navigate(messageViewPage);
        }
    }

    private void OpenContext_Click(object sender, RoutedEventArgs e)
    {
        if (messagesLV.SelectedItem is Message selectedMessage)
        {
            MessagesViewPage messageViewPage = new MessagesViewPage(selectedMessage);
            NavigationService.Navigate(messageViewPage);
        }
    }

    private void SendContext_Click(object sender, RoutedEventArgs e)
    {
        ReplyAndWritePage replyAndWritePage = new ReplyAndWritePage();
        NavigationService.Navigate(replyAndWritePage);
    }
}