using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using ImapX;
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
            // Создаем кнопку для каждой папки
            Button folderButton = new Button();
            folderButton.Style = FindResource("FolderButtonStyle") as Style;
            folderButton.Content = folder.Name;
            folderButton.Click += FolderButton_Click; // Обработчик нажатия на кнопку
            // Добавляем кнопку к TreeView
            foldersTreeView.Items.Add(folderButton);
        }
    }

    private void FoldersTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
    {
        // Проверяем, что выбран пункт TreeView (может быть null, если ничего не выбрано)
        if (foldersTreeView.SelectedItem is TreeViewItem selectedNode)
        {
            // Получаем название выбранной папки
            string selectedFolderName = selectedNode.Header.ToString();

            // Создаем новую страницу с сообщениями и передаем название папки
            MessagesPage messagesPage = new MessagesPage(selectedFolderName);

            // Загружаем страницу во Frame на текущей странице
            contentFrame.NavigationService.Navigate(messagesPage);
        }
    }
    
    private void FolderButton_Click(object sender, RoutedEventArgs e)
    {
        // Обработчик нажатия на кнопку папки
        if (sender is Button button)
        {
            string selectedFolderName = button.Content.ToString();

            // Создаем новую страницу с сообщениями и передаем название папки
            MessagesPage messagesPage = new MessagesPage(selectedFolderName);

            // Загружаем страницу во Frame на текущей странице
            contentFrame.Content = messagesPage;
        }
    }
}