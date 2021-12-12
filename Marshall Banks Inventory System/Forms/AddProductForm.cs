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
        // create reference to MainForm to access the selected Product.
        MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];

        // Create a bindingList designated for the associatedPartsDGV Datasource.
        private BindingList<Part> tempAssociatedParts = new BindingList<Part>();

        public AddProductForm()
        {
            InitializeComponent();

            // Populate All Candidate Parts list with data
            allPartsDGV.DataSource = Inventory.PartList;

            // Bind temporary binding list to associated parts DGV
            associatedPartsDGV.DataSource = tempAssociatedParts;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempSearchList = new BindingList<Part>();
            bool searchTxtFound = false;
            if (candidatePartsSearchBox.Text != "")
            {
                for (int i = 0; i < Inventory.PartList.Count; ++i)
                {
                    if (Inventory.PartList[i].Name.ToLower().Contains(candidatePartsSearchBox.Text.ToLower()))
                    {
                        TempSearchList.Add(Inventory.PartList[i]);
                        searchTxtFound = true;
                    }
                }
                if (searchTxtFound)
                {
                    allPartsDGV.DataSource = TempSearchList;
                }

            }
            if (!searchTxtFound)
            {
                MessageBox.Show($"\"{candidatePartsSearchBox.Text}\" not found.");
                allPartsDGV.DataSource = Inventory.PartList;
            }
        }

        private void addCandidatePartButton_Click(object sender, EventArgs e)
        {
            // Create reference to currently selected part in available parts DGV
            Part partToAdd = allPartsDGV.CurrentRow.DataBoundItem as Part;

            tempAssociatedParts.Add(partToAdd);
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            try
            {
                Part partToRemove = associatedPartsDGV.CurrentRow.DataBoundItem as Part;

                DialogResult answer = MessageBox.Show($"Are you sure you wish to delete {partToRemove.Name} from the list?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer != DialogResult.Yes)
                {
                    return;
                }

                tempAssociatedParts.Remove(partToRemove);
            }
            catch
            {
                MessageBox.Show("Please select the associated part you wish to delete", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

            // Create Product object using all data in the form
            Product newProduct = new Product(productID, name, priceCost, inventory, min, max);

            // Get any parts in the bottom DataGridView and add it to the new product
            foreach (Part part in tempAssociatedParts)
            {
                newProduct.AssociatedParts.Add(part);
            }

            Inventory.addProduct(newProduct);

            this.Close();
        }

        private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
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
