using System;
using System.Windows;
using System.Windows.Input;

namespace CustomCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Application exit: " + DateTime.Now.ToShortDateString() + " " +
                DateTime.Now.ToLongTimeString());

                writer.Flush();
            }

            this.Close();
        }
    }
}
