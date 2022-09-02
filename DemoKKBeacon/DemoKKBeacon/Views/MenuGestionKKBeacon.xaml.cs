
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using System.Collections.Generic;



namespace DemoKKBeacon
{
    public partial class MenuGestionKKBeacon : ContentPage
    {




        public MenuGestionKKBeacon()
        {
            InitializeComponent();

        }


        private async void MenuEditarBeacons_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroKKBeacon());
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);


        }



        private async void MenuAgregarKKBeacons_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroKKBeacon());
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);


        }

        private async void MenuEliminarKKBeacons_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EliminarKKBeacon());
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);


        }

        private async void MenuModificarKKBeacons_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuGestionKKBeacon());
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);


        }



    }
}