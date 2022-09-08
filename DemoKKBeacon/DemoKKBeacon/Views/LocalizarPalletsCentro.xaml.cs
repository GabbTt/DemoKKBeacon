using RestSharp;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using DemoKKBeacon.Models;
using DemoKKBeacon.Views ;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Linq;

namespace DemoKKBeacon
{
    public partial class LocalizarPalletsCentro : ContentPage
    {


        List<String> localidades;

        public LocalizarPalletsCentro()
        {
            InitializeComponent();

            this.BindingContext = this;

            localidades = GetLocalizarPalletsActivos().Select(e => e.Centro).Distinct().ToList();

            //listViewRegistroPalletSensor.ItemsSource = GetLocalizarPalletsActivos();

            pickerLocalidad.ItemsSource = localidades;

        }

        public  List<LocalizarPalletActivo> GetLocalizarPalletsActivos()
        {

            var client = new RestClient("http://192.168.1.40:88");
            var request = new RestRequest("/api/LocalizarPalletsActivos", Method.Get);

            var queryResult = client.Execute<List<LocalizarPalletActivo>>(request).Data;



            return queryResult.ToList<LocalizarPalletActivo>();
        }


        private void Actualizar_Clicked(object sender, EventArgs e)
        {
            var localidad = pickerLocalidad.SelectedItem.ToString();
            listViewRegistroPalletSensor.ItemsSource = GetLocalizarPalletsActivos().Where(registro => registro.Centro.ToUpper() == localidad);

        }


    }




       

    
}
