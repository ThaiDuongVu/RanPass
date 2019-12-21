using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RanPass
{
    public partial class RanPass : Form
    {
        private string password;
        private string passwordBase;

        private string lowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private string upperCaseLetters = "ABCDEFGHIJKLMNOPQRTSUVWXYZ";

        private string numbers = "1234567890";
        private string specialCharacters = "!@#$%^&*(){}[]:;<>,.?~/|`-_";

        private int passwordLength;
        private const int passwordLengthMax = 40;
        private const int passwordLengthMin = 1;

        private bool passwordGenerated = false;
        private string hint;

        private Random random = new Random();

        public RanPass()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)   // Call if generate button is clicked
        {
            if (int.TryParse(lengthBox.Text, out passwordLength))
            {
                passwordLength = Convert.ToInt32(lengthBox.Text);

                if (passwordLength <= passwordLengthMax && passwordLength > 0)  // Generate password if all the requirements are satisfied
                {
                    GeneratePassword();
                }

                if (passwordLength > passwordLengthMax)     // Print a warning if desired password length is too long
                {
                    passwordBox.Text = "Password cannot be longer than " + passwordLengthMax.ToString() + " characters";
                }
                if (passwordLength < passwordLengthMin)     // Print a warning if desired password length is less than 1
                {
                    passwordBox.Text = "Password must have at least one character";
                }
            }
            else    // Print a warning if the input is not an integer
            {
                passwordBox.Text = "Please enter a valid length";
            }
        }

        private void GeneratePassword()     // Generate a string of random characters
        {
            password = "";
            passwordBase = "";

            if (lowerCaseCheckBox.Checked)
            {
                passwordBase += lowerCaseLetters;
            }
            if (upperCaseCheckBox.Checked)
            {
                passwordBase += upperCaseLetters;
            }
            if (numberCheckBox.Checked)
            {
                passwordBase += numbers;
            }
            if (specialCharacterCheckBox.Checked)
            {
                passwordBase += specialCharacters;
            }

            if (lowerCaseCheckBox.Checked || upperCaseCheckBox.Checked || numberCheckBox.Checked || specialCharacterCheckBox.Checked)
            {
                for (int i = 1; i <= passwordLength; i++)
                {
                    password += passwordBase[random.Next(0, passwordBase.Length - 1)];
                }

                passwordBox.Text = password;
                passwordGenerated = true;
            }
            else    // Print a warning if none of the boxes are checked
            {
                passwordBox.Text = "Please check at least one box above";
            }
        }

        private void copyButton_Click(object sender, EventArgs e)   // Copy generated password to the clipboard if a password is generated
        {
            if (passwordGenerated)
            {
                Clipboard.SetText(password);
                MessageBox.Show("Password copied");
            }
            else
            {
                MessageBox.Show("Password not generated!");
            }
        }

        private void save_Click(object sender, EventArgs e)     // Save the password with hint to a txt file if a password is generated
        {
            if (passwordGenerated)
            {
                string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                hint = hintBox.Text;

                string existingText = File.ReadAllText(projectDirectory + "\\passwords.txt");
                StreamWriter streamWriter = new StreamWriter(projectDirectory + "\\passwords.txt");

                if (streamWriter != null)
                {
                    streamWriter.Write(existingText);
                    streamWriter.WriteLine(hint + " : " + password);
                    streamWriter.Close();

                    MessageBox.Show("Password saved");
                }
            }
            else
            {
                MessageBox.Show("Password not generated!");
            }
        }
    }
}
