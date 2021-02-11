using System;
using System.Diagnostics;
using System.IO;

namespace Snake
{
    public class Leader_Board
    {
        public Leader_Board(int score, string pathToResources)
        {
            Console.Clear(); //Очищаем консоль
            Console.WriteLine("Write onw Name or Nickname:"); //Пишем в консоли что нужно ввести ник
            string name = Console.ReadLine(); //Переход на следующую строку и вводим имя игрока
            StreamWriter file=new StreamWriter(pathToResources + "LeaderBorad.txt",true); //Записываем файл на С диск
            file.WriteLine(name + " - " + score + " "); // Записываем имя игрок и его счёт, через тире
            file.Close(); //Закрываем файл
            /*var fileToOpen = pathToResources + "LeaderBorad.txt"; //Указываем Директория где лежит файл
            var process = new Process(); //Запускаем новый процесс
            process.StartInfo = new ProcessStartInfo() //Запускаем проццес
            {
                UseShellExecute = true, //Используем консоль для запуска приложения по умолчанию
                FileName = fileToOpen //Указываем что открыть приложением по умолчанию
            };

            process.Start(); //Старт процесса
            process.WaitForExit(); //Ожидание пока не закроют приложение которое открыло по умолчанию*/
        }
    }
}