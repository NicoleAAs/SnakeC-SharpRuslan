using System;
using System.Threading;

namespace Snake
{
    public class Game
    {
        public Game()
        {
            Console.SetWindowSize(90,25);
            Walls walls = new Walls(80, 25);
            walls.Draw();
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80, 25, '#','@','$'); 
            Point food = foodCreator.CreateFood(); 
            Point spsfood = foodCreator.CreateSpsFood();
            Point badfood = foodCreator.CreateBadFood();
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
                    count.ScoreUp(); //функция повышает вчёт очков на 1
                    count.ScoreWrite(); // Выводит на экран счёт
                    soundEat.PlayEat(); // Воспроизводит звук поедания еды
                    if (count.GetScore() % 10 == 0) //Если остаток счёта развен 0 ( то есть каждые 10 очков будет появляться спец. еда) + //получает счёт в данный момент времени и заносит в переменную
                    { 
                        spsfood = foodCreator.CreateSpsFood(); //создаём спец еду
                        spsfood.Draw(); //отрисовываем спец еду
                        badfood = foodCreator.CreateBadFood();
                        badfood.Draw();
                    } 
                } 
                if (snake.Eat(spsfood)) //Если спец. еду съедают то ...
                { 
                    count.ScoreUpx3(); //увеличиваем счёт на 3 единицы
                    count.ScoreWrite(); //выводим на экран увеличеный счёт
                    soundEat.PlaySpsEat(); //воспроизводим звук съедания спец. еды
                }
                if (snake.BadEat(badfood))
                {
                    count.ScoreDown();
                    count.ScoreWrite();
                    soundEat.PlayBadEat();
                }
                else 
                { 
                    snake.Move(); 
                }
                new Speed(count.GetScore()); //изменение скорости при наборе определённого количества очков
                
                if (Console.KeyAvailable) 
                { 
                    ConsoleKeyInfo key = Console.ReadKey(); 
                    snake.MandlKey(key.Key); 
                } 
            }
            new WriteGameOver();
            sound.Stop();
            Thread.Sleep(1500); // Задержка на появление Игра окончена
            new Leader_Board(count.GetScore(), settings.GetResourcesFolder()); // Запись имени игрока + счёта
            ShowBestScores best = new ShowBestScores(); 
            best.ReadFile(); //Показ лучших игроков
        }
    }
}