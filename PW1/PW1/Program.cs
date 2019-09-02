using System;

namespace PracticalWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oralbayev Galymzhan!");

            Console.WriteLine("Введите количество чисел для подсчета суммы");
            var count = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            while (count > 0)
            {
                sum += Convert.ToInt32(Console.ReadLine());
                count--;
            }
            Console.WriteLine($"Сумма чисел: {sum}");

            Console.ReadKey();
        }
    }
}
