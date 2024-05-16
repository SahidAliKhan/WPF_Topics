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
    /// Interaction logic for StatusBarExample.xaml
    /// </summary>
    public partial class StatusBarExample : Window
    {
        public StatusBarExample()
        {
            InitializeComponent();
        }

        private void inputtxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            int row = inputtxt.GetLineIndexFromCharacterIndex(inputtxt.CaretIndex);
            int col = inputtxt.CaretIndex - inputtxt.GetLineIndexFromCharacterIndex(row);
            txt1.Text = "Line No. " + (row + 1) + "  Characters: " + (col + 1);
        }
    }
}
