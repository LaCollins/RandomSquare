using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < 20; i += 1)
            {
                randomNumbers.Add(random.Next(50));
            }

            List<int> squaredNumbers = new List<int>();

            foreach (var num in randomNumbers)
            {
                squaredNumbers.Add(num * num);
            }

            foreach (var num in randomNumbers)
            {
                var squared = num * num;
                if (squared % 2 != 0)
                {
                    squaredNumbers.Remove(squared);
                }
            }

        }
    }
}
