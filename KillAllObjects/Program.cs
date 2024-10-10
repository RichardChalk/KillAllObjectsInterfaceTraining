using KillAllObjects.Enemies;

namespace KillAllObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var building = new Building();
            var goblin = new Goblin();
            var treasureChest = new TreasureChest();

            // DRY????? Nope!
            // Antalet IF satser måste öka för varje ny enemy!
            // Antalet ökar linjärt!
            // INTE Scalable!
            if (building is Building)
            {
                building.TakeDamage();
            }

            if (goblin is Goblin)
            {
                goblin.TakeDamage();
            }

            if (treasureChest is TreasureChest)
            {
                treasureChest.TakeDamage();
            }

            // INTERFACE  INTERFACE  INTERFACE  INTERFACE  INTERFACE  INTERFACE  
            // Med en Interface spelar det ingen roll vad det är
            // för typ så länge den implementerar IDamageable!
            Console.WriteLine("\nINTERFACE - INTERFACE - INTERFACE");

            IDamageable randomEnemy = new Building(); // Kan vara vilken typ som helst
            if (randomEnemy is IDamageable)
            {
                // Polymorphism baby!
                randomEnemy.TakeDamage();
            }

            // Jag kan även skapa en samling av dessa Interface typer!
            // Detta är ommöjligt annars!
            // Jag kan inte skapa en lista av Building, Goblin & Treasure Chest

            Console.WriteLine("\nFOREACH - FOREACH - FOREACH - FOREACH");
            var myEnemies = new List<IDamageable>
            {
                new Goblin(),
                new Building(),
                new TreasureChest()
            };

            foreach (var enemy in myEnemies) { enemy.TakeDamage(); }
        }
    }
}
