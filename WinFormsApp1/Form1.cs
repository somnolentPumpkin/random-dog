using Newtonsoft.Json;
using System.Linq.Expressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _client;
        private Image _currentDogImage;

        public Form1()
        {
            InitializeComponent();
            CenterPictureBox(pictureBoxDog);
            this.Icon = Icon.FromHandle(((Bitmap)Properties.Resources.icon_32).GetHicon());
            this.BackColor = Color.FromArgb(30, 30, 30);
            buttonFetchDog.BackColor = Color.FromArgb(30, 30, 30);
            buttonFetchDog.ForeColor = Color.White;
            pictureBoxDog.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDog.MinimumSize = new Size(512, 512);
            this.SizeChanged += MainForm_SizeChanged;

            _client = new HttpClient();

            FetchRandomDogImage();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            CenterPictureBox(pictureBoxDog);
            pictureBoxDog.Image = _currentDogImage;
        }

        private async void FetchRandomDogImage()
        {
            // Make the GET request to the dog API, and update the window with the new picture.
            try
            {
                string url = "https://dog.ceo/api/breeds/image/random";
                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    DogApiResponse result = JsonConvert.DeserializeObject<DogApiResponse>(content);
                    _currentDogImage = await LoadImageAsync(result.Message);
                    pictureBoxDog.Image = _currentDogImage;
                    
                    // This helps avoid images being off-center when maximizing/restoring the window.
                    CenterPictureBox(pictureBoxDog);
                }
                else
                {
                    MessageBox.Show("Error fetching dog image.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching dog image.");
            }
        }

        private async Task<Image> LoadImageAsync(string url)
        {
            // Get the dog image from the API, and return the image.
            HttpResponseMessage response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                return Image.FromStream(stream);
            }
        }

        private void buttonFetchDog_Click(object sender, EventArgs e)
        {
            // When the random dog button is pressed, fetch a new image.
            FetchRandomDogImage();

        }

        private void CenterPictureBox(PictureBox picBox)
        {
            var x = (this.ClientSize.Width - picBox.Width) / 2;
            var y = (this.ClientSize.Height - picBox.Height) / 2;

            picBox.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));
        }


        public class DogApiResponse
        {
            public string Status { get; set; }
            public string Message { get; set; }
        }
    }
}