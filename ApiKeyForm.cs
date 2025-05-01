using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swift_Edit
{
    public partial class ApiKeyForm : Form
    {
        public ApiKeyForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private async void submit_btn_Click(object sender, EventArgs e)
        {
            string apiKey = apienter_textbox.Text.Trim();

            if (string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("Please enter an API key.");
                return;
            }

            bool isValid = await ValidateApiKey(apiKey);

            if (isValid)
            {
                // 💾 Save the valid API key to user settings
                Properties.Settings.Default.APIKey = apiKey;
                Properties.Settings.Default.Save();

                // ✅ Launch the chatbot form
                var chatForm = new FormAI(apiKey);
                chatForm.Show();
                this.Close(); // or this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid API Key. Please try again.");
            }
        }
        private async Task<bool> ValidateApiKey(string apiKey)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://api.openai.com/v1/models");
                    return response.IsSuccessStatusCode;
                }
                catch
                {
                    return false;
                }
            }
        }

        private void close_picturebox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
