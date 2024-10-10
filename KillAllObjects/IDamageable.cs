using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillAllObjects
{
    internal interface IDamageable
    {
        public int Damage { get; set; }
        public void TakeDamage();
    }
}
