using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramos_ExProgreso33.Model
{
    public class ARMainPageModel
    {
        public int Index { get; set; } = 0;
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
                    result = "Nombre: "+fruta.name+"\nFamilia: "+fruta.family+"\nAzúcar: "+fruta.nutritions.sugar;
                }
            }
            Index++;
            return result;
        }
    }
}
