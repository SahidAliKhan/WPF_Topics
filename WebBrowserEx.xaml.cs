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

namespace KfcApp2
{
    /// <summary>
    /// Interaction logic for WebBrowserEx.xaml
    /// </summary>
    public partial class WebBrowserEx : Window
    {
        public WebBrowserEx()
        {
            InitializeComponent();
            WebBroswer1.Navigate("https://www.google.co.in/");
        }

        private void WebBroswer1_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            //MessageBox.Show(e.Uri.OriginalString);
            urltxt.Text = e.Uri.OriginalString;
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ((WebBroswer1 != null) && (WebBroswer1.CanGoBack));
        }

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ((WebBroswer1 != null) && (WebBroswer1.CanGoForward));
        }

        private void CommandBinding_CanExecute_2(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            WebBroswer1.GoBack();
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            WebBroswer1.GoForward();
        }

        private void CommandBinding_Executed_2(object sender, ExecutedRoutedEventArgs e)
        {
            WebBroswer1.Navigate(urltxt.Text);
        }

        private void urltxt_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                WebBroswer1.Navigate(urltxt.Text);
            }
        }
    }
}
