using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WindowAES.AES;

namespace WindowAES
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }


        private void btnCypher_Click(object sender, EventArgs e)
        {
            var en = new Encryption();
            if (txtPlain.Text == "" || txtCipherKey.Text == "")
            {
                return;
            }

            txtCypher.Text =  en.Encrypt(txtPlain.Text, txtCipherKey.Text);

        }

        private void btnDecypher_Click(object sender, EventArgs e)
        {

            var de = new Decryption();
            if (txtCypher.Text == "" || txtCipherKey.Text == "")
            {
                return;
            }

            txtPlain.Text = de.Decrypt(txtCypher.Text, txtCipherKey.Text);
        }

        private void btnLoadPlain_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtPlain.Text = File.ReadAllText(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file");
                }
            }
        }

        

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

     
        private void txtCipherKey_TextChanged(object sender, EventArgs e)
        {
            int keysize = Encoding.ASCII.GetBytes(txtCipherKey.Text).Length;
            lblCipherKeySize.Text = keysize.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                File.WriteAllText(name, txtPlain.Text);
            }
        }

      
    }
}
