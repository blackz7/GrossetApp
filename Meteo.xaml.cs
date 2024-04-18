using GrossetApp.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace GrossetApp;

public partial class Meteo : ContentPage
{
    private readonly HttpClient _httpClient = new HttpClient();

    private string urlApiMeteo = "https://api.jsonbin.io/v3/b/662034fead19ca34f85bbe8b";

    public ObservableCollection<RootMeteo> meteos { get; set; } = new();


    public Meteo()
	{
		InitializeComponent();
        OnAppearing();
    }


    protected override async void OnAppearing()
    {

        base.OnAppearing();

        var response = await _httpClient.GetFromJsonAsync<RootMeteo>(urlApiMeteo);
        meteos.Clear();
        meteos.Add(response);
    }
}