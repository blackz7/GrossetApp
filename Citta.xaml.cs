using GrossetApp.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace GrossetApp;

public partial class Citta : ContentPage
{

    private readonly HttpClient _httpClient = new HttpClient();

    private string urlApiCitta = "https://api.jsonbin.io/v3/b/6620334ce41b4d34e4e60a2c";

    public ObservableCollection<RootCitta> cittas { get; set; } = new();

    public Citta()
    {
        InitializeComponent();
        
        OnAppearing();
    }


    protected override async void OnAppearing()
    {

        base.OnAppearing();

        var response = await _httpClient.GetFromJsonAsync<RootCitta>(urlApiCitta);
        cittas.Clear();
        cittas.Add(response);   
    }
}