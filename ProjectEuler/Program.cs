using ProjectEuler.Solutions;
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
        static Dictionary<int, Solution> questionNumberToSolution = new Dictionary<int, Solution>();

        private static void initializeSolutions()
        {
            questionNumberToSolution.Add(1, new Solution1());
            questionNumberToSolution.Add(2, new Solution2());
            questionNumberToSolution.Add(3, new Solution3());
            questionNumberToSolution.Add(4, new Solution4());
            questionNumberToSolution.Add(5, new Solution5());
            questionNumberToSolution.Add(6, new Solution6());
            questionNumberToSolution.Add(7, new Solution7());
            questionNumberToSolution.Add(8, new Solution8());
            questionNumberToSolution.Add(9, new Solution9());
            questionNumberToSolution.Add(10, new Solution10());
            questionNumberToSolution.Add(11, new Solution11());
            questionNumberToSolution.Add(12, new Solution12());
            questionNumberToSolution.Add(13, new UnimplementedSolution());
            questionNumberToSolution.Add(14, new UnimplementedSolution());
            questionNumberToSolution.Add(15, new UnimplementedSolution());
            questionNumberToSolution.Add(16, new UnimplementedSolution());
            questionNumberToSolution.Add(17, new UnimplementedSolution());
            questionNumberToSolution.Add(18, new UnimplementedSolution());
            questionNumberToSolution.Add(19, new UnimplementedSolution());
            questionNumberToSolution.Add(20, new UnimplementedSolution());
            questionNumberToSolution.Add(21, new UnimplementedSolution());
            questionNumberToSolution.Add(22, new UnimplementedSolution());
            questionNumberToSolution.Add(23, new UnimplementedSolution());
            questionNumberToSolution.Add(24, new UnimplementedSolution());
            questionNumberToSolution.Add(25, new UnimplementedSolution());
            questionNumberToSolution.Add(26, new UnimplementedSolution());
            questionNumberToSolution.Add(27, new UnimplementedSolution());
            questionNumberToSolution.Add(28, new UnimplementedSolution());
            questionNumberToSolution.Add(29, new UnimplementedSolution());
            questionNumberToSolution.Add(30, new UnimplementedSolution());
        }

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

            // Initialize the question numbers and their corresponding Solution objects
            initializeSolutions();

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
                if (!Program.questionNumberToSolution.ContainsKey(questionNum))
                    throw new Exception("Question number " + questionNum + " either hasn't been answered or doesn't exist.");
                // If it does exist, set s to the wanted solution
                else
                    s = questionNumberToSolution[questionNum];
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            Console.WriteLine("Question: " + questionNum);
            Console.WriteLine("   Processing...");
            
            // Start a timer
            timer = Stopwatch.StartNew();
            try
            {
                // Get answer to problem
                answer = s.run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            // Stop timer
            timer.Stop();

            Console.WriteLine("   Time: " + timer.ElapsedMilliseconds + "ms");
            Console.WriteLine("Answer: " + answer);

            return 0;
        }
    }
}
