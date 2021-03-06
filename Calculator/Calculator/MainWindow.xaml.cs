﻿using System;
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

        private bool CheckInt(string str)
        {
            int number;
            bool ok;
            ok= int.TryParse(str, out number);
            ok = ok&&(number > -100 && number < 100);
            return ok;
        }

        public MainWindow()
        {
            InitializeComponent();
            _calculator = new Calc();
            //Argument1TextBox.Clear();
           Argument1TextBox.Focus();
            //Argument2TextBox.Clear();
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
            if (!CheckInt(arg2))
            {
         //      MessageBox.Show("Error");
                arg2 = "";
                Argument2TextBox.Clear();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var ax = int.Parse(arg1);
            var ay = int.Parse(arg2);
            ResulTextBlock.Text = _calculator.Sub(ax, ay).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var ax = int.Parse(arg1);
            var ay = int.Parse(arg2);
            ResulTextBlock.Text = _calculator.Mult(ax, ay).ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var ax = int.Parse(arg1);
            var ay = int.Parse(arg2);
            ResulTextBlock.Text = _calculator.Div(ax, ay).ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var ax = int.Parse(arg1);
            var ay = int.Parse(arg2);
            ResulTextBlock.Text = _calculator.Mod(ax, ay).ToString();
        }

        private void Argument1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            arg1 = Argument1TextBox.Text;

            if (!CheckInt(arg1))
            {
               // MessageBox.Show("Error");
                arg1 = "";
                Argument1TextBox.Clear();
            }
        }
    }
}
