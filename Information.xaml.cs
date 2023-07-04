namespace MauiApp6;

public partial class Information : ContentPage
{
	public Information()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}