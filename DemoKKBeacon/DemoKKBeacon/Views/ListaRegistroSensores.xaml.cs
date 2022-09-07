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
    public partial class ListaRegistroSensores : ContentPage
    {




        public ListaRegistroSensores()
        {
            InitializeComponent();

            this.BindingContext = this;



            var listaSensorPallet = GetPalletSensors();
            var listaStr = "";// "DMAC    TIME    X   Y   Z   HUMIDITY    TEMP\n";


            listViewRegistroPalletSensor.ItemsSource = GetPalletSensors();

            foreach (var sensorInfo in listaSensorPallet)
            {
                listaStr +=
                    $"NumLote : {sensorInfo.NumLote}\n" +
                    $"CodPallet : {sensorInfo.CodPallet}\n" +
                    $"COORD: (15,200,126)\n" +
                    $"HUM  : 26.5\n" +
                    $"Centro  : Quito\n" +
                    $"Bodega  : Bodega1\n" +
                    $"HUM  : 26.5\n" +
                    $"TEMP : 20.10\n------------------------\n";//+
                                                                            //$"Lote : {sensorInfo.lote}\n------------------------\n";
                                                                            //break;
            }

            listaStr += $"Total Registros: {listaSensorPallet.Count.ToString()}";
            editor.Text = listaStr;
        }

        public List<RegistroPalletSensor> GetPalletSensors()
        {

            var client = new RestClient("http://192.168.174.181:88");
            var request = new RestRequest("/api/ListaSensores/1/1", Method.Get);

            var something = client.Execute(request);

            var queryResult = client.Execute<List<RegistroPalletSensor>>(request).Data;



            return queryResult.ToList<RegistroPalletSensor>();
        }

    }




       

    
}
