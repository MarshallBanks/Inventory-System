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
    public partial class ModifyPartForm : Form
    {
        public ModifyPartForm()
        {
            InitializeComponent();

            // create reference to MainForm to access the partsDGV.
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];

            // Create a reference to the currently selected row and 
            // corresponding item in the data source
            Part selectedPart = mainForm.partsDGV.CurrentRow.DataBoundItem as Part;

            // Determine if Part is inHouse or Outsourced
            // Check correct radio button and pre-fill last text box
            if (selectedPart is Outsourced)
            {
                // Create reference to the selected part as an outSourced type
                // to get class specific variable CompanyName
                Outsourced partToModify = (Outsourced)selectedPart;
                outSourcedRadioButton.Checked = true;

                // Populate CompanyName TextBox
                lastTextBox.Text = partToModify.CompanyName.ToString();
            }
            else if(selectedPart is Inhouse)
            {
                // Create reference to the selected part as an inHouse type
                // to get class specific variable MachineID
                Inhouse partToModify = (Inhouse)selectedPart;
                inHouseRadioButton.Checked = true;

                //populate Machine ID TextBox
                lastTextBox.Text = partToModify.MachineID.ToString();
            }

            // Populate TextBoxes
            idTextBox.Text = selectedPart.PartID.ToString();
            nameTextBox.Text = selectedPart.Name.ToString();
            inventoryTextBox.Text = selectedPart.InStock.ToString();
            priceTextBox.Text = selectedPart.Price.ToString();
            maxTextBox.Text = selectedPart.Max.ToString();
            minTextBox.Text = selectedPart.Min.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (outSourcedRadioButton.Checked == true)
            {
                int partID = int.Parse(idTextBox.Text); 
                string name = nameTextBox.Text;
                int inventory = int.Parse(inventoryTextBox.Text);
                decimal priceCost = decimal.Parse(priceTextBox.Text);
                int max = int.Parse(maxTextBox.Text);
                int min = int.Parse(minTextBox.Text);
                string companyName = lastTextBox.Text;

                if (min > max)
                {
                    maxTextBox.BackColor = Color.FromArgb(255, 128, 128);
                    minTextBox.BackColor = Color.FromArgb(255, 128, 128);
                    MessageBox.Show("The Minimum cannot be more than the Maximum.", "Invalid Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Inventory.updatePart(new Outsourced(partID, name, priceCost, inventory, min, max, companyName));
            }
            else // 
            {
                int partID = int.Parse(idTextBox.Text); // Need to fix
                string name = nameTextBox.Text;
                int inventory = int.Parse(inventoryTextBox.Text);
                decimal priceCost = decimal.Parse(priceTextBox.Text);
                int max = int.Parse(maxTextBox.Text);
                int min = int.Parse(minTextBox.Text);
                int machineId = int.Parse(lastTextBox.Text);

                if (min > max)
                {
                    maxTextBox.BackColor = Color.FromArgb(255, 128, 128);
                    minTextBox.BackColor = Color.FromArgb(255, 128, 128);
                    MessageBox.Show("The Minimum cannot be more than the Maximum.", "Invalid Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Inventory.updatePart(new Inhouse(partID, name, priceCost, inventory, min, max, machineId));
            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyPartForm_FormClosing(object sender, FormClosingEventArgs e)
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

            if ((textBox.Name == "lastTextBox") && !textBox.Text.All(char.IsDigit) && lastLabel.Text == "Machine ID")
            {
                textBox.BackColor = Color.FromArgb(255, 128, 128);
            }

            if ((textBox.Name == "lastTextBox") && textBox.Text.All(char.IsDigit) && lastLabel.Text == "Company Name")
            {
                textBox.BackColor = Color.FromArgb(255, 128, 128);
            }


            // Checks that each textbox is valid (not red) before enabling the save button
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (tb.BackColor == Color.FromArgb(255, 128, 128))
                {
                    saveButton.Enabled = false;
                    break;
                }
                else
                {
                    saveButton.Enabled = true;
                }
            }

        }

        // Changes the label of the last text box to MachineID for In-House and Company Name for Outsourced. 
        // Clears the text that way the user cannot save a letter as a machineID by putting in a number
        // and switching to In-House 
        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lastLabel.Text = "Machine ID";
            lastTextBox.Text = "";
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lastLabel.Text = "Company Name";
            lastTextBox.Text = "";
        }


    }
}
