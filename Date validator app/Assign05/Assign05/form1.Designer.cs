namespace Assign05
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
            this.YearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.checkDateButton = new System.Windows.Forms.Button();
            this.validLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(10, 13);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(32, 13);
            this.YearLabel.TabIndex = 1;
            this.YearLabel.Text = "&Year:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(82, 13);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 3;
            this.monthLabel.Text = "&Month:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(158, 13);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(29, 13);
            this.dayLabel.TabIndex = 5;
            this.dayLabel.Text = "&Day:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.AcceptsReturn = true;
            this.yearTextBox.AcceptsTab = true;
            this.yearTextBox.AccessibleDescription = "";
            this.yearTextBox.Location = new System.Drawing.Point(13, 30);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(65, 20);
            this.yearTextBox.TabIndex = 2;
            this.yearTextBox.Enter += new System.EventHandler(this.yearTextBox_Enter);
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(85, 30);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(70, 20);
            this.monthTextBox.TabIndex = 4;
            this.monthTextBox.Enter += new System.EventHandler(this.monthTextBox_Enter);
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(161, 30);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(70, 20);
            this.dayTextBox.TabIndex = 6;
            this.dayTextBox.Enter += new System.EventHandler(this.dayTextBox_Enter);
            // 
            // checkDateButton
            // 
            this.checkDateButton.Location = new System.Drawing.Point(151, 81);
            this.checkDateButton.Name = "checkDateButton";
            this.checkDateButton.Size = new System.Drawing.Size(80, 23);
            this.checkDateButton.TabIndex = 7;
            this.checkDateButton.Text = "&Check Date";
            this.checkDateButton.UseVisualStyleBackColor = true;
            this.checkDateButton.Click += new System.EventHandler(this.checkDateButton_Click);
            // 
            // validLabel
            // 
            this.validLabel.AutoSize = true;
            this.validLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validLabel.ForeColor = System.Drawing.Color.Green;
            this.validLabel.Location = new System.Drawing.Point(9, 81);
            this.validLabel.Name = "validLabel";
            this.validLabel.Size = new System.Drawing.Size(0, 24);
            this.validLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.checkDateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 128);
            this.Controls.Add(this.validLabel);
            this.Controls.Add(this.checkDateButton);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.YearLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Date Validator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.Button checkDateButton;
        private System.Windows.Forms.Label validLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

