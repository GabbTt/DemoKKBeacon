using System;
using System.Collections.Generic;
using System.Text;

namespace DemoKKBeacon.Models
{
    public class SensorAndGatewayData
    {
        public int Id { get; set; }
        public DateTime SensorTime { get; set; }
        public string Gmac { get; set; }
        public string Dmac { get; set; }
        public string Rssi { get; set; }
        public string Vbatt { get; set; }
        public string Temp { get; set; }
        public string X0 { get; set; }
        public string Y0 { get; set; }
        public string Z0 { get; set; }


    }
}
