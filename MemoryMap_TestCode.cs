using System;

public class Program1
{
    static void Main()
    {
        int count = 1;
        int iteration = 0;

        while (count < 10)
        {
            iteration += 1;
            Console.WriteLine("iteration is {0}", iteration);

            Console.WriteLine("Point A: count is {0}", count);
            count += 1;

            if (count > 5)
            {
                Console.WriteLine("I am in the If statement now...");
                count += 2;
            }
            Console.WriteLine("Point B: count is {0}", count);
        }

        Console.WriteLine("the final value of count is {0}", count);

        Console.ReadLine();
    }
}