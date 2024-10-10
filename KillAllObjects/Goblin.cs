using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillAllObjects
{
    internal class Goblin : IDamageable
    {
        public int Damage { get; set; }
        public int HP { get; set; }

        public Goblin()
        {
            Damage = 100;
        }
        public void TakeDamage()
        {
            Console.WriteLine($"Goblin took {Damage} damage");
        }
    }
}
