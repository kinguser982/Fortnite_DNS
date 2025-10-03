

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

    private async void OnEmailTapped(object sender, EventArgs e)
    {


        await Launcher.OpenAsync("mailto:kinguser981@gmail.com");
 
    }

}