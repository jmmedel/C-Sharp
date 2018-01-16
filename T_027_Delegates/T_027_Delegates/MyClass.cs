using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_027_Delegates
{
    class MyClass

    {   // delagate
        delegate void Mydelegate(string mystring);
        public void ShowThoseMessage()
        {   // adding to the delegate
            Mydelegate md = new Mydelegate(ShowMessage);
            md += ShowAnotherMessage;
            md("kagaya");
            
        }

        void ShowMessage(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);
        }

        void ShowAnotherMessage(string a)
        {
            System.Windows.Forms.MessageBox.Show(a,"Test");
        }
    }

}
