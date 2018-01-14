using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace T_021_Inheritance_And_Overriding
{    // base class
    class MyClass
    {   // public can only be inherited
        // protected only can access in base and drive class
        // cant accces out side of the 2
        protected string Name = "Kagaya";
        protected int Age = 10;
        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }
        public virtual void  overideshowmessage(string msg)
        {
            MessageBox.Show(msg);
        }
    }
    // drive class 
    class MysecondClass : MyClass
    {
        public string Haircolor = "Brown";
        public void Messageboxspecial()
        {    //access to the base class 
             //MessageBox.Show(base.Age.ToString());
           
        }
        // overide the methods using new
        public new void ShowMessage(string msg)
        {
            MessageBox.Show(msg,"MY Tiitle");
        }
        // override using virtual and override keywords
        public override void overideshowmessage(string msg)
        {
            base.overideshowmessage(msg);
        }
    }

}
