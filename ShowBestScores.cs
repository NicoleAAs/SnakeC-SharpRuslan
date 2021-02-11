using System;
using System.Collections.Generic;
using System.IO;

namespace Snake
{
    public class ShowBestScores
    {
        List<Player> ltext = new List<Player>();
        string text;
        public void ReadFile()
        {

            Params settings = new Params();
            StreamReader filest = new StreamReader(settings.GetResourcesFolder()+ "LeaderBorad.txt");
            text= filest.ReadToEnd();
            char[] separators = new char[] { ' ', '-',' ' };
            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < subs.Length; i++)
            {
                subs[i] = subs[i].Replace("\r\n", string.Empty);
            }
            for (int i = 0; i<subs.Length-1;i+=2)
            {
                Player temp = new Player();
                temp.Name = subs[i];
                temp.Score = int.Parse(subs[i + 1]);
                ltext.Add(temp);
            }
            List<Player> sortedList = Player.MySort(ltext);
            int ss = 0;
            foreach (var leader in sortedList)
            {
                Console.WriteLine(leader.Name + " - " + leader.Score);
                if (ss >= 10)
                {
                    break;
                }
                ss++;
            }
            Console.ReadKey();
        }
    }
}