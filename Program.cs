using System;

namespace ConditionalStatementEthanAnderson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to recieve in ISM 4300?");
            Console.WriteLine("Please enter an integer without the '%' sign.");
            string userInteger;
            userInteger = Console.ReadLine();

            string grade;
            // Attempting to convert user input to a computable
            // format and returning false if not possible
            bool tryConvert = Int32.TryParse(userInteger, out int tempConvert);

            // Only allowing program to continue if tryConvert returns true
            if (tryConvert)
            {
                // Range of A's:
                if (tempConvert >= 98)
                {
                    grade = "A+";
                }

                else if (tempConvert >= 92 && tempConvert <= 97)
                {
                    grade = "A";
                }

                else if (tempConvert >= 90 && tempConvert <= 91)
                {
                    grade = "A-";
                }

                // Range of B's:
                else if (tempConvert >= 88 && tempConvert <= 89)
                {
                    grade = "B+";
                }

                else if (tempConvert >= 82 && tempConvert <= 87)
                {
                    grade = "B";
                }

                else if (tempConvert >= 80 && tempConvert <= 81)
                {
                    grade = "B-";
                }

                // Range of C's:
                else if (tempConvert >= 78 && tempConvert <= 79)
                {
                    grade = "C+";
                }

                else if (tempConvert >= 72 && tempConvert <= 77)
                {
                    grade = "C";
                }

                else if (tempConvert >= 70 && tempConvert <= 71)
                {
                    grade = "C-";
                }

                // Range of D's
                else if (tempConvert >= 68 && tempConvert <= 69)
                {
                    grade = "D+";
                }

                else if (tempConvert >= 62 && tempConvert <= 67)
                {
                    grade = "D";
                }

                else if (tempConvert >= 60 && tempConvert <= 61)
                {
                    grade = "D-";
                }

                // F's:
                else if (tempConvert < 60)
                {
                    grade = "F";
                }

                else
                {
                    grade = "error";
                }

                // Handling users that think they're smart:
                if (tempConvert > 100)
                {
                    Console.WriteLine("Overachiever!");
                }
                else if (tempConvert < 50)
                {
                    Console.WriteLine("You can do better!");
                }

                Console.WriteLine("Looks like you will get a(n) " + grade + ".");
            }
            else
            {
                // Program skips to here if tryConvert returns false
                Console.WriteLine("Error. Please restart program.");
            }
        }
    }
}
