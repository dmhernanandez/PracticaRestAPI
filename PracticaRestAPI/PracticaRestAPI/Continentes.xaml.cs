using PracticaRestAPI.ViewModels;
using PracticaRestAPI.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracticaRestAPI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Continentes : ContentPage
    {
        public Continentes()
        {
            InitializeComponent();
            PiNombres.Items.Add("Africa");
            PiNombres.Items.Add("America");
            PiNombres.Items.Add("Asia");
            PiNombres.Items.Add("Europa");
            PiNombres.Items.Add("Oceania");
        }

        private async void PiNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = PiNombres.Items[PiNombres.SelectedIndex];
            await DisplayAlert(name, "Item Seleccionado", "Aceptar");

            if (name == "America")
            {
                name = "Americas";
            }
            else if (name == "Europa")
            {
                name = "Europe";
            }
            ListCountriesViewModel.url = "https://restcountries.eu/rest/v2/region/"+name;
            await Navigation.PushAsync(new CountriesPage());
        }
    }
}