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

        public List<PalletsEnBodegaModel> GetLocalizarPalletsActivos()
        {

            var client = new RestClient("http://192.168.174.181:88");
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
            


            //List<PalletsEnBodegaModel> listaSensores = GetLocalizarPalletsActivos();
            var listaSensores = GetLocalizarPalletsActivos();

            gye1.Text = "";
            gye2.Text = "";
            uio1.Text = "";
            uio2.Text = "";

            bbgye1.Color = Color.Gold;
            bbgye2.Color = Color.Gold;
            bbuio1.Color = Color.Gold;
            bbuio2.Color = Color.Gold;

            foreach (var sensor in listaSensores)
            {
                if (sensor.Centro.Equals("GUAYAQUIL"))
                {
                    if (sensor.Bodega.Equals("B1"))
                    {
                        gye1.Text = "GYE B1 / " + sensor.Pallets;
                        bbgye1.Color = Color.LightGreen;
                    }
                    else if (sensor.Bodega.Equals("B2"))
                    {
                        gye2.Text = "GYE B2 / " + sensor.Pallets;
                        bbgye2.Color = Color.LightGreen;
                    }
                }
                else if (sensor.Centro.Equals("QUITO"))
                {
                    if (sensor.Bodega.Equals("B1"))
                    {
                        uio1.Text = "UIO B1 / " + sensor.Pallets;
                        bbuio1.Color = Color.LightGreen;
                    }
                    else if (sensor.Bodega.Equals("B2"))
                    {
                        uio2.Text = "UIO B2 / " + sensor.Pallets;
                        bbuio2.Color = Color.LightGreen;
                    }
                }
            }

        }
    }


  







}
