using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marshall_Banks_Inventory_System
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            partsDGV.DataSource = Inventory.PartList;
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddPartForm().Show();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if(!partsDGV.CurrentRow.Selected)
            {
                MessageBox.Show("Please select the part you wish to modify", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Hide();
                new ModifyPartForm().Show();
            }
            // How to get the current index/how to get the current object
            /*Part P = partsDGV.CurrentRow.DataBoundItem as Part;

            int Index = partsDGV.CurrentCell.RowIndex;

            MessageBox.Show(P.ToString() + " at row index " + Index);*/
            
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddProductForm().Show(); 
        }

        private void ModifyProductsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ModifyProductForm().Show();
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            if (partsDGV.CurrentRow == null)
            {
                MessageBox.Show("Please select the part you wish to modify", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Part selectedPart = partsDGV.CurrentRow.DataBoundItem as Part;

            Inventory.PartList.Remove(selectedPart);
        }

        private void searchProductsButton_Click(object sender, EventArgs e)
        {

        }

        private void searchPartsButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // for testing and debugging during development
        private void testButton_Click(object sender, EventArgs e)
        {
            
        }

        private void partsDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // clears selection so the first row is not selected when the form loads
            partsDGV.ClearSelection();
        }

        private void partsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(partsDGV.CurrentRow.Cells["PartID"].Value + " was clicked");
        }
    }
}
