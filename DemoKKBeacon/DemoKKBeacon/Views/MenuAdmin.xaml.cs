using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace DemoKKBeacon
{
    public partial class MenuAdmin : ContentPage
    {

     


        public MenuAdmin()
        {
            InitializeComponent();
            
        }


        private async void MenuGestionKKBeacon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuGestionKKBeacon());
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);

           
        }

        private async void MenuGestionSensores_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuGestionSensores());
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);


        }

        private async void MenuGestionReportes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuGestionReportes());
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);


        }

        private async void MenuGraficas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuAdmin());
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);


        }

    }
}
