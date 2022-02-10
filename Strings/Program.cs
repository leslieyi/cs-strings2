using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //"string" is a class in c# method which means it has properties and methods.

            string someText = "Leslie is learning about strings.";
            Console.WriteLine(someText.ToLower());
            Console.WriteLine(someText.ToUpper());
            Console.WriteLine(someText.Trim());

            Console.WriteLine(someText.IndexOf("about"));
            Console.WriteLine(someText.LastIndexOf("i"));

            Console.WriteLine(someText.Substring(2, 4));
            Console.WriteLine(someText.Replace("Leslie", "Baudouin"));

            Console.WriteLine(String.IsNullOrEmpty(someText));
            Console.WriteLine(String.IsNullOrWhiteSpace(someText));

            //when user submits data, we receive it as strings
            string stringNumber = "1994";

            //Throws an exception if null or empty
            int intNumber = int.Parse(stringNumber);

            //returns 0 if null or empty
            int intNumber2 = Convert.ToInt32(stringNumber);

            //and to convert it back to a string
            string stringNumber2 = intNumber.ToString();



        }
    }
}
