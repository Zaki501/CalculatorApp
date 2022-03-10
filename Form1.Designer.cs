namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.nDot = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.nAdd = new System.Windows.Forms.Button();
            this.nSubtract = new System.Windows.Forms.Button();
            this.nMultiply = new System.Windows.Forms.Button();
            this.nDivide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox
            // 
            this.TxtBox.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBox.Location = new System.Drawing.Point(5, 12);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(529, 54);
            this.TxtBox.TabIndex = 0;
            this.TxtBox.Text = "0";
            this.TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBox.TextChanged += new System.EventHandler(this.TxtBox_TextChanged);
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n1.Location = new System.Drawing.Point(14, 93);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(90, 90);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.nButton_Click);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n2.Location = new System.Drawing.Point(108, 93);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(90, 90);
            this.n2.TabIndex = 1;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.nButton_Click);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n3.Location = new System.Drawing.Point(204, 93);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(90, 90);
            this.n3.TabIndex = 1;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.nButton_Click);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n4.Location = new System.Drawing.Point(12, 189);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(90, 90);
            this.n4.TabIndex = 1;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.nButton_Click);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n5.Location = new System.Drawing.Point(108, 189);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(90, 90);
            this.n5.TabIndex = 1;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.nButton_Click);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n6.Location = new System.Drawing.Point(204, 189);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(90, 90);
            this.n6.TabIndex = 1;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.nButton_Click);
            // 
            // n7
            // 
            this.n7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n7.Location = new System.Drawing.Point(12, 285);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(90, 90);
            this.n7.TabIndex = 1;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.nButton_Click);
            // 
            // n8
            // 
            this.n8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n8.Location = new System.Drawing.Point(108, 285);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(90, 90);
            this.n8.TabIndex = 1;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.nButton_Click);
            // 
            // n9
            // 
            this.n9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n9.Location = new System.Drawing.Point(204, 285);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(90, 90);
            this.n9.TabIndex = 1;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.nButton_Click);
            // 
            // n0
            // 
            this.n0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n0.Location = new System.Drawing.Point(12, 381);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(90, 90);
            this.n0.TabIndex = 1;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.nButton_Click);
            // 
            // nDot
            // 
            this.nDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nDot.Location = new System.Drawing.Point(108, 381);
            this.nDot.Name = "nDot";
            this.nDot.Size = new System.Drawing.Size(90, 90);
            this.nDot.TabIndex = 1;
            this.nDot.Text = ".";
            this.nDot.UseVisualStyleBackColor = true;
            this.nDot.Click += new System.EventHandler(this.nButton_Click);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equals.Location = new System.Drawing.Point(204, 381);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(90, 90);
            this.equals.TabIndex = 1;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // nAdd
            // 
            this.nAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nAdd.Location = new System.Drawing.Point(300, 93);
            this.nAdd.Name = "nAdd";
            this.nAdd.Size = new System.Drawing.Size(90, 90);
            this.nAdd.TabIndex = 1;
            this.nAdd.Text = "+";
            this.nAdd.UseVisualStyleBackColor = true;
            this.nAdd.Click += new System.EventHandler(this.nButton_Click);
            // 
            // nSubtract
            // 
            this.nSubtract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nSubtract.Location = new System.Drawing.Point(300, 189);
            this.nSubtract.Name = "nSubtract";
            this.nSubtract.Size = new System.Drawing.Size(90, 90);
            this.nSubtract.TabIndex = 1;
            this.nSubtract.Text = "-";
            this.nSubtract.UseVisualStyleBackColor = true;
            this.nSubtract.Click += new System.EventHandler(this.nButton_Click);
            // 
            // nMultiply
            // 
            this.nMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nMultiply.Location = new System.Drawing.Point(300, 285);
            this.nMultiply.Name = "nMultiply";
            this.nMultiply.Size = new System.Drawing.Size(90, 90);
            this.nMultiply.TabIndex = 1;
            this.nMultiply.Text = "*";
            this.nMultiply.UseVisualStyleBackColor = true;
            this.nMultiply.Click += new System.EventHandler(this.nButton_Click);
            // 
            // nDivide
            // 
            this.nDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nDivide.Location = new System.Drawing.Point(300, 381);
            this.nDivide.Name = "nDivide";
            this.nDivide.Size = new System.Drawing.Size(90, 90);
            this.nDivide.TabIndex = 1;
            this.nDivide.Text = "/";
            this.nDivide.UseVisualStyleBackColor = true;
            this.nDivide.Click += new System.EventHandler(this.nButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(396, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "AC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AC_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(396, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 90);
            this.button2.TabIndex = 1;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(535, 596);
            this.Controls.Add(this.nDivide);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.nDot);
            this.Controls.Add(this.nMultiply);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.nSubtract);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nAdd);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.TxtBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtBox;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button n0;
        private Button nDot;
        private Button equals;
        private Button nAdd;
        private Button nSubtract;
        private Button nMultiply;
        private Button nDivide;
        private Button button1;
        private Button button2;
    }
}