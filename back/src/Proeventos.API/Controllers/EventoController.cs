using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.API.Models;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly ILogger<EventoController> _logger;

        public EventoController(ILogger<EventoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }
         [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put {id}" ;
        }
         [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete {id}" ;
        }

        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                EventoId = 1,
                Local = "São Paulo",
                Tema = "Api .Net 5",
                Lote = "Lote 1",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                QtdPessoas = 25,
                ImagemUrl = "teste.png"
                },
                 new Evento(){
                EventoId = 2,
                Local = "São Paulo",
                Tema = "Api .Net 5",
                Lote = "Lote 3",
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                QtdPessoas = 27,
                ImagemUrl = "teste2.png"
                }
            };
    }
}
