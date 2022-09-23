using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakti4eskaya_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбор действия");
            Console.WriteLine("1 - сложить 2 числа ");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7.Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");
            int action = Convert.ToInt32(Console.ReadLine());
            int a;
            int b;
           
           

            while ((action > 0) && (action <= 9))
                    {
                if (action == 1)
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a + b);                      
                }
                else if (action == 2)
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a - b);


                }  
                else if (action == 3)
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a * b);



                }
                else if (action == 4)
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a / b);



                }

                else if (action == 5)
                    
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Math.Pow(a, b));
                }
                else if (action == 6)

                {
                    a = Convert.ToInt32(Console.ReadLine());
                    

                    Console.WriteLine(Math.Sqrt(a));
                }

                else if (action == 7)

                {
                    a = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine(a / 100);
                }
                else if (action == 8)

                {
                    a = Convert.ToInt32(Console.ReadLine());

                    int w = 1;
                    for (int n = 1; n <= a; n++ )
                    {
                        w *= n;
                    
                    }
                    Console.WriteLine(w);

                   


                }


                if (action == 9)
                {
                    Console.WriteLine("Выйди пожалста отсюда");
                }








            }
            
            
             
                   










            


        }
    }
}
