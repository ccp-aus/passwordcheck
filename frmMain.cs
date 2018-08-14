using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PasswordCheck
{
    using System.Net.Mail;

    public partial class frmMain : Form
    {
        public frmMain() => InitializeComponent();

        private void CheckEmail_Click(object sender, EventArgs e)
        {
            string email = string.Empty;
            bool addressValid = true;
            //Don't continue if no text entered.
            if (string.IsNullOrEmpty(EmailBox.Text))
                return;

            //Simple test for email validity. No point in getting complicated here.
            try
            {
                email = new MailAddress(EmailBox.Text).Address;
            }
            catch (FormatException)
            {
                addressValid = false;
            }
            if (addressValid && !string.IsNullOrEmpty(email))
            {
                //URLEncode the Email address.
                string u = Uri.EscapeDataString(email);
                using (HttpClient client = new HttpClient())
                {
                    // Enforce TLS 1.2
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    client.BaseAddress = new Uri("https://haveibeenpwned.com/api/v2/");
                    // Using the API's "BreachedAccount" Method 
                    // https://haveibeenpwned.com/API/v2#BreachesForAccount
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("CCP-PasswordChecker");
                    HttpResponseMessage r = client.GetAsync($"breachedaccount/{u}")
                            .Result;
                    string l = r.Content.ReadAsStringAsync()
                                      .Result;
                    //Easy way to count breaches
                    dynamic dyn = JsonConvert.DeserializeObject<dynamic>(l);
                    // Don't bother if it's an empty result
                    if (string.IsNullOrEmpty(l))
                        MessageBox.Show($"Congratulations! Your email address is not listed in any known breaches.", $"Email Address NOT Found in Dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        string url = $"https://haveibeenpwned.com/account/{email}";
                        if (MessageBox.Show($"The email address has been listed in known data breaches.\n\nYour email address was listed {dyn.Count} times.\n\nWould you like to open a web page that explains the extent of the breaches and where they came from?", $"Email Address Found in Dataset!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            Process.Start(url);
                    }

                }
            }
            else
                MessageBox.Show($"The Email address entered is not valid. If this is incorrect, please contact CCP on 08 9467 2269.", $"Invalid Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CheckPassword_click(object sender, EventArgs e)
        {
            bool MatchFound = false;
            int MatchCount = 0;
            // Hash the plain text password
            string h = HashString(PasswordBox.Text);
            // Clear the password box
            PasswordBox.Text = "";
            // Grab the first 5 characters of the hash
            string c = new string(h.Take(5).ToArray());


            using (HttpClient client = new HttpClient())
            {
                // Enforce TLS 1.2
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                client.BaseAddress = new Uri("https://api.pwnedpasswords.com/");
                // Using the API's "Range" Method 
                // https://haveibeenpwned.com/API/v2#SearchingPwnedPasswordsByRange
                client.DefaultRequestHeaders.UserAgent.ParseAdd("CCP-PasswordChecker");
                // Submit the first 5 characters of the password hash
                HttpResponseMessage r = client.GetAsync($"range/{c}")
                        .Result;
                string l = r.Content.ReadAsStringAsync()
                                  .Result;
                // Don't bother if it's an empty result
                if (!string.IsNullOrWhiteSpace(l))
                {
                    // Split the returned list into a list of arrays
                    List<string[]> a = l.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Split(':')).ToList();
                    // Check for full has in results and collect a count
                    foreach (string[] o in a)
                        if (string.Equals($"{c}{o[0]}", h))
                        {
                            MatchFound = true;
                            int.TryParse(o[1], out MatchCount);
                        }
                }
            }
            if (MatchFound)
                MessageBox.Show($"The password you entered has been found in a list of passwords that are known to be compromised.\n\nCCP would HIGHLY recommend performing a password change anywhere this has been used as the password is no longer considered secure.\n\nYour password was listed {MatchCount} times.", $"Password Found in Dataset!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show($"Congratulations! Your password is not listed in any known breaches.", $"Password NOT Found in Dataset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void EmailBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                CheckEmail_Click(this, new EventArgs());
        }
        /// <summary>
        /// Hashes the string using SHA-1
        /// </summary>
        /// <returns></returns>
        private string HashString(string s)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] h = sha1.ComputeHash(Encoding.UTF8.GetBytes(s));
                StringBuilder sb = new StringBuilder(h.Length * 2);

                foreach (byte b in h)
                    sb.Append(b.ToString("X2"));
                return sb.ToString();
            }
        }
        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CheckPassword_click(this, new EventArgs());
        }
    }
}