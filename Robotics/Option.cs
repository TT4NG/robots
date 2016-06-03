using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotics
{
    class Option
    {
        public void getOption()
        {
            int choice;
            Console.WriteLine("Welcome to Robotic fun \n lets choose a robot type \n 1 - battlebot \n 2 - rapp bot \n 3 - roomba ");
            Console.WriteLine("please enter a selection: ");
            int.TryParse(Console.ReadLine(), out choice);
            if(choice <= 0 || choice >= 4)
            {
                Console.WriteLine("invalid choice");
                getOption();
            }
            else if (choice == 1)
            {
                Console.WriteLine("Battlebot");
                battle();

            }
            else if (choice == 2)
            {
                Console.WriteLine("Rapp Bot");
                GetRapper();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Roomba");
                GetDancer();
            }
        }
        public void battle()
        {
            battle bat = new battle();
            bat.fightStart();
            return;
        }
        public void GetRapper()
        {
            Rapp rap = new Rapp();
            rap.rapper();
            return;
        }
        public void GetDancer()
        {
            Roomba room = new Roomba();
            room.Dance();
            return;
        }
    }
}
