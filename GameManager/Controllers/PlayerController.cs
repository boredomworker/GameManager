using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameManager.Models;
using GameManager.Services;

namespace GameManager.Controllers
{
    [Route("v1/player/")]
    [ApiController]
    public class PlayerController : Controller
    {
        private readonly PlayerServices _services;

        public PlayerController(PlayerServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("AddPlayer")]
        public ActionResult<Player> AddPlayer(Player player)
        {
            _services.AddPlayer(player);

            if(player == null)
            {
                return NotFound();
            }

            return player;
        }

        [HttpPost]
        [Route("GetPlayers")]
        public ActionResult<Dictionary<int, Player>> GetPlayers()
        {
            var players = _services.GetPlayers();

            if(players.Count == 0)
            {
                return NotFound();
            }

            return players;
        }
    }
}