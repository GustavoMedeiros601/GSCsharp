using System;

namespace SafeRoute.Client.Models
{
    public class Rastreamento
    {
        public int PedidoId { get; set; }
        public string StatusAtual { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
    }
}
