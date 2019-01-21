using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameManager.Models;
using GameManager.Services;

namespace GameManager.Controllers
{
    [Route("api/character/")]
    [ApiController]
    public class CharacterController : Controller
    {
        private readonly CharacterServices _services;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("AddCharacter")]
        public ActionResult<Character> AddCharacter(Character character)
        {
            _services.AddCharacter(character);

            if (character == null)
            {
                return NotFound();
            }

            return character;
        }

        [HttpPost]
        [Route("GetCharacters")]
        public ActionResult<Dictionary<int, Character>> GetCharacters()
        {
            var characters = _services.GetCharacters();

            if (characters.Count == 0)
            {
                return NotFound();
            }

            return characters;
        }
    }
}