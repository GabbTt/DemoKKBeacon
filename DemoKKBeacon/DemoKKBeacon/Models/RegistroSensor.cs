namespace DemoKKBeacon.Models
{
    internal class RegistroSensor
    {
        public int Id { get; set; }
        public string Dmac { get; set; }
        public bool? EsActivo { get; set; }

        public RegistroSensor(string dmac, bool? esActivo)
        {

            Dmac = dmac;
            EsActivo = esActivo;
        }
    }
}


