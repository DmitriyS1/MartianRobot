using MartianRobot.Models;
using System;

namespace MartianRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(5, 6);
            var grid2 = new Grid(2, 4);

            grid.PrintGrid();

            Console.WriteLine("______________________________");

            grid2.PrintGrid();

            Console.ReadKey();
        }
    }
}
