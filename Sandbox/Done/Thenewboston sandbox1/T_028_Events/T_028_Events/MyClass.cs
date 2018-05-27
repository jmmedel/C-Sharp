using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_028_Events
{
    class MyClass
    {   // making your own even
        public event EventHandler OnPropertyChanged;
        public string name = "";
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(this, new EventArgs());

            }
        }
    }
}
