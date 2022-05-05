using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста введите количество ваших карт: ");
            int counter = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= counter; i++)
            {
                Console.WriteLine($"Пожалуйста введите номинал {i}ой карты");
                string userNom = Console.ReadLine();

                switch (userNom)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T": sum += 10; break;
                    default: sum += int.Parse($"{userNom}"); break;
                }
            }
            if (sum > 21)
            {
                Console.WriteLine($"Вы проиграли, ваше количество очков: {sum}");
            }
            else
            {
                Console.WriteLine($"Итоговое количество очков: {sum}");
            }
            Console.ReadKey();
        }
    }
}
