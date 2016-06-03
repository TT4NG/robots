using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotics
{
    class Rapp: BaseRobot
    {
        public void rapper()
        {
            nam();
            battery -= 50;
            Console.WriteLine(name + " bot is at " + battery + " battery remaining");
            Console.WriteLine(name + " bot abides by the law to: " + AIlaws1 + "\n" + AIlaws2 + "\n" + AIlaws3);
            Console.ReadKey();
        }
        public void broken()
        {
            Console.WriteLine(name + " rapper bot is broken due to breaking the laws of human feelings, something about calling your mom a jive turkey?");
            Console.WriteLine(AIlaws1 + " has been broken");
        }
    }
}
