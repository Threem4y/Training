using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что делать?");
            Console.WriteLine("1. может быть сможет сложить 2 числа");
            Console.WriteLine("2. может быть сможет вычесть первое из второго");
            Console.WriteLine("3. мейби перемножим 2 числа");
            Console.WriteLine("4. мб сможет разделить первое на второе");
            Console.WriteLine("5. мб сможет возвести в степень N первое число");
            Console.WriteLine("6. точно не найдет квадратный ккорень из числа");
            Console.WriteLine("7. 100% не найдет 1 процент от числа");
            Console.WriteLine("8. ну попробуй найти факториал числа");
            Console.WriteLine("9. u died");
            int action = Convert.ToInt32(Console.ReadLine());
            int a;
            int b;
            int c = 1;
            {

                while ((action > 0) && (action < 9))
                {
                    switch (action)
                    {
                       if
                            Console.WriteLine(" 2 числа");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a + b);
                    }
                    if

                           Console.WriteLine(" уменьшаемое")
                    {
                        ;
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    if

                    Console.WriteLine(" вычитаемое");\
                    {
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a - b);
                    }
                    if

                          Console.WriteLine(" 2 числа");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a * b);
                    }
                    if

                          Console.WriteLine(" делимое");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    if

                    Console.WriteLine(" делитель");
                    {
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a / b);
                    }
                    if

                         Console.WriteLine(" число");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    if

                    Console.WriteLine(" степень");
                    if

                    b = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= b; i++)
                    {
                        c = c * a;
                        Console.WriteLine(c);
                    }
                    Console.WriteLine(c);

                    if

                         Console.WriteLine("Введите число, мейби квадратный корень вычислит");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Sqrt(a));
                    }
                    if

                           Console.WriteLine("Введите число,мейби по приколу найдет 1%");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Convert.ToDouble(a / 100));

                    }
                    if

                         Console.WriteLine("Введите число, мейби факториал найдет");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                        int fact = 1;
                    }
                    for (int x = 1; x <= a; x++)
                    {
                        fact *= x;
                    }
                    Console.WriteLine(fact);

                }
                if

                Console.WriteLine("Что делать?");
                {
                    action = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (action <= 0)
            {
                Console.WriteLine("трабл");
            }
            else if (action == 9)
            {
                Console.WriteLine("U died");
            }
        }
    }
}

