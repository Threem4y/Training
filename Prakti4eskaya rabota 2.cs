using System;

namespace pr2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Это таблица умножения");
            Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9");
            Console.Write("--------------------------------------------------------------------------");
            Console.WriteLine();
            for (int l = 1; l < 10; l++)
            {
                Console.WriteLine(l + "   |  ");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("\t" + l * j);
                }
                Console.WriteLine("");
                Console.WriteLine("");
             
            }
            Console.WriteLine("Напишите 2 для начала игры в угадайку");
            Console.ReadLine();
            
            Random rand = new Random();
            int i = rand.Next(100);
            int o = 1;
            Console.WriteLine("Компьютер загадал число от 0 до 100. у тебя есть 3 попытки.");
            Console.WriteLine("Введите первое число:");

            int k = Convert.ToInt32(Console.ReadLine());
            while (o <= 3)
            {
                if (i == k)
                {
                    Console.WriteLine("Да! Компьютер загадал число " + k + "!");
                    break;
                }
                else
                {
                    o++;
                    if (o == 4)
                    {
                        Console.WriteLine("Увы, вы не отгодали загаданное число. Это было число " + i + "!");
                        break;
                    }
                    Console.WriteLine("Нет, это не число " + k + "! Попытка № " + o + ":");
                    k = Convert.ToInt32(Console.ReadLine());
                }
            
            }
            Console.WriteLine("Напишите 3, что бы начать программу по нахождению делителей числа");

            Console.ReadLine();
           
            {
                Console.Write("число? ");
                var n = int.Parse(Console.ReadLine());
                Console.Write("делители: ");
                for (var c = 2; c <= n / 2; ++c) if (n % c == 0) Console.Write(" {0}", c);
                Console.WriteLine();
                Console.ReadKey();
            }

        }
    }
}
