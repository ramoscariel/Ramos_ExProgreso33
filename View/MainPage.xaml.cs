using Newtonsoft.Json;
using Ramos_ExProgreso33.Model;

namespace Ramos_ExProgreso33.View;

public partial class MainPage : ContentPage
{
    public int Index { get; set; } = 0;

	public MainPage()
	{
		InitializeComponent();
        //coleccion.ItemsSource = strings;
        datos.Text = "\n";
	}

	private async void BotonClicked(object sender, EventArgs a) 
	{
        string fruta = await GetFruta();
        datos.Text = datos.Text + fruta;
    }
	
    
    public async Task<string> GetFruta()
    {
        string result = "nada";
        string url = "https://www.fruityvice.com/api/fruit/all";
        using (var httpclient = new HttpClient())
        {
            var response = await httpclient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var frutas = JsonConvert.DeserializeObject<Fruta.Class1[]>(json);
                var fruta = frutas[Index];
                result = "\nNombre: " + fruta.name + "\nFamilia: " + fruta.family + "\nAzúcar: " + fruta.nutritions.sugar;
            }
        }
        Index++;
        return result;
    }

}

