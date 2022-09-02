using RestSharp;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using DemoKKBeacon.Models;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Linq;

namespace DemoKKBeacon
{
    public partial class SensoresVisibles : ContentPage
    {

        public SensoresVisibles()
        {
            InitializeComponent();

            this.BindingContext = this;

            listViewRegistroPalletSensor.ItemsSource = GetSensoresVisibles();


        }

        public List<SensorAndGatewayData> GetSensoresVisibles()
        {

            var client = new RestClient("http://192.168.100.240:88");
            var request = new RestRequest("/api/ListaSensoresVisibles", Method.Get);

            //var something = client.Execute(request);

            var queryResult = client.Execute<List<SensorAndGatewayData>>(request).Data;



            return queryResult.ToList<SensorAndGatewayData>();
        }


        private void Actualizar_Clicked(object sender, EventArgs e)
        {

            listViewRegistroPalletSensor.ItemsSource = GetSensoresVisibles();

        }


    }




       

    
}
