// csc.exe /t:exe /out:L:\cs_source\MyApplication.exe L:\cs_source\program1.cs
using System;
namespace HelloWorld
{
    public class Hello
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Online Gaming Forum!");
            string name;
            int age;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("How old are you, {0}?", name);
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Let's play a game, {0}", name);
            Console.WriteLine("I will guess a number between 1 and 100");
            Console.WriteLine("All you need to do, {0}, is say whether my number is closer to 1 or 100", name);
            Console.WriteLine("If you win, {0}, you will get a fabulous prize!", name);
            // int playAgainCode = 0;

          
                Console.WriteLine("OK, {0}, Let's Go! Enter you GUESS. Enter either the number 1 or 100, {0}", name);
                int players_number = int.Parse(Console.ReadLine());
               // if (players_number == -1)
               // {
               //     break;
               // }
                // Now get the computer's number;
                Random rnd = new Random();
                int computer_guess = rnd.Next(1, 100);
                Console.WriteLine("Here is my number, {0}: {1}", name, computer_guess);

                if (computer_guess < 50 && players_number == 1)
                {
                    Console.WriteLine("Player WINS!!!");
                 
                }
                else if (computer_guess >= 50 && players_number == 100)
                {
                    Console.WriteLine("Player WINS!!!");
                   
                }
                else
                {
                    Console.WriteLine("Player loses!!!");
                }
                //Console.WriteLine("Play again, {0} ?", name);
                //playAgainCode = int.Parse(Console.ReadLine());
            
        }

        static void give_Advice(string name, int age)
        {
            Console.WriteLine("As to your Prize - Honestly, {0}, at the Sweet Age of {1}, you should know better than to believe vague promises...", name, age.ToString());
        }

    }
}
