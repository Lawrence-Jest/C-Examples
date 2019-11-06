namespace A00583216_Assign06
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAddProducts = new System.Windows.Forms.GroupBox();
            this.buttonAddProducts = new System.Windows.Forms.Button();
            this.comboBoxSupplierAddProducts = new System.Windows.Forms.ComboBox();
            this.labelSupplierAddProducts = new System.Windows.Forms.Label();
            this.comboBoxManufacturerAddProducts = new System.Windows.Forms.ComboBox();
            this.labelManufacturerAddProducts = new System.Windows.Forms.Label();
            this.textBoxPriceAddProducts = new System.Windows.Forms.TextBox();
            this.labelPriceAddProducts = new System.Windows.Forms.Label();
            this.textBoxDescriptionAddProducts = new System.Windows.Forms.TextBox();
            this.labelDescriptionAddProducts = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxAddProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.manufacturersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // importDataToolStripMenuItem1
            // 
            this.importDataToolStripMenuItem1.Name = "importDataToolStripMenuItem1";
            this.importDataToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.importDataToolStripMenuItem1.Text = "Import Data";
            this.importDataToolStripMenuItem1.Click += new System.EventHandler(this.importDataToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // manufacturersToolStripMenuItem
            // 
            this.manufacturersToolStripMenuItem.Name = "manufacturersToolStripMenuItem";
            this.manufacturersToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.manufacturersToolStripMenuItem.Text = "Manufacturers";
            this.manufacturersToolStripMenuItem.Click += new System.EventHandler(this.manufacturersToolStripMenuItem_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewProducts.Location = new System.Drawing.Point(39, 47);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(659, 180);
            this.dataGridViewProducts.TabIndex = 2;
            this.dataGridViewProducts.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProducts_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeleteRow});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 26);
            // 
            // toolStripMenuItemDeleteRow
            // 
            this.toolStripMenuItemDeleteRow.Name = "toolStripMenuItemDeleteRow";
            this.toolStripMenuItemDeleteRow.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemDeleteRow.Text = "Delete Row";
            this.toolStripMenuItemDeleteRow.Click += new System.EventHandler(this.toolStripMenuItemDeleteRow_Click);
            // 
            // groupBoxAddProducts
            // 
            this.groupBoxAddProducts.Controls.Add(this.buttonAddProducts);
            this.groupBoxAddProducts.Controls.Add(this.comboBoxSupplierAddProducts);
            this.groupBoxAddProducts.Controls.Add(this.labelSupplierAddProducts);
            this.groupBoxAddProducts.Controls.Add(this.comboBoxManufacturerAddProducts);
            this.groupBoxAddProducts.Controls.Add(this.labelManufacturerAddProducts);
            this.groupBoxAddProducts.Controls.Add(this.textBoxPriceAddProducts);
            this.groupBoxAddProducts.Controls.Add(this.labelPriceAddProducts);
            this.groupBoxAddProducts.Controls.Add(this.textBoxDescriptionAddProducts);
            this.groupBoxAddProducts.Controls.Add(this.labelDescriptionAddProducts);
            this.groupBoxAddProducts.Location = new System.Drawing.Point(39, 233);
            this.groupBoxAddProducts.Name = "groupBoxAddProducts";
            this.groupBoxAddProducts.Size = new System.Drawing.Size(659, 133);
            this.groupBoxAddProducts.TabIndex = 3;
            this.groupBoxAddProducts.TabStop = false;
            this.groupBoxAddProducts.Text = "Add Products";
            // 
            // buttonAddProducts
            // 
            this.buttonAddProducts.Location = new System.Drawing.Point(524, 76);
            this.buttonAddProducts.Name = "buttonAddProducts";
            this.buttonAddProducts.Size = new System.Drawing.Size(121, 23);
            this.buttonAddProducts.TabIndex = 8;
            this.buttonAddProducts.Text = "Add";
            this.buttonAddProducts.UseVisualStyleBackColor = true;
            this.buttonAddProducts.Click += new System.EventHandler(this.buttonAddProducts_Click);
            // 
            // comboBoxSupplierAddProducts
            // 
            this.comboBoxSupplierAddProducts.FormattingEnabled = true;
            this.comboBoxSupplierAddProducts.Location = new System.Drawing.Point(79, 76);
            this.comboBoxSupplierAddProducts.Name = "comboBoxSupplierAddProducts";
            this.comboBoxSupplierAddProducts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSupplierAddProducts.TabIndex = 7;
            this.comboBoxSupplierAddProducts.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxSupplierAddProducts_Validating);
            // 
            // labelSupplierAddProducts
            // 
            this.labelSupplierAddProducts.AutoSize = true;
            this.labelSupplierAddProducts.Location = new System.Drawing.Point(28, 84);
            this.labelSupplierAddProducts.Name = "labelSupplierAddProducts";
            this.labelSupplierAddProducts.Size = new System.Drawing.Size(45, 13);
            this.labelSupplierAddProducts.TabIndex = 6;
            this.labelSupplierAddProducts.Text = "Supplier";
            // 
            // comboBoxManufacturerAddProducts
            // 
            this.comboBoxManufacturerAddProducts.FormattingEnabled = true;
            this.comboBoxManufacturerAddProducts.Location = new System.Drawing.Point(524, 26);
            this.comboBoxManufacturerAddProducts.Name = "comboBoxManufacturerAddProducts";
            this.comboBoxManufacturerAddProducts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxManufacturerAddProducts.TabIndex = 5;
            this.comboBoxManufacturerAddProducts.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxManufacturerAddProducts_Validating);
            // 
            // labelManufacturerAddProducts
            // 
            this.labelManufacturerAddProducts.AutoSize = true;
            this.labelManufacturerAddProducts.Location = new System.Drawing.Point(448, 35);
            this.labelManufacturerAddProducts.Name = "labelManufacturerAddProducts";
            this.labelManufacturerAddProducts.Size = new System.Drawing.Size(70, 13);
            this.labelManufacturerAddProducts.TabIndex = 4;
            this.labelManufacturerAddProducts.Text = "Manufacturer";
            // 
            // textBoxPriceAddProducts
            // 
            this.textBoxPriceAddProducts.Location = new System.Drawing.Point(287, 28);
            this.textBoxPriceAddProducts.Name = "textBoxPriceAddProducts";
            this.textBoxPriceAddProducts.Size = new System.Drawing.Size(121, 20);
            this.textBoxPriceAddProducts.TabIndex = 3;
            this.textBoxPriceAddProducts.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPriceAddProducts_Validating);
            // 
            // labelPriceAddProducts
            // 
            this.labelPriceAddProducts.AutoSize = true;
            this.labelPriceAddProducts.Location = new System.Drawing.Point(250, 36);
            this.labelPriceAddProducts.Name = "labelPriceAddProducts";
            this.labelPriceAddProducts.Size = new System.Drawing.Size(31, 13);
            this.labelPriceAddProducts.TabIndex = 2;
            this.labelPriceAddProducts.Text = "Price";
            // 
            // textBoxDescriptionAddProducts
            // 
            this.textBoxDescriptionAddProducts.Location = new System.Drawing.Point(79, 28);
            this.textBoxDescriptionAddProducts.Name = "textBoxDescriptionAddProducts";
            this.textBoxDescriptionAddProducts.Size = new System.Drawing.Size(121, 20);
            this.textBoxDescriptionAddProducts.TabIndex = 1;
            this.textBoxDescriptionAddProducts.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDescriptionAddProducts_Validating);
            // 
            // labelDescriptionAddProducts
            // 
            this.labelDescriptionAddProducts.AutoSize = true;
            this.labelDescriptionAddProducts.Location = new System.Drawing.Point(13, 35);
            this.labelDescriptionAddProducts.Name = "labelDescriptionAddProducts";
            this.labelDescriptionAddProducts.Size = new System.Drawing.Size(60, 13);
            this.labelDescriptionAddProducts.TabIndex = 0;
            this.labelDescriptionAddProducts.Text = "Description";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 381);
            this.Controls.Add(this.groupBoxAddProducts);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Product Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxAddProducts.ResumeLayout(false);
            this.groupBoxAddProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manufacturersToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteRow;
        private System.Windows.Forms.GroupBox groupBoxAddProducts;
        private System.Windows.Forms.Label labelManufacturerAddProducts;
        private System.Windows.Forms.TextBox textBoxPriceAddProducts;
        private System.Windows.Forms.Label labelPriceAddProducts;
        private System.Windows.Forms.TextBox textBoxDescriptionAddProducts;
        private System.Windows.Forms.Label labelDescriptionAddProducts;
        private System.Windows.Forms.ComboBox comboBoxManufacturerAddProducts;
        private System.Windows.Forms.ComboBox comboBoxSupplierAddProducts;
        private System.Windows.Forms.Label labelSupplierAddProducts;
        private System.Windows.Forms.Button buttonAddProducts;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

