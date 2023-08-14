using System.Windows;
using System.Windows.Controls;
using ImapX;

namespace Practical9WPF;

public partial class ReplyAndWritePage : Page
{
    public ReplyAndWritePage()
    {
        InitializeComponent();
    }

    private void BackBtn_Click(object sender, RoutedEventArgs e)
    {
        contentFrame.NavigationService.GoBack();
    }

    private void SendBtn_Click(object sender, RoutedEventArgs e)
    {
        
    }
}