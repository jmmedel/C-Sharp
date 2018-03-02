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

namespace T_059_WPF_Debugging
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                double total = Convert.ToDouble(textBox1.Text) +
                Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text);
                label4.Content = total.ToString();
            }
            else
            {
                MessageBox.Show("Enter the value in all field.");
            }
        }

        /*
         
         When you compile and execute the above code, it will produce the following window. Now enter values in the textboxes and press the Total button. You will get the total value after summation of all the values entered in the textboxes.

Debugging
If you try to enter values other than real values, then the above application will crash. To find and resolve the issue (why it is crashing), you can insert break points in the button click event.

Let’s write "abc" in item 1 as shown below.

Item 1
Upon clicking the Total button, you will see that the program stops at the break point.

Program is Crashing
Now move the cursor towards the textbox1.Text and you will see that the program is trying to add abc value with the other values which is why the program is crashing.

Debugging in XAML
If you are expecting the same kind of debugging in XAML, then you will be surprised to know that it is not possible yet to debug the XAML code like debugging any other procedural language code. When you hear the term debugging in XAML code, it means try and find an error.

In data binding, your data doesn't show up on screen and you don't know why

Or an issue is related to complex layouts.

Or an alignment issue or issues in margin color, overlays, etc. with some extensive templates like ListBox and combo box.

Debugging an XAML program is something you typically do to check if your bindings work; and if it is not working, then to check what's wrong. Unfortunately setting breakpoints in XAML bindings isn't possible except in Silverlight, but we can use the Output window to check for data binding errors. Let's take a look at the following XAML code to find the error in data binding.
         */
    }
}
