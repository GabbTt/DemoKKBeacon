namespace DemoKKBeacon.Models
{
    internal class RegistroGateway
    {

        public int Id { get; set; }
        public string Gmac { get; set; }
        public string Centro { get; set; }
        public string Bodega { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public int? Z { get; set; }
        public bool? EsActivo { get; set; }

        public RegistroGateway(string gmac, string centro, string bodega, int? x, int? y, int? z, bool? esActivo)
        {
            Gmac = gmac;
            Centro = centro;
            Bodega = bodega;
            X = x;
            Y = y;
            Z = z;
            EsActivo = esActivo;
        }
    }
}
