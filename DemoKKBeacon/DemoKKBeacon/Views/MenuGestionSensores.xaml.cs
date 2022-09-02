using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using System.Collections.Generic;



namespace DemoKKBeacon
{
    public partial class MenuGestionSensores : ContentPage
    {




        public MenuGestionSensores()
        {
            InitializeComponent();

        }


        private async void MenuAgregarSensores_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroSensores());
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);


        }

        private async void MenuEliminarSensores_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EliminarSensor());
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);


        }

        private async void RegistrarPalletSensor_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroPalletsSensores());
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);


        }


    }
}