

namespace DemoKKBeacon.Models
{
    public class RegistroPalletSensor
    {
        public int Id { get; set; }
        public string NumLote { get; set; }
        public string NumOrden { get; set; }
        public string CodPallet { get; set; }
        public string ColorPallet { get; set; }
        public string PesoPalletVacio { get; set; }
        public string Producto { get; set; }
        public string TipoProducto { get; set; }
        public string PesoProducto { get; set; }

        public string Dmac { get; set; }

        public RegistroPalletSensor(string numLote, string codPallet, string dmac)
        {
            NumLote = numLote;
            CodPallet = codPallet;
            Dmac = dmac;
        }
    }
}


