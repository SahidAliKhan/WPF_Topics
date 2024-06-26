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
using System.Windows.Shapes;

namespace KfcApp2
{
    /// <summary>
    /// Interaction logic for DataBindingDemo.xaml
    /// </summary>
    public partial class DataBindingDemo : Window
    {
        public DataBindingDemo()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression exp = HeightTxt.GetBindingExpression(TextBox.TextProperty);
            exp.UpdateSource();
        }
    }
}
