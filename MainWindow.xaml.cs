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




    }
}
