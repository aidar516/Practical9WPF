using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practical9WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            ImapHelper.Initialize((mailList.SelectedItem as ComboBoxItem).Tag.ToString());
            if (ImapHelper.Login(login.Text, password.Password))
            {
                MailWindow newWin = new MailWindow();
                newWin.Show();
                Close();
            }
            else if(ImapHelper.Login(login.Text, password.Password))
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}