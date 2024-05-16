using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for MessageBoxEx.xaml
    /// </summary>
    public partial class MessageBoxEx : Window
    {
        public MessageBoxEx()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Hello World", "MessageBox Example", MessageBoxButton.YesNoCancel, MessageBoxImage.Information, MessageBoxResult.No);
            switch(result)
            {
                case (MessageBoxResult.Yes):MessageBox.Show("Click Yes");
                    break;
                case (MessageBoxResult.No):
                    MessageBox.Show("Click No");
                    break;
                case (MessageBoxResult.Cancel):
                    MessageBox.Show("Click Cancel");
                    break;
            }
        }

        private void OpenDialogBoxEvent(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png File (*.png)|*.png | All Files (*.*)|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if(openFileDialog.ShowDialog()==true)
            {
                ResultOpen.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveDialogBoxEvent(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File(*.txt) | *.txt | png File (*.png)|*.png | All Files (*.*)|*.*";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, ResultOpen.Text);
            }
        }
    }
}
