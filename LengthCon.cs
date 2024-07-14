using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PUP_DIFF.CONVERT
{
    internal static class LengthCon
    {
        public static void  LengthConver()
        {
            double input = 0;
            Console.WriteLine("\nChoose Length Converter:");
            string[] length = new string[] { "m to cm ",
                                             "cm to m ",
                                             "cm to inch",
                                             "inch to cm",
                                             "ft to m ",
                                             "m to ft",
                                             "yd to m ",
                                             "m to yd ",
                                             "mile to km ",
                                             "km to mile ",
                                             "n mile to m ",
                                             "m to n mile "};
            Console.WriteLine("**********************************************************");


            for (int i = 0; i < length.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {length[i]}");
            }
            Console.WriteLine("\nSelect the number you want to use in Converting unit:");
            int convertl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**********************************************************");

            Console.WriteLine("\nEnter the number:");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nProcessing please wait..................");
            Console.WriteLine("**********************************************************");
            Console.Clear();
            string answer = Lengthresults(input, convertl);
            string[] historyconverter = new string[] { "\n**History Converter**",
                                                   "Category Converter: Length Converter",
                                                   $"Time Converter selectionn you choose:{length[convertl-1]}",
                                                   $"Number that the user input: {input}",
                                                   $"{answer}",
            "****************************************************"};


            foreach (var item in historyconverter)
            {
                Console.WriteLine(item);
            }
        }
        public static string Lengthresults(double input, int convertl)
        {
            string answer = "";
            switch (convertl)
            {
                case 1:
                    double cm = input * 100;
                    answer = $"The answer is {cm}, cm. ";
                    break;
                case 2:
                    double m = input / 100;
                    answer = $"The answer is {m}, m. ";
                    break;
                case 3:
                    double inch = input / 2.54;
                    answer = $"The answer is {inch}, inch. ";
                    break;
                case 4:
                    double inchcm = input * 2.54;
                    answer = $"The answer is {inchcm}, cm. ";
                    break;
                case 5:
                    double ft = input * 0.3048;
                    answer = $"The answer is {ft}, ft. ";
                    break;
                case 6:
                    double ftm = input / 0.3048;
                    answer = $"The answer is {ftm}, m. ";
                    break;
                case 7:
                    double myd = input * 0.9144;
                    answer = $"The answer is {myd}, m. ";
                    break;
                case 8:
                    double yd = input / 0.9144;
                    answer = $"The answer is {yd}, yd. ";
                    break;
                case 9:
                    double km = input * 1.60934;
                    answer = $"The answer is {km}, km. ";
                    break;
                case 10:
                    double mile = input / 1.60934;
                    answer = $"The answer is {mile}, miles. ";
                    break;
                case 11:
                    double mn = input * 1852;
                    answer = $"The answer is {mn}, m. ";
                    break;
                case 12:
                    double nm = input / 1852;
                    answer = $"The answer is {nm}, n. ";
                    break;
                default:
                    Console.WriteLine("Invalid Input.......");
                    break;
            }
            return answer;
        }
    }
}
