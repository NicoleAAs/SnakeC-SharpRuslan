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
            score ++; //прибавляет счёт на 1 еденицу
        }

        public void ScoreUpx3()
        {
            score += 3; // для спец. еды (прибавляет счёт на 3 еденицы)
        }

        public int GetScore()
        {
            return score; //получение счёта
        }
        
        public void ScoreWrite() //Функция вывода на экран счёта
        {

            int xOffset = 80;
            int yOffset = 22;
            Colors colors = new Colors(score); // смена цвета в зависимости он набранных очков (так же меняеться скорость)
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("Score: "+score, xOffset, yOffset++);
        }

        static void WriteText( String text, int xOffset, int yOffset )
        {
            Console.SetCursorPosition( xOffset, yOffset );
            Console.WriteLine( text );
        }
    }
}