using System;

namespace HammingDistance
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Please enter two numbers: ");
            string one = Console.ReadLine();
            int numOne = Convert.ToInt32(one);
            string two = Console.ReadLine();
            int numTwo = Convert.ToInt32(two);
            int dist = new Solution().HammingDistance(numOne, numTwo);
            Console.WriteLine("The Hamming Distance is: " + dist);
            Console.WriteLine();
        }
    }
}