using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillAllObjects.Enemies
{
    internal class TreasureChest : IDamageable
    {
        public int Damage { get; set; }
        public int Value { get; set; }

        public TreasureChest()
        {
            Damage = 20;
        }
        public void TakeDamage()
        {
            Console.WriteLine($"Treasure Chest took {Damage} damage");
        }
    }
}
