using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataEncryptDecrypt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void encrypt_data_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(encrypt_input.Text) || string.IsNullOrEmpty(encrypt_passphrase.Text))
            {
                MessageBox.Show("Missing passphrase or input.");
                return;
            }
            
            encrypt_output.Text = Crypto.Encrypt(encrypt_input.Text, encrypt_passphrase.Text);
        }

        private void decrypt_data_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(decrypt_input.Text) || string.IsNullOrEmpty(decrypt_passphrase.Text))
            {
                MessageBox.Show("Missing passphrase or input.");
                return;
            }

            decrypt_output.Text = Crypto.Decrypt(decrypt_input.Text, decrypt_passphrase.Text);
        }
    }
}
