using System;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string yn = "y";
            Console.WriteLine("Learn your squares and your cubes!");
            while (yn == "y")
            {
                Console.Write("enter an integer :");
                int input = int.Parse(Console.ReadLine());

                Console.WriteLine("Number\tSquared\t Cubed");
                Console.WriteLine("=====\t =====\t =====");

                for (int i = 1; i <= input; i++)
                {
                    
                    Console.WriteLine($"{i}\t  {i * i}\t  {i * i * i}");
                }
                Console.WriteLine("Continue? (y/n):");
                yn = Console.ReadLine();
            }

        }
    }
}
