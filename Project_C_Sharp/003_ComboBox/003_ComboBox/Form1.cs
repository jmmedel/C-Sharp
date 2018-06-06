using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // event handler index change 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            // get to the item of combo box set to the label lblValue
            lblValue.Text = comboBox1.Text;
        }
        // add item to the combobox in the loadout 
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Arizoma");
            comboBox1.Items.Add("Osaka");
            // clear the item combobox2
            comboBox2.Items.Clear();
            // Init Data
            List<State> list = new List<State>();
            list.Add(new State() { ID = "01", Name = "Celtic" });
            list.Add(new State() { ID = "02", Name = "Miami" });
            list.Add(new State() { ID = "03", Name = "Phili" });
            list.Add(new State() { ID = "04", Name = "LA" });
            list.Add(new State() { ID = "05", Name = "Brocklyn" });
            // set Display member and value for combobox2
            comboBox2.DataSource = list;
            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "Name";
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            State obj = comboBox2.SelectedItem as State;
            if(obj != null)
            {
                lblValue.Text = obj.Name;
            }
        }
    }
}
