using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotics
{
    class Roomba: BaseRobot
    {
        public string up = "up";
        public string down = "down";
        public string left = "left";
        public string right = "right";
        public string choice;
        public void Dance()
        {
            nam();
            Console.WriteLine(name + " bot is at " + battery + " battery remaining");
            Console.WriteLine(name + " bot abides by the law to: " + AIlaws1 + "\n" + AIlaws2 + "\n" + AIlaws3);
            Console.ReadKey();
            movement();
        }
        public void movement()
        {
            Console.WriteLine("select movement: \n" + up + "\n" + down + "\n" + left + "\n" + right + "\n" + "sleep");
            choice = Console.ReadLine();
            while (battery > 0)
            {
                if (choice == up)
                {
                    battery -= 25;
                    Console.WriteLine(name + " has moved up, battery at: " + battery);
                    movement();
                }
                else if (choice == down)
                {
                    battery -= 25;
                    Console.WriteLine(name + " has moved down, battery at: " + battery);
                    movement();
                }
                else if (choice == right)
                {
                    battery -= 25;
                    Console.WriteLine(name + " has moved right, battery at: " + battery);
                    movement();
                }
                else if (choice == left)
                {
                    battery -= 25;
                    Console.WriteLine(name + " has moved left, battery at: " + battery);
                    movement();
                }
                else if (choice == "sleep")
                {
                    sleep();
                }
                else
                {
                    Console.WriteLine("invalid choice");
                    movement();
                }
            }
            Console.WriteLine(name + " roombot is outta battery =( ");
            sleep();
        }
        public void sleep()
        {
            Console.WriteLine("time for sleep mode");
            Recharge();
            Console.WriteLine(name + " bot is at " + battery + " battery remaining");
            Console.ReadKey();
        }
    }
}
