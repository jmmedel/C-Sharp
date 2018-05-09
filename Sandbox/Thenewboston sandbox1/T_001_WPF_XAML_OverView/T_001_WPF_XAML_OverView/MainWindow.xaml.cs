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

namespace T_001_WPF_XAML_OverView
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
        /*
         In case you choose not to use XAML in WPF, then you can achieve the same GUI result with procedural language as well. Let’s have a look at the same example, but this time, we will create a button in C#.

using System.Windows; 
using System.Windows.Controls;  

namespace WPFXAMLOverview { 
   /// <summary> 
      /// Interaction logic for MainWindow.xaml 
   /// </summary> 
	
   public partial class MainWindow : Window { 
	
      public MainWindow() { 
         InitializeComponent(); 
			
         // Create the StackPanel 
         StackPanel stackPanel = new StackPanel(); 
         this.Content = stackPanel; 
			
         // Create the Button 
         Button button = new Button();
         button.Content = "Click Me"; 
         button.HorizontalAlignment = HorizontalAlignment.Left; 
         button.Margin = new Thickness(150); 
         button.VerticalAlignment = VerticalAlignment.Top; 
         button.Width = 75; 
         stackPanel.Children.Add(button);  
      } 
   } 
} 
             From the above example, it is clear that what you can do in XAML to create, initialize, and set properties of objects, the same tasks can also be done using code.

XAML is just another simple and easy way to design UI elements.

With XAML, it doesn’t mean that what you can do to design UI elements is the only way. You can either declare the objects in XAML or define them using code.

XAML is optional, but despite this, it is at the heart of WPF design.

The goal of XAML is to enable visual designers to create user interface elements directly.

WPF aims to make it possible to control all visual aspects of the user interface from mark-up.
        */
        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
