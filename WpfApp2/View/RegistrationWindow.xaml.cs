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

namespace WpfApp2.View
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {

        private User _user = new User();

        public RegistrationWindow()
        {
            InitializeComponent();
            DataContext = _user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (Login.Text != null || Password.Text !=null|| Name1 !=null || Name2 != null || Name3 != null)
                {
                    User user = context.User.Where(l => l.Login == Login.Text && l.Password == Password.Text && l.FirstName== Name1.Text && l.MiddleName == Name2.Text && l.LastName == Name3.Text).SingleOrDefault();
                    if (user != null)
                    {
                        MessageBox.Show("Данные существуют");

                    } 
                    else
                    {
                        user = new User();
                        user.RoleId = 1;
                        user.FirstName = Name1.Text;
                        user.LastName = Name2.Text;
                        user.MiddleName = Name3.Text;
                        user.Login = Login.Text;
                        user.Password= Password.Text;

                        context.User.Add(user);
                        context.SaveChanges();
                        this.Close();

                    }
                }
               

             


            }
        }
    }
}
