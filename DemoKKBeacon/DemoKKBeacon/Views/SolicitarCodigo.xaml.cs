using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace DemoKKBeacon
{
    public partial class SolicitarCodigo : ContentPage
    {

        public SolicitarCodigo()
        {
            InitializeComponent();



        }

        private async void Solicitar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IngresarCodigo());
            //System.Diagnostics.Debug.WriteLine(CelularTxt.Text, CedulaTxt.Text);

           
        }


        public class ImageButtonDemoPage : ContentPage
        {
            public ImageButtonDemoPage()
            {
              //  Label header = new Label
              //  {
                //    Text = "ImageButton",
                //    FontSize = 50,
                 //   FontAttributes = FontAttributes.
                 //   HorizontalOptions = LayoutOptions.Center
               // };

                ImageButton imageButton = new ImageButton
                {
                    Source = "Trigo.jpeg",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };

                // Build the page.
                //Title = "ImageButton Demo";
                //Content = new StackLayout
                //{
                   // Children = { header, imageButton }
               // };
            }
        }



    }
}
