using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillAllObjects
{
    internal class Building : IDamageable
    {
        public int Damage { get; set; }
        public int Height { get; set; }

        public Building()
        {
            Damage = 50;
        }
        public void TakeDamage()
        {
            Console.WriteLine($"Building took {Damage} damage");
        }


    }
}
