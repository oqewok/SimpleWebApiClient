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
using OpenCvSharp;
using OpenCvSharp.UserInterface;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace SimpleWebApiClient
{
    public partial class Main : Form
    {
        private string ProtocolPrefix;

        private string Host;

        private string Port;

        private string RequestURI;

        private string FullURI;

        private string _selectedURI;

        private Credentials _userCredentials;

        private Mat _originalImage;


        public Main()
        {
            InitializeComponent();
            InitURI();
            PopulateFileds();
        }

        private void InitURI()
        {
            ProtocolPrefix = "http://";
            Host = "localhost:";
            Port = "8002/";
            RequestURI = "api/status";

            RefreshFullURI();
        }

        private void RefreshFullURI()
        {
            FullURI = ProtocolPrefix + Host + Port + RequestURI;
        }

        private void RefreshURITextField()
        {
            _tbCurrentRequestURI.Text = FullURI;
        }

        private void PopulateFileds()
        {
            _userCredentials = new Credentials
            {
                Username = "client_user@yandex.ru",
                Password = "pass1234",
                AccessToken = ""
            };

            _tbUsername.Text = _userCredentials.Username;
            _tbPassword.Text = _userCredentials.Password;
            _tbAccessToken.Text = _userCredentials.AccessToken;

            RefreshURITextField();
        }


        private async void SendRequest(string endpoint)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(endpoint);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            if (true)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue
                ("Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes
                ($@"{_userCredentials.Username}:{_userCredentials.Password}")));
            }

            else
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _userCredentials.AccessToken);
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
                    //PickedImage = new Bitmap(fd.FileName);
                    //_pictureBoxMain.Image = new Bitmap(PickedImage, _pictureBoxMain.Width, _pictureBoxMain.Height);

                    _originalImage = new OpenCvSharp.Mat(fd.FileName, ImreadModes.Unchanged);
                    _pictureBoxMain.ImageIpl = _originalImage;
                    _pictureBoxMain.RefreshIplImage(_originalImage);
                }

                
            }
        }

        private void On_btnSendRequest_Click(object sender, EventArgs e)
        {
            try
            {
                //_selectedURI = _listBoxRequestsURIs.SelectedItem.ToString();
                RefreshURITextField();
                SendRequest(FullURI);
                _listBoxRequestsURIs.Items.Add(FullURI);
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
            _userCredentials.Username = _tbUsername.Text;
        }

        private void On_tbPassword_TextChanged(object sender, EventArgs e)
        {
            _userCredentials.Password = _tbPassword.Text;
        }

        private void On_tbAccessToken_TextChanged(object sender, EventArgs e)
        {
            _userCredentials.AccessToken = _tbAccessToken.Text;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void _labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void hTTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProtocolPrefix = "http://";
            RefreshFullURI();
        }

        private void hTTPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProtocolPrefix = "https://";
            RefreshFullURI();
        }

        private void localhostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Host = "localhost:";
            Port = "8002/";
            RefreshFullURI();
            RefreshURITextField();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Host = "195.239.209.250:";
            Port = "8010/";
            RefreshFullURI();
            RefreshURITextField();
        }

        private async void RCNNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _userCredentials.Username = _tbUsername.Text;
            _userCredentials.Password = _tbPassword.Text;
            _userCredentials.AccessToken = _tbAccessToken.Text;

            RequestURI = "api/f/detection?algorythm=neuro";
            RefreshFullURI();
            RefreshURITextField();

            if (_originalImage == null)
            {
                MessageBox.Show(this, "Загрузите изображение");
                return;
            }

            byte[] image = _originalImage.ToBytes();
            _pictureBoxMain.RefreshIplImage(_originalImage);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(FullURI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _userCredentials.AccessToken);

                using (var content = new MultipartFormDataContent("Upload----" + DateTime.Now.ToString(CultureInfo.InvariantCulture)))
                {
                    content.Add(new StreamContent(new MemoryStream(image)), "image", "upload.jpg");

                    using (var message = await client.PostAsync(FullURI, content))
                    {
                        if (message.StatusCode == HttpStatusCode.OK)
                        {
                            var str_result = await message.Content.ReadAsStringAsync();

                            var result = JsonConvert.DeserializeObject(str_result) as JObject;

                            JArray detections = (JArray)result["detections"];

                            if (detections.Count != 0)
                            {
                                var newImage = new Mat();
                                _originalImage.CopyTo(newImage);

                                int plateX = 0;
                                int plateY = 0;
                                int plateWidth = 0;
                                int plateHeight = 0;

                                foreach (JObject d in detections)
                                {
                                    plateX = (int)d["x"];
                                    plateY = (int)d["y"];
                                    plateWidth = (int)d["width"];
                                    plateHeight = (int)d["height"];

                                    var plateBound = new Rect(plateX, plateY, plateWidth, plateHeight);

                                    newImage.DrawRectangle(plateBound, Scalar.Chartreuse, new OpenCvSharp.Size(_pictureBoxMain.Width, _pictureBoxMain.Height));

                                }

                                _pictureBoxMain.RefreshIplImage(newImage);
                            }

                            if (result != null)
                            {
                                _tbResponse.Text = result.ToString();
                            }
                        }

                        else if (message.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            _tbResponse.Text = "Вы не авторизованы " + message.StatusCode.ToString();
                        }

                        else
                        {
                            var str_result = await message.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject(str_result) as JObject;
                            if (result != null)
                                _tbResponse.Text = result.ToString();
                        }

                        _listBoxRequestsURIs.Items.Add(FullURI);
                    }
                }
            }
        }

        private async void HaarCascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _userCredentials.Username = _tbUsername.Text;
            _userCredentials.Password = _tbPassword.Text;
            _userCredentials.AccessToken = _tbAccessToken.Text;

            RequestURI = "api/f/detection?algorythm=haar";
            RefreshFullURI();
            RefreshURITextField();

            if (_originalImage == null)
            {
                MessageBox.Show(this, "Загрузите изображение");
                return;
            }

            byte[] image = _originalImage.ToBytes();

            _pictureBoxMain.RefreshIplImage(_originalImage);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(FullURI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _userCredentials.AccessToken);

                using (var content = new MultipartFormDataContent("Upload----" + DateTime.Now.ToString(CultureInfo.InvariantCulture)))
                {
                    content.Add(new StreamContent(new MemoryStream(image)), "image", "upload.jpg");

                    using (var message = await client.PostAsync(FullURI, content))
                    {
                        if (message.StatusCode == HttpStatusCode.OK)
                        {
                            var str_result = await message.Content.ReadAsStringAsync();

                            var result = JsonConvert.DeserializeObject(str_result) as JObject;

                            JArray detections = (JArray)result["detections"];

                            if (detections.Count != 0)
                            {
                                var newImage = new Mat();
                                _originalImage.CopyTo(newImage);

                                int plateX = 0;
                                int plateY = 0;
                                int plateWidth = 0;
                                int plateHeight = 0;

                                foreach (JObject d in detections)
                                {
                                    plateX = (int)d["x"];
                                    plateY = (int)d["y"];
                                    plateWidth = (int)d["width"];
                                    plateHeight = (int)d["height"];

                                    var plateBound = new Rect(plateX, plateY, plateWidth, plateHeight);

                                    newImage.DrawRectangle(plateBound, Scalar.Chartreuse, new OpenCvSharp.Size(_pictureBoxMain.Width, _pictureBoxMain.Height));

                                }

                                _pictureBoxMain.RefreshIplImage(newImage);
                            }

                            if (result != null)
                            {
                                _tbResponse.Text = result.ToString();
                            }
                        }

                        else if (message.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            _tbResponse.Text = "Вы не авторизованы " + message.StatusCode.ToString();
                        }

                        else
                        {
                            var str_result = await message.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject(str_result) as JObject;

                            if(result!=null)
                                _tbResponse.Text = result.ToString();
                        }

                        _listBoxRequestsURIs.Items.Add(FullURI);
                    }
                }
            }
        }

        private async void NewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _userCredentials.Username = _tbUsername.Text;
            _userCredentials.Password = _tbPassword.Text;

            RequestURI = "api/f/account/new";
            RefreshFullURI();
            RefreshURITextField();


            //
            var client = new HttpClient();
            client.BaseAddress = new Uri(FullURI);
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string quote = "\"";
                string s = "{username:" + quote + _tbUsername.Text + quote+", password:" + quote + _tbPassword.Text + quote + "}";
                var response = client.PostAsync(FullURI, new StringContent(s.ToString(), Encoding.UTF8, "application/json")).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    _tbResponse.Text = "Пользователь создан " + response.StatusCode.ToString();
                }

                else
                {
                    var str_result = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject(str_result);

                    if (result != null)
                    {
                        _tbResponse.Text = result.ToString();
                    }
                }

                _listBoxRequestsURIs.Items.Add(FullURI);
            }

            catch (Exception exc)
            {
                _tbResponse.AppendText(System.Environment.NewLine);
                _tbResponse.AppendText(exc.Message);
            }
        }

        private async void GetTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _userCredentials.Username = _tbUsername.Text;
            _userCredentials.Password = _tbPassword.Text;

            RequestURI = "api/f/account/token";
            RefreshFullURI();
            RefreshURITextField();


            var client = new HttpClient();
            client.BaseAddress = new Uri(FullURI);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue
                ("Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes
                ($@"{_userCredentials.Username}:{_userCredentials.Password}")));



            try
            {
                string quote = "\"";
                string s = "{username:" + quote + _tbUsername.Text + quote + ", password:" + quote + _tbPassword.Text + quote + "}";
                var response = client.PostAsync(FullURI, new StringContent(s.ToString(), Encoding.UTF8, "application/json")).Result;

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    var str_result = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject(str_result);

                    if (result != null)
                    {
                        _tbResponse.Text = result.ToString();
                    }
                }
                _listBoxRequestsURIs.Items.Add(FullURI);
            }

            catch (Exception exc)
            {
                _tbResponse.AppendText(System.Environment.NewLine);
                _tbResponse.AppendText(exc.Message);
            }
        }

        private async void CheckLimitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _userCredentials.Username = _tbUsername.Text;
            _userCredentials.Password = _tbPassword.Text;
            _userCredentials.AccessToken = _tbAccessToken.Text;

            RequestURI = "api/f/account/limits";
            RefreshFullURI();
            RefreshURITextField();



            var client = new HttpClient();
            client.BaseAddress = new Uri(FullURI);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _userCredentials.AccessToken);



            try
            {
                string quote = "\"";
                string s = "{username:" + quote + _tbUsername.Text + quote + ", password:" + quote + _tbPassword.Text + quote + "}";
                var response = client.GetAsync(FullURI).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var str_result = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject(str_result);

                    if (result != null)
                    {
                        _tbResponse.Text = result.ToString();
                    }
                }

                else if(response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    _tbResponse.Text = "Вы не авторизованы " + response.StatusCode.ToString();
                }

                _listBoxRequestsURIs.Items.Add(FullURI);
            }

            catch (Exception exc)
            {
                _tbResponse.AppendText(System.Environment.NewLine);
                _tbResponse.AppendText(exc.Message);
            }



        }

        private async void StatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestURI = "api/status";
            RefreshFullURI();
            RefreshURITextField();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(FullURI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var response = client.GetAsync(FullURI).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var str_result = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject(str_result);

                    if (result != null)
                    {
                        _tbResponse.Text = result.ToString();
                    }
                }

            }

            _listBoxRequestsURIs.Items.Add(FullURI);
        }

        private void RefreshTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _listBoxRequestsURIs.Items.Add(FullURI);
        }
    }
}
