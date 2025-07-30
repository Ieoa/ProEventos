using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }

        [HttpGet]
        public Evento Get()
        {
            return new Evento()
            {
                EventoID = 1,
                Tema = " Angular 11 e .NET 5",
                Local = "Belo horizonte ",
                Lote = "1º Lote ",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"



            };

        }
        [HttpPost]
        public string Post()
        {
            return ok();
        }
    }
}
