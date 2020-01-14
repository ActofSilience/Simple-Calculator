namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InputTextBox1 = new System.Windows.Forms.TextBox();
            this.InputTextBox2 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.COSButton = new System.Windows.Forms.Button();
            this.SINButton = new System.Windows.Forms.Button();
            this.TANButton = new System.Windows.Forms.Button();
            this.MODULUSButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Input 2";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(148, 120);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 24);
            this.NameTextBox.TabIndex = 4;
            // 
            // InputTextBox1
            // 
            this.InputTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox1.Location = new System.Drawing.Point(148, 178);
            this.InputTextBox1.Name = "InputTextBox1";
            this.InputTextBox1.Size = new System.Drawing.Size(100, 24);
            this.InputTextBox1.TabIndex = 5;
            // 
            // InputTextBox2
            // 
            this.InputTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox2.Location = new System.Drawing.Point(148, 227);
            this.InputTextBox2.Name = "InputTextBox2";
            this.InputTextBox2.Size = new System.Drawing.Size(100, 24);
            this.InputTextBox2.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(366, 117);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(45, 38);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractionButton.Location = new System.Drawing.Point(417, 117);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(43, 38);
            this.SubtractionButton.TabIndex = 8;
            this.SubtractionButton.Text = "-";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.Location = new System.Drawing.Point(466, 117);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(45, 38);
            this.MultiplyButton.TabIndex = 9;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionButton.Location = new System.Drawing.Point(517, 117);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(45, 38);
            this.DivisionButton.TabIndex = 10;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // COSButton
            // 
            this.COSButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COSButton.Location = new System.Drawing.Point(339, 189);
            this.COSButton.Name = "COSButton";
            this.COSButton.Size = new System.Drawing.Size(72, 41);
            this.COSButton.TabIndex = 11;
            this.COSButton.Text = "COS";
            this.COSButton.UseVisualStyleBackColor = true;
            this.COSButton.Click += new System.EventHandler(this.COSButton_Click);
            // 
            // SINButton
            // 
            this.SINButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SINButton.Location = new System.Drawing.Point(439, 189);
            this.SINButton.Name = "SINButton";
            this.SINButton.Size = new System.Drawing.Size(72, 41);
            this.SINButton.TabIndex = 12;
            this.SINButton.Text = "SIN";
            this.SINButton.UseVisualStyleBackColor = true;
            this.SINButton.Click += new System.EventHandler(this.SINButton_Click);
            // 
            // TANButton
            // 
            this.TANButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TANButton.Location = new System.Drawing.Point(339, 254);
            this.TANButton.Name = "TANButton";
            this.TANButton.Size = new System.Drawing.Size(72, 41);
            this.TANButton.TabIndex = 13;
            this.TANButton.Text = "TAN";
            this.TANButton.UseVisualStyleBackColor = true;
            this.TANButton.Click += new System.EventHandler(this.TANButton_Click);
            // 
            // MODULUSButton
            // 
            this.MODULUSButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODULUSButton.Location = new System.Drawing.Point(439, 254);
            this.MODULUSButton.Name = "MODULUSButton";
            this.MODULUSButton.Size = new System.Drawing.Size(72, 41);
            this.MODULUSButton.TabIndex = 14;
            this.MODULUSButton.Text = "MOD";
            this.MODULUSButton.UseVisualStyleBackColor = true;
            this.MODULUSButton.Click += new System.EventHandler(this.MODULUSButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(578, 227);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(72, 41);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.MODULUSButton);
            this.Controls.Add(this.TANButton);
            this.Controls.Add(this.SINButton);
            this.Controls.Add(this.COSButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractionButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputTextBox2);
            this.Controls.Add(this.InputTextBox1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox InputTextBox1;
        private System.Windows.Forms.TextBox InputTextBox2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button COSButton;
        private System.Windows.Forms.Button SINButton;
        private System.Windows.Forms.Button TANButton;
        private System.Windows.Forms.Button MODULUSButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

