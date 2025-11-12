using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafeRoute.Client.Models;
using SafeRoute.Client.Services;

namespace SafeRoute.Client.Views
{
    public partial class MainForm : Form
    {
        private readonly ApiService _apiService;
        private readonly Timer _timer;

        public MainForm()
        {
            InitializeComponent();
            _apiService = new ApiService();

            _timer = new Timer();
            _timer.Interval = 3000; 
            _timer.Tick += async (s, e) => await CarregarPedidosAsync();
            _timer.Start();
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var novoPedido = new Pedido
                {
                    Origem = txtOrigem.Text,
                    Destino = txtDestino.Text,
                    Status = "PENDENTE"
                };

                await _apiService.PostPedidoAsync(novoPedido);
                await CarregarPedidosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar pedido:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnListar_Click(object sender, EventArgs e)
        {
            await CarregarPedidosAsync();
        }

        private async Task CarregarPedidosAsync()
        {
            try
            {
                var pedidos = await _apiService.GetPedidosAsync();
                dgvPedidos.DataSource = pedidos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar pedidos:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pedido = dgvPedidos.CurrentRow.DataBoundItem as Pedido;
            if (pedido == null) return;

            try
            {
                await _apiService.CancelarPedidoAsync(pedido.Id);
                await CarregarPedidosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cancelar pedido:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
