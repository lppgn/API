using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ApiMoment.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase
    {
        List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Torterra"}, 
            new Pokemon() {Name = "Empoleon"}
        };
        [HttpGet]
       public ActionResult Get(){
           return Ok(pokemons);
       } 
        
    }
}
