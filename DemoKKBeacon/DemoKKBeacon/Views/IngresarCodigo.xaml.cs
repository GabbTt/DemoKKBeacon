using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace DemoKKBeacon
{
    public partial class IngresarCodigo: ContentPage
    {

    

        public IngresarCodigo()
        {
            InitializeComponent();
            
        }


        private async void Ingresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuAdmin());
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);

           
        }

    }
}
