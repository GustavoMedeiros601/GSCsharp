using SafeRoute.Client.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SafeRoute.Client.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://localhost:64559/api/Pedidos"; 

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        //  Criar pedido
        public async Task PostPedidoAsync(Pedido pedido)
        {
            var json = JsonSerializer.Serialize(pedido);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(BaseUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erro ao enviar pedido: {response.StatusCode}\n{error}");
            }
        }

        //  Buscar todos os pedidos
        public async Task<List<Pedido>> GetPedidosAsync()
        {
            var response = await _httpClient.GetAsync(BaseUrl);
            if (!response.IsSuccessStatusCode)
                return new List<Pedido>();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Pedido>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new List<Pedido>();
        }

        //  Cancelar pedido
        public async Task CancelarPedidoAsync(int id)
        {
            var url = $"{BaseUrl}/{id}/cancelar";
            var response = await _httpClient.PostAsync(url, null);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erro ao cancelar pedido: {response.StatusCode}\n{error}");
            }
        }
    }
}


