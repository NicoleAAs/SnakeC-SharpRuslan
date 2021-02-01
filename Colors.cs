using System;

namespace Snake
{
    public class Colors
    {
        public Colors(int score) //Смена цвета в зависимости от очков
        {
            if (score <= 10)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (score >= 11 && score <= 20)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else if (score >= 21 && score <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (score >= 31 && score <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }
    }
}