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
            Console.WriteLine("��� ������?");
            Console.WriteLine("1. ����� ���� ������ ������� 2 �����");
            Console.WriteLine("2. ����� ���� ������ ������� ������ �� �������");
            Console.WriteLine("3. ����� ���������� 2 �����");
            Console.WriteLine("4. �� ������ ��������� ������ �� ������");
            Console.WriteLine("5. �� ������ �������� � ������� N ������ �����");
            Console.WriteLine("6. ����� �� ������ ���������� ������� �� �����");
            Console.WriteLine("7. 100% �� ������ 1 ������� �� �����");
            Console.WriteLine("8. �� �������� ����� ��������� �����");
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
                            Console.WriteLine(" 2 �����");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a + b);
                    }
                    if

                           Console.WriteLine(" �����������")
                    {
                        ;
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    if

                    Console.WriteLine(" ����������");\
                    {
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a - b);
                    }
                    if

                          Console.WriteLine(" 2 �����");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a * b);
                    }
                    if

                          Console.WriteLine(" �������");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    if

                    Console.WriteLine(" ��������");
                    {
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a / b);
                    }
                    if

                         Console.WriteLine(" �����");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    if

                    Console.WriteLine(" �������");
                    if

                    b = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= b; i++)
                    {
                        c = c * a;
                        Console.WriteLine(c);
                    }
                    Console.WriteLine(c);

                    if

                         Console.WriteLine("������� �����, ����� ���������� ������ ��������");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Sqrt(a));
                    }
                    if

                           Console.WriteLine("������� �����,����� �� ������� ������ 1%");
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Convert.ToDouble(a / 100));

                    }
                    if

                         Console.WriteLine("������� �����, ����� ��������� ������");
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

                Console.WriteLine("��� ������?");
                {
                    action = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (action <= 0)
            {
                Console.WriteLine("�����");
            }
            else if (action == 9)
            {
                Console.WriteLine("U died");
            }
        }
    }
}

