using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem3
{
    class Player
    {
        private int health;
        private int shield;
        private int lives;
        public string name;
        public bool alive = true;

        public Player()
        {
            health = 100;
            name = "You";
            shield = 100;
            lives = 3;
            alive = true;

        }
        public void TakeDamage(int damage)
        {
            int OriginalDamage = damage;
            if (damage > 0)
            {
                if (shield > 0)
                {
                    if (damage > shield)
                    {
                        if (damage > shield + health)
                        {
                            OriginalDamage = shield + health;
                        }
                        damage = damage - shield;
                        shield = 0;
                        health = health - damage;
                    }
                    else
                    {
                        shield = shield - damage;
                    }
                       
                }
                else
                {
                    shield = 0;
                    if (damage > health)
                    {
                        health = 0;
                        OriginalDamage = health;
                    }
                    else
                    {
                        health = health - damage;
                    }
                
                }
                Console.WriteLine("--------------------------------");
                Console.WriteLine(name + " took "+OriginalDamage+" points of damage!");
                if(health < 0)
                {
                    health = 0;
                }

            }
            else
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Damage is not a positive integer and therefore does not work.");
            }

        }
        public void ShowStats()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
        }
        public void CheckPlayer()
        {
            if(health <= 0)
            {
                if (lives > 0)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine(name + " died. However, "+ name+" had another life. Lucky.");
                    lives = lives - 1;
                    health = 100;
                    shield = 100;
                    Console.ReadKey(true);
                    Program.debugHeal = 5;
                    Program.debugDamage = 25;
                }
                else
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine(name + " died... permenantly.");
                    alive = false;
                    Console.ReadKey(true);
                }
            }

        }
        public void Heal(int heal)
        {
            if (health + heal > 100)
            {

            }
            else
            {
                health = health + heal;
                Console.WriteLine("--------------------------------");
                Console.WriteLine(name + " healed for " + heal + " health.");
                Console.ReadKey(true);
            }
        }
        public void Regenerate(int regen)
        {
            if (shield + regen > 100)
            {

            }
            else
            {shield = shield + regen;
                Console.WriteLine("--------------------------------");
                Console.WriteLine(name + " regenerated for " + regen + " shield points.");
                Console.ReadKey(true);
            }
        }
        public void Reset()
        {
            health = 100;
            name = "You";
            shield = 100;
            lives = 3;
            alive = true;
            Program.debugDamage = 0;
            Program.debugHeal = 0;
        }

    }
}
