using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class map
    {
        private string[,] fence;
        private int length;
        private int width;
        public map(string[,] fence)
        {
            this.fence = fence;
            this.length = fence.GetLength(0);
            this.width = fence.GetLength(1);
        }
        public void Build()
        {
            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    string pixel = fence[y, x];
                    Console.SetCursorPosition(x, y);
                    if (fence[y, x] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.Write(pixel);
                }
            }
        }
        public string GetPixel(int X, int Y)
        {
            return fence[Y, X];
        }
        public bool open(int x, int y)
        {
            return fence[y, x] == " " || fence[y, x] == "X";
        }
    }
}
