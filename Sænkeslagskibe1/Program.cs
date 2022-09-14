using System;

namespace Sænkeslagskibe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerOne p1 = new PlayerOne();
            PlayerTwo p2 = new PlayerTwo();

            while (p1.playerlife > 0 || p2.playerlife > 0)
            {
                // Runs the game and ask player for input
                Console.WriteLine("Take your shot");
                Console.WriteLine("Put in x and y codinates from 1-10");
                int p1x = int.Parse(Console.ReadLine());
                int p1y = int.Parse(Console.ReadLine());
                p1.Shooting(p1x, p1y);

                Console.WriteLine("Take your shot");
                Console.WriteLine("Put in x and y codinates from 1-10");
                int p2x = int.Parse(Console.ReadLine());
                int p2y = int.Parse(Console.ReadLine());
                p2.Shooting(p2x, p2y);


            }
           



            Console.ReadKey();
        }
    }
}
