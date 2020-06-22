using MartianRobot.Interfaces;
using System;

namespace MartianRobot.Models
{
    public class Grid : IGridPrinter
    {
        private readonly Cell[,] Cells;
        private readonly int Height;
        private readonly int Width;

        public Grid(int height, int width)
        {
            Height = height + 1;
            Width = width + 1;
            Cells = new Cell[Height, Width];
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
            for(int i = Height - 1; i >= 0; i--)
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
