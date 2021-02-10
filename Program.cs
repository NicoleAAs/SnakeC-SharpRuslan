using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(90,25);

            Walls walls = new Walls(80, 25);
            walls.Draw();


            Point p = new Point(4, 5, '*');
           Snake snake = new Snake(p, 4, Direction.RIGHT);
           snake.Draw();
           
           FoodCreator foodCreator = new FoodCreator(80, 25, '#');
           Point food = foodCreator.CreateFood();
           Point spsfood = foodCreator.CreateSpsFood();
           food.Draw();

           Params settings = new Params();
           
           Sounds sound = new Sounds(settings.GetResourcesFolder());
           sound.Play();
           Counter count = new Counter(0);
           count.ScoreWrite();
           Sounds soundEat = new Sounds(settings.GetResourcesFolder());
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
                   count.ScoreUp();
                   count.ScoreWrite();
                   soundEat.PlayEat();
                   int foodscore = count.GetScore();
                   if (foodscore % 10 == 0)
                   {
                       spsfood = foodCreator.CreateSpsFood();
                       spsfood.Draw();
                   }
               }
               if (snake.Eat(spsfood))
               {
                   count.ScoreUpx5();
                   count.ScoreWrite();
                   soundEat.PlaySpsEat();
               }
               else
               {
                   snake.Move();
               }
               int score = count.GetScore();
               Speed speed= new Speed(score); //изменение скорости при наборе определённого количества очков
               
               if (Console.KeyAvailable)
               {
                   ConsoleKeyInfo key = Console.ReadKey();
                   snake.MandlKey(key.Key);
               }
           }
           int score1 = count.GetScore();
           WriteGameOver gameover = new WriteGameOver();
           Thread.Sleep(1000); // Задержка на появление Игра окончена
           Leader_Board name = new Leader_Board(score1, settings.GetResourcesFolder()); // Запись имени игрока + счёта
        }
    }
}