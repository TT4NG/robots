using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotics
{
    class DeutschBot : battle
    {
        
        protected string German = "DeustchBot";
        public void declaraton()
        {
            nam();
            Console.WriteLine(name + " bot is ready to fight for glory!");
            Console.WriteLine(German + " Enters the ring");
            Console.WriteLine("Get Ready!");
            Console.ReadKey();
            Console.WriteLine("FIGHT!!");
            Console.ReadKey();
            fight();
        }
        public void fight()
        {
        int ghealth = 100;
        int armor = 50;
        int speed = 15;
        int attack = 30;
            int normal = 15;
        Random r = new Random();
            while (ghealth > 0 && health > 0 )
            {
                int Gturn = 1 * speed;
                int Pturn = 1 * regspeed;
                if(Gturn >= Pturn)
                {

                    int rInt = r.Next(1, 2);
                    if (rInt == 1)
                    {
                        Console.WriteLine(German + " attacks!!");
                        health -= (attack / regarmor);
                        Console.WriteLine(name + " bot is at " + health);
                    }
                    if (rInt == 2)
                    {
                        Console.WriteLine(German + " Defends!!");
                        ghealth += 10;
                        Console.WriteLine(German + " is at " + ghealth);
                    }
                    speed -= normal;
                    regspeed += normal;

                }
                else
                {
                    Console.WriteLine("Choose your action: \n 1- attack \n 2 - defend \n 3 - pickup weapon \n 4- rend speed \n 5 - rend armor");
                    int.TryParse(Console.ReadLine(), out option);
                    if (option >= 0 || option <= 6)
                    {
                        if (option == 1)
                        {
                            Console.WriteLine("attack");
                            if (armor > 0)
                            {
                                ghealth -= (regattack / armor);
                                Console.WriteLine(German + " health is at " + ghealth);
                            }
                            else
                            {
                                ghealth -= regattack;
                                Console.WriteLine(German + " health is at " + ghealth);
                            }
                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("defend");
                            health += 10;
                            Console.WriteLine("Current health is: " + health);
                        }
                        else if (option == 3)
                        {
                            Console.WriteLine("you reach for nearby weapons in the arena and get");
                            int rInt = r.Next(1, 4);
                            if (rInt == 1)
                            {
                                Console.WriteLine("picked a hammer");
                                attack += 10;
                            }
                            else if (rInt == 2)
                            {
                                Console.WriteLine("picked a saw");
                                attack += 20;
                            }
                            else if (rInt == 3)
                            {
                                Console.WriteLine("picked a lazergun");
                                attack += 40;
                            }

                        }
                        else if (option == 4)
                        {
                            Console.WriteLine("Rending enemy speed");
                            speed -= 10;
                        }
                        else if (option == 5)
                        {
                            Console.WriteLine("Rending Armor");
                            armor -= 15;
                        }
                        regspeed -= normal;
                        speed += normal;

                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                    }
                    
                }  
            }
            Console.WriteLine("The Battle is Over \n The winner is ");
            if (ghealth <= 0)
            {
                Console.WriteLine(name + " Bot has won");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(German + " has WON!");
                Console.ReadKey();
            }
        }
    }
}
