using System;
using System.Collections.Generic;
using System.IO;

namespace Snake
{
    public class ShowBestScores
    {
        List<Player> ltext = new List<Player>(); // Создаём новый список
        string text;
        public void ReadFile()
        {

            Params settings = new Params();
            StreamReader filest = new StreamReader(settings.GetResourcesFolder()+ "LeaderBorad.txt");
            text= filest.ReadToEnd(); //считываем файл до конца
            char[] separators = new char[] { ' ', '-',' ' }; //находение пробелов и тире
            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries); // разделение имени игрока и счета с удалением пустых строк
            for (int i = 0; i < subs.Length; i++) //перебор массива для удаление символов перехода на новую строку
            {
                subs[i] = subs[i].Replace("\r\n", string.Empty); //заменяем символы пустым значением
            }
            for (int i = 0; i<subs.Length-1;i+=2) //перебираем массив
            {
                Player temp = new Player();//подключаем метод Player
                temp.Name = subs[i]; //Записавыем (первое значение "Имя игрока" как обьект Name
                temp.Score = int.Parse(subs[i + 1]); //Тоже самое только со счётом
                ltext.Add(temp); //Добовляем это всё в список
            }
            List<Player> sortedList = Player.MySort(ltext); //создаём новый список с отсортироваными значениями от большего к меньшему
            int ss = 0; //счётчик
            foreach (var leader in sortedList) //перебор значаний пока не закончаться
            {
                Console.WriteLine(leader.Name + " - " + leader.Score);//вывод на экран консоли Имя + Счёт
                if (ss >= 10) //Если счётчик достик 10 то ...
                {
                    break; //... то останавливаем Foreach
                }
                ss++; //Добавляем к счётчику 1 пункт
            }
            Console.ReadKey(); //Ожидание нажатия кнопки
        }
    }
}