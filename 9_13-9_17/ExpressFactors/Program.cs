/*
    Goal: Create a function that takes a positive integer and returns a string expressing how the number can be made by multiplying powers of its prime factors.
    Example: 
    ExpressFactors(2) --> "2"
    ExpressFactors(4) --> "2^2"
    ExpressFactors(10) --> "2 x 5"
    ExpressFactors(60) --> "2^2 x 3 x 5"
*/
using System;
using System.Collections.Generic;

namespace ExpressFactors
{
    class Program
    {
        private static string ExpressFactor(int num)
        {
            List<int> primeFactors = new List<int>();
            string answer = default;

            // Finds all primes of the number
            for (int i = 2; i <= num; i++)
            {
                if(isPrime(i) && (num % i) == 0)
                {
                    primeFactors.Add(i);
                }
            }
            int[] occurences = new int[primeFactors.Count];

            for(int i = 0; i < primeFactors.Count; i++)
            {
                int tempNum = num;

                while (tempNum % primeFactors[i] == 0)
                {
                    occurences[i]++;
                    tempNum /= primeFactors[i];
                }
            }

            for (int i = 0; i < primeFactors.Count; i++)
            {
                string factor = $"{primeFactors[i]}";
                for (int j = 1; j < occurences[i]; j++)
                {
                    factor += $"^{primeFactors[i]}";
                }
                if(i == primeFactors.Count - 1)
                    answer += factor;
                else   
                    answer += factor + " * ";
            }
            
            return answer;
        }

        private static bool isPrime(int num)
        {
            bool prime = true;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                }
            }
            return prime;
        }
        static void Main(string[] args)
        {
           Console.WriteLine(ExpressFactor(2));
           Console.WriteLine(ExpressFactor(4));
           Console.WriteLine(ExpressFactor(10));
           Console.WriteLine(ExpressFactor(60));
        }
    }
}
