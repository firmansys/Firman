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

namespace WindowsFormsApp1
{
    public partial class AdminSecurity : Form
    {
       private string hash = "f0xle@rn";

        private frmLogin frmlogin;
        public AdminSecurity()
        {
            InitializeComponent();
            this.ActiveControl = txtKeyString;
            txtKeyString.Focus();

        }
        public AdminSecurity(frmLogin otherForm)
        {
            frmlogin = otherForm;
        }
        private void AdminSecurity_Load(object sender, EventArgs e)
        {
           
        }

        public string Encrypt( string source)
        {
            string Encrypt = "";
            byte[] data = UTF8Encoding.UTF8.GetBytes(source);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                //Encrypt data by hash key
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    Encrypt = Convert.ToBase64String(results, 0, results.Length);
                }
            }

            return Encrypt;
        }

        public  string Decrypt( string encrypt)
        {
            string Decrypt = "";
            byte[] data = Convert.FromBase64String(encrypt);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                //Decrypt data by hash key
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    Decrypt = UTF8Encoding.UTF8.GetString(results);
                }
            }
            return Decrypt;
        }

        private void txtKeyString_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyData == Keys.Enter)
            {              
                e.SuppressKeyPress = true;
               if (txtKeyString.Text == "MyKey")
                {
                    txtTextString.Text = GlobalVar.user + GlobalVar.pass;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEncrpyt.Text = Encrypt( txtTextString.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtEncrpyt.Text = Decrypt(txtEncrpyt.Text);
        }
    
    }

    
}
