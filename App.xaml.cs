namespace MauiApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            Routing.RegisterRoute(nameof(AboutMe), typeof(AboutMe));
            Routing.RegisterRoute(nameof(CheakNewVersion), typeof(CheakNewVersion));
            Routing.RegisterRoute(nameof(SinglePingTest), typeof(SinglePingTest));

        }

  
    }
}