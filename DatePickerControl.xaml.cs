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
    /// Interaction logic for DatePickerControl.xaml
    /// </summary>
    public partial class DatePickerControl : Window
    {
        public DatePickerControl()
        {
            InitializeComponent();
            DatePicker dp1 = new DatePicker();
            dp1.Name = "datepicker";
            dp1.DisplayDateStart = DateTime.Now;
            dp1.DisplayDateEnd = new DateTime(2024,03,22);
            dp1.IsTodayHighlighted = true;
            sp1.Children.Add(dp1);
        }
    }
}
