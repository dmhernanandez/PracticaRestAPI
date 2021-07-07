using Newtonsoft.Json;
using PracticaRestAPI.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;

namespace PracticaRestAPI.ViewModels
{
    public class ListCountriesViewModel
    {

        //Esta variable se utiliza para in
        private Country oldCountry;
       public ObservableCollection<Country> CountriesList { get; set; }
       public static string url;
        public ListCountriesViewModel()
        {
            
            HttpClient cliente = new HttpClient();
            try
            {
                var respuesta = cliente.GetAsync(url).Result;
                var json =  respuesta.Content.ReadAsStringAsync().Result;
                var ListaPaises1 = JsonConvert.DeserializeObject<List<Country>>(json.ToString());
                CountriesList = new ObservableCollection<Country>(ListaPaises1);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error", "Error " + e.Message, "Ok");
            }



        }

        public void FillObservableCollection(List<Country> countries)
        {
            foreach (Country pais in countries)
            {
                CountriesList.Add(pais);
            }
        }

        public void HideOrShowItem(Country country)
        {
            
            if(oldCountry==country)
            {
                if (country.IsVisible)
                {
                    country.iconDesplegable = "showMore.png";
                }
                else
                {
                    country.iconDesplegable = "showLess.png";
                }
                country.IsVisible = !country.IsVisible;
                UpdateList(country);
            }
            else
            {
                //Si ya hay un pais seleccionado anteriormente entonces el pais que esta seleccionado pasa a ser invisible
                if(oldCountry!=null)
                {
                    oldCountry.iconDesplegable = "showMore.png";
                    oldCountry.IsVisible = false;
                    //Actualizamos la lista para que oculte el pais seleccionado 
                    UpdateList(oldCountry);
                }

                country.iconDesplegable = "showLess.png";
                country.IsVisible = true;
                UpdateList(country);  
            }
            //Ahora el pais seleccionado pasa a ser 
            oldCountry = country;
        }
        public void UpdateList(Country country)
        {
            //Optemos el index que tiene el pais en el Observable Collection
            var index = CountriesList.IndexOf(country);

            //Removemos el elemento del colleccion observable
            CountriesList.Remove(country);

            //Luego se agrega en la misma posicion para hacer la simulacion que se oculta y aparece como acordion
            CountriesList.Insert(index, country);
        }
    }
}
