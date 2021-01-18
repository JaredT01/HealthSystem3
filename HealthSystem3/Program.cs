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
                    Console.WriteLine("Do you wish to run this again? Y/N");
                    string answer = Console.ReadLine();
                    if(answer == "y")
                    {
                        user.Reset();
                    } else if (answer == "Y")
                    {
                        user.Reset();

                    }
                    else if (answer == "n")
                    {
                        x = 1;
                    }
                    else if (answer == "N")
                    {
                        x = 1;
                    }
                    else
                    {
                        Console.Clear();
                    }
                    
                }

            }

        }
        static void GameLoop()
        {
            debugDamage = debugDamage + 25;
            debugHeal = debugHeal + 5;
            Console.Clear();
            user.ShowStats();
            Console.ReadKey(true);
            user.TakeDamage(debugDamage);
            Console.ReadKey(true);
            Console.Clear();
            user.ShowStats();
            user.CheckPlayer();
            if(user.alive == true) {
                Console.Clear();
                user.ShowStats();
                user.Heal(debugHeal);


                Console.Clear();
                user.ShowStats();
                user.Regenerate(debugHeal);
            }

            
           
            


        }
    }
}
