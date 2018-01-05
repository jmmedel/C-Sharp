using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_Get_All_Forms_And_Open_Form_Name
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<AppForm> list = new List<AppForm>();
            Type formtype = typeof(Form);
            
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes() )
            {
                if (formtype.IsAssignableFrom(t))
                    list.Add(new AppForm() { ID = t.FullName, FormName = t.Name });

            }
            cboxFormName.DataSource = list;
            cboxFormName.ValueMember = "Id";
            cboxFormName.DisplayMember = "Formname";
        }

        private void btmOpen_Click(object sender, EventArgs e)
        {
            AppForm obj = cboxFormName.SelectedItem as AppForm;
            if(obj != null)
            {
                Type t = Type.GetType(obj.ID);
                if(t != null)
                {
                    Form frm = Activator.CreateInstance(t) as Form;
                    if (frm != null)
                        frm.ShowDialog();
                }
            }
        }
    }
}
