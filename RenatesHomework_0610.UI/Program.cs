using System;

namespace RenatesHomework_0610.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 06.10.
            Console.WriteLine("This is what I ate today:");
            Console.Write("3 apples, ");
            Console.Write("2 bananas");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("This is what I didn't eat:");
            Console.Write("Mozarella sticks, ");
            Console.Write("Candy");
            Console.WriteLine();
            Console.WriteLine("123123123");
            Console.WriteLine();
            #endregion

            #region Classwork 11.10.
            Console.WriteLine("ABC " + "DEF");
            Console.WriteLine($"ABC DEF");
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Homework 11.10.
            Console.WriteLine("HOMEWORK 11 OCTOBER");
            Console.WriteLine();

            int number1 = 100;
            int number2 = 200;

            string number3 = "300";
            string number4 = "400";

            string NameVariable = "John ";
            string LastNameVariable = "Powers ";
            string AgeVariable = "years old";

            Console.Write("With plus: " + NameVariable + LastNameVariable + "is " + number1 + " " + AgeVariable + ".\n");
            Console.WriteLine();
            Console.Write($"With dollar sign: {NameVariable}{LastNameVariable}is {number1} {AgeVariable} \n");
            Console.WriteLine();
            Console.WriteLine("With new lines");
            Console.Write(NameVariable);
            Console.Write(LastNameVariable);
            Console.Write("is ");
            Console.Write(number2 + " ");
            Console.Write(AgeVariable + ".");
            Console.WriteLine("");
            Console.WriteLine("Attempt 2 \n");
            Console.Write(NameVariable + " " + LastNameVariable + "\n");
            Console.WriteLine("is " + number4 + " " + AgeVariable);
            #endregion
            Console.WriteLine("\n");

            #region Classwork 13.10.
            //too complex for now. Need to learn 'if' variables before
            //the potential exercise is to make a variable that reads a number and can tell whether it is an odd or an even number
            //Console.WriteLine("Input number: ");
            //string number_ = Console.ReadLine();
            //int EvenNumber = 0;
            //int OddNumber = 0;
            //Console.WriteLine($"Even number is: {EvenNumber}");
            //Console.WriteLine($"Odd number is: {OddNumber}");


            //attempt 2
            //value % 2 != 0  Formula for Odd numbers
            //value % 2 == 0  Formula for Even numbers

            Console.WriteLine("Input number: ");
            string inputstring = Console.ReadLine();
            int integerVariable = int.Parse(inputstring);
            decimal number = Convert.ToDecimal(inputstring);
            String trueOrFalse_ = number % 2 !=0 ? "Odd" : "Even";
            Console.WriteLine(trueOrFalse_);
            Console.ReadLine();


            //arithmetics
            int a = 100;
            int b = a++;

            Console.WriteLine(a++);//100
            Console.WriteLine(a++);//101
            Console.WriteLine(a++);//102
            Console.WriteLine(a++);//103
            Console.WriteLine(a++);//105
            Console.ReadLine();

            Console.WriteLine(b--);//100
            Console.WriteLine(b--);//99
            Console.WriteLine(b--);//98
            Console.WriteLine(b--);//97
            Console.WriteLine(b--);//96
            Console.ReadLine();

            //random
            Random random = new Random();
            Console.WriteLine(random.Next(0, 100));
            Console.ReadLine();


            //math formulas
            Console.WriteLine(Math.Sqrt(64));
            Console.ReadLine();
            #endregion





        }
    }
}
