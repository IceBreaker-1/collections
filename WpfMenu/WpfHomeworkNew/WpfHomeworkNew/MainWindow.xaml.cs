using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfHomeworkNew
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void red_background(object sender, RoutedEventArgs e)
        {
            mainWindow1.Background = Brushes.Red;
            radio_tool_red.IsChecked = true;
            radio_red.IsChecked = true;
        }

        private void white_background(object sender, RoutedEventArgs e)
        {
            mainWindow1.Background = Brushes.White;
            radio_tool_white.IsChecked = true;
            radio_white.IsChecked = true;
        }

        private void blue_background(object sender, RoutedEventArgs e)
        {
            mainWindow1.Background = Brushes.Blue;
            radio_tool_blue.IsChecked = true;
            radio_blue.IsChecked = true;
        }

        private void about_developer(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик - Мурзин Никита", "Информация о разработчике", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void close_window(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void radio_red_status_E(object sender, MouseEventArgs e)
        {
            status.Text = "Меняет цвет фона на красный";
        }

        private void radio_white_status_E(object sender, MouseEventArgs e)
        {
            status.Text = "Меняет цвет фона на белый";
        }

        private void status_default(object sender, MouseEventArgs e)
        {
            status.Text = "Элемент не выбран";
        }

        private void radio_blue_status_E(object sender, MouseEventArgs e)
        {
            status.Text = "Меняет цвет фона на голубой";
        }

        private void developer_status(object sender, MouseEventArgs e)
        {
            status.Text = "Позволяет посмотреть информацию о разработчике";
        }

        private void close_status(object sender, MouseEventArgs e)
        {
            status.Text = "Закрывает приложение";
        }

        private void background_color(object sender, MouseEventArgs e)
        {
            status.Text = "Позволяет изменить цвет фона";
        }

        private void toolBar_status(object sender, MouseEventArgs e)
        {
            status.Text = "Открывает панель инструментов";
        }

        private void red_brush(object sender, RoutedEventArgs e)
        {

        }

        private void green_brush(object sender, RoutedEventArgs e)
        {

        }
    }
}
