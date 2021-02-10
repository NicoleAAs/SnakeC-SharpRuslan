using System;
using System.Threading.Tasks.Sources;

namespace Snake
{
    public class Counter
    {
        public int score;

        public Counter()
        {
            
        }

        public Counter(int score)
        {
            this.score = score;
        }

        public void ScoreUp()
        {
            score ++;
        }

        public void ScoreUpx5()
        {
            score += 5;
        }

        public int GetScore()
        {
            return score;
        }
        
        public void ScoreWrite() //Функция вывода на экран счёта
        {

            int xOffset = 80;
            int yOffset = 22;
            Colors colors = new Colors(score); // смена цвета в зависимости он набранных очков (так же меняеться скорость)
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteInt(score, xOffset, yOffset++);
        }

        static void WriteInt(int text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

    }
}