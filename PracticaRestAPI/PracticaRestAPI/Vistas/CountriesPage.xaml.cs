using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using PracticaRestAPI.Modelo;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using PracticaRestAPI.ViewModels;

namespace PracticaRestAPI.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountriesPage : ContentPage
    {
        List<Country> ListaPaises1;
        public CountriesPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //Creamos una coleccion observable
  
        /*    var url = "https://restcountries.eu/rest/v2/region/oceania";
            HttpClient cliente = new HttpClient();
 

                try
                {
                    var respuesta = await cliente.GetAsync(url);
                    var json = await respuesta.Content.ReadAsStringAsync();
                    ListaPaises1 = JsonConvert.DeserializeObject<List<Country>>(json.ToString());
                    ListCountriesViewModel ListObservable = new ListCountriesViewModel();
                    ListObservable.FillObservableCollection(ListaPaises1);

                }
                catch (Exception e)
                {
                    await DisplayAlert("Error", "Error "+e.Message, "Ok");
                }*/
           
            
       
        }

        private void ListaPaises_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var viewModel = BindingContext as ListCountriesViewModel;
            var country = e.Item as Country;
            viewModel.HideOrShowItem(country);

        }
    }
}