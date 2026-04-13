using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new int[5];
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                name[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}