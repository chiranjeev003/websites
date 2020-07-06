using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiranjeevTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool not_confirmed = false;
            //bool confirmed = false;
            //string Key;
            //do
            //{
            //    ConsoleKey response;
            //    do
            //    {
            //        Console.Write("Do you want to book ticket in tatkal? [y/n] ");
            //        response = Console.ReadKey(false).Key;   // true is intercept key (dont show), false is show
            //        if (response != ConsoleKey.Enter)
            //            Console.WriteLine();

            //    } while (response != ConsoleKey.Y && response != ConsoleKey.N);

            //    confirmed = response == ConsoleKey.Y;
            //    not_confirmed = response == ConsoleKey.N;

            //    if (not_confirmed)
            //    {
            //        Console.WriteLine("");
            //        Console.WriteLine("Please enter your age.");
            //        int age = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Your Age is " + age + " year/s.");
            //        Console.WriteLine("");

            //        Console.WriteLine("Please enter your gender.[m/f]");
            //        var gender = Convert.ToString(Console.ReadLine());
            //        Console.WriteLine("Your gender is " + gender + ".");
            //        Console.WriteLine("");

            //        Console.WriteLine("Are you a student?[y/n]");
            //        var student = Convert.ToString(Console.ReadLine());
            //        Console.WriteLine("");

            //        if (age > 60)
            //        {
            //            if (gender == "f")
            //            {
            //                Console.WriteLine("You will get 40% discount!");
            //                Console.WriteLine("");
            //            }

            //            else
            //            {
            //                Console.WriteLine("You will get 30% discount!");
            //                Console.WriteLine("");
            //            }
            //        }
            //        else if (age < 5)
            //        {
            //            Console.WriteLine("You don't require a ticket!");
            //            Console.WriteLine("");
            //        }

            //        else if (age >= 5 && age <= 9)
            //        {
            //            Console.WriteLine("You will get 50% discount!");
            //            Console.WriteLine("");
            //        }

            //        else if (age > 120)
            //        {
            //            Console.WriteLine("Invalid age input");
            //            Console.WriteLine("");
            //        }

            //        else
            //        {
            //            if (student == "y")
            //            {
            //                Console.WriteLine("You will get 50% discount!");
            //                Console.WriteLine("");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Sorry You won't get any discount.");
            //                Console.WriteLine("");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("");
            //        Console.WriteLine("Sorry You won't get any discount.");
            //        Console.WriteLine("");

            //    }

            //} while (!confirmed && !not_confirmed);

            string myString = string.Empty;
            var x = myString.Length;
            //myString?.Length;
            Console.WriteLine(x);

            Console.WriteLine("Press Enter to exit");
            Console.ReadKey();
        }
    }
}





