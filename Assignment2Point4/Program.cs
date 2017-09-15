/*
 * Filename: Assignmnet2Point4
 * Name = Kyle Smeaton, Connor Flaherty
 * Dates = 2017-09-12 to 2017-09-14
 * Course = Advanced Programming
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
            string choice;
            int result;

            do
            {
                result = -1;
                //debug
                //WriteLine("\n\nresult @ top of do is {0}\n\n", result);

                WriteLine("Enter 1, 2, or 3 to select your option, then press Enter: \n1. Calculate sum of scores\n2. Enter customer purchases\n3. Quit");
                choice = ReadLine();
                try
                {
                    result = Convert.ToInt32(choice);
                }
                catch (FormatException)
                {
                    WriteLine("\n'{0}' is not a whole number. Enter a whole number please.\n", choice);
                }
                catch (Exception)
                {
                    WriteLine("Invalid: enter selection again\n");
                    choice = ReadLine();
                    result = -1;
                }
                // if the result is not 1, 2, 3, or -1 (which just forces the loop again), scold the user.
                if ((result != -1) && (result != 1) && (result != 2) && (result != 3))
                {
                    WriteLine("\n{0} is an incorrect choice. Enter 1, 2, or 3. \n", result);
                }

                //debug
                //WriteLine("\n\nresult above top of if is {0}\n\n", result);

                // if the user entered 1...
                if (result == 1)
                {
                    string strScore;
                    int intScore = 0;
                    int subTotal = 0;
                    string instructMsg = "\nEnter a whole-number score between 0 and 100, or anything else to quit: ";
                    string outOfRange = "\n{0} does not fall between 0 and 100. Re-enter score.\n";

                    // do I want to quit the loop?
                    bool quit = false;

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
                            WriteLine("\nScore entry is quitting");
                            WriteLine("Score is {0}\n\n", subTotal);
                            quit = true;
                        }
                        catch (Exception)
                        {
                            WriteLine("\nScore entry is quitting");
                            WriteLine("Score is {0}\n\n", subTotal);
                            quit = true;
                        }

                        //debugging
                        //WriteLine("\nintScore is {0}\n", intScore);
                        //WriteLine("\nquit is {0}\n", quit);

                        if ((intScore < 0) || (intScore > 100) && (quit == false))
                        {
                            WriteLine(outOfRange, intScore);
                            intScore = 0;
                        }
                        if ((intScore >= 0) && (intScore <= 100) && (quit == false))
                        {
                            subTotal = subTotal + intScore;
                            // intScore = -1;
                        }

                    }
                    while (quit == false);
                }
                    
                // if the user entered 2...
                if (result == 2)
                {

                    string compName;
                    string strCount;
                    int intCount = 0;

                    // is the input valid?
                    bool validIn = false;

                    Write("\nWhat is the company name? ");
                    compName = ReadLine();
                    
                    // keep asking for valid input until validIn flag is tripped.
                    do
                    {
                        Write("\nHow many items from 1 - 10 did {0} order? ", compName);
                        strCount = ReadLine();

                        // convert to integer. if Exception is thrown, scold the user.
                        try 
                        {
                            intCount = Convert.ToInt32(strCount);
                            validIn = true;
                        }
                        catch (Exception)
                        {
                            WriteLine("Enter a whole number please.\n");
                        }

                    }
                    while (validIn == false);

                    // data-entry/display for loop
                    for (int i = 0; i < intCount; i++)
                    {
                        string model;
                        string description;
                        string department;

                        // get the data
                        Write("\nWhat is item {0}'s model number? ", (i + 1));
                        model = ReadLine();

                        Write("\nWhat is the item {0}'s description? ", (i + 1));
                        description = ReadLine();

                        Write("\nFor which department is the item {0} intended? ", (i + 1));
                        department = ReadLine();

                        // display the data
                        WriteLine("\nItem: {0}    Description:     {1}     Model:      {2}     Department:     {3}\n", (i + 1), description, model, department);

                    }

                }
                //debug
                //WriteLine("\n\nresult @ bottom of do is {0}\n\n", result);
            }
            // do everything while the result of the input conversion is not 3
            // if it is 3, it will quit, as there are no further instructions.
            while (result != 3);
        }
    }
}
