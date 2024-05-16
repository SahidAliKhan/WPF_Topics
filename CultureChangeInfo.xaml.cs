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
using System.Windows.Shapes;
using System.Globalization;

namespace KfcApp2
{
    /// <summary>
    /// Interaction logic for CultureChangeInfo.xaml
    /// </summary>
    public partial class CultureChangeInfo : Window
    {
        public CultureChangeInfo()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo((sender as Button).Tag.ToString());
            lblNumber.Content = (567897432.42d).ToString("N2");
            lblDate.Content = DateTime.Now.ToString();
        }
    }
}
