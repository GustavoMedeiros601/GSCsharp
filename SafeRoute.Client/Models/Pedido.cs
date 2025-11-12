using System;

namespace SafeRoute.Client.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Origem { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public string Status { get; set; } = "PENDENTE";
        public double DistanciaKm { get; set; } = 0;
        public DateTime? MomentoEntregue { get; set; }
    }
}
