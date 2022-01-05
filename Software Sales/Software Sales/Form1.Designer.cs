namespace Software_Sales
{
    partial class discountCalculator
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
            this.calcButton = new System.Windows.Forms.Button();
            this.totalPackages = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.discountPercent = new System.Windows.Forms.TextBox();
            this.totalSaved = new System.Windows.Forms.TextBox();
            this.finalPricetxt = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.toalPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calcButton.FlatAppearance.BorderSize = 5;
            this.calcButton.Location = new System.Drawing.Point(359, 167);
            this.calcButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(176, 68);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalPackages
            // 
            this.totalPackages.Location = new System.Drawing.Point(618, 92);
            this.totalPackages.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.totalPackages.Name = "totalPackages";
            this.totalPackages.Size = new System.Drawing.Size(157, 38);
            this.totalPackages.TabIndex = 1;
            this.totalPackages.TextChanged += new System.EventHandler(this.totalPackages_TextChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(91, 95);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(517, 31);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Number of software packages purchased:";
            this.totalLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // discountPercent
            // 
            this.discountPercent.Location = new System.Drawing.Point(451, 302);
            this.discountPercent.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.discountPercent.Name = "discountPercent";
            this.discountPercent.Size = new System.Drawing.Size(157, 38);
            this.discountPercent.TabIndex = 3;
            this.discountPercent.TextChanged += new System.EventHandler(this.discountPercent_TextChanged);
            // 
            // totalSaved
            // 
            this.totalSaved.Location = new System.Drawing.Point(451, 363);
            this.totalSaved.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.totalSaved.Name = "totalSaved";
            this.totalSaved.Size = new System.Drawing.Size(157, 38);
            this.totalSaved.TabIndex = 4;
            // 
            // finalPricetxt
            // 
            this.finalPricetxt.Location = new System.Drawing.Point(451, 424);
            this.finalPricetxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.finalPricetxt.Name = "finalPricetxt";
            this.finalPricetxt.Size = new System.Drawing.Size(157, 38);
            this.finalPricetxt.TabIndex = 5;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(197, 309);
            this.discountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(230, 31);
            this.discountLabel.TabIndex = 6;
            this.discountLabel.Text = "Discount Percent:";
            this.discountLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // savingsLabel
            // 
            this.savingsLabel.AutoSize = true;
            this.savingsLabel.Location = new System.Drawing.Point(43, 370);
            this.savingsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(384, 31);
            this.savingsLabel.TabIndex = 7;
            this.savingsLabel.Text = "Discount Amount - You Saved:";
            // 
            // toalPriceLabel
            // 
            this.toalPriceLabel.AutoSize = true;
            this.toalPriceLabel.Location = new System.Drawing.Point(277, 424);
            this.toalPriceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toalPriceLabel.Name = "toalPriceLabel";
            this.toalPriceLabel.Size = new System.Drawing.Size(150, 31);
            this.toalPriceLabel.TabIndex = 8;
            this.toalPriceLabel.Text = "Final Price:";
            // 
            // discountCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 553);
            this.Controls.Add(this.toalPriceLabel);
            this.Controls.Add(this.savingsLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.finalPricetxt);
            this.Controls.Add(this.totalSaved);
            this.Controls.Add(this.discountPercent);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalPackages);
            this.Controls.Add(this.calcButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "discountCalculator";
            this.Text = "Discount Calculator";
            this.Load += new System.EventHandler(this.discountCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox totalPackages;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox discountPercent;
        private System.Windows.Forms.TextBox totalSaved;
        private System.Windows.Forms.TextBox finalPricetxt;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label savingsLabel;
        private System.Windows.Forms.Label toalPriceLabel;
    }
}

