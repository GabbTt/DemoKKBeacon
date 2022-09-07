using RestSharp;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using DemoKKBeacon.Models;
using Newtonsoft.Json;
using System.Linq;
using Xamarin.Essentials;

namespace DemoKKBeacon
{
    public partial class EliminarKKBeacon : ContentPage
    {

        List<String> KKBeacons = new List<string>() { "111111" };


        public EliminarKKBeacon()
        {
            InitializeComponent();


            pickerKKBeacon.ItemsSource = GetBeacons(); ;

        }


        public List<String> GetBeacons()
        {

            var client = new RestClient("http://192.168.174.181:88");
            var request = new RestRequest("/api/ListaGateways/", Method.Get);




            var queryResult = client.Execute<List<RegistroGateway>>(request).Data;




            return queryResult.Select(l => l.Gmac).ToList();
        }



        public List<String> GetLocalidad(string url)
        {
            var client = new RestClient(url);
            var response = client.Execute<List<string>>(new RestRequest());

            return response.Data;
        }



        private async void EliminarKKBeacon_Clicked(object sender, EventArgs e)
        {

            var client = new RestClient("http://192.168.174.181:88");
            var request = new RestRequest($"/api/gateways/{pickerKKBeacon.SelectedItem}", Method.Delete);


            var response = client.Execute(request);

            var result = await DisplayAlert("Eliminar KKBeacon", "Registro Eliminado Exitosamente!", null, "OK");

            System.Diagnostics.Debug.WriteLine(response.StatusCode);

            await Navigation.PopAsync();
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);
            //

        }
    }

}
