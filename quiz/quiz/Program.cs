using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Program
    {
        static Random rand = new Random();
        static string Name = "";
        static int Score = 0;
        static int queezNum = 0;
        static string[] quest;
        public static int Input()
        {
            if (Directory.Exists(@".\quest"))
            {
                int n = Directory.GetFiles(@".\quest").Length;
                if (n == 0)
                {
                    Console.WriteLine("Ошибка! Нет вопросов!");
                    return 1;
                }
            }
            else
            {
                Console.WriteLine("Ошибка, Вопросы не найдены!");
                return 2;
            }
            return 0;
        }
        static void GetQuestion(int Number)
        {
            quest = File.ReadAllLines(@".\quest\" + Number + ".txt");
            Console.WriteLine(quest[0]);
            Console.WriteLine(quest[1]);
            Console.WriteLine(quest[2]);
            Console.WriteLine(quest[3]);
            Console.WriteLine(quest[4]);
        }
        static void GameOver()
        {
            Console.Clear();
            if (queezNum == 20)
                Console.WriteLine("Поздравляем, вы победили!!! Ваш счет: {0}", Score);
            else
                Console.WriteLine("Вы завершили игру со счетом: {0}", Score);
            Console.ReadKey();
            Environment.Exit(0);
        }
        static void Start()
        {
            Console.Write("Добро пожаловать!\nВведите ваше имя: ");
            Name = Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Input();
            Start();
        }

    }
    
}
