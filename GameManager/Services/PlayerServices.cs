using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameManager.Models;

namespace GameManager.Services
{
    public class PlayerServices : IPlayerServices
    {
        private readonly Dictionary<int, Player> _players;

        public PlayerServices()
        {
            _players = new Dictionary<int, Player>();
        }

        public Player AddPlayer(Player player)
        {
            _players.Add(player.Id, player);

            return player;
        }

        public Dictionary<int, Player> GetPlayers()
        {
            return _players;
        }

    }
}
