using GPGExample.GPG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPGExample
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void FileToEncryptSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                inputfilepath.Text = choofdlog.FileName;
                          
            }
        }





       

        private void SelectPublicKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Key Files (*.Asc*)|*.asc*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                publickeypath.Text = choofdlog.FileName;

            }
        }

        private void SelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.Description = "Custom Description"; //not mandatory

            if (fbd.ShowDialog() == DialogResult.OK)
                OutputFilePath.Text = fbd.SelectedPath;
            else
                OutputFilePath.Text = string.Empty;
        }

        private bool CheckWhetherAll_the_values_areEnteredOrnOt()
        {
            if (string.IsNullOrWhiteSpace(inputfilepath.Text))
            {
                MessageBox.Show("Input File Path Cannot be Null");
                return false;
            }
            if (string.IsNullOrWhiteSpace(publickeypath.Text))
            {
                MessageBox.Show("Public Key Path Cannot be Null");
                return false;
            }

            if (string.IsNullOrWhiteSpace(OutputFilePath.Text))
            {
                MessageBox.Show("Output File Path Cannot be Null");
                return false;
            }
            return true;
        }
        private void Encrypt_Click(object sender, EventArgs e)
        {
            if(CheckWhetherAll_the_values_areEnteredOrnOt())
            {
                if(Encryption.Encrypt(inputfilepath.Text, OutputFilePath.Text, publickeypath.Text))
                {
                    MessageBox.Show("Successfully Encrypted");
                }
            }
        }

        private void SelectFileToDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                InputFilePathValue.Text = choofdlog.FileName;

            }
        }

        private void KeySelectionButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Key Files (*.Asc*)|*.asc*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                privatekeypath.Text = choofdlog.FileName;

            }
        }

        private void OutputfilePathselection_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.Description = "Custom Description"; //not mandatory

            if (fbd.ShowDialog() == DialogResult.OK)
                outputfilepathValue.Text = fbd.SelectedPath;
            else
                outputfilepathValue.Text = string.Empty;
        }

        private bool CheckWhetherAllTheValuesAreValidOrnOt()
        {
            if(string.IsNullOrWhiteSpace(InputFilePathValue.Text))
            {
                MessageBox.Show("Input File Path Not Selected");
                return false;
            }
            if (string.IsNullOrWhiteSpace(privatekeypath.Text))
            {
                MessageBox.Show("Private Key Not Selected");
                return false;
            }
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Pasword not entered");
                return false;
            }
            if (string.IsNullOrWhiteSpace(outputfilepathValue.Text))
            {
                MessageBox.Show("Output File Path not Selected");
                return false;
            }
            return true;
        }



        private void Decrypt_Click(object sender, EventArgs e)
        {
            if(CheckWhetherAllTheValuesAreValidOrnOt())
            {
                if(Decryption.DecryptPGPData(InputFilePathValue.Text, outputfilepathValue.Text, password.Text, privatekeypath.Text))
                {
                    MessageBox.Show("Successfully Decrypted");
                }
            }
        }
    }
}
