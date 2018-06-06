using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_113_Make_A_Class_For_A_Foreach_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCollection mc = new MyCollection("Kagaya");
            foreach (string s in mc)
            {
                MessageBox.Show(s);
            }
        }
        class MyCollection : IEnumerator, IEnumerable
        {
            List<string> Names = new List<string>();
            int position = -1;
            public MyCollection(string name)
            {
                Names.Add(name);
                Names.Add("Medel");
                Names.Add("QWERTYUI");
            }

            public object Current
            {
                get { return Names[position]; }
            }

            public IEnumerator GetEnumerator()
            {
                return (IEnumerator)this;
            }

            public bool MoveNext()
            {
                position++;
                return (position < Names.Count);
            }

            public void Reset()
            {
                position = -1;

            }
        }

    }
}
