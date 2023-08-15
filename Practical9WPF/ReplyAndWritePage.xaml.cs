using System;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

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
        var credentials = ImapHelper.GetCredentials();
        try
        {
            TextRange text = new TextRange(myRichTB.Document.ContentStart, myRichTB.Document.ContentEnd);

            MailMessage m = new MailMessage(credentials.Email, toTB.Text, subjectTB.Text, text.Text);
            m.IsBodyHtml = true;

            
            
            SmtpClient smtp = new SmtpClient(credentials.SmtpHost);
            smtp.Credentials = new NetworkCredential(credentials.Email, credentials.Pass);
            smtp.EnableSsl = true;
            smtp.Send(m);
            MessageBox.Show("Email sent successfully!");

        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}