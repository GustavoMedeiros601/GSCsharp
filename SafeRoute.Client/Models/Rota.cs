namespace SafeRoute.Client.Models
{
    public class Rota
    {
        public int Id { get; set; }
        public string EnderecoA { get; set; }
        public string EnderecoB { get; set; }
        public double Distancia { get; set; }
        public double Tempo { get; set; }
    }
}
