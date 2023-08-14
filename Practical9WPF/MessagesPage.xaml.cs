using System;
using System.Collections.ObjectModel;
using System.Linq;
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
            // Показать индикатор загрузки
            loadingProgressRing.Visibility = Visibility.Visible;
            loadingProgressRing.IsActive = true;

            // Очищаем коллекцию перед загрузкой новых сообщений
            messagesCollection.Clear();

            // Асинхронно получить сообщения для выбранной папки
            var messages = await Task.Run(() => ImapHelper.GetMessagesForFolder(folderName));

            // Добавляем новые сообщения в коллекцию
            foreach (var message in messages)
            {
                messagesCollection.Add(message);
            }

            // Устанавливаем коллекцию как источник данных для ListView
            messagesLV.ItemsSource = messagesCollection;

            // Скрыть индикатор загрузки
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