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

namespace testtreug
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
        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            // Попробуем преобразовать введенные значения
            if (double.TryParse(SideA.Text, out double a) &&
                double.TryParse(SideB.Text, out double b) &&
                double.TryParse(SideC.Text, out double c))
            {
                // Проверяем, могут ли введенные значения образовать треугольник
                if (a + b > c && a + c > b && b + c > a)
                {
                    if (a == b && b == c)
                    {
                        ResultLabel.Text = "Полученный треугольник равносторонний";
                    }
                    else if (a == b || a == c || b == c)
                    {
                        ResultLabel.Text = "Полученный треугольник равнобедренный";
                    }
                    else
                    {
                        ResultLabel.Text = "Полученный треугольник разносторонний";
                    }
                }
                else
                {
                    ResultLabel.Text = "Введенные значения не образуют треугольник";
                }
            }
            else
            {
                ResultLabel.Text = "Введите корректные числовые значения для сторон";
            }
        }
    }
}