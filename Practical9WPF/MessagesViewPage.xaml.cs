using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ImapX;

namespace Practical9WPF;

public partial class MessagesViewPage : Page
{
    private Message _message;
    public MessagesViewPage(Message message)
    {
        InitializeComponent();
        _message = message;
        
        SenderTextBlock.Text = _message.From.ToString();
        RecipientTextBlock.Text = _message.To.FirstOrDefault()?.Address;
        SubjectTextBlock.Text = _message.Subject;
        ContentTextBlock.Text = _message.Body.Text;
    }
    private void BackBtn_Click(object sender, RoutedEventArgs e)
    {
        contentFrame.NavigationService.GoBack();
    }

    private void ReplyBtn_Click(object sender, RoutedEventArgs e)
    {
        ReplyAndWritePage replyAndWritePage = new ReplyAndWritePage();
        NavigationService.Navigate(replyAndWritePage);
    }
} 