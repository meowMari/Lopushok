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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        Products currentProducts;
        public AddEditPage(Products products)
        {
            InitializeComponent();
            currentProducts = products ?? new Products();

            DataContext = currentProducts;
        }
        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            ConDB.mainFrame.GoBack();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentProducts.Title))
                currentProducts.Title = "";
            if (string.IsNullOrWhiteSpace(currentProducts.Article))
                currentProducts.Article = "";
            if (string.IsNullOrWhiteSpace(currentProducts.Cost))
                currentProducts.Cost = "";
            if (string.IsNullOrWhiteSpace(currentProducts.ProductType))
                currentProducts.ProductType = "";
            if (string.IsNullOrWhiteSpace(currentProducts.Count))
                currentProducts.Count = "";



            if (errors.Length > 0)
            {
                MessageBox.Show($"Заполните следующие поля:\n{errors.ToString()}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (currentProducts.ID == 0)
            {
                ConDB.Context.Products.Add(currentProducts);
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

