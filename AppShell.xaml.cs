namespace GrossetApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Citta), typeof(Citta));
            Routing.RegisterRoute(nameof(Meteo), typeof(Meteo));
        }
    }
}
