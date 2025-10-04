using System.Threading.Tasks;

namespace LocalHostMauiApiConnection
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

      

        private async void ApiCallButton_Clicked(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://tt4np094-7061.inc1.devtunnels.ms/WeatherForecast");
            var data = response.Content.ReadAsStringAsync();

        
                
        }
    }
}
