using MauiApp6.MVVM.ViewModels;

namespace MauiApp6.MVVM.Views;

public partial class TaskerView : ContentPage
{
	public TaskerViewModel taskerViewModel= new TaskerViewModel();
	public TaskerView()
	{
		InitializeComponent();
		BindingContext = taskerViewModel;
	}

    private void ChBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		taskerViewModel.InfoUpdate();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		var NTView = new NTView
		{
			BindingContext = new NTViewModel
			{
				Tasks = taskerViewModel.Task,
				Categoriess= taskerViewModel.Category,
			}
		};

	     Navigation.PushAsync(NTView);
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}