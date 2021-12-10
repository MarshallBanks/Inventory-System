﻿using System;
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
    public partial class ModifyProductForm : Form
    {
        // create reference to MainForm to access the selected Product.
        private MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];

        // Create a bindingList designated to only function as the associatedPartsDGV
        // Datasource.
        private BindingList<Part> tempAssociatedParts = new BindingList<Part>();

        public ModifyProductForm()
        {
            InitializeComponent();

            // Create a reference to the currently selected row in ProductsDGV 
            // in the main form
            Product selectedProduct = mainForm.productsDGV.CurrentRow.DataBoundItem as Product;

            // Populate TextBoxes
            idTextBox.Text = selectedProduct.ProductID.ToString();
            nameTextBox.Text = selectedProduct.Name.ToString();
            inventoryTextBox.Text = selectedProduct.InStock.ToString();
            priceTextBox.Text = selectedProduct.Price.ToString();
            maxTextBox.Text = selectedProduct.Max.ToString();
            minTextBox.Text = selectedProduct.Min.ToString();

            // Populate All Candidate Parts list with data
            allPartsDGV.DataSource = Inventory.PartList;
            
            // Populate associated parts list with data
            associatedPartsDGV.DataSource = tempAssociatedParts;

            foreach (Part part in selectedProduct.AssociatedParts)
            {
                tempAssociatedParts.Add(part);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Create reference to currently selected part in available parts DGV
            Part partToAdd = allPartsDGV.CurrentRow.DataBoundItem as Part;

            tempAssociatedParts.Add(partToAdd);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Part partToRemove = associatedPartsDGV.CurrentRow.DataBoundItem as Part;

            tempAssociatedParts.Remove(partToRemove);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;
            int inventory = int.Parse(inventoryTextBox.Text);
            decimal priceCost = decimal.Parse(priceTextBox.Text);
            int max = int.Parse(maxTextBox.Text);
            int min = int.Parse(minTextBox.Text);

            if (min > max)
            {
                maxTextBox.BackColor = Color.FromArgb(255, 128, 128);
                minTextBox.BackColor = Color.FromArgb(255, 128, 128);
                MessageBox.Show("The Minimum cannot be more than the Maximum.", "Invalid Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the current row index to pass to updateProduct
            int productIndex = mainForm.productsDGV.CurrentCell.RowIndex;

            Inventory.updateProduct(productIndex, new Product(productID, name, priceCost, inventory, min, max));

            this.Close();
        }

        private void ModifyProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

            // Create reference to the sender object as a TextBox so handler 
            // can be used with all texboxes
            TextBox textBox = (TextBox)sender;

            // Sets textbox background color to red if there is no text 
            // so user knows to fill out required fields
            if (textBox.Text != "")
            {
                textBox.BackColor = SystemColors.ControlLightLight;
            }
            else
            {
                textBox.BackColor = Color.FromArgb(255, 128, 128);
            }

            if ((textBox.Name == "inventoryTextBox") && !textBox.Text.All(char.IsDigit))
            {
                textBox.BackColor = Color.FromArgb(255, 128, 128);
            }

            if ((textBox.Name == "maxTextBox") && !textBox.Text.All(char.IsDigit))
            {
                textBox.BackColor = Color.FromArgb(255, 128, 128);
            }

            if ((textBox.Name == "minTextBox") && !textBox.Text.All(char.IsDigit))
            {
                textBox.BackColor = Color.FromArgb(255, 128, 128);
            }

            if ((textBox.Name == "priceTextBox") && !textBox.Text.All(char.IsDigit))
            {
                bool isDecimal = decimal.TryParse(textBox.Name, out decimal result);
                if (isDecimal)
                {
                    textBox.BackColor = Color.FromArgb(255, 128, 128);
                }
            }

            // Checks that each textbox is valid (not red) before enabling the save button
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (tb.BackColor == Color.FromArgb(255, 128, 128))
                {
                    modProdSaveButton.Enabled = false;
                    break;
                }
                else
                {
                    modProdSaveButton.Enabled = true;
                }
            }

        }
    }
}
