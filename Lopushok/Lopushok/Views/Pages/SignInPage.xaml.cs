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
    /// Логика взаимодействия для SignInPage.xaml
    /// </summary>
    public partial class SignInPage : Page
    {
        public SignInPage()
        {
            InitializeComponent();
        }
        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = BaseClass.db.Clients.FirstOrDefault(u => u.Login == TxbLogin.Text && u.Password == TxbPassword.Text);
            var CurrentAdmin = BaseClass.db.AuthAdmin.FirstOrDefault(u => u.Logins == TxbLogin.Text && u.Passwords == TxbPassword.Text);
            if (CurrentUser != null)
            {
                NavigationService.Navigate(new ProductForClient());

            }
            else if (CurrentAdmin != null)

            {
                NavigationService.Navigate(new ProductsLIstPage());
            }
            else
            {
                MessageBox.Show("Данных пользователя нет в базе данных, необходимо зарегистрироваться");
            }
        }
        private void BtnAddIn_Click(object sender, RoutedEventArgs e)
        {
            ConDB.mainFrame.Navigate(new AddClientsPage(null));
        }
    }
}
