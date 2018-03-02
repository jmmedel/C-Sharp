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
namespace T_061_WPF_Exception_Handling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReadFile(0);
        }
        void ReadFile(int index)
        {
            string path = ""; // type the path here
            StreamReader file = new StreamReader(path);
            char[] buffer = new char[80];

            try
            {
                file.ReadBlock(buffer, index, buffer.Length);
                string str = new string(buffer);
                str.Trim();
                textBox.Text = str;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading from " + path + "\nMessage = " + e.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }

    }
}
