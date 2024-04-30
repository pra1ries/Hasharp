using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Hasharp
{
    public partial class Hasharp : Form
    {
        readonly SHA256 sha256 = SHA256.Create();
        readonly MD5 md5 = MD5.Create();
        readonly SHA1 sha1 = SHA1.Create();

        string wordlist;
        public Hasharp()
        {
            
            InitializeComponent();
        }

        public void sha256_crack()
        {
            var inputHash = hashText.Text.ToLower();
            StreamReader stream = new StreamReader(wordlist);
            var x = 0;
            Stopwatch timer = Stopwatch.StartNew();
            for (var i = stream.ReadLine(); i != null; i = stream.ReadLine())
            {
                logTextBox.AppendText(Environment.NewLine + "Attempt #" + x + " | Attempting... | " + i);
                if (CreateSHA256(i).ToLower() == inputHash)
                {
                    decimal hashesPerSecond = x / (timer.ElapsedMilliseconds / 1000);
                    timer.Stop();
                    logTextBox.AppendText(Environment.NewLine + "Attempt #" + x + " | Match Found! | " + i + " | hashes per second: " + hashesPerSecond);
                    break;
                }
                x++;
            }
        }

        public void sha1_crack()
        {
            var inputHash = hashText.Text.ToLower();
            StreamReader stream = new StreamReader(wordlist);
            var x = 0;
            for (var i = stream.ReadLine(); i != null; i = stream.ReadLine())
            {
                logTextBox.AppendText(Environment.NewLine + "Attempt #" + x + " | Attempting... | " + i);
                if (CreateSHA1(i).ToLower() == inputHash)
                {
                    logTextBox.AppendText(Environment.NewLine + "Attempt #" + x + " | Match Found! | " + i);
                    break;
                }
                x++;
            }
        }

        public void md5_crack()
        {
            var inputHash = hashText.Text.ToLower();
            StreamReader stream = new StreamReader(wordlist);
            var x = 0;
            for (var i = stream.ReadLine(); i != null; i = stream.ReadLine())
            {
                logTextBox.AppendText(Environment.NewLine + "Attempt #" + x + " | Attempting... | " + i);
                if (CreateMD5(i).ToLower() == inputHash)
                {
                    logTextBox.AppendText(Environment.NewLine + "Attempt #" + x + " | Match Found! | " + i);
                    break;
                }
                x++;
            }
        }
        string CreateMD5(string x)
        {
            var convertTmp = Encoding.Default.GetBytes(x);
            var hashBytes = md5.ComputeHash(convertTmp);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }
        string CreateSHA1(string x)
        {
            var convertTmp = Encoding.Default.GetBytes(x);
            var hashBytes = sha1.ComputeHash(convertTmp);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }
        string CreateSHA256(string x)
        {
            var convertTmp = Encoding.Default.GetBytes(x.ToString());
            var hashBytes = sha256.ComputeHash(convertTmp);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.ShowDialog();
            wordlist = saveFileDialog.FileName;
            if (wordlist == null)
            {
                logTextBox.Text = logTextBox.Text + "\nPlease input a file!" + wordlist;
            } else
            {
                logTextBox.Text = logTextBox.Text + "\nwordlist selected: " + wordlist;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {   
            if (hashText.Text == "")
            {
                logTextBox.Text = logTextBox.Text + Environment.NewLine + "You did not input a hash!";

            }else if (algSelectionBox.Text == "MD5")
            {
                md5_crack();
            } else if (algSelectionBox.Text == "SHA256")
            {
                sha256_crack();
            } else if (algSelectionBox.Text == "SHA1")
            {
                sha1_crack();
            } else
            {
                logTextBox.Text = logTextBox.Text + Environment.NewLine + "Not a valid option!";
            }
        }
    }
}
