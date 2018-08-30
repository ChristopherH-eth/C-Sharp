// Score Average Program
// Version 1.0
//
// Christopher Hardy
// POS/409
// February 8th, 2016
// Lynn Thackeray
//
// Description:  The primary reason for this program's creation is to display proper usage of exception handling using a custom exception.  In addition, it allows the user to enter three scores
// and calculate their average.  A series of try/catch blocks (some of which utilize the custom exception) is used to ensure only good data is being entered by the user along with a switch statement
// that allows the user to proceed with more calculations or simply exit the program. The concept of the program is simple enough, and the custom exception is used in conjunction with a conditional
// statement that checks whether a score is out of bounds or not.  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Score Average Program!\n\nThis program allows the user to enter any set of three scores to have them\naveraged.\n\n");

            core();

            Console.WriteLine("\nThank you for using the Score Average Program!\nPlease press 'Enter' to exit.");
            Console.Read();
        }

        // core method for program functionality
        public static void core()
        {
            bool RUNNING = true;

            while (RUNNING)
            {
                Console.WriteLine("Enter '1' to average a new set of scores, or enter '0' to exit the program: ");

                string input = Console.ReadLine();

                // try/catch block to ensure only valid integers are used
                try
                {
                    int choice = Int32.Parse(input);

                    switch (choice)
                    {
                        case 1:
                            scoreEntry();
                            break;

                        case 0:
                            RUNNING = false;
                            break;

                        default:
                            Console.WriteLine("Invalid input.\n");
                            break;
                    }
                }

                catch
                {
                    Console.WriteLine("Invalid input.\n");
                }
            }
        }

        // scoreEntry method for storing user scores
        public static void scoreEntry()
        {
            string _score1;
            string _score2;
            string _score3;
            bool VALIDATE = true;

            Calculations myCalculations = new Calculations();

            while (VALIDATE)
            {
                Console.WriteLine("\nEnter the first score (integer between '0' and '100'): ");
                _score1 = Console.ReadLine();

                // try/catch block to ensure good data being entered
                try
                {
                    myCalculations.score1 = Int32.Parse(_score1);

                    try
                    {
                        if ((myCalculations.score1 < 0) || (myCalculations.score1 > 100))
                            throw new ScoreOutOfBoundsException("Score out of bounds.");

                        VALIDATE = false;
                    }

                    catch (ScoreOutOfBoundsException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                catch
                {
                    Console.WriteLine("Invalid Score.");
                }
            }

            VALIDATE = true; // reset VALIDATE for next score

            while (VALIDATE)
            {
                Console.WriteLine("\nEnter the second score (integer between '0' and '100'): ");
                _score2 = Console.ReadLine();

                // try/catch block to ensure good data being entered
                try
                {
                    myCalculations.score2 = Int32.Parse(_score2);

                    try
                    {
                        if ((myCalculations.score2 < 0) || (myCalculations.score2 > 100))
                            throw new ScoreOutOfBoundsException("Score out of bounds.");

                        VALIDATE = false;
                    }

                    catch (ScoreOutOfBoundsException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                catch
                {
                    Console.WriteLine("Invalid Score.");
                }
            }

            VALIDATE = true; // reset VALIDATE for next score

            while (VALIDATE)
            {
                Console.WriteLine("\nEnter the third score (integer between '0' and '100'): ");
                _score3 = Console.ReadLine();

                // try/catch block to ensure good data being entered
                try
                {
                    myCalculations.score3 = Int32.Parse(_score3);

                    try
                    {
                        if ((myCalculations.score3 < 0) || (myCalculations.score3 > 100))
                            throw new ScoreOutOfBoundsException("Score out of bounds.");

                        VALIDATE = false;
                    }

                    catch (ScoreOutOfBoundsException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                catch
                {
                    Console.WriteLine("Invalid Score.");
                }
            }

            VALIDATE = true; // reset VALIDATE for next score

            myCalculations.calculateAverage();
        }
    }

    // class to perform program calculations
    class Calculations
    {
        public int score1;
        public int score2;
        public int score3;
        int numberOfScores = 3;

        // calculateAverage method for score average calculation
        public void calculateAverage()
        {
            int average = (this.score1 + this.score2 + this.score3) / numberOfScores;

            Console.WriteLine("\nThe average of your scores is: " + average + ".\n");
        }
    }

    // custom exception for scores out of bounds
    public class ScoreOutOfBoundsException : Exception
    {
        public ScoreOutOfBoundsException() : base()
        { }

        public ScoreOutOfBoundsException(string message) : base(message)
        { }

        public ScoreOutOfBoundsException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
