using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace PROJECT_PUP_DIFF.CONVERT
{
    internal static class MassCon
    {
        public static void MassConv()
        {
            double input = 0;

            Console.WriteLine("\nChoose Mass Converter");
            string[] mass = new string[] { "Kilograms to Grams",
                                                   "Grams to Kilograms",
                                                   "Pounds to Kilograms",
                                                   "Kilograms to Pounds",
                                                   "Ounces to Grams",
                                                   "Grams to Ounces"};

            for (int i = 0; i < mass.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {mass[i]}");
            }
            Console.WriteLine("**********************************************************");

            Console.WriteLine("\nSelect Mass Converter:");
            int masss = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nEnter the number:");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nProcessing please wait..................");
            Console.WriteLine("**********************************************************");
            Console.Clear();
            string answer=Massresults(input, masss);

            string[] historyconverter = new string[] { "\n**History Converter**",
                                                   "Category Converter: Mass Converter",
                                                   $"Time Converter selectionn you choose:{mass[masss-1]}",
                                                   $"Number that the user input: {input}",
                                                   $"{answer}",
            "****************************************************"};


            foreach (var item in historyconverter)
            {
                Console.WriteLine(item);
            }
        }
        public static string Massresults(double input, int masss)
        {
            string answer = "";
            switch (masss)
            {
                case 1:
                    double grams = input * 1000;
                    answer = $"The answer is {grams} g. ";
                    break;
                case 2:
                    double kilograms = input / 1000;
                    answer = $"The answer is {kilograms} kg. ";
                    break;
                case 3:
                    double kilogramsp = input * 0.45359237;
                    answer = $"The answer is {kilogramsp} kg. ";
                    break;
                case 4:
                    double pounds = input * 2.20462262185;
                    answer = $"The answer is {pounds} lbs. ";
                    break;
                case 5:
                    double gramso = input * 28.3495231;
                    answer = $"The answer is {gramso} g. ";
                    break;
                case 6:
                    double ounces = input * 0.03527396;
                    answer = $"The answer is {ounces} oz. ";
                    break;
                default:
                    Console.WriteLine("Invalid input....");
                    break;
            }
            return answer;
        }
    }
}
