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
    public partial class LocalizarPalletsActivos : ContentPage
    {




        public LocalizarPalletsActivos()
        {
            InitializeComponent();

            this.BindingContext = this;



         


            listViewRegistroPalletSensor.ItemsSource = GetLocalizarPalletsActivos();


        }

        public  List<LocalizarPalletActivo> GetLocalizarPalletsActivos()
        {

            var client = new RestClient("http://192.168.100.240:88");
            var request = new RestRequest("/api/LocalizarPalletsActivos", Method.Get);

            var queryResult = client.Execute<List<LocalizarPalletActivo>>(request).Data;



            return queryResult.ToList<LocalizarPalletActivo>();
        }


        private void Actualizar_Clicked(object sender, EventArgs e)
        {

            listViewRegistroPalletSensor.ItemsSource = GetLocalizarPalletsActivos();

        }


    }




       

    
}
