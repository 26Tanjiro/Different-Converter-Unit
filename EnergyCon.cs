using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PUP_DIFF.CONVERT
{
    internal static class EnergyCon
    {
        public static void EnergyConv()
        {
            double input = 0;

            Console.WriteLine("\nChoose Energy Converter");
            string[] energy = new string[] { "Joules to Calories (nutritional)",
                                                   "Calories to Joules",
                                                   "Joules to Electron Volts (eV)",
                                                   "Electron Volts to Joules",
                                                   "Joules to British Thermal Units (BTUs)",
                                                   "British Thermal Units to Joules",
                                                   "Joules to Watt-hours (Wh)",
                                                   "Watt-hours to Joules",
                                                   "Joules to Foot-Pounds (ft-lb)",
                                                   "Foot-Pounds to Joules",
                                                   "Watt-hours to Joules",
                                                   "Joules to Watt-hours"};
            Console.WriteLine("**********************************************************");


            for (int i = 0; i < energy.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {energy[i]}");
            }
            Console.WriteLine("**********************************************************");
            Console.WriteLine("\nSelect Mass Converter:");
            int energyc = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nEnter the number:");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nProcessing please wait..................");
            Console.WriteLine("**********************************************************");
            Console.Clear();
            string answer=Energyresults(energyc, input);
            string[] historyconverter = new string[] { "\n**History Converter**",
                                                   "Category Converter: Energy Converter",
                                                   $"Time Converter selectionn you choose:{energy[energyc-1]}",
                                                   $"Number that the user input: {input}",
                                                   $"{answer}",
            "****************************************************"};


            foreach (var item in historyconverter)
            {
                Console.WriteLine(item);
            }

        }
        public static string Energyresults(int energyc, double input)
        {
            string answer = "";
            switch (energyc)
            {
                case 1:
                    double jc = input * 0.239;
                    answer = $"The answer is {jc}, cal. ";
                    break;
                case 2:
                    double cj = input * 4.184;
                    answer = $"The answer is {cj}, J. ";
                    break;
                case 3:
                    double conversionFactor1 = 6.242 * Math.Pow(10, 18);
                    double ej = (input) * conversionFactor1;
                    answer = $"The answer is {ej}, eV. ";
                    break;
                case 4:
                    double conversionFactor2 = 1.602 * Math.Pow(10, -19);
                    double je = (input) * conversionFactor2;
                    answer = $"The answer is {je}, J. ";
                    break;
                case 5:
                    double btuj = input * 0.0009478;
                    answer = $"The answer is {btuj}, BTU. ";
                    break;
                case 6:
                    double jb = input * 1055.06;
                    answer = $"The answer is {jb}, J. ";
                    break;
                case 7:
                    double whj = input * 0.0002778;
                    answer = $"The answer is {whj}, Wh. ";
                    break;
                case 8:
                    double jwh = input * 3600;
                    answer = $"The answer is {jwh}, J. ";
                    break;
                case 9:
                    double ftlb = input * 0.7376;
                    answer = $"The answer is {ftlb}, ft-lb. ";
                    break;
                case 10:
                    double jftlb = input * 1.35582;
                    Console.WriteLine(jftlb + ", J.");
                    answer = $"The answer is {jftlb}, J. ";
                    break;
                case 11:
                    double wwhj = input * 3600;
                    Console.WriteLine(wwhj + ", J.");
                    answer = $"The answer is {wwhj}, j. ";
                    break;
                case 12:
                    double JWWH = input * 0.000277778;
                    Console.WriteLine(JWWH + ", WH.");
                    answer = $"The answer is {JWWH}, WH. ";
                    break;
                default:
                    Console.WriteLine("Invalid input....");
                    break;
            }
            return answer;
        }
    }
}
