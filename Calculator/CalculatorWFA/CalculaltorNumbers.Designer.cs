namespace CalculatorWFA
{
    partial class CalculatorNumbers
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
            this.FirstNumberTextBox = new System.Windows.Forms.TextBox();
            this.SecondNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddNumberButton = new System.Windows.Forms.Button();
            this.MulNumberButton = new System.Windows.Forms.Button();
            this.SubNumberButton = new System.Windows.Forms.Button();
            this.DivNumberButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstNumberTextBox
            // 
            this.FirstNumberTextBox.Location = new System.Drawing.Point(24, 30);
            this.FirstNumberTextBox.Name = "FirstNumberTextBox";
            this.FirstNumberTextBox.Size = new System.Drawing.Size(89, 20);
            this.FirstNumberTextBox.TabIndex = 0;
            this.FirstNumberTextBox.TextChanged += new System.EventHandler(this.FirstNumberTextBox_TextChanged);
            // 
            // SecondNumberTextBox
            // 
            this.SecondNumberTextBox.Location = new System.Drawing.Point(128, 30);
            this.SecondNumberTextBox.Name = "SecondNumberTextBox";
            this.SecondNumberTextBox.Size = new System.Drawing.Size(87, 20);
            this.SecondNumberTextBox.TabIndex = 1;
            // 
            // AddNumberButton
            // 
            this.AddNumberButton.Location = new System.Drawing.Point(24, 57);
            this.AddNumberButton.Name = "AddNumberButton";
            this.AddNumberButton.Size = new System.Drawing.Size(75, 23);
            this.AddNumberButton.TabIndex = 2;
            this.AddNumberButton.Text = "Add";
            this.AddNumberButton.UseVisualStyleBackColor = true;
            this.AddNumberButton.Click += new System.EventHandler(this.AddNumberButton_Click);
            // 
            // MulNumberButton
            // 
            this.MulNumberButton.Location = new System.Drawing.Point(24, 87);
            this.MulNumberButton.Name = "MulNumberButton";
            this.MulNumberButton.Size = new System.Drawing.Size(75, 23);
            this.MulNumberButton.TabIndex = 3;
            this.MulNumberButton.Text = "Mul";
            this.MulNumberButton.UseVisualStyleBackColor = true;
            this.MulNumberButton.Click += new System.EventHandler(this.MulNumberButton_Click);
            // 
            // SubNumberButton
            // 
            this.SubNumberButton.Location = new System.Drawing.Point(127, 56);
            this.SubNumberButton.Name = "SubNumberButton";
            this.SubNumberButton.Size = new System.Drawing.Size(75, 23);
            this.SubNumberButton.TabIndex = 4;
            this.SubNumberButton.Text = "Sub";
            this.SubNumberButton.UseVisualStyleBackColor = true;
            this.SubNumberButton.Click += new System.EventHandler(this.SubNumberButton_Click);
            // 
            // DivNumberButton
            // 
            this.DivNumberButton.Location = new System.Drawing.Point(127, 87);
            this.DivNumberButton.Name = "DivNumberButton";
            this.DivNumberButton.Size = new System.Drawing.Size(75, 23);
            this.DivNumberButton.TabIndex = 5;
            this.DivNumberButton.Text = "Div";
            this.DivNumberButton.UseVisualStyleBackColor = true;
            this.DivNumberButton.Click += new System.EventHandler(this.DivNumberButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(24, 138);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultTextBox.TabIndex = 6;
            this.ResultTextBox.Text = "result";
            // 
            // CalculatorNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.DivNumberButton);
            this.Controls.Add(this.SubNumberButton);
            this.Controls.Add(this.MulNumberButton);
            this.Controls.Add(this.AddNumberButton);
            this.Controls.Add(this.SecondNumberTextBox);
            this.Controls.Add(this.FirstNumberTextBox);
            this.Name = "CalculatorNumbers";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumberTextBox;
        private System.Windows.Forms.TextBox SecondNumberTextBox;
        private System.Windows.Forms.Button AddNumberButton;
        private System.Windows.Forms.Button MulNumberButton;
        private System.Windows.Forms.Button SubNumberButton;
        private System.Windows.Forms.Button DivNumberButton;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

