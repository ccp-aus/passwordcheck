using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PasswordCheck
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Hashes the string using SHA-1
        /// </summary>
        /// <returns></returns>
        private string HashString(string s)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var h = sha1.ComputeHash(Encoding.UTF8.GetBytes(s));
                var sb = new StringBuilder(h.Length * 2);

                foreach (byte b in h)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }
        private void CheckPassword_click(object sender, EventArgs e)
        {
            bool MatchFound = false;
            int MatchCount = 0;
            // Grab the first 5 characters
            var h = HashString(textBox2.Text);
            var c = new string(h.Take(5).ToArray());


            using (HttpClient client = new HttpClient())
            {
                // Enforce TLS 1.2
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                client.BaseAddress = new Uri("https://api.pwnedpasswords.com");
                // Using the API's "Range" Method 
                // https://haveibeenpwned.com/API/v2#SearchingPwnedPasswordsByRange
                client.DefaultRequestHeaders.UserAgent.ParseAdd("CCP-PasswordChecker");
                var r = client.GetAsync($"range/{c}")
                        .Result;
                var l = r.Content.ReadAsStringAsync()
                                  .Result;
                // Don't bother if it's an empty result
                if (!string.IsNullOrWhiteSpace(l))
                {
                    // Split the returned list into a list of arrays
                    List<string[]> a = l.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Split(':')).ToList();

                    foreach (string[] o in a)
                    {
                        if (string.Equals($"{c}{o[0]}", h))
                        {
                            MatchFound = true;
                            Int32.TryParse(o[1], out MatchCount);
                        }
                    }
                }
            }
            if (MatchFound)
                MessageBox.Show($"The password you entered has been found in a list of passwords that are known to be compromised.\n\nCCP would HIGHLY recommend performing a password change anywhere this has been used as the password is no longer considered secure.\n\nYour password was listed {MatchCount} times.", $"Password Found in Dataset!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}