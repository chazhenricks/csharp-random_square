using System;
using System.Collections.Generic;

namespace random_square
{

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> randomNumList = new List<int>();
            List<int> squaredNums = new List<int>();
            List<int> noOdds = new List<int>();

            for (int i = 0; i < 20; i = i + 1){
                randomNumList.Add(random.Next(1,50));
            }

            foreach(int num in randomNumList){
            squaredNums.Add((num * num));
            }

            Console.WriteLine("List of Random Numbers");
            foreach(int num in randomNumList){
                Console.WriteLine(num);
            }
            Console.WriteLine(" ");
            Console.WriteLine("List of Squared Random Number List");

            foreach(int num in squaredNums){
                Console.WriteLine(num);
            }

            for (int i = squaredNums.Count -1; i >= 0; i--){
                if(squaredNums[i] % 2 != 0){
                    squaredNums.Remove(squaredNums[i]);
                }
            }

            foreach(int num in squaredNums){
                if(num % 2 == 0){
                   noOdds.Add(num); 
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("List of the Squared random numbers with all odd numbers removed");
            foreach(int num in squaredNums){
                Console.WriteLine(num);
            }

        }
    }
}
