using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CliDemo.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoDelPedidoController : ControllerBase
    {
        // GET: api/<EstadoDelPedidoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EstadoDelPedidoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "El valor solicitado es: "+id.ToString();
        }

        // POST api/<EstadoDelPedidoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EstadoDelPedidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EstadoDelPedidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
