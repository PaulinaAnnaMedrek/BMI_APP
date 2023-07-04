using MauiApp6.MVVM.Models;
using MauiApp6.MVVM.ViewModels;

namespace MauiApp6.MVVM.Views;

public partial class NTView : ContentPage
{
	public NTView()
	{
		InitializeComponent();
	}

    private async void AddTask(object sender, EventArgs e)
    {
		var nt = BindingContext as NTViewModel;

		var  select=
			nt.Categoriess.Where(x=>x.Select== true).FirstOrDefault();

		if(select != null)
		{
			var task = new Tasks
			{
				TaskName = nt.Task,
				CategoryId = select.CategoryId,
			};
			nt.Tasks.Add(task);
			await Navigation.PopAsync();
		}
		else
		{
			await DisplayAlert("Selection is not corect", "Please select Show Progress first ", "OK");
		}


    }

    
}