
namespace Marshall_Banks_Inventory_System
{
    partial class MainForm
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
            this.partsSearchBox = new System.Windows.Forms.TextBox();
            this.searchPartsButton = new System.Windows.Forms.Button();
            this.partsGridViewLabel = new System.Windows.Forms.Label();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.partsDGV = new System.Windows.Forms.DataGridView();
            this.productsDGV = new System.Windows.Forms.DataGridView();
            this.deleteProductsButton = new System.Windows.Forms.Button();
            this.ModifyProductsButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // partsSearchBox
            // 
            this.partsSearchBox.CausesValidation = false;
            this.partsSearchBox.Location = new System.Drawing.Point(389, 59);
            this.partsSearchBox.Multiline = true;
            this.partsSearchBox.Name = "partsSearchBox";
            this.partsSearchBox.Size = new System.Drawing.Size(213, 32);
            this.partsSearchBox.TabIndex = 4;
            // 
            // searchPartsButton
            // 
            this.searchPartsButton.Location = new System.Drawing.Point(310, 59);
            this.searchPartsButton.Name = "searchPartsButton";
            this.searchPartsButton.Size = new System.Drawing.Size(62, 23);
            this.searchPartsButton.TabIndex = 3;
            this.searchPartsButton.Text = "Search";
            this.searchPartsButton.UseVisualStyleBackColor = true;
            this.searchPartsButton.Click += new System.EventHandler(this.searchPartsButton_Click);
            // 
            // partsGridViewLabel
            // 
            this.partsGridViewLabel.AutoSize = true;
            this.partsGridViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGridViewLabel.Location = new System.Drawing.Point(11, 68);
            this.partsGridViewLabel.Name = "partsGridViewLabel";
            this.partsGridViewLabel.Size = new System.Drawing.Size(68, 29);
            this.partsGridViewLabel.TabIndex = 5;
            this.partsGridViewLabel.Text = "Parts";
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(365, 359);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(75, 33);
            this.AddPartButton.TabIndex = 8;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.Location = new System.Drawing.Point(446, 359);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(75, 33);
            this.ModifyPartButton.TabIndex = 9;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(527, 359);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(75, 33);
            this.deletePartButton.TabIndex = 10;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // partsDGV
            // 
            this.partsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDGV.Location = new System.Drawing.Point(16, 100);
            this.partsDGV.MultiSelect = false;
            this.partsDGV.Name = "partsDGV";
            this.partsDGV.ReadOnly = true;
            this.partsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDGV.Size = new System.Drawing.Size(586, 253);
            this.partsDGV.TabIndex = 14;
            this.partsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsDGV_CellClick);
            this.partsDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.partsDGV_DataBindingComplete);
            // 
            // productsDGV
            // 
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.Location = new System.Drawing.Point(650, 100);
            this.productsDGV.MultiSelect = false;
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.ReadOnly = true;
            this.productsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDGV.Size = new System.Drawing.Size(586, 253);
            this.productsDGV.TabIndex = 21;
            // 
            // deleteProductsButton
            // 
            this.deleteProductsButton.Location = new System.Drawing.Point(1161, 359);
            this.deleteProductsButton.Name = "deleteProductsButton";
            this.deleteProductsButton.Size = new System.Drawing.Size(75, 33);
            this.deleteProductsButton.TabIndex = 20;
            this.deleteProductsButton.Text = "Delete";
            this.deleteProductsButton.UseVisualStyleBackColor = true;
            // 
            // ModifyProductsButton
            // 
            this.ModifyProductsButton.Location = new System.Drawing.Point(1080, 359);
            this.ModifyProductsButton.Name = "ModifyProductsButton";
            this.ModifyProductsButton.Size = new System.Drawing.Size(75, 33);
            this.ModifyProductsButton.TabIndex = 19;
            this.ModifyProductsButton.Text = "Modify";
            this.ModifyProductsButton.UseVisualStyleBackColor = true;
            this.ModifyProductsButton.Click += new System.EventHandler(this.ModifyProductsButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(999, 359);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 33);
            this.AddProductButton.TabIndex = 18;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Products";
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(1023, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 32);
            this.textBox1.TabIndex = 16;
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.Location = new System.Drawing.Point(944, 59);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(62, 23);
            this.searchProductsButton.TabIndex = 15;
            this.searchProductsButton.Text = "Search";
            this.searchProductsButton.UseVisualStyleBackColor = true;
            this.searchProductsButton.Click += new System.EventHandler(this.searchProductsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1161, 424);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 33);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(73, 368);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 23;
            this.testButton.Text = "testButton";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 469);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.productsDGV);
            this.Controls.Add(this.deleteProductsButton);
            this.Controls.Add(this.ModifyProductsButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchProductsButton);
            this.Controls.Add(this.partsDGV);
            this.Controls.Add(this.deletePartButton);
            this.Controls.Add(this.ModifyPartButton);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.partsGridViewLabel);
            this.Controls.Add(this.partsSearchBox);
            this.Controls.Add(this.searchPartsButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.partsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox partsSearchBox;
        private System.Windows.Forms.Button searchPartsButton;
        private System.Windows.Forms.Label partsGridViewLabel;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.DataGridView productsDGV;
        private System.Windows.Forms.Button deleteProductsButton;
        private System.Windows.Forms.Button ModifyProductsButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchProductsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView partsDGV;
        private System.Windows.Forms.Button testButton;
    }
}

