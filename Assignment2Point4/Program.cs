/*
 * Filename: Assignmnet2Point4
 * Name = Kyle Smeaton, Connor Flaherty
 * Dates = 2017-09-12 to 2017-09-14
 * Course = CWEB2020 Advanced Programming
 * Assignment Name = Assignment 2 (Chapters 4 & 5)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment2Point4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int result = -1;

            do
            {
                //debug
                WriteLine("\n\nresult @ top of do is {0}\n\n", result);

                WriteLine("Enter 1, 2, or 3 to select your option, then press Enter: \n1. Calculate sum of scores\n2. Enter customer purchases\n3. Quit");
                input = ReadLine();
                try
                {
                    result = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    WriteLine("\n'{0}' is not a whole number. Enter a whole number please.\n", input);
                }
                catch (Exception)
                {
                    WriteLine("PLACEHOLDER - enter selection again");
                    input = ReadLine();
                    result = -1;
                }
                if ((result != -1) && (result != 1) && (result != 2) && (result != 3))
                {
                    WriteLine("\n{0} is an incorrect choice. Enter 1, 2, or 3. \n", result);
                }

                //debug
                WriteLine("\n\nresult above top of if is {0}\n\n", result);

                if (result == 1)
                {
                    string strScore;
                    int intScore = 0;
                    int subTotal = 0;
                    string instructMsg = "\nEnter a whole-number score between 0 and 100, or anything else to quit: ";
                    string outOfRange = "\n{0} does not fall between 0 and 100. Re-enter score.\n";

                    do
                    {
                        Write(instructMsg);
                        strScore = ReadLine();
                        try
                        {
                            intScore = Convert.ToInt32(strScore);
                        }
                        catch (FormatException)
                        {
                            WriteLine("Score entry is quitting");
                            WriteLine("Score is {0}", subTotal);
                        }
                        catch (Exception)
                        {
                            WriteLine("Score entry is quitting");
                            WriteLine("Score is {0}", subTotal);
                        }
                        if ((intScore < 0) || (intScore > 100) && (intScore == -1))
                        {
                            WriteLine(outOfRange, intScore);
                            intScore = 0;
                        }
                        if ((intScore >= 0) && (intScore <= 100))
                        {
                            subTotal = subTotal + intScore;
                            intScore = -1;
                        }

                    }
                    while ((intScore < 0) || (intScore > 100) && (intScore == -1));
                }
                if (result == 2)
                {
                    // temp
                    WriteLine("if == 2 is being called.");
                }
                //debug
                WriteLine("\n\nresult @ bottom of do is {0}\n\n", result);
            }
            while (result != 3);
        }
    }
}
