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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();

            // create reference to MainForm to access the selected Product.
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];

            // Create a reference to the currently selected row and 
            // corresponding item in the data source
            Product selectedProduct = mainForm.productsDGV.CurrentRow.DataBoundItem as Product;

            // Populate associated parts list with data
            associatedPartsDGV.DataSource = selectedProduct.AssociatedParts;

            // Populate All Candidate Parts list with data
            allPartsDGV.DataSource = Inventory.PartList;
        }

        private void searchCandidatePartsButton_Click(object sender, EventArgs e)
        {

        }

        private void addCandidatePartButton_Click(object sender, EventArgs e)
        {
            // Create reference to currently selected part in available parts DGV
            Part partToAdd = allPartsDGV.CurrentRow.DataBoundItem as Part;

            // create reference to MainForm to access the selected Product.
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];

            // Create a reference to the currently selected row in ProductsDGV 
            // in the main form
            Product selectedProduct = mainForm.productsDGV.CurrentRow.DataBoundItem as Product;

            selectedProduct.AssociatedParts.Add(partToAdd);
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveProductButton_Click(object sender, EventArgs e)
        {
            int productID = 0; // Handled by addProduct
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

            Inventory.addProduct(new Product(productID, name, priceCost, inventory, min, max));

            this.Close();
        }

        private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm main = (MainForm)Application.OpenForms["MainForm"];
            main.Show();
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
                    saveProductButton.Enabled = false;
                    break;
                }
                else
                {
                    saveProductButton.Enabled = true;
                }
            }

        }
    }
}
