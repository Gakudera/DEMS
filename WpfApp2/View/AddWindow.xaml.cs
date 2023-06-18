using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private Product _currentProduct = new Product();


        public AddWindow( Product selectedProduct )
        {

            InitializeComponent();

            if(selectedProduct !=null)
            {
               _currentProduct = selectedProduct;
            }
            DataContext = _currentProduct;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            using (var context = new ApplicationDbContext())
            {

                StringBuilder errors = new StringBuilder();

                if (string.IsNullOrWhiteSpace(_currentProduct.Title))
                    errors.AppendLine("Укажите данные");
          

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
    }
}
