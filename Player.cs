using System;
using System.Collections.Generic;

namespace Snake
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public static List<Player> MySort (List<Player> tempList)
        {
            Player temp;
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
            return tempList;
        }
    }
}