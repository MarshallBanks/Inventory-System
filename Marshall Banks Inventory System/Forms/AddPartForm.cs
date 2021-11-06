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
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Collects data from textboxes and assigned to variables
            // last variable changes based on radio button checked
            if (outsourcedRadioButton.Checked == true)
            {
                int partID = 1; // Need to fix
                string name    = nameTextBox.Text;
                int inventory = int.Parse(inventoryTextBox.Text);
                decimal priceCost = decimal.Parse(priceTextBox.Text);
                int max = int.Parse(maxTextBox.Text);
                int min = int.Parse(minTextBox.Text);
                string companyName = lastTextBox.Text;

                Inventory.addPart(new Outsourced(partID, name, priceCost, inventory, min, max, companyName));
                //MainForm.updateGrid();
                MessageBox.Show(name + "\n" + inventory + "\n" + priceCost + "\n" + max + "\n"+ min + "\n" + companyName);
            }
            else
            {
                string name = nameTextBox.Text;
                int inventory = int.Parse(inventoryTextBox.Text);
                decimal priceCost = decimal.Parse(priceTextBox.Text);
                int max = int.Parse(maxTextBox.Text);
                int min = int.Parse(minTextBox.Text);
                int machineId = int.Parse(lastTextBox.Text);
                MessageBox.Show(name + "\n" + inventory + "\n" + priceCost + "\n" + max + "\n" + min + "\n" + machineId);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Create reference to the open but hidden MainForm and show it
            // instead of creating a new instance of the MainForm. 
            MainForm main = (MainForm)Application.OpenForms["MainForm"];
            main.Show();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Checks that each textbox is filled before enabling the save button
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text) && tb.Name != "idTextBox") 
                {
                    saveButton.Enabled = false;
                    break;
                }
                else
                {
                    saveButton.Enabled = true;
                }
            }
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
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lastLabel.Text = "Company Name";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lastLabel.Text = "Machine ID";
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if (T
        }
    }
}
