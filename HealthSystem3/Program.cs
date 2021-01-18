using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem3
{
    class Program
    {
         static Player user = new Player();
        public static int debugDamage = 0;
        public static int debugHeal = 0;
        static void Main(string[] args)
        {
            for(int x = 0; x < 1;)
            {
                if (user.alive == true)
                {
                    GameLoop();
                }
                else
                {
                    Console.ReadKey(true);
                    x = 1;
                }

            }

        }
        static void GameLoop()
        {
            debugDamage = debugDamage + 25;
            debugHeal = debugHeal + 5;
            Console.Clear();
            user.DisplayStats();
            Console.ReadKey(true);
            user.TakeDamage(debugDamage);
            Console.ReadKey(true);
            Console.Clear();
            user.DisplayStats();
            user.CheckPlayer();


            Console.Clear();
            user.DisplayStats();
            user.Heal(debugHeal);


            Console.Clear();
            user.DisplayStats();
            Console.ReadKey(true);
            user.Regenerate(debugHeal);
            


        }
    }
}
