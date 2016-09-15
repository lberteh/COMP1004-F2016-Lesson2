namespace COMP1004_F2016_Lesson2
{
    partial class InvoiceTotalForm
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
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.DiscountPercentLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.DiscountPercentTextBox = new System.Windows.Forms.TextBox();
            this.DiscountAmountTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(13, 13);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(50, 13);
            this.SubTotalLabel.TabIndex = 0;
            this.SubTotalLabel.Text = "SubTotal";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(13, 91);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalLabel.TabIndex = 1;
            this.TotalLabel.Text = "Total";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Location = new System.Drawing.Point(13, 65);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(88, 13);
            this.DiscountAmountLabel.TabIndex = 2;
            this.DiscountAmountLabel.Text = "Discount Amount";
            // 
            // DiscountPercentLabel
            // 
            this.DiscountPercentLabel.AutoSize = true;
            this.DiscountPercentLabel.Location = new System.Drawing.Point(13, 39);
            this.DiscountPercentLabel.Name = "DiscountPercentLabel";
            this.DiscountPercentLabel.Size = new System.Drawing.Size(89, 13);
            this.DiscountPercentLabel.TabIndex = 3;
            this.DiscountPercentLabel.Text = "Discount Percent";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(112, 10);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotalTextBox.TabIndex = 4;
            // 
            // DiscountPercentTextBox
            // 
            this.DiscountPercentTextBox.BackColor = System.Drawing.Color.White;
            this.DiscountPercentTextBox.Location = new System.Drawing.Point(112, 36);
            this.DiscountPercentTextBox.Name = "DiscountPercentTextBox";
            this.DiscountPercentTextBox.ReadOnly = true;
            this.DiscountPercentTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountPercentTextBox.TabIndex = 5;
            this.DiscountPercentTextBox.Text = "10.0 %";
            // 
            // DiscountAmountTextBox
            // 
            this.DiscountAmountTextBox.BackColor = System.Drawing.Color.White;
            this.DiscountAmountTextBox.Location = new System.Drawing.Point(112, 62);
            this.DiscountAmountTextBox.Name = "DiscountAmountTextBox";
            this.DiscountAmountTextBox.ReadOnly = true;
            this.DiscountAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountAmountTextBox.TabIndex = 6;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.BackColor = System.Drawing.Color.White;
            this.TotalTextBox.Location = new System.Drawing.Point(112, 88);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(45, 123);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(137, 123);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // InvoiceTotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 163);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.DiscountAmountTextBox);
            this.Controls.Add(this.DiscountPercentTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.DiscountPercentLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Name = "InvoiceTotalForm";
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
        private System.Windows.Forms.Label DiscountPercentLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox DiscountPercentTextBox;
        private System.Windows.Forms.TextBox DiscountAmountTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

