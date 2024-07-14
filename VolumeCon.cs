using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PUP_DIFF.CONVERT
{
    internal static class VolumeCon
    {
        public static void VoluneConv()
        {
            double input = 0;

            Console.WriteLine("\nChoose Volume Converter");
            string[] volume = new string[] { "Cubic Meters to Cubic Centimeters",
                                                   "Cubic Meters to Liters ",
                                                   "Cubic Centimeters to Liters",
                                                   "Cubic Inches to Liters",
                                                   "Gallons (US) to Liters" };
            Console.WriteLine("**********************************************************");

            for (int i = 0; i < volume.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {volume[i]}");
            }
            Console.WriteLine("**********************************************************");

            Console.WriteLine("\nSelect Volume Converter:");
            int volumes = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nEnter the number:");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nProcessing please wait..................");
            Console.WriteLine("**********************************************************");
            Console.Clear();
            string answer= Volumeresults(input, volumes);

            string[] historyconverter = new string[] { "\n**History Converter**",
                                                   "Category Converter: Volume Converter",
                                                   $"Time Converter selectionn you choose:{volume[volumes-1]}",
                                                   $"Number that the user input: {input}",
                                                   $"{answer}",
            "****************************************************"};


            foreach (var item in historyconverter)
            {
                Console.WriteLine(item);
            }


        }
        public static string Volumeresults(double input, int volumes)
        {
            string answer = "";
            switch (volumes)
            {
                case 1:
                    double Vcm = input * Math.Pow(10, 6);
                    answer = $"The answer is {Vcm}, cm^3. ";
                    break;
                case 2:
                    double Vl = input * 1000;
                    answer = $"The answer is {Vl}, L. ";
                    break;
                case 3:
                    double Vcml = input / 1000;
                    answer = $"The answer is {Vcml}, L ";
                    break;
                case 4:
                    double Vinl = input * 0.016387;
                    Console.Write(Vinl + ", L.");
                    answer = $"The answer is {Vinl}, L. ";
                    break;
                case 5:
                    double Vgal = input * 3.78541;
                    answer = $"The answer is {Vgal}, L. ";
                    break;
                case 6:
                    double Vmmm = input / 1000;
                    answer = $"The answer is {Vmmm}, m^3. ";
                    break;
                default:
                    Console.WriteLine("Invalid input....");
                    break;
            }
            return answer;
        }
}
}
