using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using EFwebapi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EFwebapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
        new Character(),
        new Character { Id = 1, Name = "Sam" }
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(character => character.Id == id));
        }
    }
}