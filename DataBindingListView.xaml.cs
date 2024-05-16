using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for DataBindingListView.xaml
    /// </summary>
    public partial class DataBindingListView : Window
    {
        ObservableCollection<Product> products = new ObservableCollection<Product>();
        public DataBindingListView()
        {
            InitializeComponent();
            //List of Data
            products.Add(new Product { Name = "Camera" });
            products.Add(new Product { Name = "TV" });
            products.Add(new Product { Name = "Mobiile" });
            products.Add(new Product { Name = "Radio" });
            list1.ItemsSource = products;
        }
        [AddINotifyPropertyChangedInterface]
        public class Product
        {
            public string Name { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //To Add
            products.Add(new Product { Name = "Watch" });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (list1.SelectedItem != null)
            {
                //To Change
                (list1.SelectedItem as Product).Name = "Electronic Gadget";
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (list1.SelectedItem != null)
            {
                //To Delete
                products.Remove(list1.SelectedItem as Product);
            }
        }
    }
}
