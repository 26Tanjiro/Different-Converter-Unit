using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PUP_DIFF.CONVERT
{
    internal static class TemperatureCon
    {
        public static void TemperatureConv()
        {
            double input = 0;

            Console.WriteLine("\nChoose Temperature Converter");
            
            string[] temperature = new string[] { "Celsius to Fahrenheit",
                                                   "Fahrenheit to Celsius",
                                                   "Celsius to Kelvin",
                                                   "Kelvin to Celsius",
                                                   "Fahrenheit to Kelvin",
                                                   "Kelvin to Fahrenheit"};

            for (int i = 0; i < temperature.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {temperature[i]}");
            }
            Console.WriteLine("**********************************************************");

            Console.WriteLine("\nSelect Tempereture Converter:");
            int temperaturec = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nEnter the number:");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nProcessing please wait..................");
            Console.WriteLine("**********************************************************");
            Console.Clear();
           string answer= Timeresults(temperaturec, input);
            string[] historyconverter = new string[] { "\n**History Converter**",
                                                   "Category Converter: Temperature Converter",
                                                   $"Time Converter selectionn you choose:{temperature[temperaturec-1]}",
                                                   $"Number that the user input: {input}",
                                                   $"{answer}",
            "****************************************************"};


            foreach (var item in historyconverter)
            {
                Console.WriteLine(item);
            }
        }
        public static string Timeresults (int temperaturec, double input)
        {
            string answer = "";
            switch (temperaturec)
            {
               
                case 1:
                    double F = (5 / 9) * input + 32;
                    answer = $"The answer is {F}∘F. ";
                    break;
                case 2:
                    double C = (input - 32) * 5 / 9;
                    answer = $"The answer is {C}∘C. ";
                    break;
                case 3:
                    double K = input + 273.15;
                    answer = $"The answer is {K}∘K. ";
                    break;
                case 4:
                    double CK = input - 273.15;
                    answer = $"The answer is {CK}∘C. ";
                    break;
                case 5:
                    double KF = (5 / 9) * (input - 32) + 273.15;
                    answer = $"The answer is {KF}∘K. ";
                    break;
                case 6:

                    double FK = (9 / 5) * (input - 273.15) + 32;
                    answer = $"The answer is {FK}∘F. ";
                    break;
                default:
                    Console.WriteLine("Invalid input....");
                    break;
            }
            return answer;
        }
    }
}
