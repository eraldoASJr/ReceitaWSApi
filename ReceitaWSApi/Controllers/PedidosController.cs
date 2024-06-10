using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReceitaWSApi.Data;
using ReceitaWSApi.Models;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;

namespace ReceitaWSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly HttpClient _httpClient;

        public PedidosController(AppDbContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;
        }

        // POST: api/Pedidos
       [HttpPost]
       public async Task<ActionResult<Pedido>> PostPedido([FromBody] CNPJModel model)
       {
           // Limpar caracteres de formatação do CNPJ
           var cnpjLimpo = Regex.Replace(model.CNPJ, "[^0-9]", "");

           var response = await _httpClient.GetAsync($"https://www.receitaws.com.br/v1/cnpj/{cnpjLimpo}");
           if (!response.IsSuccessStatusCode)
           {
               return BadRequest("Failed to retrieve data from ReceitaWS");
           }

           var resultado = await response.Content.ReadAsStringAsync();

           // Desserializar e reformatar o resultado JSON
           var jsonFormatado = JToken.Parse(resultado).ToString(Newtonsoft.Json.Formatting.Indented);

           var pedido = new Pedido
           {
               CNPJ = model.CNPJ,  // Armazena o CNPJ com formatação original
               Resultado = jsonFormatado  // Armazena o JSON formatado
           };

           _context.Pedidos.Add(pedido);
           await _context.SaveChangesAsync();

           return CreatedAtAction("GetPedido", new { id = pedido.Id }, pedido);
       }

        // GET: api/Pedidos/{id}
        [HttpGet("{id}")]
        
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);

            if (pedido == null)
            {
                return NotFound();
            }

            return pedido;
        }
    }
}
