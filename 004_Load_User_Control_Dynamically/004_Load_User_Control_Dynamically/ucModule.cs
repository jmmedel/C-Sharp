using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_Load_User_Control_Dynamically
{
    public partial class ucModule : UserControl
    {  // singleton pattern 
        private static ucModule _instance;
        public static  ucModule Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucModule();
                return _instance;
            }
        }

        public ucModule()
        {
            InitializeComponent();
        }
    }
}
