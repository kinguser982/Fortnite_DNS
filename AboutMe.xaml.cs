namespace MauiApp2;

public partial class AboutMe : ContentPage
{
	public AboutMe()
	{
		InitializeComponent();
	}

    private async void OnClicked(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://github.com/kinguser981");
    }

    private async void OnClickedd(object sender, TappedEventArgs e)
    {
        await Launcher.OpenAsync("https://www.youtube.com/@help-me-sam");
    }



}