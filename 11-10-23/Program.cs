using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[4];
        Console.WriteLine("Podaj liczby X Y A B");

        for (int i = 0; i < 4; i++)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                numbers[i] = number;
            }
        }

        for (int i = 0; i < numbers[1]; i++)
        {
            Console.WriteLine("");
        }

        for (int i = 0; i < numbers[3]; i++)
        {
            for (int j = 0; j < numbers[0]; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < numbers[2]; j++)
            {
                Console.Write("x");
            }
            Console.WriteLine("");
        }
    }
}