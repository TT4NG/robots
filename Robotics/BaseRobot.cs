using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotics
{
    class BaseRobot
    {
        public string AIlaws1 = "can never harm humans";
        public string AIlaws2 = "must always promote safety of humanity";
        public string AIlaws3 = "can never put other life before humans";
        public string name;
        public int health = 100;
        public int regarmor = 10;
        public int regspeed = 25;
        public int regattack = 30;
        public int battery = 100;
        public void Robotics()
        {
            Console.WriteLine(battery);
        }
        public void Recharge()
        {
            Console.WriteLine(name + " bot is outta juice, time for a recharge");
            battery = 100;
            Console.WriteLine("battery is at " + battery + "%");
        }
        public string nam()
        {
            Console.WriteLine("Please enter your Bots name: ");
            name = Console.ReadLine();
            return name;
        }
    }
}
