using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_024_Structs
{
    // struct
    struct Client 
    {
        public Client(string name)
        {
            Name = name;
            Age = 0;
        }
        public string Name;
        public int Age;
        public void ClearClientInfo()
        {
            Name = "";
            Age = 0;

        }
    }

    

}
