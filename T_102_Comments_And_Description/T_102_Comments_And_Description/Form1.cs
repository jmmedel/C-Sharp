using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_102_Comments_And_Description
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        #region this is a button
        private void button1_Click(object sender, EventArgs e)
        {
            // coments 
            Client a = new Client();
                
        }

        /*
        multiple line of code
     */
        #endregion
    }

    // /// is Description you can see it when youhover the class you can 
    // see What Description it is 
    /// <summary>
    /// Represent a person many properties about the person
    /// </summary>
    public class Client
    {
        public string name
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"> the Person name</param>
        void printHelloWorld(string name)
        {
            MessageBox.Show(name);
            
        }
    }

}
