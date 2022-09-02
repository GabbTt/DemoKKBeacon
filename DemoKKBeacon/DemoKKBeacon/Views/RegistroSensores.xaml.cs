using RestSharp;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using DemoKKBeacon.Models;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace DemoKKBeacon
{
    public partial class RegistroSensores : ContentPage
    {




        public RegistroSensores()
        {
            InitializeComponent();


        }


        private async void RegistroSensores_Clicked(object sender, EventArgs e)
        {

            var newRegistroSensor = new RegistroSensor(MacTxtSensor.Text, true);


            var client = new RestClient("http://192.168.100.240:88");
            var request = new RestRequest("/api/RegistroSensores", Method.Post);

            request.AddJsonBody(newRegistroSensor);

            RestResponse response = await client.ExecuteAsync(request);
            var content = response.Content; // {"message":" created."}

            System.Diagnostics.Debug.WriteLine(response.StatusCode + "---" + content);

            var result = await DisplayAlert("Registro de Sensor", "Registro Exitoso!", null, "OK");


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
