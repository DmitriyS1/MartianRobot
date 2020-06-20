using System;
using System.Runtime.CompilerServices;

namespace MartianRobot.Models
{
    public class Grid
    {
        private Cell[,] Cells;

        private int Height, Width;

        public Grid(int height, int width)
        {
            Height = height;
            Width = width;
            Cells = new Cell[height, width];
            CreateGrid();
        }

        private void CreateGrid()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Cells[i, j] = new Cell { Y = i, X = j };
                }
            }
        }

        public void PrintGrid()
        {
            for(int i = 0; i < Height; i++)
            {
                for(int j = 0; j < Width; j++)
                {
                    Console.Write(Cells[i, j]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
