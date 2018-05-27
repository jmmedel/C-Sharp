using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_098_Inheriting_From_Existing_Controls
{
    public partial class UserControl1 : Button
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public override string Text {
            get => base.Text;
            set
            {
                if (value == "Kagaya")
                {
                    MessageBox.Show("You are not authorize to use that name");
                    base.Text = "Usercontrol";
                }
                    
            }
        }

        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("Hello");
        }

    }
}
