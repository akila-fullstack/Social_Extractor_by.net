using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPackHtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace SocialExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void findButton_Click(object sender, EventArgs e)
        {
            string keyword = keywordTextBox.Text;
            string socialNetwork = socialNetworkComboBox.Text;
            string phoneCode = phoneCodeComboBox.Text;
            string contactMethod = contactMethodComboBox.Text;

            await FetchData(keyword, socialNetwork, phoneCode, contactMethod);
        }

        private async Task FetchData(string keyword, string socialNetwork, string phoneCode, string contactMethod)
        {
            if (socialNetwork == "Facebook")
            {
                await FetchRealData(keyword, phoneCode, contactMethod, socialNetwork);
            }
            else if (socialNetwork == "Twitter")
            {
                MessageBox.Show("NULL", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No data available for the selected social network.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task FetchRealData(string keyword, string phoneCode, string contactMethod, string socialNetwork)
        {
            try
            {
                string url = $"https://www.google.com/search?q={contactMethod}+{phoneCode}+{keyword}+AND+site:{socialNetwork}.com&num=100";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        var doc = new HtmlAgilityPackHtmlDocument();
                        doc.LoadHtml(responseBody);

                        var results = doc.DocumentNode.SelectNodes("//div[@class='BNeawe s3v9rd AP7Wnd']");
                        if (results != null)
                        {
                            resultsPanel.Controls.Clear(); // Clear previous results

                            foreach (var result in results)
                            {
                                string text = result.InnerText;
                                string phoneNumber = null;

                                // Attempt to extract phone number
                                Match phoneNumberMatch = Regex.Match(text, @"\+\d{1,3}\s?\d{3,14}");
                                if (phoneNumberMatch.Success)
                                {
                                    phoneNumber = phoneNumberMatch.Value;
                                    AddPhoneNumberToList(phoneNumber);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No results found.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve data. Please try again.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private HashSet<string> uniquePhoneNumbers = new HashSet<string>();

        private void AddPhoneNumberToList(string phoneNumber)
        {
            if (uniquePhoneNumbers.Contains(phoneNumber))
            {
                return; // Skip if phone number is already in the set
            }
            else
            {
                int lenph = phoneNumber.Length;
                if(lenph < 11)
                {
                    return;
                }
            }

            uniquePhoneNumbers.Add(phoneNumber);

            var panel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                Margin = new Padding(0, 0, 0, 10)
            };

            var label = new Label
            {
                Text = phoneNumber,
                AutoSize = true
            };

            var button = new Button
            {
                Text = "WhatsApp",
                AutoSize = true
            };

            button.Click += (sender, e) => OpenWhatsApp(phoneNumber);

            panel.Controls.Add(label);
            panel.Controls.Add(button);

            resultsPanel.Controls.Add(panel);
        }


        private void OpenWhatsApp(string phoneNumber)
        {
            try
            {
                string whatsappUri = $"whatsapp://send?phone={phoneNumber}";
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = whatsappUri,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to open WhatsApp: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Join(Environment.NewLine, resultsPanel.Controls));
            MessageBox.Show("Results copied to clipboard!", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
