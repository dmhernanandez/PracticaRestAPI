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

        private void PiNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = PiNombres.Items[PiNombres.SelectedIndex];
            DisplayAlert(name, "Item Seleccionado", "Okis");

            if (name == "America")
            {
                name = "Americas";
            }
            else if (name == "Europa")
            {
                name = "Europe";
            }
        }
    }
}