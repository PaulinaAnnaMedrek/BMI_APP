using MauiApp6.MVVM.ViewModels;

namespace MauiApp6;

public partial class BMI : ContentPage
{
	public BMI()
	{
		InitializeComponent();

		BindingContext = new BMIViewModel();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}