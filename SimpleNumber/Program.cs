using System;

namespace SimpleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста введите число: ");
            int userNum = int.Parse(Console.ReadLine()), i = 2;
            bool flag = false;
            while (i < userNum - 1)
            {
                if (userNum % i == 0)
                {
                    flag = true;
                    break;
                }
                i++;
            }
            if (flag)
            {
                Console.WriteLine("Число не является простым");
            }
            else if (userNum == 1)
            {
                Console.WriteLine("Введена единица которая не является ни простым ни составным числом");
            }
            else
            {
                Console.WriteLine("Число простое");
            }
            Console.ReadKey();
        }
    }
}
