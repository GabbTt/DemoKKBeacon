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
    public partial class PalletsEnBodega : ContentPage
    {




        public PalletsEnBodega()
        {
            InitializeComponent();

            this.BindingContext = this;



         


            listViewRegistroPalletSensor.ItemsSource = GetLocalizarPalletsActivos();


        }

        public  List<PalletsEnBodegaModel> GetLocalizarPalletsActivos()
        {

            var client = new RestClient("http://192.168.1.40:88");
            var request = new RestRequest("/api/PalletsEnBodega", Method.Get);

            var queryResult = client.Execute<List<PalletsEnBodegaModel>>(request).Data;



            return queryResult.ToList<PalletsEnBodegaModel>();
        }


        private void Actualizar_Clicked(object sender, EventArgs e)
        {

            listViewRegistroPalletSensor.ItemsSource = GetLocalizarPalletsActivos();

        }


    }




       

    
}
