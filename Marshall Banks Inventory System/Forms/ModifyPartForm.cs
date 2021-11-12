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
                outsourcedRadioButton.Checked = true;

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

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lastLabel.Text = "Machine ID";
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lastLabel.Text = "Company Name";
        }
    }
}
