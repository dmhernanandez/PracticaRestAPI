using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;

using PracticaRestAPI.Modelo;
using PracticaRestAPI.Vistas;
using PracticaRestAPI.ViewModels;

namespace PracticaRestAPI
{
    public partial class MainPage : ContentPage
    {
        public static string url;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnConsumeApi_Clicked(object sender, EventArgs e)
        {
            ListCountriesViewModel.url= "https://restcountries.eu/rest/v2/region/oceania";
            await Navigation.PushAsync(new CountriesPage());
          
          /*  var url= "https://restcountries.eu/rest/v2/region/oceania";
            using (HttpClient cliente=new HttpClient())
            {
               
                try
                {
                    var respuesta = await cliente.GetAsync(url);
                    var json = await respuesta.Content.ReadAsStringAsync();
                    
                    List<Country> ListaPaises= JsonConvert.DeserializeObject<List<Country>>(json.ToString());
                    Country pais = ListaPaises.ElementAt(0);
                  
                    EdtShowResult.Text = pais.name+" "+ pais.currencies.ElementAt(0).ToString();
                 

                }
                catch(Exception )
                {
                    DisplayAlert("Error","Error","Ok");
                }
                
            }*/
        }

        private async void btnContinentes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Continentes());
        }
    }
}
