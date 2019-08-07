namespace RanPass
{
    partial class RanPass
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
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.lowerCaseLabel = new System.Windows.Forms.Label();
            this.lowerCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.upperCaseLabel = new System.Windows.Forms.Label();
            this.upperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberCheckBox = new System.Windows.Forms.CheckBox();
            this.specialCharacterLabel = new System.Windows.Forms.Label();
            this.specialCharacterCheckBox = new System.Windows.Forms.CheckBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.hintBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.AutoSize = true;
            this.passwordLengthLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.passwordLengthLabel.Location = new System.Drawing.Point(13, 13);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Padding = new System.Windows.Forms.Padding(8);
            this.passwordLengthLabel.Size = new System.Drawing.Size(229, 38);
            this.passwordLengthLabel.TabIndex = 0;
            this.passwordLengthLabel.Text = "How long is your password?";
            // 
            // lengthBox
            // 
            this.lengthBox.Font = new System.Drawing.Font("Calibri", 14F);
            this.lengthBox.Location = new System.Drawing.Point(358, 20);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 30);
            this.lengthBox.TabIndex = 1;
            // 
            // lowerCaseLabel
            // 
            this.lowerCaseLabel.AutoSize = true;
            this.lowerCaseLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.lowerCaseLabel.Location = new System.Drawing.Point(13, 53);
            this.lowerCaseLabel.Name = "lowerCaseLabel";
            this.lowerCaseLabel.Padding = new System.Windows.Forms.Padding(8);
            this.lowerCaseLabel.Size = new System.Drawing.Size(354, 38);
            this.lowerCaseLabel.TabIndex = 2;
            this.lowerCaseLabel.Text = "Does your password have lower case letters?";
            // 
            // lowerCaseCheckBox
            // 
            this.lowerCaseCheckBox.AutoSize = true;
            this.lowerCaseCheckBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerCaseCheckBox.Location = new System.Drawing.Point(393, 61);
            this.lowerCaseCheckBox.Name = "lowerCaseCheckBox";
            this.lowerCaseCheckBox.Padding = new System.Windows.Forms.Padding(8);
            this.lowerCaseCheckBox.Size = new System.Drawing.Size(31, 30);
            this.lowerCaseCheckBox.TabIndex = 3;
            this.lowerCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // upperCaseLabel
            // 
            this.upperCaseLabel.AutoSize = true;
            this.upperCaseLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.upperCaseLabel.Location = new System.Drawing.Point(12, 93);
            this.upperCaseLabel.Name = "upperCaseLabel";
            this.upperCaseLabel.Padding = new System.Windows.Forms.Padding(8);
            this.upperCaseLabel.Size = new System.Drawing.Size(354, 38);
            this.upperCaseLabel.TabIndex = 4;
            this.upperCaseLabel.Text = "Does your password have upper case letters?";
            // 
            // upperCaseCheckBox
            // 
            this.upperCaseCheckBox.AutoSize = true;
            this.upperCaseCheckBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperCaseCheckBox.Location = new System.Drawing.Point(393, 101);
            this.upperCaseCheckBox.Name = "upperCaseCheckBox";
            this.upperCaseCheckBox.Padding = new System.Windows.Forms.Padding(8);
            this.upperCaseCheckBox.Size = new System.Drawing.Size(31, 30);
            this.upperCaseCheckBox.TabIndex = 5;
            this.upperCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.numberLabel.Location = new System.Drawing.Point(10, 133);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Padding = new System.Windows.Forms.Padding(8);
            this.numberLabel.Size = new System.Drawing.Size(288, 38);
            this.numberLabel.TabIndex = 6;
            this.numberLabel.Text = "Does your password have numbers?";
            // 
            // numberCheckBox
            // 
            this.numberCheckBox.AutoSize = true;
            this.numberCheckBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberCheckBox.Location = new System.Drawing.Point(393, 137);
            this.numberCheckBox.Name = "numberCheckBox";
            this.numberCheckBox.Padding = new System.Windows.Forms.Padding(8);
            this.numberCheckBox.Size = new System.Drawing.Size(31, 30);
            this.numberCheckBox.TabIndex = 7;
            this.numberCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialCharacterLabel
            // 
            this.specialCharacterLabel.AutoSize = true;
            this.specialCharacterLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.specialCharacterLabel.Location = new System.Drawing.Point(10, 172);
            this.specialCharacterLabel.Name = "specialCharacterLabel";
            this.specialCharacterLabel.Padding = new System.Windows.Forms.Padding(8);
            this.specialCharacterLabel.Size = new System.Drawing.Size(356, 38);
            this.specialCharacterLabel.TabIndex = 8;
            this.specialCharacterLabel.Text = "Does your password have special characters?";
            // 
            // specialCharacterCheckBox
            // 
            this.specialCharacterCheckBox.AutoSize = true;
            this.specialCharacterCheckBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialCharacterCheckBox.Location = new System.Drawing.Point(393, 180);
            this.specialCharacterCheckBox.Name = "specialCharacterCheckBox";
            this.specialCharacterCheckBox.Padding = new System.Windows.Forms.Padding(8);
            this.specialCharacterCheckBox.Size = new System.Drawing.Size(31, 30);
            this.specialCharacterCheckBox.TabIndex = 9;
            this.specialCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generateButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(185, 224);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 45);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Calibri", 13F);
            this.passwordBox.Location = new System.Drawing.Point(12, 286);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(340, 29);
            this.passwordBox.TabIndex = 11;
            this.passwordBox.Text = "Password";
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.copyButton.Location = new System.Drawing.Point(358, 282);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(100, 35);
            this.copyButton.TabIndex = 12;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // hintBox
            // 
            this.hintBox.Font = new System.Drawing.Font("Calibri", 13F);
            this.hintBox.Location = new System.Drawing.Point(12, 333);
            this.hintBox.Name = "hintBox";
            this.hintBox.Size = new System.Drawing.Size(340, 29);
            this.hintBox.TabIndex = 13;
            this.hintBox.Text = "Hint";
            this.hintBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.saveButton.Location = new System.Drawing.Point(358, 329);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 35);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_Click);
            // 
            // RanPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 400);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.hintBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.specialCharacterCheckBox);
            this.Controls.Add(this.specialCharacterLabel);
            this.Controls.Add(this.numberCheckBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.upperCaseCheckBox);
            this.Controls.Add(this.upperCaseLabel);
            this.Controls.Add(this.lowerCaseCheckBox);
            this.Controls.Add(this.lowerCaseLabel);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.passwordLengthLabel);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RanPass";
            this.Text = "Ran Pass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.Label lowerCaseLabel;
        private System.Windows.Forms.CheckBox lowerCaseCheckBox;
        private System.Windows.Forms.Label upperCaseLabel;
        private System.Windows.Forms.CheckBox upperCaseCheckBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.CheckBox numberCheckBox;
        private System.Windows.Forms.Label specialCharacterLabel;
        private System.Windows.Forms.CheckBox specialCharacterCheckBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox hintBox;
        private System.Windows.Forms.Button saveButton;
    }
}

