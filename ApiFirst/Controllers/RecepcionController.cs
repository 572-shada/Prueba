using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFirst.Controllers
{

    [Route("api/Recepcion")]
    [ApiController]
    public class RecepcionController : ControllerBase

    {
        private List<Peliculas> Peliculas { get; set; } = new List<Peliculas>() {
        new Peliculas(){
        Id = 123,
        NombrePelicula = "El castillo ambulante",
        Estudio = "Ghibli"

         }
        };

        [HttpGet]
        public List<Peliculas> Get()
        {
            return Peliculas;
        }

        [HttpPut("{id}")]
        public Peliculas Update([FromBody] Peliculas peliculasUp, [FromQuery] int id)
        {
            var peliculas = Peliculas.Find(peliculas => peliculas.Id == id);
            peliculas.NombrePelicula = peliculasUp.NombrePelicula;
            peliculas.Estudio = peliculasUp.Estudio;
            return peliculas;
        }

        [HttpPost]
        public Peliculas Update([FromBody] Peliculas peliculas)
        {
            Peliculas.Add(peliculas);
            return peliculas;
        }

        [HttpDelete]
        [Route("{id}")]
        public Peliculas Delete([FromQuery] int id)
        {
            var peliculas = Peliculas.Find(peliculas => peliculas.Id == id);
            Peliculas.Remove(peliculas);
            return peliculas;
        }
    }
}

    
