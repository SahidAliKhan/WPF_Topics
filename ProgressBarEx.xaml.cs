using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for ProgressBarEx.xaml
    /// </summary>
    public partial class ProgressBarEx : Window
    {
        public ProgressBarEx()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    Status1.Value++;
            //    Thread.Sleep(100);
            //}
            BackgroundWorker backworker = new BackgroundWorker();
            backworker.WorkerReportsProgress = true;
            backworker.DoWork += backworker_DoWork;
            backworker.ProgressChanged += backworker_ProgressChanged;
            backworker.RunWorkerAsync();
        }

        private void backworker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            Status1.Value = e.ProgressPercentage;
        }

        private void backworker_DoWork(object? sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(100);
            }
        }
    }
}
