using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.api.Models;

namespace ProEventos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _Evento = new Evento[] {
            new Evento() {
                    EventoId = 1,
                    Tema = "Angular 11 e .net 5",
                    Local = "Glória-SE",
                    Lote = "Primeiro Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "Foto.png"
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "Angular e suas Novidades",
                    Local = "Aracaju-SE",
                    Lote = "Segundo Lote",
                    QtdPessoas = 200,
                    DataEvento = DateTime.Now.AddDays(10).ToString("dd/MM/yyyy"),
                    ImagemURL = "Foto2.png"
                },
        };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _Evento;
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _Evento.Where(Evento => Evento.EventoId == id);
        }


        [HttpPost]
        public string Post()
        {
            return "Modelo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Modelo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Modelo de delete com id = {id}";
        }
    }
}
