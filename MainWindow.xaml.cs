using System;
using System.Windows;
using System.Windows.Controls;

namespace SimpleCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddClick(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Input1.Text);
            double b = double.Parse(Input2.Text);
            double c = a + b;
            ResultText.Text = "Результат: " + c;
        }

        private void SubtractClick(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Input1.Text);
            double b = double.Parse(Input2.Text);
            double c = a - b;
            ResultText.Text = "Результат: " + c;
        }


        private void MultiplyClick(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Input1.Text);
            double b = double.Parse(Input2.Text);
            double c = a * b;
            ResultText.Text = "Результат: " + c;
        }

        private void DivideClick(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Input1.Text);
            double b = double.Parse(Input2.Text);

            if (b == 0)
            {
                ResultText.Text = "Делить на 0 нельзя!";
            }
            else
            {
                double c = a / b;
                ResultText.Text = "Результат: " + c;
            }
        }

    }
}
