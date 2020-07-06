using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_numbers
{
    class Program
    {
        public int lowerLimit, upperLimit;

        static void Main(string[] args)
        {
            Program result = new Program();

            Console.Write("Enter Lower Limit: ");
            var lowerLimitInput = Console.ReadLine();
            try
            {
                result.lowerLimit = Convert.ToInt32(lowerLimitInput);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please only input integer.");
                Console.ReadKey();
                return;
            }

            Console.Write("Enter Upper Limit: ");
            var upperLimitInput = Console.ReadLine();
            try
            {
                result.upperLimit = Convert.ToInt32(upperLimitInput);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please only input integer.");
                Console.ReadKey();
                return;
            }

            if (result.lowerLimit > result.upperLimit)
            {
                Console.WriteLine("Lower Limit should be less than upper limit.");
            }
            else
            {
                Console.WriteLine("Press enter to generate random number");

                while (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    var dateSeed = DateTime.Now;
                    byte[] byteSeed = BitConverter.GetBytes(dateSeed.Ticks);
                    var intSeed = BitConverter.ToInt32(byteSeed, 0);

                    int x = result.RandomNumberValue(intSeed);
                    Console.WriteLine(x);
                    continue;
                }
            }
        }

        public int RandomNumberValue(int intSeed)
        {
            var randomNumber = intSeed;

            if (randomNumber > upperLimit)
            {
                while (randomNumber > upperLimit)
                    randomNumber = (randomNumber - upperLimit);

                if (randomNumber < lowerLimit)
                    while (randomNumber <= lowerLimit)
                        randomNumber = randomNumber + 1;

            }
            else if (randomNumber < lowerLimit)
            {
                while (randomNumber < lowerLimit)
                    randomNumber = (randomNumber + upperLimit);

                if (randomNumber > upperLimit)
                    while (randomNumber >= lowerLimit)
                        randomNumber = randomNumber - 1;
            }
            return randomNumber;
        }
    }
}
