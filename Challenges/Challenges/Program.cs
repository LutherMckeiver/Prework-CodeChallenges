using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
          //  ArrayMaxResult();
            LeapYear();
        }

        static int ArrayMaxResult()
        {
            int[] userValues = new int[5];
            int result;

            string question = "Please choose a number between 1 and 10:";

            for (var i = 0; i < userValues.Length; i++)
            {
                Console.WriteLine(question);
                int.TryParse(Console.ReadLine(), out userValues[i]);
            }
           
            Console.WriteLine("The values you've entered are:");
            Console.WriteLine(String.Join(", ", userValues));

            

            Console.Write("Please enter one of the numbers that you selected: ");
            int.TryParse(Console.ReadLine(), out result);
            Console.ReadLine();

            List<int> newList = new List<int>();

            for (var i = 0; i < userValues.Length; i++)
            {
                if (result == userValues[i])
                    newList.Add(userValues[i]);
            }
            int[] newArr = newList.ToArray();
            int answer = newArr[0] * newArr.Length;
            Console.Write($"The answer is {answer}");
            Console.ReadLine();
            return answer;
        }

        static bool LeapYear()
        {
            int year;

            Console.Write("Pick a year and I will determine if it's a Leap Year: ");
            int.TryParse(Console.ReadLine(), out year);
            Console.ReadLine();

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine($"{year} is a leap year");
                        Console.ReadLine();
                        return true;
                    }
                }
            }
            Console.Write($"{year} is not a leap year");
            Console.ReadLine();
            return false;
        }            

        
    }
}
