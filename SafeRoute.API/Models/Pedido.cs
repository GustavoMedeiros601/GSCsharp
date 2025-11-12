namespace SafeRoute.API.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Origem { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public double DistanciaKm { get; set; }
        public DateTime? MomentoEntregue { get; set; }
    }
}




