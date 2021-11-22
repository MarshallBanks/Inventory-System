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
            productsDGV.DataSource = Inventory.ProductList;
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

            try
            {
                if (!partsDGV.CurrentRow.Selected)
                {
                    MessageBox.Show("Please select the part you wish to delete", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Part selectedPart = partsDGV.CurrentRow.DataBoundItem as Part;

                    DialogResult answer = MessageBox.Show($"Are you sure you wish to delete {selectedPart.Name} from the list?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (answer != DialogResult.Yes)
                    {
                        return;
                    }
                    
                    Inventory.deletePart(selectedPart);

                    /*if (Inventory.deletePart(selectedPart))
                    {
                        MessageBox.Show($"{selectedPart.Name} was deleted");
                    }
                    else
                    {
                        MessageBox.Show($"{selectedPart.Name} failed to delete");
                    }*/
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please select the part you wish to delete", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void searchProductsButton_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempSearchList = new BindingList<Product>();
            bool searchTxtFound = false;
            if (productsSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.ProductList.Count; ++i)
                {
                    if (Inventory.ProductList[i].Name.ToLower().Contains(productsSearchBox.Text.ToLower()))
                    {
                        TempSearchList.Add(Inventory.ProductList[i]);
                        searchTxtFound = true;
                    }
                }
                if (searchTxtFound)
                {
                    productsDGV.DataSource = TempSearchList;
                }

            }
            if (!searchTxtFound)
            {
                MessageBox.Show($"\"{productsSearchBox.Text}\" not found.");
                productsDGV.DataSource = Inventory.ProductList;
            }
        }

        private void searchPartsButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempSearchList = new BindingList<Part>();
            bool searchTxtFound = false;
            if (partsSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.PartList.Count; ++i)
                {
                    if (Inventory.PartList[i].Name.ToLower().Contains(partsSearchBox.Text.ToLower()))
                    {
                        TempSearchList.Add(Inventory.PartList[i]);
                        searchTxtFound = true;
                    }
                }
                if(searchTxtFound)
                {
                    partsDGV.DataSource = TempSearchList;
                }

            }
            if(!searchTxtFound)
            {
                MessageBox.Show($"\"{partsSearchBox.Text}\" not found.");
                partsDGV.DataSource = Inventory.PartList;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // for testing and debugging during development
        private void testButton_Click(object sender, EventArgs e)
        {
            foreach (Product product in Inventory.ProductList)
            {
                int index = Inventory.ProductList.IndexOf(product);
                MessageBox.Show($"{product.Name}'s index is {index}");
            }
            
        
        }

        private void partsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(partsDGV.CurrentRow.Cells["PartID"].Value + " was clicked");
        }

        private void partsDGV_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           partsDGV.Rows[0].Selected = false;
        }

        private void productsDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productsDGV.Rows[0].Selected = false;
        }
    }
}
