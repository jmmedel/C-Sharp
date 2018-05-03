using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_Search_DataGridView_Using_ComboBox_And_TxtBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            // TODO: This line of code loads data into the 'saleData.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.saleData.sales);
            // TODO: This line of code loads data into the 'kagayaDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
            cbColumn.SelectedIndex = 0;

        }

        private void txtsearch_keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    salesBindingSource.Filter = string.Empty;
                }
                else
                    salesBindingSource.Filter = string.Format("{0} = {1}", cbColumn.Text, txtSearch.Text);

            }
        }
    }
}
