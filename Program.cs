using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pl = new Point();
            pl.x = 1;
            pl.y = 3;
            pl.sym = '*';
            pl.Draw();
            
            Point pl2=new Point();
            pl2.x = 4;
            pl2.y = 5;
            pl2.sym = '#';
            pl2.Draw();
            
            Console.ReadLine();
        }
        
    }
}