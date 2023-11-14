using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfHomework
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


        public string check = "";

        private void t_true(object sender, RoutedEventArgs e)
        {
            check = "Присутствует";
        }

        private void t_false(object sender, RoutedEventArgs e)
        {
            check = "Отсутствует";
        }

        private void add_info(object sender, RoutedEventArgs e)
        {
            ListViewItem a = new ListViewItem();
            string[] test = new string[] {$"{product.Text}", $"{curator.Text}", $"{date.Text}", $"{language.Text}", $"{check}", $"{comment.Text}" };
            a.Content = test;
            listView.Items.Add(a);

        }

        private void next_table(object sender, RoutedEventArgs e)
        {
            TabControl1.SelectedItem = TabControl1.Items[1];
        }

        private void previous_table(object sender, RoutedEventArgs e)
        {
            TabControl1.SelectedItem = TabControl1.Items[0];
        }
    }
}
