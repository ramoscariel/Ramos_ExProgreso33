using Newtonsoft.Json;
using Ramos_ExProgreso33.Model;

namespace Ramos_ExProgreso33.View;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		//CounterBtn.Text = await GetFruta();
	}
	
}

