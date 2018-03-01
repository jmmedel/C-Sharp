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

namespace T_000_WPF_Hello_World
{

    /*
     Under Templates, select Visual C# and in the middle panel, select WPF Application.

Give the project a name. Type HelloWorld in the name field and click the OK button.

By default, two files are created, one is the XAML file (mainwindow.xaml) and the other one is the CS file (mainwindow.cs)

On mainwindow.xaml, you will see two sub-windows, one is the design window and the other one is the source (XAML) window.

In WPF application, there are two ways to design an UI for your application. One is to simply drag and drop UI elements from the toolbox to the Design Window. The second way is to design your UI by writing XAML tags for UI elements. Visual Studio handles XAML tags when drag and drop feature is used for UI designing.

In mainwindow.xaml file, the following XAML tags are written by default.
    */

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
