using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class character
    {
        private int X;
        private int Y;
        private char characterIcon;
        private ConsoleColor characterColor;
        public character (int startingX, int startingY,char characterIcon ,string colorLeter)
        {
            this.X = startingX;
            this.Y = startingY;
            this.characterIcon = characterIcon;
            this.characterColor = ConsoleColor.Red;
            if (colorLeter.ToUpper() == "B")
            {
                this.characterColor = ConsoleColor.Blue;
            }
            if (colorLeter.ToUpper() == "R")
            {
                this.characterColor = ConsoleColor.Red;
            }
            if (colorLeter.ToUpper() == "G")
            {
                this.characterColor = ConsoleColor.Green;
            }
            if (colorLeter.ToUpper() == "Y")
            {
                this.characterColor = ConsoleColor.DarkYellow;
            }
            if (colorLeter.ToUpper() == "M")
            {
                this.characterColor = ConsoleColor.Magenta;
            }

        }
        public void setIcon(char icon)
        {
            this.characterIcon = icon;
        }
        public void setColor(ConsoleColor color)
        {
            this.characterColor = color;
        }
        public int GetX()
        {
            return X;
        }
        public void SetX(int X)
        {
            this.X = X;
        }
        public int GetY()
        {
            return Y;
        }
        public void SetY(int Y)
        {
            this.Y = Y;
        }
        public void goUp()
        {
            this.Y--;
        }
        public void goDown()
        {
            this.Y++;
        }
        public void goRight()
        {
            this.X++;
        }
        public void goLeft()
        {
            this.X--;
        }


        public void DrawCharacter()
        {
            Console.ForegroundColor = characterColor;
            Console.SetCursorPosition(X, Y);
            Console.Write(characterIcon);            
        }
        public void unDrawCharacter()
        {
            Console.ForegroundColor = characterColor;
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }


    }
}
