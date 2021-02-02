using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0; // Обьявления переменной счёт и присваивание к ней 0
            Console.SetWindowSize(90,25);

            Walls walls = new Walls(80, 25);
            walls.Draw();


            Point p = new Point(4, 5, '*');
           Snake snake = new Snake(p, 4, Direction.RIGHT);
           snake.Draw();
           
           FoodCreator foodCreator = new FoodCreator(80, 25, '#');
           Point food = foodCreator.CreateFood();
           food.Draw();

           
           while(true)
           {
               if (walls.IsHit(snake) || snake.IsHitTail())
               {
                   break;
               }
               if (snake.Eat( food ))
               {
                   food = foodCreator.CreateFood();
                   food.Draw();
                   score++; // Евеличиваем счёт на 1 если еда съедена
                   Counter(score);// Передаём увеличеный счёт в функцию вывода на экран
               }
               else
               {
                   snake.Move();
               }
               Speed speed= new Speed(score); //изменение скорости при наборе определённого количества очков
               if (Console.KeyAvailable)
               {
                   ConsoleKeyInfo key = Console.ReadKey();
                   snake.MandlKey(key.Key);
               }
           }
           WriteGameOver();
           Thread.Sleep(1000); // Задержка на появление Игра окончена
           Leader_Board name = new Leader_Board(score); // Запись имени игрока + счёта
        }

        static void Counter(int score) //Функция вывода на экран счёта
        {
            int xOffset = 80;
            int yOffset = 22;
            Colors colors = new Colors(score); // смена цвета в зависимости он набранных очков (так же меняеться скорость)
            Console.SetCursorPosition( xOffset, yOffset++ );
            WriteInt(score,xOffset,yOffset++);
        }
        static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition( xOffset, yOffset++ );
            WriteText( "============================", xOffset, yOffset++ );
            WriteText( "И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++ );
            WriteText( "============================", xOffset, yOffset++ );
        }

        static void WriteText( String text, int xOffset, int yOffset )
        {
            Console.SetCursorPosition( xOffset, yOffset );
            Console.WriteLine( text );
        }
        static void WriteInt( int text, int xOffset, int yOffset )
        {
            Console.SetCursorPosition( xOffset, yOffset );
            Console.WriteLine( text );
        }
        
    }
}