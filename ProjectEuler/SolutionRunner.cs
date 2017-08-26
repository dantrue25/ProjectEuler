using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using ProjectEuler.Solutions;

namespace ProjectEuler
{
    class SolutionRunner
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
            questionNumberToSolution.Add(13, new Solution13());
            questionNumberToSolution.Add(14, new Solution14());
            questionNumberToSolution.Add(15, new Solution15());
            questionNumberToSolution.Add(16, new Solution16());
            questionNumberToSolution.Add(17, new Solution17());
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

        public static void Start(string[] args)
        {
            // Initialize the question numbers and their corresponding Solution objects
            initializeSolutions();
            
            int question;
            
            //bool isValidQuestion = false;
            var hasTooManyArgs = args.Length > 1;
            var hasOneArg = args.Length == 1;
            var isValidQuestion = (hasOneArg && int.TryParse(args[0], out question)) ? 
                questionNumberToSolution.ContainsKey(question) : false;
            var incorrectArgs = hasTooManyArgs || !isValidQuestion;

            if(incorrectArgs)
            {
                Console.WriteLine("Incorrect arguments.");
                return;
            }
            else if(isValidQuestion)
            {
                RunSolution(int.Parse(args[0]));
                return;
            }

            GetQuestionNumberFromUser();
        }

        public static void GetQuestionNumberFromUser()
        {
            Console.WriteLine("Enter question number. Enter 'exit' to leave.");
            var input = Console.ReadLine();
            int question;

            while(!input.Equals("exit"))
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------");
                if (int.TryParse(input, out question) && questionNumberToSolution.ContainsKey(question))
                {
                    RunSolution(question);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Enter question number. Enter 'exit' to leave.");
                input = Console.ReadLine();
            }
        }

        public static void RunSolution(int question)
        {
            // Answer to question
            BigInteger answer;
            // Solution object
            Solution s;
            // Stopwatch object for timing
            Stopwatch timer;

            s = questionNumberToSolution[question];

            Console.WriteLine("Question: " + question);
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
                timer.Stop();
                Console.WriteLine(e.Message);
                return;
            }
            // Stop timer
            timer.Stop();

            Console.WriteLine("   Time: " + timer.ElapsedMilliseconds + "ms");
            Console.WriteLine("Answer: " + answer);
        }
    }
}
