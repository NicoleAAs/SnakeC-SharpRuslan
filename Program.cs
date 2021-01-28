using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           //Console.SetBufferSize(80,25);

           HLine upLine = new HLine(0,78,0,'-');
           HLine downLine= new HLine(0,78,24,'-');
           VLine leftLine = new VLine(0,24,0,'|');
           VLine rightLine = new VLine(0,24,78,'|');
           upLine.Draw();
           downLine.Draw();
           leftLine.Draw();
           rightLine.Draw();

           Point p = new Point(4, 5, '*');
           Snake snake = new Snake(p, 4, Direction.RIGHT);
           snake.Draw();
           
           while(true)
           {
               if (Console.KeyAvailable)
               {
                   ConsoleKeyInfo key = Console.ReadKey();
                   snake.MandlKey(key.Key);
               }

               Thread.Sleep(100);
               snake.Move();
           }
        }
        
    }
}