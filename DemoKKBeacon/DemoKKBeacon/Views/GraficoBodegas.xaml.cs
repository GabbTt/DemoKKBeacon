using RestSharp;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using DemoKKBeacon.Models;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Linq;
using Android.Hardware;
using System.Timers;

namespace DemoKKBeacon
{
    public partial class GraficoBodegas : ContentPage
    {




        public GraficoBodegas()
        {
            InitializeComponent();

            this.BindingContext = this;



            /*
            var timer = new Timer();
            timer.Elapsed += (sender, e) =>
            {
                updateTable();
            };

            timer.Interval = 5000;
            timer.Start();*/




        }

        public List<LocalizarPalletActivo> GetLocalizarPalletsActivos()
        {

            var client = new RestClient("http://192.168.1.40:88");
            var request = new RestRequest("/api/LocalizarPalletsActivos", Method.Get);

            var queryResult = client.Execute<List<LocalizarPalletActivo>>(request).Data;



            return queryResult.ToList<LocalizarPalletActivo>();
        }


        public List<PalletsEnBodegaModel> GetPalletsEnBodega()
        {

            var client = new RestClient("http://192.168.1.40:88");
            var request = new RestRequest("/api/PalletsEnBodega", Method.Get);

            var queryResult = client.Execute<List<PalletsEnBodegaModel>>(request).Data;



            return queryResult.ToList<PalletsEnBodegaModel>();
        }


        private void Actualizar_Clicked(object sender, EventArgs e)
        {
            updateTable();
        }


        private void updateTable()
        {
            //List<PalletsEnBodegaModel> listaBodegas = GetPalletsEnBodega();
            var listaBodegas = GetPalletsEnBodega();

            



            cay1.Text = "";
            gye2.Text = "";
            uio3.Text = "";
            caj4.Text = "";

            bbcay1.Color = Color.Gold;
            bbgye2.Color = Color.Gold;
            bbcaj4.Color = Color.Gold;
            bbuio3.Color = Color.Gold;

            foreach (var sensor in listaBodegas)
            {
                if (sensor.Centro.Equals("GUAYAQUIL") && sensor.Bodega.Equals("B2"))
                {
                    gye2.Text = "GYE B2 / " + sensor.Pallets;
                    bbgye2.Color = Color.LightGreen;
                }
                else if (sensor.Centro.Equals("CAYAMBE") && sensor.Bodega.Equals("B1"))
                {
                    cay1.Text = "CAY B1 / " + sensor.Pallets;
                    bbcay1.Color = Color.LightGreen;
                }
                else if (sensor.Centro.Equals("QUITO") && sensor.Bodega.Equals("B3"))
                {
                    uio3.Text = "UIO B3 / " + sensor.Pallets;
                    bbuio3.Color = Color.LightGreen;

                }
                else if (sensor.Centro.Equals("CAJABAMBA") &&  sensor.Bodega.Equals("B4"))
                {
                    caj4.Text = "CAJ B4 / " + sensor.Pallets;
                    bbcaj4.Color = Color.LightGreen;
                
                }
            }

            
        }
    }

}


  


