using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSVirtualAcademyArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //long way to declare an array
            //useful if it is populated by, say, user input
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            //shorter way to declare the array:
            int[] numbers2 = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };

            string[] names = new string[] { "Bob", "Mary", "Jim", "Kim" };

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            //reversing a string:

            string gabsName = "Gabrielle Sudik";

            char[] nameArray = gabsName.ToCharArray(); //ToCharArray is a built-in method
            Array.Reverse(nameArray);

            foreach (char nameLetter in nameArray)
            {
                Console.Write(nameLetter);
            }

            Console.ReadLine();
        }
    }
}
