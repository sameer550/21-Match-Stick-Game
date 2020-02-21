using System;

namespace _21_Match_Stick_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int user; int comp;
            int total = 21;
            while (total>1)
            {
                
                Console.WriteLine("User turn");
                user = Convert.ToInt32(Console.ReadLine());
                total -= user;
                Console.WriteLine("Left = "+total);
                comp = 5 - user;
                Console.WriteLine("Computer Turn");
                
                total -= comp;
                Console.WriteLine("Computer Selected = "+comp);
                Console.WriteLine("Left = "+total);
                


            }
            if (total == 1)
            {
                Console.WriteLine("You lose");
            }


        }
    }
}
