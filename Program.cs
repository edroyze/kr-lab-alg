using System;
namespace ConsoleApp
{
    internal class Program
    {
        static void n(double y)
        {
            Console.WriteLine("f(n) = n");
            for (int x = 0; x <= 50; x++)
            {
                if (y < 500)
                {
                    y = x;
                    Console.WriteLine($"f({x}) = {y}");
                }
                else
                    break;
            }
        }
        static void logn(double y)
        {
            Console.WriteLine("f(n) = log(n)");
            for (int x = 0; x <= 50; x++)
            {
                if (y < 500)
                {
                    y = Math.Log(x);
                    Console.WriteLine($"f({x}) = {y}");
                }
                else
                    break;
            }
        }
        static void nlogn(double y)
        {
            Console.WriteLine("f(n) = n * log(n)");
            for (int x = 0; x <= 50; x++)
            {
                y = x * Math.Log(x);
                if (y > 500)
                    break;
                Console.WriteLine($"f({x}) = {y}");
            }
        }
        static void n2(double y)
        {
            Console.WriteLine("f(n) = n^2");
            for (int x = 0; x <= 50; x++)
            {
                y = Math.Pow(x, 2);
                if (y > 500)
                    break;
                Console.WriteLine($"f({x}) = {y}");
            }
        }
        static void twoTo_n(double y)
        {
            Console.WriteLine("f(n) = 2^n");
            for (int x = 0; x <= 50; x++)
            {
                y = Math.Pow(2, x);
                if (y > 500)
                    break;
                Console.WriteLine($"f({x}) = {y}");
            }
        }
        static void factorial_n(double y)
        {
            Console.WriteLine("f(n) = n!");
            for (int x = 0; x <= 50; x++)
            {
                y = 1;
                int xcopy = x;
                while (xcopy > 0)
                {
                    y *= xcopy;
                    xcopy--;
                }
                if (y > 500)
                    break;
                Console.WriteLine($"f({x}) = {y}");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            double y = 0;
            int swtch = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. f(n) = n\n2. f(n) = log(n)\n3. f(n) = n * log(n)\n4.f(n) = n ^ 2\n5.f(n) = 2 ^ n\n6.f(n) = n!\n");
               

                Console.Write("Виберіть функцію: ");
                while (!int.TryParse(Console.ReadLine(), out swtch))
                {
                    Console.WriteLine("Функції під таким номером не існує. Спробуйте ще раз");
                   
                    Console.Write("Виберіть функцію: ");
                }
                switch (swtch)
                {
                    case 1:
                        Console.Clear();
                        n(y);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        logn(y);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        nlogn(y);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        n2(y);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        twoTo_n(y);
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        factorial_n(1);
                        Console.ReadKey();
                        break;
                }
            } while (swtch > 0);
        }
    }
}
