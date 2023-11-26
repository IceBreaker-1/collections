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

        private void ex1_addName(object sender, RoutedEventArgs e)
        {
            if (ex1_name.Text == "")
            {
                MessageBox.Show("Введите имя!", "Задание 1", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show($"Введённое имя - {ex1_name.Text}", "Задание 1", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }

        private void ex2_addTextFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                ex2_text.Text = File.ReadAllText(openFileDialog.FileName);
            }

        }

        private void ex3_addImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Png-изображения (*.png)|*.png|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;
                ex3_Image.Source = new BitmapImage(new Uri(fileName));
            }

        }
    }
}
