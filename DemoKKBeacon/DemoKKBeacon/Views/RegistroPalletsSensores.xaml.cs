
using RestSharp;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using DemoKKBeacon.Models;
using Newtonsoft.Json;
using System.Linq;

namespace DemoKKBeacon
{
    public partial class RegistroPalletsSensores : ContentPage
    {

        public RegistroPalletsSensores()
        {
            InitializeComponent();

            pickerSensor.ItemsSource = GetSensors();
        }


        public List<String> GetSensors()
        {

            var client = new RestClient("http://192.168.100.240:88");
            var request = new RestRequest("/api/ListaSensoresDisponibles", Method.Get);

            var something = client.Execute(request);

            var queryResult = client.Execute<List<RegistroSensor>>(request).Data;



            return queryResult.Select(l => l.Dmac).ToList();
        }

        private async void IngresarKKBeacon_Clicked(object sender, EventArgs e)
        {


            
            
            var newRegistroPalletSensor = new RegistroPalletSensor(LoteTxt.Text, PalletTxt.Text, pickerSensor.SelectedItem.ToString());

            var client = new RestClient("http://192.168.100.240:88");
            var request = new RestRequest("/api/RegistroPalletSensor", Method.Post);

            request.AddJsonBody(newRegistroPalletSensor);

            RestResponse response = await client.ExecuteAsync(request);
            var content = response.Content; // {"message":" created."}

            System.Diagnostics.Debug.WriteLine(response.StatusCode + "---" + content);

            var result = await DisplayAlert("Registro De Pallet y Sensor", "Registro Exitoso!", null, "OK");
            pickerSensor.ItemsSource = GetSensors();

            await Navigation.PopAsync();
            //System.Diagnostics.Debug.WriteLine(CodigoTxt.Text);


        }

        public List<String> GetLocalidad(string url)
        {
            var client = new RestClient(url);
            var response = client.Execute<List<string>>(new RestRequest());

            return response.Data;
        }

    }
}
