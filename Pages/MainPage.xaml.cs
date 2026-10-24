using ServiceTicketMaui.Models;
using System.Net.Http.Json;

namespace ServiceTicketMaui.Pages
{
    public partial class MainPage : ContentPage
    {
        private readonly HttpClient _http = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7066")
        };

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoadTicketsClicked(object sender, EventArgs e)
        {
            try
            {
                var tickets = await _http.GetFromJsonAsync<List<Ticket>>("/tickets");

                if (tickets != null)
                {
                    TicketsCollection.ItemsSource = tickets;
                }
            }
            catch (Exception ex)
            {
                //Replace DisplayAlert (deprecated) with DisplayAlertAsync
                await DisplayAlertAsync("Error", ex.Message, "OK");
            }
        }
    }
}
