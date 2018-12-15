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
        
    }
}
