using RestSharp;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using DemoKKBeacon.Models;
using Newtonsoft.Json;
using System.Linq;

namespace DemoKKBeacon
{
    public partial class MenuGestionReportes : ContentPage
    {
        public MenuGestionReportes()
        {
            InitializeComponent();
        }

        private async void GenerarReporte_Clicked(object sender, EventArgs e)
        {
           if (RadioSensores.IsChecked)
                await Navigation.PushAsync(new SensoresVisibles());
           else if (RadioPallets.IsChecked)
                await Navigation.PushAsync(new LocalizarPalletsActivos());


        }


     



        private void Switch_Toggled(Object snder, ToggledEventArgs e)
        {
          //  bool generaReportes= Switch.IsToggled;
           // DisplayAlert("Message", generaReportes.ToString(), "Ok");
        }

      
    }
}