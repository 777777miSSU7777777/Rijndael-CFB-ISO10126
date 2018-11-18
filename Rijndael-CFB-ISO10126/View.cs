using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rijndael_CFB_ISO10116
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            EncryptMode.Checked = true;
            InfoLabel.Text = CryptService.GetInfo();
        }

        private void CryptoButton_Click(object sender, EventArgs e)
        {
            OutputTextBox.Clear();
            if (EncryptMode.Checked)
            {
                byte[] bytes = Encoding.Unicode.GetBytes(InputTextBox.Text);
                byte[] cipher = CryptService.Encrypt(bytes, KeyTextBox.Text);
                OutputTextBox.Text += "Bytes: " + CryptService.ByteArrayToStringView(cipher) + Environment.NewLine;
                OutputTextBox.Text += "String: " + CryptService.ByteArrayToString(cipher);
                KeyValueLabel.Text = "Key: " + CryptService.GetSecretKeyString();
                IVValueLabel.Text = "IV: " + CryptService.GetIVString();
            }
            else if (DecryptMode.Checked)
            {
                byte[] bytes = Encoding.Unicode.GetBytes(InputTextBox.Text);
                byte[] source = CryptService.Decrypt(bytes, KeyTextBox.Text);
                OutputTextBox.Text += "Bytes: " + CryptService.ByteArrayToStringView(source) + Environment.NewLine;
                OutputTextBox.Text += "String: " + CryptService.ByteArrayToString(source);
                KeyValueLabel.Text = "Key: " + CryptService.GetSecretKeyString();
                IVValueLabel.Text = "IV: " + CryptService.GetIVString();
            }
        }
    }
}
