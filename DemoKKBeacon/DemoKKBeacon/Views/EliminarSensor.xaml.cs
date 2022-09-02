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
    public partial class EliminarSensor : ContentPage
    {

        public EliminarSensor()
        {
            InitializeComponent();


            pickerKKBeacon.ItemsSource = GetSensors();

        }


        public List<String> GetSensors()
        {

            var client = new RestClient("http://192.168.100.240:88");
            var request = new RestRequest("/api/ListaSensores", Method.Get);

            var something = client.Execute(request);

            var queryResult = client.Execute<List<RegistroSensor>>(request).Data;



            return queryResult.Select(l => l.Dmac).ToList();
        }



        public List<String> GetLocalidad(string url)
        {
            var client = new RestClient(url);
            var response = client.Execute<List<string>>(new RestRequest());

            return response.Data;
        }



        private async void EliminarKKBeacon_Clicked(object sender, EventArgs e)
        {

            var client = new RestClient("http://192.168.100.240:88");
            var request = new RestRequest($"/api/sensores/{pickerKKBeacon.SelectedItem}", Method.Delete);


            var response = client.Execute(request);

            var result = await DisplayAlert("Eliminar Sensores", "Sensor Eliminado Exitosamente!", null, "OK");

            System.Diagnostics.Debug.WriteLine(response.StatusCode);

            await Navigation.PopAsync();
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);
            //

        }
    }

}
