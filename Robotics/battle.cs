using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotics
{
    class battle : BaseRobot
    {
        public int option;
        public void fightStart()
        {
            fightchoice();
        }
        public void fightchoice()
        {

            Console.WriteLine("Select an opponent: \n" + "1 - DeutschBot \n" + "2 - NipponBot");
            int.TryParse(Console.ReadLine(), out option);
            if (option <= 0 || option >= 3)
            {
                Console.WriteLine("invalid choice");
                fightchoice();
            }
            else if (option == 1)
            {
                Console.WriteLine("DeutschBot");
                Deustch();

            }
            else if (option == 2)
            {
                Console.WriteLine("NipponBot");
                Nipp();
            }
        }
        public void Deustch()
        {
            DeutschBot D = new DeutschBot();
            D.declaraton();

        }
        public void Nipp()
        {
            NipponBot nipp = new NipponBot();
            nipp.declaraton();
            
        }
    }
}
