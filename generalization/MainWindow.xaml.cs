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
using System.IO;
using static System.Math;

namespace generalization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int i = 0;
        delegate void Message(); // объявление делегата для вывода Характеристик
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // присваивание адреса метода через контруктор
            Message mes1 = Specifications; // делегат указывает на метод Specifications, который находится ниже
            mes1(); // Вызов

            static void Specifications()
            {
                MessageBox.Show(File.ReadAllText(@"C:\Users\misha\source\repos\generalization\generalization\resourse\Boeing747-400.txt"));
            }

        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            Class1<int> number = new Class1<int>();

            number.Add(i++);

            LabelValue.Content = "Колличество на складе: " + i + " шт";
        }

        private void ButtonResize_Click(object sender, RoutedEventArgs e)
        {
            Class1<int> number = new Class1<int>();

            if (i > 0)
            {
                number.Resize(i--);

                LabelValue.Content = "Колличество на складе: " + i + " шт";
            }
            else
            {
                MessageBox.Show("Колличество не может быть отрицательным");
            }
        }
    }
}
