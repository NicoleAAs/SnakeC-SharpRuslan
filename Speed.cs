using System;
using System.Drawing;
using System.Threading;

namespace Snake
{
    public class Speed 
    {
        public Speed(int score) 
        {
            if (score <= 10)
            {
                Thread.Sleep(100); //Выставляем изначальную скорость
            }
            else if (score >= 11 && score <= 20)
            {
                Thread.Sleep(80); // Увеличиваем скорость
            }
            else if (score >= 21 && score <= 30)
            {
                Thread.Sleep(60); // Увеличиваем скорость
            }
            else if (score >= 31 && score <= 40)
            {
                Thread.Sleep(40); // Увеличиваем скорость
            }
        }
    }
}