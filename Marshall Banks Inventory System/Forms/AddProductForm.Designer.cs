
namespace Marshall_Banks_Inventory_System
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveProductButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.associatedPartsDGV = new System.Windows.Forms.DataGridView();
            this.addCandidatePartButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.searchCandidatePartsButton = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.allPartsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // minTextBox
            // 
            this.minTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.minTextBox.Location = new System.Drawing.Point(205, 351);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(69, 20);
            this.minTextBox.TabIndex = 4;
            this.minTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(863, 539);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(52, 34);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveProductButton
            // 
            this.saveProductButton.Enabled = false;
            this.saveProductButton.Location = new System.Drawing.Point(789, 539);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(52, 34);
            this.saveProductButton.TabIndex = 8;
            this.saveProductButton.Text = "Save";
            this.saveProductButton.UseVisualStyleBackColor = true;
            this.saveProductButton.Click += new System.EventHandler(this.saveProductButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Price / Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "ID";
            // 
            // maxTextBox
            // 
            this.maxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.maxTextBox.Location = new System.Drawing.Point(89, 351);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(69, 20);
            this.maxTextBox.TabIndex = 3;
            this.maxTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.priceTextBox.Location = new System.Drawing.Point(124, 311);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 2;
            this.priceTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.inventoryTextBox.Location = new System.Drawing.Point(124, 276);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryTextBox.TabIndex = 1;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nameTextBox.Location = new System.Drawing.Point(124, 239);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(124, 209);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 20;
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(863, 499);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(52, 34);
            this.deletePartButton.TabIndex = 9;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // associatedPartsDGV
            // 
            this.associatedPartsDGV.AllowUserToAddRows = false;
            this.associatedPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.associatedPartsDGV.Location = new System.Drawing.Point(377, 327);
            this.associatedPartsDGV.MultiSelect = false;
            this.associatedPartsDGV.Name = "associatedPartsDGV";
            this.associatedPartsDGV.ReadOnly = true;
            this.associatedPartsDGV.RowHeadersVisible = false;
            this.associatedPartsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsDGV.Size = new System.Drawing.Size(586, 147);
            this.associatedPartsDGV.TabIndex = 62;
            // 
            // addCandidatePartButton
            // 
            this.addCandidatePartButton.Location = new System.Drawing.Point(863, 276);
            this.addCandidatePartButton.Name = "addCandidatePartButton";
            this.addCandidatePartButton.Size = new System.Drawing.Size(52, 34);
            this.addCandidatePartButton.TabIndex = 7;
            this.addCandidatePartButton.Text = "Add";
            this.addCandidatePartButton.UseVisualStyleBackColor = true;
            this.addCandidatePartButton.Click += new System.EventHandler(this.addCandidatePartButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Parts Associated with this Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "All Candidate Parts";
            // 
            // searchCandidatePartsButton
            // 
            this.searchCandidatePartsButton.Location = new System.Drawing.Point(675, 72);
            this.searchCandidatePartsButton.Name = "searchCandidatePartsButton";
            this.searchCandidatePartsButton.Size = new System.Drawing.Size(59, 20);
            this.searchCandidatePartsButton.TabIndex = 6;
            this.searchCandidatePartsButton.Text = "Search";
            this.searchCandidatePartsButton.UseVisualStyleBackColor = true;
            this.searchCandidatePartsButton.Click += new System.EventHandler(this.searchCandidatePartsButton_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(740, 72);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(223, 20);
            this.textBox7.TabIndex = 5;
            // 
            // allPartsDGV
            // 
            this.allPartsDGV.AllowUserToAddRows = false;
            this.allPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.allPartsDGV.Location = new System.Drawing.Point(377, 108);
            this.allPartsDGV.MultiSelect = false;
            this.allPartsDGV.Name = "allPartsDGV";
            this.allPartsDGV.ReadOnly = true;
            this.allPartsDGV.RowHeadersVisible = false;
            this.allPartsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsDGV.Size = new System.Drawing.Size(586, 147);
            this.allPartsDGV.TabIndex = 68;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 582);
            this.Controls.Add(this.allPartsDGV);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.searchCandidatePartsButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addCandidatePartButton);
            this.Controls.Add(this.associatedPartsDGV);
            this.Controls.Add(this.deletePartButton);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveProductButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProductForm";
            this.Text = "Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProductForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveProductButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.DataGridView associatedPartsDGV;
        private System.Windows.Forms.Button addCandidatePartButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button searchCandidatePartsButton;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView allPartsDGV;
    }
}