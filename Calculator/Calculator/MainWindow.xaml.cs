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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ICalculator _calculator;
        private string  arg1, arg2;

        public MainWindow()
        {
            InitializeComponent();
            _calculator = new Calc();
            Argument1TextBox.Clear();
            Argument1TextBox.Focus();
            Argument2TextBox.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ax = int.Parse(arg1);
            var ay = int.Parse(arg2);
            ResulTextBlock.Text = _calculator.Add(ax, ay).ToString();
        }

        private void Argument2TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            arg2 = Argument2TextBox.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var ax = int.Parse(arg1);
            var ay = int.Parse(arg2);
            ResulTextBlock.Text = _calculator.Sub(ax, ay).ToString();
        }

        private void Argument1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            arg1 = Argument1TextBox.Text;
        }
    }
}
