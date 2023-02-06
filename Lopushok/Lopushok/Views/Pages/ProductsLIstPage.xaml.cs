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
    /// Логика взаимодействия для ProductsLIstPage.xaml
    /// </summary>
    public partial class ProductsLIstPage : Page
    {
        public ProductsLIstPage()
        {
            InitializeComponent();
            productListView.ItemsSource = ConDB.Context.Products.ToList();

            var Filteritems = ConDB.Context.Products.ToList();
            Filteritems.Insert(0, new Products { Title = "Все типы" });
            sortComboBox.SelectedIndex = 0;
        }
        void Sorting()
        {
            var items = ConDB.Context.Products.ToList();

            if (sortComboBox.SelectedIndex > 0)
            {
                switch (sortComboBox.SelectedIndex)
                {
                    case 1:
                        {
                            if ((bool)ascDescCheckBox.IsChecked)
                                items = items.OrderByDescending(x => x.Title).ToList();
                            else
                                items = items.OrderBy(x => x.Title).ToList();
                            break;
                        }
                    case 2:
                        {
                            if ((bool)ascDescCheckBox.IsChecked)
                                items = items.OrderByDescending(x => x.Article).ToList();
                            else
                                items = items.OrderBy(x => x.Article).ToList();
                            break;
                        }
                }
            }
            if (searchTextBox.Text.Length > 0)
            {
                items = items.Where(x => x.Title.ToLower().Contains(searchTextBox.Text.ToLower())
                                        || x.ProductType.ToLower().Contains(searchTextBox.Text.ToLower())
                                        || x.Title.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
            }
            productListView.ItemsSource = items;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Sorting();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Sorting();
        }

        private void sortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Sorting();
        }

        private void filterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Sorting();
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Sorting();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var itemToDelete = productListView.SelectedItem as Products;
            if (itemToDelete != null)
            {
                if (MessageBox.Show($"Вы действительно хотите удалить запись №{itemToDelete.ID}", "Удаление данных", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    ConDB.Context.Products.Remove(itemToDelete);
                    try
                    {
                        ConDB.Context.SaveChanges();
                        MessageBox.Show($"Данные удалены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    return;
            }
            Sorting();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            ConDB.mainFrame.Navigate(new AddEditPage(productListView.SelectedItem as Products));
            Sorting();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            ConDB.mainFrame.Navigate(new AddEditPage(null));
            Sorting();
        }

        private void productListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            editBtn.Visibility = Visibility.Visible;
            deleteBtn.Visibility = Visibility.Visible;
        }

    }
}

