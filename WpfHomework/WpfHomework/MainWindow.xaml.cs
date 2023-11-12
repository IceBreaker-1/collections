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

namespace WpfHomework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double area;
        public double perimeter;
        public double dlina;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Area(object sender, RoutedEventArgs e)
        {
            try
            {
                dlina = Convert.ToDouble(d.Text);
                area = Math.Round(Math.Pow(dlina, 2), 2);
                MessageBox.Show($"Площадь квадрата = {area}");
            }
            catch 
            {
                MessageBox.Show("Длина должна быть числом");
            }
        }

        private void Perimeter(object sender, RoutedEventArgs e)
        {
            try
            {
                dlina = Convert.ToDouble(d.Text);
                perimeter = dlina * 4;
                MessageBox.Show($"Периметр квадрата = {perimeter}");
            }
            catch 
            {
                MessageBox.Show("Длина должна быть числом");
            }
        }

        private void new_a(object sender, TextChangedEventArgs e)
        {
            a1.Text = d.Text;
            a2.Text = d.Text;
            a3.Text = d.Text;
            a4.Text = d.Text;
        }
    }
}
