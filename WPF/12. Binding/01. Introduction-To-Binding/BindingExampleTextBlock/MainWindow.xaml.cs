using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace BindingExampleTextBlock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Bind();

            // clear one binding:
            // BindingOperations.ClearBinding(myTextBlock2, TextBlock.TextProperty);
            
            // clear all bindings:
            // BindingOperations.ClearAllBindings(myTextBlock2);
        }

        private void Bind()
        {
            Binding binding = new Binding();

            binding.ElementName = "myTextBox"; // source
            binding.Path = new PropertyPath("Text"); // source property
            myTextBlock2.SetBinding(TextBlock.TextProperty, binding); // set binding
        }
    }
}

