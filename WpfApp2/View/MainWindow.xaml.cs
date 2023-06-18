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
using System.Windows.Shapes;
using WpfApp2.Domain.Entities;
using WpfApp2.Infrastructure.Persistence;
using WpfApp2.ViewModel;

namespace WpfApp2.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Product _currentProduct = new Product();

        private MainWindowViewModel _model;

        public MainWindow(User? user)
        {

            InitializeComponent();
            _model=(MainWindowViewModel)DataContext;
            _model.User = user;


            if ( user == null )
            {
                Add.Visibility = Visibility.Collapsed;
                //Edit.Visibility = Visibility.Collapsed;



            }
            else if ( user.Role.Title =="Manager" ) 
            {
                Add.Visibility= Visibility.Collapsed;


            }
            else if (user.Role.Title=="User")
            {
                Add.Visibility=(Visibility) Visibility.Collapsed;
                Delete.Visibility = Visibility.Collapsed;  
            }           

        }

        private void MenuItem_Click_Add(object sender, RoutedEventArgs e)
        {


            var Window = new AddWindow(null);
            Window.Show();
            this.Close();

            using (var context = new ApplicationDbContext())
            {

                StringBuilder errors = new StringBuilder();

                if (string.IsNullOrWhiteSpace(_currentProduct.Title))
                    errors.AppendLine("Укажите название продукта");
                if (_currentProduct.Manufacturer == null)
                    errors.AppendLine("Укажите производителя");

                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }

                if (_currentProduct.Id == 0)

                    context.Product.Add(_currentProduct);

                context.SaveChanges();

            }


        }


        private void MenuItem_Click_Delete(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_Edit(object sender, RoutedEventArgs e)
        {
            Window window = new AddWindow((sender as ListViewItem).DataContext as Product);
            window.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Window = new AddWindow(null);
            Window.Show();
            this.Close();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Window window = new AddWindow((sender as Button).DataContext as Product);
            window.Show();
        }

       
    }
}
