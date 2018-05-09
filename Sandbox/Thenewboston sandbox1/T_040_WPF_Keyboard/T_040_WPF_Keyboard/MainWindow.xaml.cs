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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace T_040_WPF_Keyboard
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

        private void OnTextInputButtonClick(object sender, RoutedEventArgs e)
        {
            handle();
            e.Handled = true;
        }

        private void OnTextInputKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.O && Keyboard.Modifiers == ModifierKeys.Control)
            {
                handle();
                e.Handled = true;
            }
        }
        public void handle()
        {
            MessageBox.Show("Do you want to open a file?");
        }

    }
}
