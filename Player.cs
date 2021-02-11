using System;
using System.Collections.Generic;

namespace Snake
{
    public class Player
    {
        public string Name { get; set; } //Поле объектов Имён
        public int Score { get; set; } //Поле Объектов Счёта

        public static List<Player> MySort (List<Player> tempList) //Далее принимаем tempList и отдаём уже MySort
        {
            Player temp; //Временное хранилище обьектов
            
            //Пузырковая сортировка
            for (int write = 0; write < tempList.Count; write++) 
            {
                for (int sort = 0; sort < tempList.Count - 1; sort++) 
                {
                    if (tempList[sort].Score < tempList[sort + 1].Score) 
                    {
                        temp = tempList[sort + 1];
                        tempList[sort + 1] = tempList[sort];
                        tempList[sort] = temp;
                    }
                }
            }
            return tempList; //Возращаем отсортированный tempList
        }
    }
}