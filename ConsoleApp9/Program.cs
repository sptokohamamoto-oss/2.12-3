using System;
using System.Numerics;

class Program
{

    static void Main(string[] args)
    {

        int sum = 0;
        int inputNumber = 0;

        while (sum <= 100)
        {
            Console.WriteLine("数字を入力してください: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (int.TryParse(input, out inputNumber))
            {
                sum += inputNumber;
            }
        }
            Console.WriteLine($"合計は{sum}です");

    }
}


