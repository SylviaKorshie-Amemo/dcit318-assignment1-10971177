using System;

namespace ConsoleApp1
{

    public void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Enter your score:");
        float score = Math.Round(float.Parse(Console.ReadLine(), 2);
        if (score >= 90) {
            Console.WriteLine("Your grade is A");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else {
            Console.WriteLine("Your grade is F")
        }
        Console.ReadKey();
    }
}
