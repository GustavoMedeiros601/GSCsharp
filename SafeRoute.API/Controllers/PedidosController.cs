using Microsoft.AspNetCore.Mvc;
using SafeRoute.API.Models;
using SafeRoute.API.Repositories;

namespace SafeRoute.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoRepository _repository;

        public PedidosController(IPedidoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pedidos = await _repository.GetAllAsync();
            return Ok(pedidos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var pedido = await _repository.GetByIdAsync(id);
            if (pedido == null)
                return NotFound();
            return Ok(pedido);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Pedido pedido)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            pedido.Status = "PENDENTE";
            await _repository.AddAsync(pedido);
            return CreatedAtAction(nameof(GetById), new { id = pedido.Id }, pedido);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Pedido pedido)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            existing.Origem = pedido.Origem;
            existing.Destino = pedido.Destino;
            existing.Status = pedido.Status;
            existing.DistanciaKm = pedido.DistanciaKm;
            existing.MomentoEntregue = pedido.MomentoEntregue;

            await _repository.UpdateAsync(existing);
            return Ok(existing);
        }

        [HttpPost("{id}/cancelar")]
        public async Task<IActionResult> Cancelar(int id)
        {
            var pedido = await _repository.GetByIdAsync(id);
            if (pedido == null)
                return NotFound();

            pedido.Status = "CANCELADO";
            await _repository.UpdateAsync(pedido);
            return Ok(pedido);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
