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
             ArrayMaxResult();
             LeapYear();
             int[] numbArr = new int[3] {1, 2, 3};
             PerfectSequence(numbArr);
             int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
             SumOfRows(myArray);
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
        static bool PerfectSequence(int[] arr)
        {
            int sum = 0;
            int product = 1;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    return false;
                }
                else
                {
                    sum += arr[i];
                    product *= arr[i];
                }
            }
            if (sum == product)
            {
                Console.WriteLine($"{sum} and {product} are equal, therefore a Perfect Sequence");
                Console.ReadLine();
                return true;
            }
            Console.WriteLine("Not a perfect Sequence");
            Console.ReadLine();
            return false;
        }
        static int[] SumOfRows(int[,] myArray)
        {
            int[] newArr = new int[myArray.GetLength(0)];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    rowSum += myArray[i, j];
                }

                newArr[i] = rowSum;
                
            }
            Console.WriteLine($"[{string.Join(", ", newArr)}]");
            Console.ReadLine();
            return newArr;
        }
    }
}

