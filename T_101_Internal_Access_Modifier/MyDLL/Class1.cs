using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDLL
{   
    namespace Client
    {
        public class Client
        {
            internal string Name
            {
                get;
                set;
            }
            internal int height = 25;
            public int Age
            {
                get;
                set;
            }
            public string Email
            {
                get;
                set;
            }

        }

    }

    class myclass
    {
        void MyMethod()
        {
            Client.Client c = new Client.Client();
            // itss ok to acces beucase its internal
            c.height = 21;
            
        }

    }

    
}
