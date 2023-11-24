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

using System.IO;
using Microsoft.Win32;

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

        public Dictionary<int, string> infoForCheck = new Dictionary<int,string>();

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
            MessageBoxResult result = MessageBox.Show("Занести информацию в список?", "Добавление информации", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes: MessageBox.Show("Информация успешно добавлена!", "Добавление информации", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    ListViewItem a = new ListViewItem();
                    string[] test = new string[] { $"{product.Text}", $"{curator.Text}", $"{date.Text}", $"{language.Text}", $"{check}", $"{comment.Text}" };
                    a.Content = test;
                    listView.Items.Add(a);
                    break;
                case MessageBoxResult.No: MessageBox.Show("Информация не добавлена!", "Добавление информации", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    break;
            }
        }

        private void next_table(object sender, RoutedEventArgs e)
        {
            TabControl1.SelectedItem = TabControl1.Items[1];
        }

        private void previous_table(object sender, RoutedEventArgs e)
        {
            TabControl1.SelectedItem = TabControl1.Items[0];
        }

        public double total;
        public bool ch = false;
        private void f_e(object sender, RoutedEventArgs e)
        {
            ch = !ch;

            if (ch)
            {
                front_end.Content = "Выбрано";
                sum.Text = $"{Convert.ToInt32(sum.Text) + 58900}";
                infoForCheck.Add(58900, $"{front_end_forCheck.Text} -> Цена: 58900\n");
            }
            else if (!ch)
            {
                front_end.Content = "Выбрать";
                sum.Text = $"{Convert.ToInt32(sum.Text) - 58900}";
                infoForCheck.Remove(58900);
            }
            

        }

        public bool ch1 = false;
        private void b_e(object sender, RoutedEventArgs e)
        {
            ch1 = !ch1;

            if (ch1)
            {
                back_end.Content = "Выбрано";
                sum.Text = $"{Convert.ToInt32(sum.Text) + 115000}";
                infoForCheck.Add(115000, $"{Back_end_forCheck.Text} -> Цена: 115000\n");
            }
            else if (!ch1)
            {
                back_end.Content = "Выбрать";
                sum.Text = $"{Convert.ToInt32(sum.Text) - 115000}";
                infoForCheck.Remove(115000);
            }

        }

        public bool ch2 = false;
        private void p_m(object sender, RoutedEventArgs e)
        {
            ch2 = !ch2;

            if (ch2)
            {
                software_module.Content = "Выбрано";
                sum.Text = $"{Convert.ToInt32(sum.Text) + 100000}";
                infoForCheck.Add(100000, $"{software_module_forCheck.Text} -> Цена: 100000\n");
            }
            else if (!ch2)
            {
                software_module.Content = "Выбрать";
                sum.Text = $"{Convert.ToInt32(sum.Text) - 100000}";
                infoForCheck.Remove(100000);
            }

        }

        public bool ch3 = false;
        private void android(object sender, RoutedEventArgs e)
        {
            ch3 = !ch3;

            if (ch3)
            {
                android_app.Content = "Выбрано";
                sum.Text = $"{Convert.ToInt32(sum.Text) + 125000}";
                infoForCheck.Add(125000, $"{android_app_forCheck.Text} -> Цена: 125000\n");
            }
            else if (!ch3)
            {
                android_app.Content = "Выбрать";
                sum.Text = $"{Convert.ToInt32(sum.Text) - 125000}";
                infoForCheck.Remove(125000);
            }

        }

        public bool ch4 = false;
        private void ios(object sender, RoutedEventArgs e)
        {
            ch4 = !ch4;

            if (ch4)
            {
                ios_app.Content = "Выбрано";
                sum.Text = $"{Convert.ToInt32(sum.Text) + 195000}";
                infoForCheck.Add(195000, $"{ios_app_forCheck.Text} -> Цена: 195000\n");
            }
            else if (!ch4)
            {
                ios_app.Content = "Выбрать";
                sum.Text = $"{Convert.ToInt32(sum.Text) - 195000}";
                infoForCheck.Remove(195000);
            }

        }

        public bool ch5 = false;
        private void debugging(object sender, RoutedEventArgs e)
        {
            ch5 = !ch5;

            if (ch5)
            {
                debug.Content = "Выбрано";
                sum.Text = $"{Convert.ToInt32(sum.Text) + 75000}";
                infoForCheck.Add(75000, $"{debug_forCheck.Text} -> Цена: 75000\n");
            }
            else if (!ch5)
            {
                debug.Content = "Выбрать";
                sum.Text = $"{Convert.ToInt32(sum.Text) - 75000}";
                infoForCheck.Remove(75000);
            }

        }

        private void create_check(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(sum.Text) <= 0)
            {
                MessageBox.Show("Вы не выбрали ни одну из указанных услуг!", "Чек", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                string resultForCheck = "Чек\n----------------------------------------------\n";
                foreach (var t in infoForCheck)
                {
                    resultForCheck += t.Value;
                }
                resultForCheck += $"----------------------------------------------\nК оплате: {sum.Text} руб.";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == true)
                {
                    File.WriteAllText(saveFileDialog.FileName, resultForCheck);
                }
                MessageBox.Show("Чек успешно сформирован!", "Чек", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
