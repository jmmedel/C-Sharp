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
using System.IO;
namespace WPF_002
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Contructor
        /// <summary>
        /// Default Contructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            
        }
        #endregion
        #region Loaded
        /// <summary>
        /// when the apllication first open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
             foreach (var drive in Directory.GetLogicalDrives())
            {
                var item = new TreeViewItem();
                item.Header = drive;
                item.Tag = drive;
                // comeback at 20.23   
                FolderView.Items.Add(item);
            }
        }
        #endregion
    }
}
