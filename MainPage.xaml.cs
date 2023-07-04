using MauiApp6.MVVM.Views;

namespace MauiApp6;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new BMI());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Information());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
       Navigation.PushAsync(new TaskerView());
    }
}

