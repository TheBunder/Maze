using chocolate_line;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maze
{
    class game
    {
        private map myMap;
        private map myHardMap;
        private character player;
        public void start()
        {
            Console.SetWindowSize(124, 25);

            
            string[,] HardTheMaze =
            {
                { "█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█"},
                { "█"," "," "," "," "," "," "," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","█"," "," "," "," "," ","█"," "," "," "," "," ","█"," "," "," "," "," ","█"},
                { "█","█","█","█"," "," ","█","█","█","█"," "," ","█"," "," ","█"," "," ","█","█","█","█"," "," ","█"," "," ","█","█","█","█","█","█","█"," "," ","█"," "," ","█","█","█","█","█","█","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"},
                { "█"," "," ","█"," "," ","█"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","█"," "," ","█"," "," "," "," "," "," "," "," ","█"," "," "," "," "," ","█"," "," "," "," "," ","█"," "," ","█"},
                { "█"," "," ","█"," "," ","█","█","█","█"," "," ","█"," "," ","█","█","█","█","█","█","█","█","█","█"," "," ","█","█","█","█","█","█","█","█","█","█","█","█","█"," "," ","█"," "," ","█","█","█","█","█","█","█"," "," ","█"," "," ","█","█","█","█"},
                { "█"," "," "," "," "," "," "," "," "," "," "," ","█"," "," "," "," "," ","█"," "," "," "," "," ","█"," "," ","█"," "," "," "," "," "," "," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," "," "," "," ","█"," "," "," "," "," ","█"},
                { "█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█","█","█","█","█","█","█"," "," ","█"," "," ","█"," "," ","█","█","█","█","█","█","█"," "," ","█","█","█","█"," "," ","█","█","█","█","█","█","█"," "," ","█","█","█","█"," "," ","█"},
                { "█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," "," "," "," ","█"," "," ","█"," "," "," "," "," "," "," "," ","█"," "," ","█"," "," "," "," "," "," "," "," "," "," "," ","█"," "," "," "," "," ","█"," "," ","█"},
                { "█"," "," ","█","█","█","█","█","█","█","█","█","█"," "," ","█"," "," ","█","█","█","█","█","█","█"," "," ","█"," "," ","█"," "," ","█","█","█","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█","█","█","█","█","█","█","█","█","█"," "," ","█"},
                { "█"," "," "," "," "," "," "," "," ","█"," "," "," "," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," "," "," "," ","█"," "," "," "," "," ","█"," "," "," "," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," "," "," "," ","█"," "," ","█"},
                { "█"," "," ","█","█","█","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█","█","█","█"," "," ","█","█","█","█","█","█","█"," "," ","█"," "," ","█","█","█","█"," "," ","█","█","█","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"},
                { "█"," "," "," "," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," "," "," "," "," "," "," ","█"," "," "," "," "," ","█"," "," "," "," "," ","█"," "," "," "," "," ","█"," "," "," "," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"},
                { "█","█","█","█","█","█","█"," "," ","█"," "," ","█","█","█","█","█","█","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█","█","█","█"," "," ","█","█","█","█"," "," ","█","█","█","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"},
                { "█"," "," "," "," "," "," "," "," ","█"," "," "," "," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," "," "," "," ","█"," "," "," "," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," ","█"},
                { "█"," "," ","█","█","█","█"," "," ","█"," "," ","█","█","█","█"," "," ","█"," "," ","█","█","█","█"," "," ","█","█","█","█","█","█","█","█","█","█","█","█","█"," "," ","█"," "," ","█","█","█","█"," "," ","█","█","█","█"," "," ","█"," "," ","█"},
                { "█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," ","█"," "," "," "," "," "," "," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," ","█"," "," ","█"," "," "," "," "," ","█"," "," ","█"},
                { "█"," "," ","█"," "," ","█"," "," ","█","█","█","█"," "," ","█","█","█","█","█","█","█"," "," ","█","█","█","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█","█","█","█"," "," ","█"," "," ","█","█","█","█","█","█","█"," "," ","█"},
                { "█"," "," "," "," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," "," "," "," ","█"," "," "," "," "," ","█"," "," ","█"," "," ","█"," "," "," "," "," ","█"," "," ","█"," "," "," "," "," ","█"," "," "," "," "," ","█"," "," ","█"," "," ","█"},
                { "█"," "," ","█","█","█","█","█","█","█"," "," ","█"," "," ","█","█","█","█","█","█","█","█","█","█","█","█","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█"," "," ","█","█","█","█"," "," ","█","█","█","█"," "," ","█"," "," ","█"},
                { "█"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","█"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","█"," "," "," "," "," ","█"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","█","X","X","█"},
                { "█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█","█"},
            };
            
            string[,] theMaze =
            {
                { "╔","═","═","═","═","═","═","═","╦","═","═","═","╦","═","═","═","╗"},
                { "║"," "," "," "," "," "," "," ","║"," "," "," ","║"," "," "," ","║"},
                { "║"," ","║"," ","║"," ","║"," ","║"," ","║"," "," "," ","╔","═","╣"},
                { "╠","═","╝"," ","║"," ","║"," ","║"," ","║"," "," "," ","║"," ","║"},
                { "║"," "," "," ","║"," ","╚","═","╩","═","╝"," ","╔","═","╝"," ","║"},
                { "╠","═","╗"," ","║"," "," "," "," "," "," "," ","║"," "," "," ","║"},
                { "║"," ","║"," ","╚","═","╗"," ","║"," ","║"," ","║"," ","═","═","╣"},
                { "║"," "," "," "," "," ","║"," ","║"," ","║"," "," "," "," "," ","║"},
                { "╠","═","═"," ","╔","═","╩","═","╝"," ","║"," ","╔","═","═","═","╣"},
                { "║"," "," "," ","║"," "," "," "," "," ","║"," ","║"," "," "," ","║"},
                { "╠","═","═","═","╣"," ","║"," ","╔","═","╩","═","╣"," ","║"," ","║"},
                { "║"," "," "," ","║"," ","╚","═","╝"," "," "," ","║"," ","╚","═","║"},
                { "║"," ","║"," "," "," "," "," "," "," ","║"," "," "," "," ","X","║"},
                { "║"," ","╚","═","╦","═","═"," ","╔","═","╩","═","═","═"," ","═","╣"},
                { "║"," "," "," ","║"," "," "," ","║"," "," "," "," "," "," "," ","║"},
                { "╚","═","═","═","╩","═","═","═","╩","═","═","═","═","═","═","═","╝"},
            };
            

            string startingTital_1 = "███╗▒▒▒███╗▒█████╗▒███████╗███████╗  ▒██████╗▒▒█████╗▒███╗▒▒▒███╗███████╗";
            string startingTital_2 = "████╗▒████║██╔══██╗╚════██║██═════╝  ██╔════╝▒██╔══██╗████╗▒████║██═════╝";
            string startingTital_3 = "██╔████╔██║███████║▒▒███╔═╝█████╗▒▒  ██║▒▒██╗▒███████║██╔████╔██║█████╗▒▒";
            string startingTital_4 = "██║╚██╔╝██║██╔══██║██╔══╝▒▒██╔══╝▒▒  ██║▒▒╚██╗██╔══██║██║╚██╔╝██║██╔══╝▒▒";
            string startingTital_5 = "██║▒╚═╝▒██║██║▒▒██║███████╗███████╗  ╚██████╔╝██║▒▒██║██║▒╚═╝▒██║███████╗";
            string startingTital_6 = "╚═╝▒▒▒▒▒╚═╝╚═╝▒▒╚═╝╚══════╝╚══════╝  ▒╚═════╝▒╚═╝▒▒╚═╝╚═╝▒▒▒▒▒╚═╝╚══════╝";
            string WiningText = @" .----------------.  .----------------.  .----------------.     .----------------.  .----------------.  .-----------------.
| .--------------. || .--------------. || .--------------. |   | .--------------. || .--------------. || .--------------. |
| |  ____  ____  | || |     ____     | || | _____  _____ | |   | | _____  _____ | || |     ____     | || | ____  _____  | |
| | |_  _||_  _| | || |   .'    `.   | || ||_   _||_   _|| |   | ||_   _||_   _|| || |   .'    `.   | || ||_   \|_   _| | |
| |   \ \  / /   | || |  /  .--.  \  | || |  | |    | |  | |   | |  | | /\ | |  | || |  /  .--.  \  | || |  |   \ | |   | |
| |    \ \/ /    | || |  | |    | |  | || |  | '    ' |  | |   | |  | |/  \| |  | || |  | |    | |  | || |  | |\ \| |   | |
| |    _|  |_    | || |  \  `--'  /  | || |   \ `--' /   | |   | |  |   /\   |  | || |  \  `--'  /  | || | _| |_\   |_  | |
| |   |______|   | || |   `.____.'   | || |    `.__.'    | |   | |  |__/  \__|  | || |   `.____.'   | || ||_____|\____| | |
| |              | || |              | || |              | |   | |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' |   | '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'     '----------------'  '----------------'  '----------------' ";
           

            // ALT 219 --> █
            // ALT 186 --> ║
            // ALT 187 --> ╗
            // ALT 188 --> ╝
            // ALT 200 --> ╚
            // ALT 201 --> ╔
            // ALT 205 --> ═
            // ALT 204 --> ╠
            // ALT 202 --> ╩
            // ALT 203 --> ╦
            // ALT 185 --> ╣
            // ALT 177 --> ▒

            myMap = new map(theMaze);
            myHardMap = new map(HardTheMaze);
            repeater(WiningText, startingTital_1,   startingTital_2,   startingTital_3,   startingTital_4,   startingTital_5,   startingTital_6);
            
        }
        
        public void OpeningScreen()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("Welcome to my maze game");
            Console.SetCursorPosition(44, 11);
            Console.WriteLine("You move by using the arrow buttons");
            Console.SetCursorPosition(48, 12);
            Console.Write("Your goal is to reach the: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(74, 12);
            Console.WriteLine("X");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(46, 13);
            Console.WriteLine("But first, choose your character");
            Console.SetCursorPosition(57, 14);
            Console.WriteLine("good luck!");
            Console.SetCursorPosition(49, 18);
            Console.ResetColor();
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            player = new character(1, 2, setIcon(), setColor());
        }
        public void MidScreen()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@" ____    ___   __    __      ______  __ __    ___      ____     ___   ____  _         
|    \  /   \ |  |__|  |    |      ||  |  |  /  _]    |    \   /  _] /    || |        
|  _  ||     ||  |  |  |    |      ||  |  | /  [_     |  D  ) /  [_ |  o  || |        
|  |  ||  O  ||  |  |  |    |_|  |_||  _  ||    _]    |    / |    _]|     || |___     
|  |  ||     ||  `  '  |      |  |  |  |  ||   [_     |    \ |   [_ |  _  ||     |    
|  |  ||     | \      /       |  |  |  |  ||     |    |  .  \|     ||  |  ||     |    
|__|__| \___/   \_/\_/        |__|  |__|__||_____|    |__|\_||_____||__|__||_____|    
                                                                                      
    __  __ __   ____  _      _        ___  ____    ____    ___      __      __        
   /  ]|  |  | /    || |    | |      /  _]|    \  /    |  /  _]    |  |    |  |       
  /  / |  |  ||  o  || |    | |     /  [_ |  _  ||   __| /  [_     |  |    |  |       
 /  /  |  _  ||     || |___ | |___ |    _]|  |  ||  |  ||    _]    |__|    |__|       
/   \_ |  |  ||  _  ||     ||     ||   [_ |  |  ||  |_ ||   [_      __      __        
\     ||  |  ||  |  ||     ||     ||     ||  |  ||     ||     |    |  |    |  |       
 \____||__|__||__|__||_____||_____||_____||__|__||___,_||_____|    |__|    |__|       
 ");
        }

        private void frames(map maze)
        {
            //Console.Clear();
            Console.SetCursorPosition(0, 0);
            maze.Build();
            Console.ResetColor();
            player.DrawCharacter();

        }
        
        public void movement(map maze)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;
            if (key ==ConsoleKey.UpArrow)
            {
                if (maze.open(player.GetX(),player.GetY()-1))
                {
                    player.goUp();
                }               
            }
            if (key == ConsoleKey.DownArrow)
            {
                if (maze.open(player.GetX(), player.GetY() + 1))
                {
                    player.goDown();
                }                
            }
            if (key == ConsoleKey.RightArrow)
            {
                if (maze.open(player.GetX() + 1, player.GetY()))
                {
                    player.goRight();
                }
            }
            if (key == ConsoleKey.LeftArrow)
            {
                if (maze.open(player.GetX() - 1, player.GetY()))
                {
                    player.goLeft();
                }
            }
        }
        public char setIcon()
        {
            TRect frame = new TRect(37, 2, 50, 18, ConsoleColor.DarkYellow);
            frame.Draw();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(40, 3);
            Console.Write("which character");
            Console.SetCursorPosition(40, 4);
            Console.Write("would you like ");
            Console.SetCursorPosition(40, 5);
            Console.Write("to be");
            Console.ResetColor();
            Console.SetCursorPosition(65, 3);
            Console.Write("(1)");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(68, 3);
            Console.WriteLine("☻");
            Console.ResetColor();
            Console.SetCursorPosition(65, 4);
            Console.Write("(2)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(68, 4);
            Console.WriteLine("♥");
            Console.ResetColor();
            Console.SetCursorPosition(65, 5);
            Console.Write("(3)");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(68, 5);
            Console.WriteLine("♠");
            Console.ResetColor();
            Console.SetCursorPosition(70, 3);
            Console.Write("(4)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(73, 3);
            Console.WriteLine("♦");
            Console.ResetColor();
            Console.SetCursorPosition(70, 4);
            Console.Write("(5)");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(73, 4);
            Console.WriteLine("♣");
            Console.ResetColor();
            Console.SetCursorPosition(60, 7);
            Console.ForegroundColor = ConsoleColor.Yellow;
            int iconNum = int.Parse(Console.ReadLine());
            char icon;
            if (iconNum == 1)
            {
                icon = '☻';
            }
            else if (iconNum == 2)
            {
                icon = '♥';
            }
            else if (iconNum == 3)
            {
                icon = '♠';
            }
            else if (iconNum == 4)
            {
                icon = '♦';
            }
            else
            {
                icon = '♣';
            }
            return icon;
        }
        public string setColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(40, 9);
            Console.Write("what color you");
            Console.SetCursorPosition(40, 10);
            Console.Write("want the character");
            Console.SetCursorPosition(40, 11);
            Console.Write("to be");
            Console.SetCursorPosition(64, 9);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("(M) Magenta");
            Console.SetCursorPosition(64, 10);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("(Y) Yellow");
            Console.SetCursorPosition(64, 11);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("(G) Green");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(76, 9);
            Console.Write("(B) Blue");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(76, 10);
            Console.Write("(R) Red");
            Console.ResetColor();


            Console.SetCursorPosition(60, 13);
            Console.ForegroundColor = ConsoleColor.Yellow;
            string colorLetter = Console.ReadLine();
            return colorLetter;
        }
        public void ChosetheCharacter()
        {
            char icon='0';
            ConsoleColor color= ConsoleColor.Cyan;
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;
            int line = 0;
            int wichIcon = 0;
            int wichColor = 0;
            if (key == ConsoleKey.UpArrow || key == ConsoleKey.DownArrow)
            {
                if (key == ConsoleKey.UpArrow)
                {
                    line++;
                }
                if (key == ConsoleKey.DownArrow)
                {
                    line--;
                }
            }
            else
            {
                if (Math.Abs(line) % 2 == 0)
                {
                    if (key == ConsoleKey.RightArrow)
                    {
                        wichIcon++;
                    }
                    if (key == ConsoleKey.LeftArrow)
                    {
                        wichIcon--;
                    }
                }
                else
                {
                    if (key == ConsoleKey.RightArrow)
                    {
                        wichColor++;
                    }
                    if (key == ConsoleKey.LeftArrow)
                    {
                        wichColor--;
                    }
                }
            }

            Console.SetCursorPosition(56, 8);
            Console.Write('<');

            Console.SetCursorPosition(68, 8);
            Console.Write('>');
            if (Math.Abs(wichColor) % 5 == 0)
            {
                color = ConsoleColor.Magenta;
                Console.ForegroundColor = color;
                Console.SetCursorPosition(58, 8);
                Console.Write("MAGENTA");
                Console.ResetColor();
            }
            if (Math.Abs(wichColor) % 5 == 1)
            {
                color = ConsoleColor.DarkYellow;
                Console.ForegroundColor = color;
                Console.SetCursorPosition(59, 8);
                Console.Write("YELLOW");
                Console.ResetColor();
            }
            if (Math.Abs(wichIcon) % 5 == 2)
            {
                color = ConsoleColor.Green;
                Console.ForegroundColor = color;
                Console.SetCursorPosition(60, 8);
                Console.Write("GREEN");
                Console.ResetColor();
            }
            if (Math.Abs(wichIcon) % 5 == 3)
            {
                color = ConsoleColor.Blue;
                Console.ForegroundColor = color;
                Console.SetCursorPosition(61, 8);
                Console.Write("BLUE");
                Console.ResetColor();
            }
            if (Math.Abs(wichIcon) % 5 == 3)
            {
                color = ConsoleColor.Red;
                Console.ForegroundColor = color;
                Console.SetCursorPosition(62, 8);
                Console.Write("RED");
                Console.ResetColor();
            }


            Console.SetCursorPosition(61, 4);
            Console.Write('<');

            Console.SetCursorPosition(63, 4);
            Console.Write('>');
            if (Math.Abs(wichIcon) % 5 == 0)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(62, 4);
                Console.Write('☻');
                icon = '☻';
                    Console.ResetColor();
            }
            if (Math.Abs(wichIcon) % 5 == 1)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(62, 4);
                Console.Write('♥');
                icon = '♥';
                    Console.ResetColor();
            }
            if (Math.Abs(wichIcon) % 5 == 2)
                {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(62, 4);
                Console.Write('♦');
                icon = '♦';
                Console.ResetColor();
            }
            if (Math.Abs(wichIcon) % 5 == 3)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(62, 4);
                Console.Write('♣');
                icon = '♣';
                Console.ResetColor();
            }
            if (Math.Abs(wichIcon) % 5 == 4)
            {
                Console.ForegroundColor = color;
                Console.SetCursorPosition(62, 4);
                Console.Write('♠');
                icon = '♠';
                Console.ResetColor();
            }


            
            player.setColor(color);
            player.setIcon(icon);
        }
        private void repeater(string WiningText, string startingTital_1, string startingTital_2, string startingTital_3, string startingTital_4, string startingTital_5, string startingTital_6)
        {

            //opaningTital.Build();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(25, 1);
            Console.WriteLine(startingTital_1);
            Console.SetCursorPosition(25, 2);
            Console.WriteLine(startingTital_2);
            Console.SetCursorPosition(25, 3);
            Console.WriteLine(startingTital_3);
            Console.SetCursorPosition(25, 4);
            Console.WriteLine(startingTital_4);
            Console.SetCursorPosition(25, 5);
            Console.WriteLine(startingTital_5);
            Console.SetCursorPosition(25, 6);
            Console.WriteLine(startingTital_6);
            
            OpeningScreen();
            Console.Clear();
            /*
            ConsoleKey key = ConsoleKey.LeftArrow;
            while (key != ConsoleKey.Enter)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                key = keyInfo.Key;
                ChosetheCharacter();
            }
            */
            Console.Clear();
            while (myMap.GetPixel(player.GetX(), player.GetY()) != "X")
            {
                frames(myMap);                
                movement(myMap);
            }
            Console.Clear();
            MidScreen();
            Console.ReadKey();
            Console.Clear();
            player.SetX(4);
            player.SetY(1);
            while (myHardMap.GetPixel(player.GetX(), player.GetY()) != "X")
            {
                frames(myHardMap);
                movement(myHardMap);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.SetBufferSize(124,25);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(WiningText);
            Console.ResetColor();
            Console.ReadKey();
            Console.SetCursorPosition(0, 20);
        }

    }
    

}
