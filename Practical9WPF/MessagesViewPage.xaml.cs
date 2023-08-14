using System.Windows;
using System.Windows.Controls;
using ImapX;

namespace Practical9WPF;

public partial class MessagesViewPage : Page
{
    public MessagesViewPage(Message message)
    {
        InitializeComponent();
    }

    private void BackBtn_Click(object sender, RoutedEventArgs e)
    {
        contentFrame.NavigationService.GoBack();
    }

    private void ReplyBtn_Click(object sender, RoutedEventArgs e)
    {
        ReplyAndWritePage replyAndWritePage = new ReplyAndWritePage();
        contentFrame.Content = replyAndWritePage;
    }
    
    
}