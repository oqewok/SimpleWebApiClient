using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SimpleWebApiClient
{
    public partial class Main : Form
    {
        private string SelectedURI;

        private Bitmap PickedImage;

        private Credentials UserCredentials;

        private bool UseAccesToken;


        public Main()
        {
            InitializeComponent();
            PopulateFileds();
            CheckStatus("http://195.239.209.250:8010/api/status");
        }

        private void PopulateFileds()
        {
            UserCredentials = new Credentials
            {
                Username = "api_login",
                Password = "api_password1234",
                AccessToken = "very_sercret_test_token_35622gjmv"
            };

            _tbUsername.Text = UserCredentials.Username;
            _tbPassword.Text = UserCredentials.Password;
            _tbAccessToken.Text = UserCredentials.AccessToken;

            UseAccesToken = false;

            SelectedURI = "http://195.239.209.250:8010/api/status";


            _listBoxAllURI.Items.Add("http://195.239.209.250:8010/api/status");
            _listBoxAllURI.Items.Add("http://195.239.209.250:8010/api/detect");
            _listBoxAllURI.Items.Add("http://195.239.209.250:8010/api/detection");
            _listBoxAllURI.Items.Add("http://195.239.209.250:8010/api/detection/old");
        }


        private async void SendRequest(string endpoint)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(endpoint);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            if (!UseAccesToken)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue
                ("Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes
                ($@"{UserCredentials.Username}:{UserCredentials.Password}")));
            }

            else
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserCredentials.AccessToken);
            }
            

            try
            {
                var response = client.GetAsync(endpoint).Result;

                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    var str_result = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject(str_result);

                    _tbResponse.Text = result.ToString();

                }

                else
                {
                    _tbResponse.Text = "Not ok";
                }
            }

            catch(Exception exc)
            {
                _tbResponse.AppendText(System.Environment.NewLine);
                _tbResponse.AppendText(exc.Message);
            }
            
        }

        private async void CheckStatus(string endpoint)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(endpoint);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


            try
            {
                var response = client.GetAsync(endpoint).Result;
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    var str_result = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject(str_result);

                    _tbResponse.Text = result.ToString();
                }

                else
                {
                    _tbResponse.Text = "Not ok";
                }
            }

            catch (Exception exc)
            {
                _tbResponse.AppendText(System.Environment.NewLine);
                _tbResponse.AppendText(exc.Message);
            }

        }

        private void On_btnPickImg_Click(object sender, EventArgs e)
        {
            using(var fd = new OpenFileDialog())
            {
                fd.Filter = "Images | *.jpg; *jpeg; *.png";
                fd.Title = "Pick suitable picture";

                if(fd.ShowDialog() == DialogResult.OK)
                {
                    PickedImage = new Bitmap(fd.FileName);
                    _pictureBoxMain.Image = new Bitmap(PickedImage, _pictureBoxMain.Width, _pictureBoxMain.Height);
                }

                
            }
        }

        private void On_btnSendRequest_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedURI = _listBoxAllURI.SelectedItem.ToString();

                SendRequest(SelectedURI);
            }
            catch(NullReferenceException nre)
            {
                _tbResponse.AppendText(System.Environment.NewLine);
                _tbResponse.AppendText($@"Select suitable URI : {nre.Message}");
            }

            catch (Exception exc)
            {
                _tbResponse.AppendText(System.Environment.NewLine);
                _tbResponse.AppendText(exc.Message);
            }
            
        }

        private void On_tbUsername_TextChanged(object sender, EventArgs e)
        {
            UserCredentials.Username = _tbUsername.Text;
        }

        private void On_tbPassword_TextChanged(object sender, EventArgs e)
        {
            UserCredentials.Password = _tbPassword.Text;
        }

        private void On_tbAccessToken_TextChanged(object sender, EventArgs e)
        {
            UserCredentials.AccessToken = _tbAccessToken.Text;
        }
    }
}
