using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameManager.Models;

namespace GameManager.Services
{
    public class CharacterServices : ICharacterServices
    {
        private readonly Dictionary<int, Character> _characters;

        public CharacterServices()
        {
            _characters = new Dictionary<int, Character>();
        }

        public Character AddCharacter(Character character)
        {
            _characters.Add(character.Id, character);

            return character;
        }

        public Dictionary<int, Character> GetCharacters()
        {
            return _characters;
        }
    }
}
