using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PUP_DIFF.CONVERT
{
    internal static class AreaCon
    {
        public static void AreaConv()
        {
            double input = 0;

            Console.WriteLine("\nChoose Area Converter");
            Console.WriteLine("**********************************************************");
            string[] area = new string[] {"Square meters to Square kilometers",
                                                   "Square kilometers  to Square meters",
                                                   "Square meter to Hectares",
                                                   "Hectares to Square meters",
                                                   "Square meters to Acres",
                                                   "Arces to Square meters",
                                                   "Square meter to Square feet",
                                                   "Square feet to Square meters",
                                                   "Square meter to Square inch",
                                                   "Square inches to Square meters",
                                                   "Square meter to Square yard",
                                                   "Square yard to Square meter",
                                                   "Square kilometers to Square miles",
                                                   "Square miles to Square kilometers",
                                                   "Squar feet to Square yard",
                                                   "Squar yard to square feet",
                                                   "Square feet to Acres",
                                                   "Arces to Square feet",
                                                   "Square inches to Square feet",
                                                   "Square feet to Square inches"};

            for (int i = 0; i < area.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {area[i]}");
            }
            Console.WriteLine("**********************************************************");
            Console.WriteLine("\nSelect Volume Converter:");
            int areacon = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nEnter the number:");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nProcessing please wait..................");
            Console.WriteLine("**********************************************************");
            Console.Clear();
           string answer=Arearesults(input, areacon);
          

            string[] historyconverter = new string[] { "\n**History Converter**",
                                                   "Category Converter: Area Converter",
                                                   $"Time Converter selectionn you choose:{area[areacon-1]}",
                                                   $"Number that the user input: {input}",
                                                   $"{answer}",
            "****************************************************"};


            foreach (var item in historyconverter)
            {
                Console.WriteLine(item);
            }
        }
        public static string Arearesults(double input, int areacon)
        {
            string answer = "";
            switch (areacon)
            {
                case 1:
                    double kmm = input * 1000000;
                    answer = $"The answer is {kmm}, km^2. ";
                    break;
                case 2:
                    double mkm = input / 1000000;
                    answer = $"The answer is {mkm}, m^2. ";
                    break;
                case 3:
                    double ham = input * 10000;
                    answer = $"The answer is {ham}, ha. ";
                    break;
                case 4:
                    double mha = input / 10000;
                    answer = $"The answer is {mha}, m^2. ";
                    break;
                case 5:
                    double arcesm = input * 4046.85642;
                    answer = $"The answer is {arcesm}, arces. ";
                    break;
                case 6:
                    double marces = input / 4046.85642;
                    answer = $"The answer is {marces}, m^2. ";
                    break;
                case 7:
                    double mft = input / 0.09203;
                    answer = $"The answer is {mft}, ft^2. ";
                    break;
                case 8:
                    double ftm = input / 10.7639;
                    answer = $"The answer is {ftm}, m^2. ";
                    break;
                case 9:
                    double minch = input * 1550.0031;
                    answer = $"The answer is {minch}, in^2. ";
                    break;
                case 10:
                    double inchm = input / 0.00064516;
                    answer = $"The answer is {inchm}, m^2. ";
                    break;
                case 11:
                    double yrdm = input * 1.19599;
                    answer = $"The answer is {yrdm}, yd^2. ";
                    break;
                case 12:
                    double myrd = input / 0.836127;
                    answer = $"The answer is {myrd}, m^2. ";
                    break;
                case 13:
                    double milekm = input * 0.386102;
                    answer = $"The answer is {milekm}, miles^2. ";
                    break;
                case 14:
                    double kmmile = input / 2.58999;
                    answer = $"The answer is {kmmile}, km^2. ";
                    break;
                case 15:
                    double ftyrd = input * 9;
                    answer = $"The answer is {ftyrd}, ft^2. ";
                    break;
                case 16:
                    double yrdft = input / 9;
                    answer = $"The answer is {yrdft}, ft^2. ";
                    break;
                case 17:
                    double ftarces = input / 43560;
                    answer = $"The answer is {ftarces}, arces. ";
                    break;
                case 18:
                    double arcesft = input * 43560;
                    answer = $"The answer is {arcesft}, ft^2. ";
                    break;
                case 19:
                    double inchft = input / 144;
                    answer = $"The answer is {inchft}, ft^2. ";
                    break;
                case 20:
                    double ftinch = input * 144;
                    answer = $"The answer is {ftinch}, in^2. ";
                    break;
                default:
                    Console.WriteLine("Invalid input....");
                    break;
            }
            return answer;
        }
    }
}

