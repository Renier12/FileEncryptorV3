using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileEncryptorV3
{
    public partial class FormFileEncryptor : Form
    {
        public FormFileEncryptor()
        {
            InitializeComponent();
            //create "Storage" directory
            string dir = "Storage//";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            PopulateComboBox();
        }

        private void FormFileEncryptor_Load(object sender, EventArgs e)
        {

        }

        private void buttonHidePassword_Click(object sender, EventArgs e)
        {
            textBoxEncryptionKey.PasswordChar = 'O';
            buttonHidePassword.Enabled = false;
            buttonHidePassword.Visible = false;
            buttonShowPassword.Enabled = true;
            buttonShowPassword.Visible = true;
        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            textBoxEncryptionKey.PasswordChar = '\0';
            buttonShowPassword.Enabled = false;
            buttonShowPassword.Visible = false;
            buttonHidePassword.Enabled = true;
            buttonHidePassword.Visible = true;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        #region Functions
        public void PopulateComboBox()
        {
            comboBoxFileName.Items.Clear();
            string[] files = Directory.GetFiles("Storage//");

            for (int i = 0; i < files.Length; i++)
            {
                //remove "Storage//" from string name
                //add string to a temp variable
                string temp = files[i].ToString().Remove(0, 9);

                //check if the temp value contains the text entered
                if (temp.Contains(comboBoxFileName.Text))
                {
                    comboBoxFileName.Items.Add(temp);
                }
            }
        }
        
        //New encryption and decryption functions that encrypt and decrypt entire files instead of strings, this allows the program to break free of it's restraints :D
        public void EncryptFile(string inputFile, string password)
        {
            // Output file = original + ".fe3"
            string outputFile = inputFile + ".fe3";

            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            using (var keyDerivation = new Rfc2898DeriveBytes(password, salt, 100000))
            using (Aes aes = Aes.Create())
            {
                aes.Key = keyDerivation.GetBytes(32);
                aes.IV = keyDerivation.GetBytes(16);

                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                {
                    // Write salt at start
                    fsOutput.Write(salt, 0, salt.Length);

                    using (CryptoStream cs = new CryptoStream(fsOutput, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                    {
                        fsInput.CopyTo(cs);
                    }
                }
            }
            // Delete the original file after successful encryption
            if (File.Exists(outputFile))
            {
                File.Delete(inputFile);
            }
        }

        public void DecryptFile(string inputFile, string password)
        {
            // Strip ".fe3" extension
            string outputFile = Path.ChangeExtension(inputFile, null);

            using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
            {
                byte[] salt = new byte[16];
                fsInput.Read(salt, 0, salt.Length);

                using (var keyDerivation = new Rfc2898DeriveBytes(password, salt, 100000))
                using (Aes aes = Aes.Create())
                {
                    aes.Key = keyDerivation.GetBytes(32);
                    aes.IV = keyDerivation.GetBytes(16);

                    using (CryptoStream cs = new CryptoStream(fsInput, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                    {
                        cs.CopyTo(fsOutput);
                    }
                }
            }
            // Delete the original file after successful encryption
            if (File.Exists(outputFile))
            {
                File.Delete(inputFile);
            }
        }

        public void DisableUI()
        {
            progressBarWorking.Enabled = true;
            progressBarWorking.Visible = true;
            progressBarWorking.MarqueeAnimationSpeed = 30;
            progressBarWorking.Style = ProgressBarStyle.Marquee;

            comboBoxFileName.Enabled = false;
            textBoxEncryptionKey.Enabled = false;
            buttonEncrypt.Enabled = false;
            buttonDecrypt.Enabled = false;
            buttonCreateNewFile.Enabled = false;
            buttonOpenFile.Enabled = false;
            menuStrip1.Enabled = false;
        }

        public void EnableUI()
        {
            progressBarWorking.Enabled = false;
            progressBarWorking.Visible = false;
            progressBarWorking.Style = ProgressBarStyle.Blocks;

            comboBoxFileName.Enabled = true;
            textBoxEncryptionKey.Enabled = true;
            buttonEncrypt.Enabled = true;
            buttonDecrypt.Enabled = true;
            buttonCreateNewFile.Enabled = true;
            buttonOpenFile.Enabled = true;
            menuStrip1.Enabled = true;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        #endregion Functions
        private void comboBoxFileName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBoxFileName_DropDown(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            //check if account name is empty
            if (comboBoxFileName.Text == string.Empty)
            {
                MessageBox.Show("File Name cannot be empty!");
            }
            else if (textBoxEncryptionKey.Text == string.Empty)
            {
                MessageBox.Show("Encryption key cannot be empty!");
            }
            else
            {
                //check if a file with the same name exists
                if (File.Exists("Storage//" + comboBoxFileName.Text))
                {
                    DisableUI();
                    //Encrypt the file
                    EncryptFile("Storage//" + comboBoxFileName.Text, textBoxEncryptionKey.Text);
                    string fileName = comboBoxFileName.Text;
                    comboBoxFileName.Text = fileName + ".fe3";

                    //MessageBox.Show("File encrypted and saved successfully!");
                }
                else
                {
                    MessageBox.Show("The File you are trying to access does not exist. Please create the file first.");
                }
            }
            EnableUI();
        }


        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (File.Exists("Storage//" + comboBoxFileName.Text) && textBoxEncryptionKey.Text != string.Empty)
            {
                DisableUI();
                try
                {
                    DecryptFile("Storage//" + comboBoxFileName.Text, textBoxEncryptionKey.Text);
                    string fileName = comboBoxFileName.Text;
                    comboBoxFileName.Text = fileName.Substring(0, fileName.Length - 4);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
                //MessageBox.Show("File decrypted and saved successfully!");
            }
            else
            {
                MessageBox.Show("There no file with that name!");
            }
            EnableUI();
        }

        private void buttonCreateFile(object sender, EventArgs e)
        {
            if (!File.Exists("Storage//" + comboBoxFileName.Text))
            {
                try
                {
                    new FileStream(("Storage//" + comboBoxFileName.Text), FileMode.CreateNew);
                    MessageBox.Show("File created successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n Please enter a valid File Name");
                }
            }
            else
            {
                // Open the file with the default program (e.g., Notepad)
                System.Diagnostics.Process.Start("notepad.exe", ("Storage//" + comboBoxFileName.Text));
            }
        }
        private void buttonPeakOpenFile(object sender, EventArgs e)
        {
            if (File.Exists("Storage//" + comboBoxFileName.Text))
            {
                // Open the file with the default program (e.g., Notepad)
                System.Diagnostics.Process.Start("notepad.exe", ("Storage//" + comboBoxFileName.Text));
            }
            else
            {
                MessageBox.Show("There no file with that name!");
            }
                
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encryption key is the key used to encrypt the data :)\n\n" +
                "File name is the name of the file you want to encrypt or decrypt :3\n\n" +
                "This version of the encryption program encrypts an entire file. This allows the program to berak free of it's restraints ;)\n\n" +
                "In this version of the program you need to use an exixting file, this file is encrypted/decrypted and can be viewed at a later stage :p\n\n" +
                "Batch encrypt and batch decrypt: This encrypts or decrypts all files in the \"Storage\" using the key you provided ^_^\n");
        }

        private async void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show a warning message box with Yes/No options
            DialogResult result = MessageBox.Show(
            "You are about to encrypt all files, this could result in corrupted data. Do you want to proceed?",
            "Warning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                if (textBoxEncryptionKey.Text != string.Empty)
                {
                    string[] files = Directory.GetFiles("Storage//");
                    // Setup batch progress bar
                    // Set Minimum to 1 to represent the first file being copied.
                    progressBarBatch.Minimum = 0;
                    // Set Maximum to the total number of files to copy.
                    progressBarBatch.Maximum = files.Length;
                    // Set the initial value of the ProgressBar.
                    progressBarBatch.Value = 1;
                    // Set the Step property to a value of 1 to represent each file being copied.
                    progressBarBatch.Step = 1;
                    DisableUI();
                    await Task.Run(() => 
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            if (Path.GetExtension(files[i]) != ".fe3")
                            {
                                EncryptFile(files[i], textBoxEncryptionKey.Text);
                            }
                            //progress progressbar
                            Invoke(new Action(() =>
                            {
                                progressBarBatch.PerformStep();
                            }));
                            }
                     });
                        //Show after operation
                        MessageBox.Show("Operation completed successfully.", "Info");
                    }
                    else
                    {
                        // Cancel the operation
                        MessageBox.Show("Operation canceled. Encryption Key Empty", "Info");
                    }
            }
            EnableUI();

        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show a warning message box with Yes/No options
            DialogResult result = MessageBox.Show(
            "You are about to decrypt all files, this could result in corrupted data. Do you want to proceed?",
            "Warning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                if (textBoxEncryptionKey.Text != string.Empty)
                {
                    string[] files = Directory.GetFiles("Storage//");

                    // Setup batch progress bar
                    // Set Minimum to 1 to represent the first file being copied.
                    progressBarBatch.Minimum = 0;
                    // Set Maximum to the total number of files to copy.
                    progressBarBatch.Maximum = files.Length;
                    // Set the initial value of the ProgressBar.
                    progressBarBatch.Value = 1;
                    // Set the Step property to a value of 1 to represent each file being copied.
                    progressBarBatch.Step = 1;
                    DisableUI();

                    Task.Run(() =>
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            if (Path.GetExtension(files[i]) == ".fe3")
                            {
                                DecryptFile(files[i], textBoxEncryptionKey.Text);
                            }
                            //progress progressbar
                            Invoke(new Action(() =>
                            {
                                progressBarBatch.PerformStep();
                            }));
                        }
                    });
                //Show after operation
                MessageBox.Show("Operation completed successfully.", "Info");
                }
                else
                {
                    // Cancel the operation
                    MessageBox.Show("Operation canceled. Encryption Key Empty", "Info");
                }
            }
            EnableUI();
        }
    }
}
