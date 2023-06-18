using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using WpfApp2.Domain.Entities;
using WpfApp2.Infrastructure.Persistence;

namespace WpfApp2.View
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {

        private User _user = new User ();
       

        public AutorizationWindow()
        {
            InitializeComponent();
            DataContext = _user;
        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            using (var currentUser = new ApplicationDbContext())
            {
                currentUser.User.FirstOrDefault(u => u.Login == TBLogin.Text && u.Password == TBPass.Text);

                if (currentUser != null)
                {
                    MessageBox.Show("Добро пожаловать в систему", "Уведомление");

                    var Window = new MainWindow();
                    Window.Show();
                    this.Close();
                }
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window wnd  = new RegistrationWindow();
            wnd.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window wnd = new MainWindow();

            using (var context = new ApplicationDbContext())
            {

                    User user = context.User.FirstOrDefault(l => l.Login == TBLogin.Text && l.Password == TBPass.Text);
                    if (user != null)
                    {
                      
                        wnd.Show();
                    }

                    else
                    {
                        MessageBox.Show("Данных о пользователе нет в базе");
                    }
                



            }
        }
    }
}
