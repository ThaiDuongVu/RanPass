namespace RanPass
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
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lowerCaseLabel = new System.Windows.Forms.Label();
            this.lowerCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.upperCaseLabel = new System.Windows.Forms.Label();
            this.upperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberCheckBox = new System.Windows.Forms.CheckBox();
            this.specialCharacterLabel = new System.Windows.Forms.Label();
            this.specialCharacterCheckBox = new System.Windows.Forms.CheckBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.AutoSize = true;
            this.passwordLengthLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.passwordLengthLabel.Location = new System.Drawing.Point(13, 13);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Padding = new System.Windows.Forms.Padding(8);
            this.passwordLengthLabel.Size = new System.Drawing.Size(244, 39);
            this.passwordLengthLabel.TabIndex = 0;
            this.passwordLengthLabel.Text = "How long is your password?";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14F);
            this.textBox1.Location = new System.Drawing.Point(388, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 1;
            // 
            // lowerCaseLabel
            // 
            this.lowerCaseLabel.AutoSize = true;
            this.lowerCaseLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.lowerCaseLabel.Location = new System.Drawing.Point(13, 53);
            this.lowerCaseLabel.Name = "lowerCaseLabel";
            this.lowerCaseLabel.Padding = new System.Windows.Forms.Padding(8);
            this.lowerCaseLabel.Size = new System.Drawing.Size(374, 39);
            this.lowerCaseLabel.TabIndex = 2;
            this.lowerCaseLabel.Text = "Does your password have lower case letters?";
            // 
            // lowerCaseCheckBox
            // 
            this.lowerCaseCheckBox.AutoSize = true;
            this.lowerCaseCheckBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerCaseCheckBox.Location = new System.Drawing.Point(421, 62);
            this.lowerCaseCheckBox.Name = "lowerCaseCheckBox";
            this.lowerCaseCheckBox.Padding = new System.Windows.Forms.Padding(8);
            this.lowerCaseCheckBox.Size = new System.Drawing.Size(31, 30);
            this.lowerCaseCheckBox.TabIndex = 3;
            this.lowerCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // upperCaseLabel
            // 
            this.upperCaseLabel.AutoSize = true;
            this.upperCaseLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.upperCaseLabel.Location = new System.Drawing.Point(12, 93);
            this.upperCaseLabel.Name = "upperCaseLabel";
            this.upperCaseLabel.Padding = new System.Windows.Forms.Padding(8);
            this.upperCaseLabel.Size = new System.Drawing.Size(376, 39);
            this.upperCaseLabel.TabIndex = 4;
            this.upperCaseLabel.Text = "Does your password have upper case letters?";
            // 
            // upperCaseCheckBox
            // 
            this.upperCaseCheckBox.AutoSize = true;
            this.upperCaseCheckBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperCaseCheckBox.Location = new System.Drawing.Point(421, 102);
            this.upperCaseCheckBox.Name = "upperCaseCheckBox";
            this.upperCaseCheckBox.Padding = new System.Windows.Forms.Padding(8);
            this.upperCaseCheckBox.Size = new System.Drawing.Size(31, 30);
            this.upperCaseCheckBox.TabIndex = 5;
            this.upperCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.numberLabel.Location = new System.Drawing.Point(10, 133);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Padding = new System.Windows.Forms.Padding(8);
            this.numberLabel.Size = new System.Drawing.Size(308, 39);
            this.numberLabel.TabIndex = 6;
            this.numberLabel.Text = "Does your password have numbers?";
            // 
            // numberCheckBox
            // 
            this.numberCheckBox.AutoSize = true;
            this.numberCheckBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberCheckBox.Location = new System.Drawing.Point(421, 142);
            this.numberCheckBox.Name = "numberCheckBox";
            this.numberCheckBox.Padding = new System.Windows.Forms.Padding(8);
            this.numberCheckBox.Size = new System.Drawing.Size(31, 30);
            this.numberCheckBox.TabIndex = 7;
            this.numberCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialCharacterLabel
            // 
            this.specialCharacterLabel.AutoSize = true;
            this.specialCharacterLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.specialCharacterLabel.Location = new System.Drawing.Point(10, 172);
            this.specialCharacterLabel.Name = "specialCharacterLabel";
            this.specialCharacterLabel.Padding = new System.Windows.Forms.Padding(8);
            this.specialCharacterLabel.Size = new System.Drawing.Size(376, 39);
            this.specialCharacterLabel.TabIndex = 8;
            this.specialCharacterLabel.Text = "Does your password have special characters?";
            // 
            // specialCharacterCheckBox
            // 
            this.specialCharacterCheckBox.AutoSize = true;
            this.specialCharacterCheckBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialCharacterCheckBox.Location = new System.Drawing.Point(421, 181);
            this.specialCharacterCheckBox.Name = "specialCharacterCheckBox";
            this.specialCharacterCheckBox.Padding = new System.Windows.Forms.Padding(8);
            this.specialCharacterCheckBox.Size = new System.Drawing.Size(31, 30);
            this.specialCharacterCheckBox.TabIndex = 9;
            this.specialCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(194, 235);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 45);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(115, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 32);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Password";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.specialCharacterCheckBox);
            this.Controls.Add(this.specialCharacterLabel);
            this.Controls.Add(this.numberCheckBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.upperCaseCheckBox);
            this.Controls.Add(this.upperCaseLabel);
            this.Controls.Add(this.lowerCaseCheckBox);
            this.Controls.Add(this.lowerCaseLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.passwordLengthLabel);
            this.Name = "Form1";
            this.Text = "Ran Pass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lowerCaseLabel;
        private System.Windows.Forms.CheckBox lowerCaseCheckBox;
        private System.Windows.Forms.Label upperCaseLabel;
        private System.Windows.Forms.CheckBox upperCaseCheckBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.CheckBox numberCheckBox;
        private System.Windows.Forms.Label specialCharacterLabel;
        private System.Windows.Forms.CheckBox specialCharacterCheckBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox textBox2;
    }
}

