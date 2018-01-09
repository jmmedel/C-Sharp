using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020_Copy_Selected_Row_From_DataGridView2_other_DG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_Right_Click(object sender, EventArgs e)
        {
            for(int i = dataGridViewLeft.RowCount - 1; i >= 0; i--)
            {   
                DataGridViewRow row = dataGridViewLeft.Rows[i];
                if (Convert.ToBoolean(row.Cells["colLeftSelected"].Value))
                {
                    salesBindingSource1.Add((kagayaDataSet)row.DataBoundItem);
                    salesBindingSource.RemoveAt(row.Index);
                }
            }
        }

        private void btmLeft_Click(object sender, EventArgs e)
        {
            for(int i = dataGridViewRight.RowCount -1; i>=0; i--)
            {
                DataGridViewRow row = dataGridViewRight.Rows[i];
                if (Convert.ToBoolean(row.Cells["colRightSelected"].Value))
                {
                    salesBindingSource.Add((kagayaDataSet)row.DataBoundItem);
                    salesBindingSource1.RemoveAt(row.Index);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kagayaDataSet.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.kagayaDataSet.sales);

        }
    }
}
