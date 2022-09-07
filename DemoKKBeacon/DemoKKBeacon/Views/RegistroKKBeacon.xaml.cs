
using RestSharp;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using DemoKKBeacon.Models;
using Newtonsoft.Json;

namespace DemoKKBeacon
{
    public partial class RegistroKKBeacon : ContentPage
    {

        List<String> Localidades = new List<string>() { "QUITO", "GUAYAQUIL", "CAYAMBE" };
        List<String> Bodegas = new List<string>() { "B1", "B2", "B3", "B4"};

        public RegistroKKBeacon()
        {
            InitializeComponent();
            pickerLocalidad.ItemsSource = Localidades;
            pickerBodega.ItemsSource = Bodegas;
        }


        private async void IngresarKKBeacon_Clicked(object sender, EventArgs e)
        {



            var newIngresoKKBeacon = new RegistroGateway(MacTxt.Text, pickerLocalidad.SelectedItem.ToString(), pickerBodega.SelectedItem.ToString(), Int32.Parse(XTxt.Text), Int32.Parse(YTxt.Text), Int32.Parse(ZTxt.Text), true);


            var client = new RestClient("http://192.168.174.181:88");
            var request = new RestRequest("/api/RegistroGateways", Method.Post);

            request.AddJsonBody(newIngresoKKBeacon);

            RestResponse response = await client.ExecuteAsync(request);
            var content = response.Content; // {"message":" created."}

            System.Diagnostics.Debug.WriteLine(response.StatusCode + "---" + content);

            var result = await DisplayAlert("Registro KKBeacon", "Registro Exitoso!", null, "OK");


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
