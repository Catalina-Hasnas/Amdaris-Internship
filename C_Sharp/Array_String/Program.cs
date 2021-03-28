using System;
using System.Linq;
using System.Text;

namespace Array_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // created an array of integers with 9 values in it

            //IsEven(arrOfInt);
            //Sum(arrOfInt);

            // two-dimensional array

            string[,] arrOfNames = new string[4, 2]

            {
                { "Catalina", "24y"},
                { "Petru", "22y"},
                { "Adriana", "30y" },
                { "Robert", "32y" }
            };

            // will log the value of the first column of the first line - Catalina.
            //Console.WriteLine(arrOfNames[0, 0]);

            //GetAge(arrOfNames);

            // three-dimensional array

            string[,,] arrOfNamesAndColors = new string[2, 2, 3]

            {
                {
                    { "Catalina", "24y", "pink" },
                    { "Adriana", "30y", "green" }
                },

                {

                    { "Robert", "32y", "brown" },
                    { "Petru", "22y", "blue" }
                }
            };

            // wil log the second dimension, first line and third column - brown.

            //Console.WriteLine(arrOfNamesAndColors[1, 0, 2]);

            //GetInformation(arrOfNamesAndColors);

            string helloWorld = "Hello, World!";
            string lowerCaseHelloWorld = "hello, world!";

            // will log the number of characters in the string

            //Console.WriteLine(helloWorld.Length);

            // will log 1, because the string with capitalized letters is considered bigger than the other one.

            //Console.WriteLine(String.Compare(helloWorld, lowerCaseHelloWorld));

            //string beautifulWorld = helloWorld.Insert(7, "beautiful ");

            //Console.WriteLine(beautifulWorld);

            //string dottedString = "sometimes,.dots.can.be.intimidating.";

            //FixDottedString(dottedString);
        }

        

        static void IsEven(int[] arrOfInt)
        {
            Console.WriteLine("the even numbers of this array are: ");

            //for each element in the array, if it divides by 2 without any remainer, log it.

            foreach (int i in arrOfInt)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Sum(int[] arrOfInt)
        {
            // used the "Sum" method to calculate the sum of all elements in an array.
            Console.WriteLine("the sum of numbers of this array is: " + arrOfInt.Sum());
        }

        private static void GetAge(string[,] arrOfNames)
        {
            // iterates through the first dimension
            for (int i = 0; i < arrOfNames.GetLength(0); i++)
            {
                // creates a stringbuilder for each element of first dimension array

                StringBuilder sb = new StringBuilder("", 20);

                // iterates though the second dimension

                for (int j = 0; j < arrOfNames.GetLength(1); j++)
                {
                    // arrOfNames[i,j] is {0} and it adds a "is " string at the end
                    sb.AppendFormat("{0} is ", arrOfNames[i, j]);
                }

                // calculates the length of the string without the last 3 characters

                int stringLength = sb.Length - 3;

                // removes 3 characters starting from that index

                sb.Remove(stringLength, 3);

                Console.WriteLine(sb);

            }

        }

        private static void GetInformation(string[,,] arrOfNamesAndColors)
        {

            for (int i = 0; i < arrOfNamesAndColors.GetLength(0); i++)
            {
                for (int j = 0; j < arrOfNamesAndColors.GetLength(1); j++)
                {
                    StringBuilder sb = new StringBuilder("", 50);

                    // if i is the first dimension, pronoun should be "her", else "his".

                    string pronoun = i == 0 ? "her" : "his";

                    // it iterates though the array the same as the previous function, but it's a better way to obtain the same result.
                    
                    Console.WriteLine(sb.AppendFormat("{0} is {1} and {2} favorite color is {3}", arrOfNamesAndColors[i,j,0], arrOfNamesAndColors[i,j,1], pronoun, arrOfNamesAndColors[i,j,2]));
                    
                }
            }
        }

        private static void FixDottedString(string dottedString)
        {
            // creates an array of strings, splited at the dot
            string[] subs = dottedString.Split('.');
            // joins the array in a string, using a blank space
            // trims the last blank space
            string result = String.Join(' ', subs).TrimEnd(' ');
            // will log a string, with blank spaces between words and a dot at the end
            Console.WriteLine(result + '.');
        }
    }
}
