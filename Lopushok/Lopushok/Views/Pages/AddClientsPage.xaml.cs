using Lopushok.Bascon;
using Lopushok.Base;
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

namespace Lopushok.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddClientsPage.xaml
    /// </summary>

    public partial class AddClientsPage : Page
    {
        Clients currentClients;
        public AddClientsPage(Clients clients)
        {
            InitializeComponent();
            currentClients = clients ?? new Clients();

            DataContext = currentClients;
        }
        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            ConDB.mainFrame.GoBack();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentClients.Login))
                currentClients.Login = "";
            if (string.IsNullOrWhiteSpace(currentClients.Password))
                currentClients.Password = "";
            if (string.IsNullOrWhiteSpace(currentClients.Nickname))
                currentClients.Nickname = "";




            if (errors.Length > 0)
            {
                MessageBox.Show($"Заполните следующие поля:\n{errors.ToString()}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (currentClients.ID == 0)
            {
                ConDB.Context.Clients.Add(currentClients);
            }

            try
            {
                ConDB.Context.SaveChanges();
                MessageBox.Show($"Данные сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                ConDB.mainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

