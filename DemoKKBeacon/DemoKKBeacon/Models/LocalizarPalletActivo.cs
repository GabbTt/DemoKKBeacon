using System;
using System.Collections.Generic;
using System.Text;

namespace DemoKKBeacon.Models
{
    public class LocalizarPalletActivo
    {
        public int Id { get; set; }
        public DateTime SensorTime { get; set; }
        public string Gmac { get; set; }
        public string Dmac { get; set; }

        public string NumLote { get; set; }
        public string CodPallet { get; set; }
        public string Centro { get; set; }
        public string Bodega { get; set; }
        public string Rssi { get; set; }
    }
}
