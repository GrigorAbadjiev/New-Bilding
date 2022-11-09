using System;

namespace New_Bilding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            for (int floor = floors; floor >= 1; floor--)
            {
                for (int number = 0; number < count; number++)
                {
                    string type = "";
                    if (floor == floors)
                    {
                        type = "L";
                    }
                    else if (floor % 2 == 0)
                    {
                        type = "O";
                    }
                    else
                    {
                        type = "A";
                    }
                    Console.Write($"{type}{floor}{number} "); 
                }
               Console.WriteLine();
            }
        }
    }
}
