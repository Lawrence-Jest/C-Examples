namespace A00583216_Assign06
{
    partial class FormManufacturerInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManufacturerInput));
            this.labelManufacturerName = new System.Windows.Forms.Label();
            this.labelManufacturerDiscount = new System.Windows.Forms.Label();
            this.textBoxManufacturerName = new System.Windows.Forms.TextBox();
            this.textBoxMaufacturerDiscount = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelManufacturerName
            // 
            this.labelManufacturerName.AutoSize = true;
            this.labelManufacturerName.Location = new System.Drawing.Point(23, 33);
            this.labelManufacturerName.Name = "labelManufacturerName";
            this.labelManufacturerName.Size = new System.Drawing.Size(104, 13);
            this.labelManufacturerName.TabIndex = 0;
            this.labelManufacturerName.Text = "Manufacturer Name:";
            // 
            // labelManufacturerDiscount
            // 
            this.labelManufacturerDiscount.AutoSize = true;
            this.labelManufacturerDiscount.Location = new System.Drawing.Point(23, 77);
            this.labelManufacturerDiscount.Name = "labelManufacturerDiscount";
            this.labelManufacturerDiscount.Size = new System.Drawing.Size(52, 13);
            this.labelManufacturerDiscount.TabIndex = 1;
            this.labelManufacturerDiscount.Text = "Discount:";
            // 
            // textBoxManufacturerName
            // 
            this.textBoxManufacturerName.Location = new System.Drawing.Point(134, 33);
            this.textBoxManufacturerName.Name = "textBoxManufacturerName";
            this.textBoxManufacturerName.Size = new System.Drawing.Size(187, 20);
            this.textBoxManufacturerName.TabIndex = 2;
            // 
            // textBoxMaufacturerDiscount
            // 
            this.textBoxMaufacturerDiscount.Location = new System.Drawing.Point(134, 77);
            this.textBoxMaufacturerDiscount.Name = "textBoxMaufacturerDiscount";
            this.textBoxMaufacturerDiscount.Size = new System.Drawing.Size(187, 20);
            this.textBoxMaufacturerDiscount.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(134, 115);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(246, 115);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormManufacturerInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 158);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxMaufacturerDiscount);
            this.Controls.Add(this.textBoxManufacturerName);
            this.Controls.Add(this.labelManufacturerDiscount);
            this.Controls.Add(this.labelManufacturerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManufacturerInput";
            this.Text = "Manufacturer Input";
            this.Load += new System.EventHandler(this.FormManufacturerInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManufacturerName;
        private System.Windows.Forms.Label labelManufacturerDiscount;
        private System.Windows.Forms.TextBox textBoxManufacturerName;
        private System.Windows.Forms.TextBox textBoxMaufacturerDiscount;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}