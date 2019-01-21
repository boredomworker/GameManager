using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameManager.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public int playerId { get; set; }

        public string umaRecipe { get; set; }

        public int inventoryId { get; set; }
        public byte[] characterUMASlots { get; set; }
        public byte[] characterEquipmentSlots { get; set; }
    }
}
