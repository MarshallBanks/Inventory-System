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
    public partial class ModifyPartForm : Form
    {
        public ModifyPartForm()
        {
            InitializeComponent();
            Part P = MainForm.partsDGV.CurrentRow.DataBoundItem as Part
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
    }
}