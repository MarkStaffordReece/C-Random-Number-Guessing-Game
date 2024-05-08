using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace NumberGuessingGame
{
    class Program  //declares the class
    {
        static void Main(string[] args)
        {
            Random r = new Random(); // sets R as a random number
            int winNum = r.Next(0, 100); // this assigns the random number to the newly declared variable integer WinNum
            bool win = false;

            do
            {
                Console.WriteLine("Please pick a number between 0 & 100 to start the game!!");
                string s = Console.ReadLine(); // these 2 statements take the number that the person in the game picks and then converts to a string to tell you to go higher or lower
                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Too HIGH!!!.....Guess Lower!!!");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too LOW!!!!..... Guess Higher");
                }
                else if (i == winNum)
                {
                    Console.WriteLine(" You picked the correct number!!! YOU WIN!!!");
                    win = true;
                }
                Console.WriteLine();
            } while (win == false);
            Console.WriteLine("Thank you for playing the game");
            Console.WriteLine("Please hit any key to exit the game now......");
            Console.ReadKey(true);


        }
    }

}
 
