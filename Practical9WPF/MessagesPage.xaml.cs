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

            // Асинхронно получить сообщения для выбранной папки
            var messages = await Task.Run(() => ImapHelper.GetMessagesForFolder(folderName));

            // Создать новую коллекцию для сообщений
            var messagesCollection = new ObservableCollection<Message>(messages);

            // Установить новую коллекцию для ListView
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
}