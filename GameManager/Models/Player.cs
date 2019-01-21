using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameManager.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public bool Active { get; set; }
    }
}
