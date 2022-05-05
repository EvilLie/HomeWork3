using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int userNum = int.Parse(Console.ReadLine());
            if (userNum % 2 == 0)
            {
                Console.WriteLine("Введённое число чётное");
            }
            else
            {
                Console.WriteLine("Введённое число нечётное");
            }
            Console.ReadKey();
        }
    }
}
