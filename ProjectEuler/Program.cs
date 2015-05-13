using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        // List of answered questions
        static List<int> answeredQuestions = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

        static int Main(string[] args)
        {
            // Question number from argument
            int questionNum = 0;
            // Answer to question
            BigInteger answer;
            // Solution object
            Solution s;
            // Stopwatch object for timing
            Stopwatch timer;

            // Check that argument is a valid question number
            try
            {
                // Check if there is one argument
                if (args.Length != 1)
                    throw new Exception("Incorrect number of arguments.");
                // Check that argument is an integer
                if (!Int32.TryParse(args[0], out questionNum))
                    throw new Exception("Incorrect argument type given (expects integer).");
                // Check that questionNum is a valid question that is answered
                if (!Program.answeredQuestions.Contains(questionNum))
                    throw new Exception("Question number " + questionNum + " either hasn't been answered or doesn't exist.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            Console.WriteLine("Question: " + questionNum);

            // Create Solution object corresponding to argument
            switch (questionNum)
            {
                case (1):
                    s = new Solution1();
                    break;
                case (2):
                    s = new Solution2();
                    break;
                case (3):
                    s = new Solution3();
                    break;
                case (4):
                    s = new Solution4();
                    break;
                case (5):
                    s = new Solution5();
                    break;
                case (6):
                    s = new Solution6();
                    break;
                case (7):
                    s = new Solution7();
                    break;
                default:
                    s = new UnimplementedSolution();
                    break;
            }

            Console.WriteLine("   Processing...");

            try
            {
                // Start a timer
                timer = Stopwatch.StartNew();
                // Get answer to problem
                answer = s.run();
                // Stop timer
                timer.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            Console.WriteLine("   Time: " + timer.ElapsedMilliseconds + "ms");
            Console.WriteLine("Answer: " + answer);

            return 0;
        }
    }
}
