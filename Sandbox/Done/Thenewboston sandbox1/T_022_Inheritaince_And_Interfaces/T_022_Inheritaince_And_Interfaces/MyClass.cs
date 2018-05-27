using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace T_022_Inheritaince_And_Interfaces
{
    class MyClass
    {
        private string Name = "Bob";
        protected int age = 10;
        public virtual void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }
    }
    
    class MysecondClass : MyClass,IMyInterface
    {
        public string Haircolor = "Blue";
        // implements the interface
        public void Myvoid()
        {
            base.ShowMessage("MY void");
        }

        public override void ShowMessage(string msg)
        {
            MessageBox.Show(msg, "MyTiitle");
        }
    }
    // interface all are no body {} simple template 
    // interface and inheritances multiple class 
    // the default for interface is public 
    // you cant set to private

    interface IMyInterface
    {
        void Myvoid();
    }

}
