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

namespace WpfHomeworkResources
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            obj = (object[])Application.Current.Resources.Keys;
        }

        object[] obj;

        int index = 0;
        int Index
        {
            set { if (value >= 0 && obj.Length > value) index = value; }
            get { return index; }
        }

        private void BtnForward_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["imgRes1"] = (BitmapImage)Application.Current.Resources[obj[Index]];
            Index++;
        }


        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["imgRes1"] = (BitmapImage)Application.Current.Resources[obj[Index]];
            Index--;
        }
    }
}
