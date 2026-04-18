using System;
class Program
{
    static void Main(string[] args)
    {
        int number = 0;

        Console.WriteLine("Give a number:");
        number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even");
        }
        else
        {
            Console.WriteLine($"{number} is odd");
        }
    }
}