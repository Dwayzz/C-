namespace PigLatin
{
    partial class PigLatin
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
            this.convertButton = new System.Windows.Forms.Button();
            this.englishWordTextBox = new System.Windows.Forms.TextBox();
            this.pigLatinTxt = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.middleLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(245, 20);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(34, 26);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "->";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // englishWordTextBox
            // 
            this.englishWordTextBox.Location = new System.Drawing.Point(82, 24);
            this.englishWordTextBox.Name = "englishWordTextBox";
            this.englishWordTextBox.Size = new System.Drawing.Size(89, 20);
            this.englishWordTextBox.TabIndex = 1;
            // 
            // pigLatinTxt
            // 
            this.pigLatinTxt.Location = new System.Drawing.Point(294, 24);
            this.pigLatinTxt.Name = "pigLatinTxt";
            this.pigLatinTxt.Size = new System.Drawing.Size(100, 20);
            this.pigLatinTxt.TabIndex = 2;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(24, 27);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(52, 13);
            this.inputLabel.TabIndex = 3;
            this.inputLabel.Text = "The word";
            this.inputLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // middleLabel
            // 
            this.middleLabel.AutoSize = true;
            this.middleLabel.Location = new System.Drawing.Point(177, 27);
            this.middleLabel.Name = "middleLabel";
            this.middleLabel.Size = new System.Drawing.Size(62, 13);
            this.middleLabel.TabIndex = 4;
            this.middleLabel.Text = "in English is";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(400, 27);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(59, 13);
            this.endLabel.TabIndex = 5;
            this.endLabel.Text = "in Pig Latin";
            // 
            // PigLatin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 62);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.middleLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.pigLatinTxt);
            this.Controls.Add(this.englishWordTextBox);
            this.Controls.Add(this.convertButton);
            this.Name = "PigLatin";
            this.Text = "Pig Latin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox englishWordTextBox;
        private System.Windows.Forms.TextBox pigLatinTxt;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label middleLabel;
        private System.Windows.Forms.Label endLabel;
    }
}

