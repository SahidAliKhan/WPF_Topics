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
    /// Interaction logic for DataBindingAdvanced.xaml
    /// </summary>
    public partial class DataBindingAdvanced : Window
    {
        public DataBindingAdvanced()
        {
            InitializeComponent();
 
            Binding b1 = new Binding("Text");
            b1.Source = nametxt;
            resultblock.SetBinding(TextBlock.TextProperty, b1);
        }
    }
}
