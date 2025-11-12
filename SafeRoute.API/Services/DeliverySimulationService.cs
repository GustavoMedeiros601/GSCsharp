using SafeRoute.API.Repositories;
using SafeRoute.API.Models;

namespace SafeRoute.API.Services
{
    public class DeliverySimulationService : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public DeliverySimulationService(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using var scope = _scopeFactory.CreateScope();
                var repo = scope.ServiceProvider.GetRequiredService<IPedidoRepository>();
                var pedidos = await repo.GetAllAsync();

                foreach (var pedido in pedidos)
                {
                    if (pedido.Status == "PENDENTE")
                    {
                        pedido.Status = "SAIU PARA ENTREGA";
                        pedido.DistanciaKm = new Random().Next(1, 500);
                        await repo.UpdateAsync(pedido);
                    }
                    else if (pedido.Status == "SAIU PARA ENTREGA")
                    {
                        pedido.DistanciaKm -= 30;

                        if (pedido.DistanciaKm <= 0)
                        {
                            pedido.DistanciaKm = 0;
                            pedido.Status = "ENTREGUE";
                            pedido.MomentoEntregue = DateTime.Now;
                        }

                        await repo.UpdateAsync(pedido);
                    }
                }

                await Task.Delay(3000, stoppingToken);
            }
        }
    }
}
