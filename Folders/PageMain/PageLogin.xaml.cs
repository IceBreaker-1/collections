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
using WpfHomeworkNew.ApplicationData;
using WpfHomeworkNew.PageAdmin;
using WpfHomeworkNew.PageStudent;

namespace WpfHomeworkNew.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void for_entry(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = AppConnect.modelOdb.User.FirstOrDefault(x => x.Login == txbLogin.Text && x.Password == psbPassword.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нет!", "Ошибка при авторизации!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (userObj.IdRole)
                    {
                        case 1:
                            MessageBox.Show("Здравствуйте, Администратор " + userObj.Name + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            AppFrame.frameMain.Navigate(new PageMenuAdmin());
                            break;
                        case 2:
                            MessageBox.Show("Здравствуйте, Ученик " + userObj.Name + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            AppFrame.frameMain.Navigate(new PageAccountStudent());
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка " + Ex.Message.ToString() + "Критическая работа приложения!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnRegIn_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageCreateAcc());
        }
    }
}
