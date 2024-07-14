using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PUP_DIFF.CONVERT
{
    internal class TimeCon
    {
        public static void Timeconver()
        {
            double input = 0;
           
            Console.WriteLine("\nChoose Time Converter");
            string[] time = new string[] { "sec to min ",
                                                   "min to sec ",
                                                   "hours to min ",
                                                   "min to hours ",
                                                   "hours to sec ",
                                                   "sec to hours ",
                                                   "hours to days",
                                                   "days to hours",
                                                   "days to min",
                                                   "min to days",
                                                   "days to sec",
                                                   "sec to days"};
            Console.WriteLine("**********************************************************");

            for (int i = 0; i < time.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {time[i]}");
            }
            
            Console.WriteLine("\nSelect Time Converter:");
            int timer = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("\nEnter the number:");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nProcessing please wait..................");
            Console.WriteLine("**********************************************************");
            Console.Clear();
            string answer=TimeConverteresults(input, timer);
            
            string[] historyconverter= new string[] { "\n**History Converter**",
                                                   "Category Converter: Time Converter",
                                                   $"Time Converter selectionn you choose:{time[timer-1]}",
                                                   $"Number that the user input: {input}",
                                                   $"{answer}",
            "****************************************************"};

           
            foreach (var item in historyconverter)
            {
                Console.WriteLine(item);
            }

        }
        public static string TimeConverteresults( double input, int timer)
        {
            string answer = "";
            switch (timer)
            {
                case 1:
                    double sm = input / 60;
                    answer = $"The answer is {sm}, minutes. ";
                    break;
                case 2:
                    double ms = input * 60;
                    answer = $"The answer is {ms}, seconds. ";
                    break;
                case 3:
                    double hm = input * 60;
                    answer = $"The answer is {hm}, minutes. ";
                    break;
                case 4:
                    double mh = input / 60;
                    answer = $"The answer is {mh}, hours. ";
                    break;
                case 5:
                    double hs = input * 3600;
                    answer = $"The answer is {hs}, seconds. ";
                    break;
                case 6:
                    double sh = input / 3600;
                    answer = $"The answer is {sh}, hours. ";
                    break;
                case 7:
                    double hd = input / 24;
                    answer = $"The answer is {hd}, days";
                    break;
                case 8:
                    double dh = input * 24;
                    answer = $"The answer is {dh}, hours. ";
                    break;
                case 9:
                    double dm = input * 24 * 60;
                    answer = $"The answer is {dm}, minutes. ";
                    break;
                case 10:
                    double md = input / 24 * 60;
                    answer = $"The answer is {md}, days. ";
                    break;
                case 11:
                    double ds = input * 24 * 60 * 60;
                    answer = $"The answer is {ds}, seconds. ";
                    break;
                case 12:
                    double sd = input / 24 * 60 * 60;
                    answer = $"The answer is {sd}, days. ";
                    break;
                default:
                    Console.WriteLine("Invalid input....");
                    break;
            }
            return answer;
        }


    }
}
